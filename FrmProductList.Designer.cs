
namespace StockTracing
{
    partial class FrmProductList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStockMore = new System.Windows.Forms.RadioButton();
            this.rbStockLess = new System.Windows.Forms.RadioButton();
            this.rbStockEqual = new System.Windows.Forms.RadioButton();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(268, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(502, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(383, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(146, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 150);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(638, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(515, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStockMore);
            this.groupBox2.Controls.Add(this.rbStockLess);
            this.groupBox2.Controls.Add(this.rbStockEqual);
            this.groupBox2.Location = new System.Drawing.Point(546, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 42);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // rbStockMore
            // 
            this.rbStockMore.AutoSize = true;
            this.rbStockMore.Location = new System.Drawing.Point(118, 20);
            this.rbStockMore.Name = "rbStockMore";
            this.rbStockMore.Size = new System.Drawing.Size(49, 17);
            this.rbStockMore.TabIndex = 2;
            this.rbStockMore.Text = "More";
            this.rbStockMore.UseVisualStyleBackColor = true;
            // 
            // rbStockLess
            // 
            this.rbStockLess.AutoSize = true;
            this.rbStockLess.Location = new System.Drawing.Point(65, 20);
            this.rbStockLess.Name = "rbStockLess";
            this.rbStockLess.Size = new System.Drawing.Size(47, 17);
            this.rbStockLess.TabIndex = 1;
            this.rbStockLess.Text = "Less";
            this.rbStockLess.UseVisualStyleBackColor = true;
            // 
            // rbStockEqual
            // 
            this.rbStockEqual.AutoSize = true;
            this.rbStockEqual.Checked = true;
            this.rbStockEqual.Location = new System.Drawing.Point(7, 20);
            this.rbStockEqual.Name = "rbStockEqual";
            this.rbStockEqual.Size = new System.Drawing.Size(52, 17);
            this.rbStockEqual.TabIndex = 0;
            this.rbStockEqual.TabStop = true;
            this.rbStockEqual.Text = "Equal";
            this.rbStockEqual.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(415, 67);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(122, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(294, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPriceMore);
            this.groupBox1.Controls.Add(this.rbPriceLess);
            this.groupBox1.Controls.Add(this.rbPriceEqual);
            this.groupBox1.Location = new System.Drawing.Point(546, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // rbPriceMore
            // 
            this.rbPriceMore.AutoSize = true;
            this.rbPriceMore.Location = new System.Drawing.Point(118, 20);
            this.rbPriceMore.Name = "rbPriceMore";
            this.rbPriceMore.Size = new System.Drawing.Size(49, 17);
            this.rbPriceMore.TabIndex = 2;
            this.rbPriceMore.Text = "More";
            this.rbPriceMore.UseVisualStyleBackColor = true;
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(65, 20);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(47, 17);
            this.rbPriceLess.TabIndex = 1;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // rbPriceEqual
            // 
            this.rbPriceEqual.AutoSize = true;
            this.rbPriceEqual.Checked = true;
            this.rbPriceEqual.Location = new System.Drawing.Point(7, 20);
            this.rbPriceEqual.Name = "rbPriceEqual";
            this.rbPriceEqual.Size = new System.Drawing.Size(52, 17);
            this.rbPriceEqual.TabIndex = 0;
            this.rbPriceEqual.TabStop = true;
            this.rbPriceEqual.Text = "Equal";
            this.rbPriceEqual.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(140, 69);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(122, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(415, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(294, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Price";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(140, 19);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(122, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStockMore;
        private System.Windows.Forms.RadioButton rbStockLess;
        private System.Windows.Forms.RadioButton rbStockEqual;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label1;
    }
}