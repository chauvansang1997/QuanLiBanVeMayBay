using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculate_YearAndMonth_InCome
{
    class RegisTry_Help
    {
        public RegistryKey reg;
        public RegisTry_Help()
        {
            reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Tinh Doanh Thu", System.Reflection.Assembly.GetEntryAssembly().Location.ToString());
        }
    }
}
