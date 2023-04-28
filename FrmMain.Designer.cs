
namespace StockTracing
{
    partial class FrmMain
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ststrip = new System.Windows.Forms.StatusStrip();
            this.stlblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblPermission = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblIsAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ststrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(119, 112);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleted.Location = new System.Drawing.Point(270, 135);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(119, 112);
            this.btnDeleted.TabIndex = 1;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(140, 135);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(119, 112);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.Silver;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(12, 135);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(119, 112);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(270, 12);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 112);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(140, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(119, 112);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(270, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 56);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ststrip
            // 
            this.ststrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblName,
            this.stlblPermission,
            this.stlblIsAdmin});
            this.ststrip.Location = new System.Drawing.Point(0, 376);
            this.ststrip.Name = "ststrip";
            this.ststrip.Size = new System.Drawing.Size(402, 22);
            this.ststrip.TabIndex = 7;
            this.ststrip.Text = "statusStrip1";
            // 
            // stlblName
            // 
            this.stlblName.Name = "stlblName";
            this.stlblName.Size = new System.Drawing.Size(61, 17);
            this.stlblName.Text = "stlblName";
            // 
            // stlblPermission
            // 
            this.stlblPermission.Name = "stlblPermission";
            this.stlblPermission.Size = new System.Drawing.Size(87, 17);
            this.stlblPermission.Text = "stlblPermission";
            // 
            // stlblIsAdmin
            // 
            this.stlblIsAdmin.Name = "stlblIsAdmin";
            this.stlblIsAdmin.Size = new System.Drawing.Size(0, 17);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(12, 253);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(119, 112);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(270, 267);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(402, 398);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.ststrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnCustomer);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ststrip.ResumeLayout(false);
            this.ststrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip ststrip;
        private System.Windows.Forms.ToolStripStatusLabel stlblName;
        private System.Windows.Forms.ToolStripStatusLabel stlblPermission;
        private System.Windows.Forms.ToolStripStatusLabel stlblIsAdmin;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
    }
}