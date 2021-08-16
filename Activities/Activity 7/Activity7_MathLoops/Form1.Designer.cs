
namespace Activity7_MathLoops
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericLoops = new System.Windows.Forms.NumericUpDown();
            this.numericStartAt = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartAt)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 304);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter how many iterations to go through \r\n(hint: each iteration is 10 degrees)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start at (Fahrenheit):";
            // 
            // numericLoops
            // 
            this.numericLoops.Location = new System.Drawing.Point(12, 53);
            this.numericLoops.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLoops.Name = "numericLoops";
            this.numericLoops.Size = new System.Drawing.Size(225, 23);
            this.numericLoops.TabIndex = 3;
            this.numericLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericStartAt
            // 
            this.numericStartAt.DecimalPlaces = 1;
            this.numericStartAt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericStartAt.Location = new System.Drawing.Point(12, 113);
            this.numericStartAt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericStartAt.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericStartAt.Name = "numericStartAt";
            this.numericStartAt.Size = new System.Drawing.Size(225, 23);
            this.numericStartAt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericStartAt);
            this.Controls.Add(this.numericLoops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericLoops;
        private System.Windows.Forms.NumericUpDown numericStartAt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

