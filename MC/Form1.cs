﻿using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MC
{
    public partial class Form1 : Form
    {
        private static int lineCount = 0;
        private static StringBuilder output = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process miner = new Process())
                {
                    miner.StartInfo.UseShellExecute = false;
                    folderBrowserDialog1.ShowDialog();
                    miner.StartInfo.FileName = folderBrowserDialog1.SelectedPath+"\\PhoenixMiner.exe";
                    miner.StartInfo.CreateNoWindow = true;
                    miner.StartInfo.RedirectStandardOutput = true;
                    output = new StringBuilder();
                    miner.StartInfo.Arguments = "-pool ssl://eu1.ethermine.org:5555 -pool2 ssl://us1.ethermine.org:5555 -wal 0xde8b076f78ffb6d4a787103c3a70550535b13c06.urbnywrt";
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

        private void Miner_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        private void Miner_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            // Prepend line numbers to each line of the output.
            if (!String.IsNullOrEmpty(e.Data))
            {
                lineCount++;
                output.Append("\n[" + lineCount + "]: " + e.Data);
                label1.Invoke(new Action(() => label1.Text = output.ToString()));


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
