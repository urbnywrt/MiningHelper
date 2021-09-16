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
        private static IEnumerable<string> files;

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
            currentMiner = null;
            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(dir, "*.exe", SearchOption.TopDirectoryOnly);
                foreach (string exes in files)
                    switch (exes.Substring(dir.Length + 1))
                    {
                        case "PhoenixMiner.exe":
                            currentMiner = "PhoenixMiner";
                            
                            break;
                        case "nbminer.exe":
                            currentMiner = "NBMiner";
                            break;
                        default:
                            break;
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            if (currentMiner != null)
            {
                MessageBox.Show("Майнер нашелся в папке");

                return true;
            }
            else
            {
                MessageBox.Show("Майнер не нашёлся в папке");
                return false;
            }
        }

        public static String paramsBuilder()
        {
            if (currentMiner == "PhoenixMiner")
                return "-a ethash -pool tcp+stratum://" + Form1.pool_url + " -wal " + Form1.wallet;
            if (currentMiner == "NBMiner")
                return "-a ethash -o stratum+tcp://" + Form1.pool_url + " -u " + Form1.wallet;
            else
                return null;
        }
    }

}

