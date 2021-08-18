
namespace Activity8_caloriesCalc
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
            this.numericFatGrams = new System.Windows.Forms.NumericUpDown();
            this.numericCarbGrams = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fat = new System.Windows.Forms.Label();
            this.lbl_carbs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericFatGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbGrams)).BeginInit();
            this.SuspendLayout();
            // 
            // numericFatGrams
            // 
            this.numericFatGrams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericFatGrams.Location = new System.Drawing.Point(34, 185);
            this.numericFatGrams.Name = "numericFatGrams";
            this.numericFatGrams.Size = new System.Drawing.Size(120, 29);
            this.numericFatGrams.TabIndex = 0;
            // 
            // numericCarbGrams
            // 
            this.numericCarbGrams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericCarbGrams.Location = new System.Drawing.Point(312, 185);
            this.numericCarbGrams.Name = "numericCarbGrams";
            this.numericCarbGrams.Size = new System.Drawing.Size(120, 29);
            this.numericCarbGrams.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Members, please enter the number of fat grams and \r\ncarbohydrate grams that you c" +
    "onsume in a day.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fat Grams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(300, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carbohydrate Grams";
            // 
            // lbl_fat
            // 
            this.lbl_fat.AutoSize = true;
            this.lbl_fat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fat.Location = new System.Drawing.Point(133, 312);
            this.lbl_fat.Name = "lbl_fat";
            this.lbl_fat.Size = new System.Drawing.Size(186, 30);
            this.lbl_fat.TabIndex = 5;
            this.lbl_fat.Text = "0 Calories from Fat";
            // 
            // lbl_carbs
            // 
            this.lbl_carbs.AutoSize = true;
            this.lbl_carbs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_carbs.Location = new System.Drawing.Point(133, 353);
            this.lbl_carbs.Name = "lbl_carbs";
            this.lbl_carbs.Size = new System.Drawing.Size(211, 30);
            this.lbl_carbs.TabIndex = 6;
            this.lbl_carbs.Text = "0 Calories from Carbs";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(176, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_carbs);
            this.Controls.Add(this.lbl_fat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericCarbGrams);
            this.Controls.Add(this.numericFatGrams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calories";
            ((System.ComponentModel.ISupportInitialize)(this.numericFatGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbGrams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericFatGrams;
        private System.Windows.Forms.NumericUpDown numericCarbGrams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fat;
        private System.Windows.Forms.Label lbl_carbs;
        private System.Windows.Forms.Button button1;
    }
}

