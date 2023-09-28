namespace HomeWork1.ADO.NET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateBD = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonTitle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(12, 37);
            this.tbConnectionString.Multiline = true;
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(678, 24);
            this.tbConnectionString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // buttonCreateBD
            // 
            this.buttonCreateBD.Location = new System.Drawing.Point(12, 83);
            this.buttonCreateBD.Name = "buttonCreateBD";
            this.buttonCreateBD.Size = new System.Drawing.Size(139, 36);
            this.buttonCreateBD.TabIndex = 2;
            this.buttonCreateBD.Text = "Create BD";
            this.buttonCreateBD.UseVisualStyleBackColor = true;
            this.buttonCreateBD.Click += new System.EventHandler(this.buttonCreateBD_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(12, 154);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(139, 36);
            this.buttonFill.TabIndex = 3;
            this.buttonFill.Text = "Fill BD";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 107);
            this.textBox1.TabIndex = 4;
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Location = new System.Drawing.Point(12, 208);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(139, 36);
            this.buttonAuthor.TabIndex = 5;
            this.buttonAuthor.Text = "Поиск по автору";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // buttonTitle
            // 
            this.buttonTitle.Location = new System.Drawing.Point(12, 261);
            this.buttonTitle.Name = "buttonTitle";
            this.buttonTitle.Size = new System.Drawing.Size(139, 36);
            this.buttonTitle.TabIndex = 6;
            this.buttonTitle.Text = "Поиск по названию";
            this.buttonTitle.UseVisualStyleBackColor = true;
            this.buttonTitle.Click += new System.EventHandler(this.buttonTitle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 36);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 261);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 36);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Напишите автора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(194, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Напишите название книги";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonTitle);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonCreateBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConnectionString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateBD;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.Button buttonTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

