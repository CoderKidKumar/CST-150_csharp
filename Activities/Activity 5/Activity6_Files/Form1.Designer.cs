
namespace Activity7_MathForLoops
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_openFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.txt_Long = new System.Windows.Forms.TextBox();
            this.txt_Vowels = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(25, 19);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 23);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Alphabetical Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Alphabetical Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longest Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Most Vowels Word";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(547, 251);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(241, 23);
            this.txt_A.TabIndex = 6;
            // 
            // txt_Z
            // 
            this.txt_Z.Location = new System.Drawing.Point(547, 294);
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(241, 23);
            this.txt_Z.TabIndex = 7;
            // 
            // txt_Long
            // 
            this.txt_Long.Location = new System.Drawing.Point(547, 336);
            this.txt_Long.Name = "txt_Long";
            this.txt_Long.Size = new System.Drawing.Size(241, 23);
            this.txt_Long.TabIndex = 8;
            // 
            // txt_Vowels
            // 
            this.txt_Vowels.Location = new System.Drawing.Point(547, 376);
            this.txt_Vowels.Name = "txt_Vowels";
            this.txt_Vowels.Size = new System.Drawing.Size(241, 23);
            this.txt_Vowels.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(106, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(25, 48);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Main.Size = new System.Drawing.Size(763, 99);
            this.txt_Main.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Words Found in File";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 214);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Main);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_Vowels);
            this.Controls.Add(this.txt_Long);
            this.Controls.Add(this.txt_Z);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_openFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_Z;
        private System.Windows.Forms.TextBox txt_Long;
        private System.Windows.Forms.TextBox txt_Vowels;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

