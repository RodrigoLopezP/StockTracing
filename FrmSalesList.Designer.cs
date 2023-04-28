
namespace StockTracing
{
    partial class FrmSalesList
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
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chDate = new System.Windows.Forms.CheckBox();
            this.dpSalesDateTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpSalesDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSalesAmountMore = new System.Windows.Forms.RadioButton();
            this.rbSalesAmountLess = new System.Windows.Forms.RadioButton();
            this.rbSalesAmountEqual = new System.Windows.Forms.RadioButton();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostumer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Clean);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.chDate);
            this.panel1.Controls.Add(this.dpSalesDateTo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dpSalesDateFrom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtSalesAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCostumer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clean.Location = new System.Drawing.Point(677, 111);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(117, 45);
            this.btn_Clean.TabIndex = 12;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(554, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 45);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chDate
            // 
            this.chDate.AutoSize = true;
            this.chDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDate.Location = new System.Drawing.Point(458, 151);
            this.chDate.Name = "chDate";
            this.chDate.Size = new System.Drawing.Size(71, 28);
            this.chDate.TabIndex = 5;
            this.chDate.Text = "Date";
            this.chDate.UseVisualStyleBackColor = true;
            this.chDate.CheckedChanged += new System.EventHandler(this.chDate_CheckedChanged);
            // 
            // dpSalesDateTo
            // 
            this.dpSalesDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSalesDateTo.Location = new System.Drawing.Point(329, 155);
            this.dpSalesDateTo.Name = "dpSalesDateTo";
            this.dpSalesDateTo.Size = new System.Drawing.Size(123, 20);
            this.dpSalesDateTo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(294, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "To";
            // 
            // dpSalesDateFrom
            // 
            this.dpSalesDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSalesDateFrom.Location = new System.Drawing.Point(163, 155);
            this.dpSalesDateFrom.Name = "dpSalesDateFrom";
            this.dpSalesDateFrom.Size = new System.Drawing.Size(123, 20);
            this.dpSalesDateFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sales Date From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSalesAmountMore);
            this.groupBox2.Controls.Add(this.rbSalesAmountLess);
            this.groupBox2.Controls.Add(this.rbSalesAmountEqual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(584, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 42);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Amount";
            // 
            // rbSalesAmountMore
            // 
            this.rbSalesAmountMore.AutoSize = true;
            this.rbSalesAmountMore.Location = new System.Drawing.Point(118, 20);
            this.rbSalesAmountMore.Name = "rbSalesAmountMore";
            this.rbSalesAmountMore.Size = new System.Drawing.Size(53, 17);
            this.rbSalesAmountMore.TabIndex = 2;
            this.rbSalesAmountMore.TabStop = true;
            this.rbSalesAmountMore.Text = "More";
            this.rbSalesAmountMore.UseVisualStyleBackColor = true;
            // 
            // rbSalesAmountLess
            // 
            this.rbSalesAmountLess.AutoSize = true;
            this.rbSalesAmountLess.Location = new System.Drawing.Point(65, 20);
            this.rbSalesAmountLess.Name = "rbSalesAmountLess";
            this.rbSalesAmountLess.Size = new System.Drawing.Size(51, 17);
            this.rbSalesAmountLess.TabIndex = 1;
            this.rbSalesAmountLess.TabStop = true;
            this.rbSalesAmountLess.Text = "Less";
            this.rbSalesAmountLess.UseVisualStyleBackColor = true;
            // 
            // rbSalesAmountEqual
            // 
            this.rbSalesAmountEqual.AutoSize = true;
            this.rbSalesAmountEqual.Location = new System.Drawing.Point(7, 20);
            this.rbSalesAmountEqual.Name = "rbSalesAmountEqual";
            this.rbSalesAmountEqual.Size = new System.Drawing.Size(57, 17);
            this.rbSalesAmountEqual.TabIndex = 0;
            this.rbSalesAmountEqual.TabStop = true;
            this.rbSalesAmountEqual.Text = "Equal";
            this.rbSalesAmountEqual.UseVisualStyleBackColor = true;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Location = new System.Drawing.Point(430, 71);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(122, 20);
            this.txtSalesAmount.TabIndex = 3;
            this.txtSalesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(308, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sales Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPriceMore);
            this.groupBox1.Controls.Add(this.rbPriceLess);
            this.groupBox1.Controls.Add(this.rbPriceEqual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(584, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 42);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // rbPriceMore
            // 
            this.rbPriceMore.AutoSize = true;
            this.rbPriceMore.Location = new System.Drawing.Point(118, 20);
            this.rbPriceMore.Name = "rbPriceMore";
            this.rbPriceMore.Size = new System.Drawing.Size(53, 17);
            this.rbPriceMore.TabIndex = 2;
            this.rbPriceMore.TabStop = true;
            this.rbPriceMore.Text = "More";
            this.rbPriceMore.UseVisualStyleBackColor = true;
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(65, 20);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(51, 17);
            this.rbPriceLess.TabIndex = 1;
            this.rbPriceLess.TabStop = true;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // rbPriceEqual
            // 
            this.rbPriceEqual.AutoSize = true;
            this.rbPriceEqual.Location = new System.Drawing.Point(7, 20);
            this.rbPriceEqual.Name = "rbPriceEqual";
            this.rbPriceEqual.Size = new System.Drawing.Size(57, 17);
            this.rbPriceEqual.TabIndex = 0;
            this.rbPriceEqual.TabStop = true;
            this.rbPriceEqual.Text = "Equal";
            this.rbPriceEqual.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(156, 111);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(122, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(430, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(308, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Price";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(156, 69);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(122, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Name";
            // 
            // txtCostumer
            // 
            this.txtCostumer.Location = new System.Drawing.Point(155, 11);
            this.txtCostumer.Name = "txtCostumer";
            this.txtCostumer.Size = new System.Drawing.Size(122, 20);
            this.txtCostumer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Costumer Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(294, 32);
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
            this.btnClose.Location = new System.Drawing.Point(528, 32);
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
            this.btnDelete.Location = new System.Drawing.Point(409, 32);
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
            this.btnAdd.Location = new System.Drawing.Point(172, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 329);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSalesList";
            this.Text = "Sales List";
            this.Load += new System.EventHandler(this.FrmSalesList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCostumer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chDate;
        private System.Windows.Forms.DateTimePicker dpSalesDateTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpSalesDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSalesAmountMore;
        private System.Windows.Forms.RadioButton rbSalesAmountLess;
        private System.Windows.Forms.RadioButton rbSalesAmountEqual;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btnSearch;
    }
}