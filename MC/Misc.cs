using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC
{
    class Misc
    {
        public static String currentMiner = null;
        public static bool FindAndKillProcess(string name)
        {
            try
            {
                foreach (System.Diagnostics.Process processToKill in
                                   System.Diagnostics.Process.GetProcesses())
                {

                    if (processToKill.ProcessName.StartsWith(name))
                    {
                        processToKill.Kill();
                        processToKill.WaitForExit();
                        if (processToKill.HasExited)
                            return true;
                        else
                            return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static bool FindMiner(string dir)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(dir, "*.exe", SearchOption.TopDirectoryOnly);
            foreach (string exes in files)  
                switch (exes.Substring(dir.Length + 1))
            {
                case "PhoenixMiner.exe":
                    currentMiner = "PhoenixMiner";
                    MessageBox.Show("Майнер нашелся в папке");
                    break;
                default:
                    break;
              }

            if (currentMiner != null)
                return true;
            else
                return false;
        }

    }
}
