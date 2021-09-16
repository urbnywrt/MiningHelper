namespace MC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.start1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.strWal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.strPool = new System.Windows.Forms.TextBox();
            this.wal = new System.Windows.Forms.Label();
            this.pool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(577, 12);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(103, 44);
            this.start1.TabIndex = 0;
            this.start1.Text = "Запуск";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(12, 13);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(88, 43);
            this.selectFolder.TabIndex = 4;
            this.selectFolder.Text = "Выбор папки";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(776, 364);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // strWal
            // 
            this.strWal.Location = new System.Drawing.Point(216, 27);
            this.strWal.Name = "strWal";
            this.strWal.Size = new System.Drawing.Size(355, 20);
            this.strWal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Параметры запуска";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(329, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Default";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // strPool
            // 
            this.strPool.Location = new System.Drawing.Point(216, 48);
            this.strPool.Name = "strPool";
            this.strPool.Size = new System.Drawing.Size(355, 20);
            this.strPool.TabIndex = 10;
            // 
            // wal
            // 
            this.wal.AutoSize = true;
            this.wal.Location = new System.Drawing.Point(146, 34);
            this.wal.Name = "wal";
            this.wal.Size = new System.Drawing.Size(52, 13);
            this.wal.TabIndex = 11;
            this.wal.Text = "Кошелек";
            // 
            // pool
            // 
            this.pool.AutoSize = true;
            this.pool.Location = new System.Drawing.Point(146, 51);
            this.pool.Name = "pool";
            this.pool.Size = new System.Drawing.Size(64, 13);
            this.pool.TabIndex = 12;
            this.pool.Text = "Адрес пула";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pool);
            this.Controls.Add(this.wal);
            this.Controls.Add(this.strPool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strWal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Miner Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox strWal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox strPool;
        private System.Windows.Forms.Label wal;
        private System.Windows.Forms.Label pool;
    }
}

