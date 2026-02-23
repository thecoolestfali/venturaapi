using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VenturaAPI
{
    public class VenturaAPI
    {
        public static void DisallowRun(string processname)
        {
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun").SetValue(processname, processname);
        }
    }
}