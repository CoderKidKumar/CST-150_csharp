
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_SKU = new System.Windows.Forms.ColumnHeader();
            this.col_Category = new System.Windows.Forms.ColumnHeader();
            this.col_Quantity = new System.Windows.Forms.ColumnHeader();
            this.col_Purchase = new System.Windows.Forms.ColumnHeader();
            this.col_Sell = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.text_sell = new System.Windows.Forms.TextBox();
            this.text_purchase = new System.Windows.Forms.TextBox();
            this.text_category = new System.Windows.Forms.TextBox();
            this.text_qty = new System.Windows.Forms.TextBox();
            this.text_SKU = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
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
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 237);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.text_sell);
            this.groupBox1.Controls.Add(this.text_purchase);
            this.groupBox1.Controls.Add(this.text_category);
            this.groupBox1.Controls.Add(this.text_qty);
            this.groupBox1.Controls.Add(this.text_SKU);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Properies";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Goldenrod;
            this.button_update.Enabled = false;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.Location = new System.Drawing.Point(438, 119);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 33);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Add.Location = new System.Drawing.Point(532, 119);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(118, 33);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Save / Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.Location = new System.Drawing.Point(656, 119);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(103, 33);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // text_sell
            // 
            this.text_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_sell.Location = new System.Drawing.Point(506, 68);
            this.text_sell.Name = "text_sell";
            this.text_sell.Size = new System.Drawing.Size(141, 24);
            this.text_sell.TabIndex = 12;
            // 
            // text_purchase
            // 
            this.text_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_purchase.Location = new System.Drawing.Point(506, 19);
            this.text_purchase.Name = "text_purchase";
            this.text_purchase.Size = new System.Drawing.Size(141, 24);
            this.text_purchase.TabIndex = 11;
            // 
            // text_category
            // 
            this.text_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_category.Location = new System.Drawing.Point(121, 91);
            this.text_category.Name = "text_category";
            this.text_category.Size = new System.Drawing.Size(240, 24);
            this.text_category.TabIndex = 9;
            // 
            // text_qty
            // 
            this.text_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_qty.Location = new System.Drawing.Point(121, 125);
            this.text_qty.Name = "text_qty";
            this.text_qty.Size = new System.Drawing.Size(240, 24);
            this.text_qty.TabIndex = 10;
            // 
            // text_SKU
            // 
            this.text_SKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_SKU.Location = new System.Drawing.Point(121, 57);
            this.text_SKU.Name = "text_SKU";
            this.text_SKU.Size = new System.Drawing.Size(240, 24);
            this.text_SKU.TabIndex = 8;
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_name.Location = new System.Drawing.Point(121, 22);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(240, 24);
            this.text_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(386, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(386, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item SKU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(454, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(529, 202);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 29);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Enabled = false;
            this.button_clear.Location = new System.Drawing.Point(654, 514);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(134, 25);
            this.button_clear.TabIndex = 17;
            this.button_clear.Text = "Clear Results";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventory Manager";
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
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox text_sell;
        private System.Windows.Forms.TextBox text_purchase;
        private System.Windows.Forms.TextBox text_category;
        private System.Windows.Forms.TextBox text_qty;
        private System.Windows.Forms.TextBox text_SKU;
        private System.Windows.Forms.TextBox text_name;
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
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clear;
    }
}

