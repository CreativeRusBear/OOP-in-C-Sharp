﻿namespace Museum
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
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.UslovBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Классы и объекты";
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(41, 169);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(122, 59);
            this.AuthorBtn.TabIndex = 1;
            this.AuthorBtn.Text = "Автор";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            this.AuthorBtn.Click += new System.EventHandler(this.AuthorBtn_Click);
            // 
            // UslovBtn
            // 
            this.UslovBtn.Location = new System.Drawing.Point(221, 169);
            this.UslovBtn.Name = "UslovBtn";
            this.UslovBtn.Size = new System.Drawing.Size(122, 59);
            this.UslovBtn.TabIndex = 1;
            this.UslovBtn.Text = "Условие";
            this.UslovBtn.UseVisualStyleBackColor = true;
            this.UslovBtn.Click += new System.EventHandler(this.UslovBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(401, 169);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(122, 59);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Начало";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(581, 169);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(122, 59);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 267);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.UslovBtn);
            this.Controls.Add(this.AuthorBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.Button UslovBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

