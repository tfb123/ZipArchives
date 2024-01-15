namespace Zipulia_ZipArchives_
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CreateZipButton = new System.Windows.Forms.Button();
            this.ExtractZipButton = new System.Windows.Forms.Button();
            this.ExtractZipButton7z = new System.Windows.Forms.Button();
            this.CreateZipButton7z = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Archive";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(189, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 31);
            this.textBox1.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseButton.Location = new System.Drawing.Point(674, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(139, 42);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archive Content";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(29, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(764, 229);
            this.listBox1.TabIndex = 4;
            // 
            // CreateZipButton
            // 
            this.CreateZipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateZipButton.Location = new System.Drawing.Point(63, 380);
            this.CreateZipButton.Name = "CreateZipButton";
            this.CreateZipButton.Size = new System.Drawing.Size(160, 61);
            this.CreateZipButton.TabIndex = 5;
            this.CreateZipButton.Text = "Create Zip from folder";
            this.CreateZipButton.UseVisualStyleBackColor = true;
            this.CreateZipButton.Click += new System.EventHandler(this.CreateZipButton_Click);
            // 
            // ExtractZipButton
            // 
            this.ExtractZipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractZipButton.Location = new System.Drawing.Point(242, 380);
            this.ExtractZipButton.Name = "ExtractZipButton";
            this.ExtractZipButton.Size = new System.Drawing.Size(160, 61);
            this.ExtractZipButton.TabIndex = 6;
            this.ExtractZipButton.Text = "Extract Zip to folder";
            this.ExtractZipButton.UseVisualStyleBackColor = true;
            this.ExtractZipButton.Click += new System.EventHandler(this.ExtractZipButton_Click);
            // 
            // ExtractZipButton7z
            // 
            this.ExtractZipButton7z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractZipButton7z.Location = new System.Drawing.Point(423, 380);
            this.ExtractZipButton7z.Name = "ExtractZipButton7z";
            this.ExtractZipButton7z.Size = new System.Drawing.Size(160, 61);
            this.ExtractZipButton7z.TabIndex = 7;
            this.ExtractZipButton7z.Text = "Extract Zip to folder 7z";
            this.ExtractZipButton7z.UseVisualStyleBackColor = true;
            this.ExtractZipButton7z.Click += new System.EventHandler(this.ExtractZipButton7z_Click);
            // 
            // CreateZipButton7z
            // 
            this.CreateZipButton7z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateZipButton7z.Location = new System.Drawing.Point(603, 380);
            this.CreateZipButton7z.Name = "CreateZipButton7z";
            this.CreateZipButton7z.Size = new System.Drawing.Size(160, 61);
            this.CreateZipButton7z.TabIndex = 8;
            this.CreateZipButton7z.Text = "Create Zip from folder 7z";
            this.CreateZipButton7z.UseVisualStyleBackColor = true;
            this.CreateZipButton7z.Click += new System.EventHandler(this.CreateZipButton7z_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(764, 29);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CreateZipButton7z);
            this.Controls.Add(this.ExtractZipButton7z);
            this.Controls.Add(this.ExtractZipButton);
            this.Controls.Add(this.CreateZipButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CreateZipButton;
        private System.Windows.Forms.Button ExtractZipButton;
        private System.Windows.Forms.Button ExtractZipButton7z;
        private System.Windows.Forms.Button CreateZipButton7z;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

