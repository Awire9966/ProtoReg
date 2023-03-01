using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace ProtoReg
{
    public static class Registrar
    {
        public static void Register(string protocolname, string openapp, bool allowargs = true)
        {
            var newprotocol = Registry.ClassesRoot.CreateSubKey(protocolname);
            newprotocol.SetValue("", "URL:" + protocolname + " Protocol");
            newprotocol.SetValue("URL Protocol", "");
            var newprotocolshell = newprotocol.CreateSubKey("shell");
            var newprotocolopen = newprotocolshell.CreateSubKey("open");
            var newprotocolcmd = newprotocolopen.CreateSubKey("command");
            if (allowargs)
            {
                newprotocolcmd.SetValue("", openapp + " \"%1\"");
            }
            else if (!allowargs)
            {
                newprotocolcmd.SetValue("", openapp);
            }
        }
    }
}
