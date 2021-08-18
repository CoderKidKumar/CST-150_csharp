
namespace InventoryManagerApp
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_SKU = new System.Windows.Forms.ColumnHeader();
            this.col_Category = new System.Windows.Forms.ColumnHeader();
            this.col_Quantity = new System.Windows.Forms.ColumnHeader();
            this.col_Purchase = new System.Windows.Forms.ColumnHeader();
            this.col_Sell = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_SKU,
            this.col_Category,
            this.col_Quantity,
            this.col_Purchase,
            this.col_Sell});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 237);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Properies";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save / Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(506, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 25);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(506, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 25);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(121, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 25);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(121, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 25);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(121, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 25);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(121, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 25);
            this.textBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(386, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(386, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item SKU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(500, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(575, 203);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 29);
            this.textBox7.TabIndex = 7;
            // 
            // col_Name
            // 
            this.col_Name.Text = "Item Name";
            this.col_Name.Width = 225;
            // 
            // col_SKU
            // 
            this.col_SKU.Text = "SKU";
            this.col_SKU.Width = 125;
            // 
            // col_Category
            // 
            this.col_Category.Text = "Category";
            this.col_Category.Width = 160;
            // 
            // col_Quantity
            // 
            this.col_Quantity.Text = "Qty";
            // 
            // col_Purchase
            // 
            this.col_Purchase.Text = "Purchase $";
            this.col_Purchase.Width = 100;
            // 
            // col_Sell
            // 
            this.col_Sell.Text = "Sell $";
            this.col_Sell.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_SKU;
        private System.Windows.Forms.ColumnHeader col_Category;
        private System.Windows.Forms.ColumnHeader col_Quantity;
        private System.Windows.Forms.ColumnHeader col_Purchase;
        private System.Windows.Forms.ColumnHeader col_Sell;
    }
}

