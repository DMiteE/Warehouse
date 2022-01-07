
namespace Warehouse
{
    partial class Box
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductName2 = new System.Windows.Forms.Label();
            this.ProductName3 = new System.Windows.Forms.Label();
            this.PnameText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SearchID = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amountt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Namee,
            this.Pricee,
            this.Amountt,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(15, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(945, 478);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(242, 128);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Добавить";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(13, 21);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(83, 13);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Наименование";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // ProductName2
            // 
            this.ProductName2.AutoSize = true;
            this.ProductName2.Location = new System.Drawing.Point(13, 47);
            this.ProductName2.Name = "ProductName2";
            this.ProductName2.Size = new System.Drawing.Size(72, 13);
            this.ProductName2.TabIndex = 3;
            this.ProductName2.Text = "Колличество";
            this.ProductName2.Click += new System.EventHandler(this.ProductName2_Click);
            // 
            // ProductName3
            // 
            this.ProductName3.AutoSize = true;
            this.ProductName3.Location = new System.Drawing.Point(13, 79);
            this.ProductName3.Name = "ProductName3";
            this.ProductName3.Size = new System.Drawing.Size(33, 13);
            this.ProductName3.TabIndex = 4;
            this.ProductName3.Text = "Цена";
            this.ProductName3.Click += new System.EventHandler(this.ProductName3_Click);
            // 
            // PnameText
            // 
            this.PnameText.Location = new System.Drawing.Point(102, 18);
            this.PnameText.Name = "PnameText";
            this.PnameText.Size = new System.Drawing.Size(215, 20);
            this.PnameText.TabIndex = 5;
            this.PnameText.TextChanged += new System.EventHandler(this.PnameText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriceText);
            this.groupBox1.Controls.Add(this.AmountText);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.AddProduct);
            this.groupBox1.Controls.Add(this.ProductName2);
            this.groupBox1.Controls.Add(this.ProductName3);
            this.groupBox1.Controls.Add(this.PnameText);
            this.groupBox1.Location = new System.Drawing.Point(966, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(102, 76);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(215, 20);
            this.PriceText.TabIndex = 7;
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(102, 44);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(215, 20);
            this.AmountText.TabIndex = 6;
            this.AmountText.TextChanged += new System.EventHandler(this.AmountText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textID);
            this.groupBox2.Controls.Add(this.textName);
            this.groupBox2.Controls.Add(this.SearchID);
            this.groupBox2.Controls.Add(this.SearchName);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Location = new System.Drawing.Point(966, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 142);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(113, 58);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(204, 20);
            this.textID.TabIndex = 4;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(113, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(204, 20);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // SearchID
            // 
            this.SearchID.AutoSize = true;
            this.SearchID.Location = new System.Drawing.Point(19, 61);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(94, 13);
            this.SearchID.TabIndex = 2;
            this.SearchID.Text = "Поиск по номеру";
            this.SearchID.Click += new System.EventHandler(this.SearchID_Click);
            // 
            // SearchName
            // 
            this.SearchName.AutoSize = true;
            this.SearchName.Location = new System.Drawing.Point(19, 34);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(89, 13);
            this.SearchName.TabIndex = 1;
            this.SearchName.Text = "Поиск по имени";
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(242, 102);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "id";
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Namee
            // 
            this.Namee.DataPropertyName = "Name";
            this.Namee.HeaderText = "Наименование";
            this.Namee.Name = "Namee";
            this.Namee.Width = 500;
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "Price";
            this.Pricee.HeaderText = "Цена";
            this.Pricee.Name = "Pricee";
            this.Pricee.ReadOnly = true;
            this.Pricee.Width = 125;
            // 
            // Amountt
            // 
            this.Amountt.DataPropertyName = "Amount";
            this.Amountt.HeaderText = "Колличество";
            this.Amountt.Name = "Amountt";
            this.Amountt.Width = 115;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Удалить";
            this.Delete.ToolTipText = "Удалить";
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Склад_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.Button AddProduct;
        private new System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductName2;
        private System.Windows.Forms.Label ProductName3;
        private System.Windows.Forms.TextBox PnameText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label SearchID;
        private System.Windows.Forms.Label SearchName;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amountt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}