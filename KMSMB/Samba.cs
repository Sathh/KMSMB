using Microsoft.Win32;

namespace KMSMB
{
    class Samba
    {
        private string Smb1 { get; set; }
        private string Smb2 { get; set; }
        public Samba()
        {
            CheckSamba1();
            CheckSamba2();
        }

        private void CheckSamba1()
        {
            RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mrxsmb10");

            try
            {
                if (key1 == null)
                {
                    Smb1 = "Protokol SMB1 nie je povolený (programy a súčasti)";
                    return;
                }
                if (key1.GetValue("Start").Equals(2)) //automatic
                {
                    Smb1 = "Protokol SMB1 je zapnutý";
                }
                if (key1.GetValue("Start").Equals(3)) //manual
                {
                    Smb1 = "Protokol SMB1 je zapnutý (služba je nastavená na MANUAL START)";
                }
                if (key1.GetValue("Start").Equals(4)) //disabled
                {
                    Smb1 = "Protokol SMB1 je zakázaný !";
                }
            }
            catch
            {
            }
            finally
            {
                if (key1 != null)
                {
                    key1.Close();
                }
                Globals.Smb1 = this.Smb1;
            }
        }

        private void CheckSamba2()
        {
            RegistryKey key2 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\mrxsmb20");
            try
            {
                if (key2 == null)
                {
                    Smb2 = "Protokol SMB2 nie je povolený";
                    return;
                }
                if (key2.GetValue("Start").Equals(2)) //automatic
                {
                    Smb2 = "Protokol SMB2 je zapnutý";
                }
                if (key2.GetValue("Start").Equals(3)) //manual
                {
                    Smb2 = "Protokol SMB2 je zapnutý (služba je nastavená na MANUAL START)";
                }
                if (key2.GetValue("Start").Equals(4)) //disabled
                {
                    Smb2 = "Protokol SMB2 je zakázany !";
                }
            }
            catch
            {
            }
            finally 
            {
                if (key2 == null)
                {
                    key2.Close();
                }
                Globals.Smb2 = this.Smb2;
            }
        }
    }
}
