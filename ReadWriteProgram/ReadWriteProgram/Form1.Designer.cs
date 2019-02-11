namespace ReadWriteProgram
{
    partial class fMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputBtn = new System.Windows.Forms.Button();
            this.OutputBtn = new System.Windows.Forms.Button();
            this.WriteIntoFileBtn = new System.Windows.Forms.Button();
            this.ReadFromFile = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод и вывод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Группа";
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(30, 255);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(93, 49);
            this.InputBtn.TabIndex = 1;
            this.InputBtn.Text = "Ввод";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // OutputBtn
            // 
            this.OutputBtn.Location = new System.Drawing.Point(129, 255);
            this.OutputBtn.Name = "OutputBtn";
            this.OutputBtn.Size = new System.Drawing.Size(93, 49);
            this.OutputBtn.TabIndex = 1;
            this.OutputBtn.Text = "Вывод";
            this.OutputBtn.UseVisualStyleBackColor = true;
            this.OutputBtn.Click += new System.EventHandler(this.OutputBtn_Click);
            // 
            // WriteIntoFileBtn
            // 
            this.WriteIntoFileBtn.Location = new System.Drawing.Point(228, 255);
            this.WriteIntoFileBtn.Name = "WriteIntoFileBtn";
            this.WriteIntoFileBtn.Size = new System.Drawing.Size(201, 49);
            this.WriteIntoFileBtn.TabIndex = 1;
            this.WriteIntoFileBtn.Text = "Записать в файл";
            this.WriteIntoFileBtn.UseVisualStyleBackColor = true;
            this.WriteIntoFileBtn.Click += new System.EventHandler(this.WriteIntoFileBtn_Click);
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.Location = new System.Drawing.Point(435, 255);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(199, 49);
            this.ReadFromFile.TabIndex = 1;
            this.ReadFromFile.Text = "Считать из файла";
            this.ReadFromFile.UseVisualStyleBackColor = true;
            this.ReadFromFile.Click += new System.EventHandler(this.ReadFromFile_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 87);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(129, 120);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(155, 27);
            this.tbSurname.TabIndex = 2;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(129, 153);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(155, 27);
            this.tbPatronymic.TabIndex = 2;
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(129, 186);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(155, 27);
            this.tbGroup.TabIndex = 2;
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 21;
            this.lbOutput.Location = new System.Drawing.Point(330, 87);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(410, 130);
            this.lbOutput.TabIndex = 3;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1086, 246);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(93, 49);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(775, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 130);
            this.textBox1.TabIndex = 4;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 338);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.WriteIntoFileBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OutputBtn);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Button OutputBtn;
        private System.Windows.Forms.Button WriteIntoFileBtn;
        private System.Windows.Forms.Button ReadFromFile;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

