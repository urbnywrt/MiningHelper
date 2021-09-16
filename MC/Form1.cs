using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MC
{
    public partial class Form1 : Form
    {
        private static int lineCount = 0;
        public static StringBuilder output = null;
        public static String wallet;
        public static String pool_url;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process miner = new Process())
                {
                    miner.StartInfo.UseShellExecute = false;
                    miner.StartInfo.FileName = folderBrowserDialog1.SelectedPath + "\\" + Misc.currentMiner + ".exe";
                    miner.StartInfo.CreateNoWindow = true;
                    miner.StartInfo.RedirectStandardOutput = true;
                    output = new StringBuilder();
                    parametrs();
                    miner.StartInfo.Arguments = Misc.paramsBuilder();

                    miner.OutputDataReceived += Miner_OutputDataReceived;
                    miner.ErrorDataReceived += Miner_ErrorDataReceived;
                    miner.Start();
                    miner.BeginOutputReadLine();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка");
            }



        }

        private void parametrs()
        {
            if ((strWal == null) || (strPool == null))

                 MessageBox.Show("Кошелек и/или адрес пула введены неверно", "Ошибка");


            else
            {
                wallet = strWal.Text;
                pool_url = strPool.Text;
            }

        }

        private void Miner_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        private void Miner_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            if (!String.IsNullOrEmpty(e.Data))
            {
                lineCount++;
                output.Append("\n" + e.Data);
                richTextBox1.Invoke(new Action(() => richTextBox1.Text = output.ToString()));
                richTextBox1.Invoke(new Action(() => richTextBox1.SelectionStart = richTextBox1.Text.Length));
                richTextBox1.Invoke(new Action(() => richTextBox1.ScrollToCaret()));

            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (Misc.FindAndKillProcess(Misc.currentMiner))
                MessageBox.Show("Майнер остановлен", "Успешно!");
            else
                MessageBox.Show("Майнер не остановлен", "Ошибка!");
        }

      

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                strPool.Text = "eu1.ethermine.org:4444";
                strWal.Text = "0xde8b076f78ffb6d4a787103c3a70550535b13c06";
            }

            else
            {
                MessageBox.Show("Параметры запуска сброшены");
                strPool.Text = "";
                strWal.Text = "";
            }
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            if (Misc.currentMiner != null)
            {
                folderBrowserDialog1.SelectedPath = null;
                Misc.FindAndKillProcess(Misc.currentMiner);
                checkBox1.Checked = false;
            }
            folderBrowserDialog1.ShowDialog();
            checkBox1.Checked = Misc.FindMiner(folderBrowserDialog1.SelectedPath);
            checkBox1.Text = Misc.currentMiner;
        }

        
    }
}
