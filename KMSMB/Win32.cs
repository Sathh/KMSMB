using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KMSMB
{
    class Win32
    {
        public Win32()
        {
            Application.Run(new MainForm(CheckDomain()));
        }

        const int ErrorSuccess = 0;

        [DllImport("Netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int NetGetJoinInformation(string server, out IntPtr domain, out NetJoinStatus status);

        [DllImport("Netapi32.dll")]
        static extern int NetApiBufferFree(IntPtr Buffer);

        enum NetJoinStatus
        {
            NetSetupUnknownStatus = 0,
            NetSetupUnjoined,
            NetSetupWorkgroupName,
            NetSetupDomainName
        }
        private bool CheckDomain()
        {
            NetJoinStatus status = NetJoinStatus.NetSetupUnknownStatus;
            IntPtr pDomain = IntPtr.Zero;
            int result = Win32.NetGetJoinInformation(null, out pDomain, out status);
            if (pDomain != IntPtr.Zero)
            {
                NetApiBufferFree(pDomain);
            }
            if (result == Win32.ErrorSuccess)
            {
                return status == NetJoinStatus.NetSetupDomainName;
            }
            else
            {
                throw new Exception("Nepodarilo sa načítať info o doméne", new Win32Exception());
            }
        }
    }
}