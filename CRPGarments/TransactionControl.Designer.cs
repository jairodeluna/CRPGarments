namespace CRPGarments
{
    partial class TransactionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_transactionMenu = new System.Windows.Forms.Label();
            this.btn_addTransaction = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchText = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.transactionDataGridView);
            this.ContentPanel.Controls.Add(this.lbl_transactionMenu);
            this.ContentPanel.Controls.Add(this.btn_addTransaction);
            this.ContentPanel.Controls.Add(this.txt_search);
            this.ContentPanel.Controls.Add(this.lbl_searchText);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(960, 577);
            this.ContentPanel.TabIndex = 0;
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionNo,
            this.Image,
            this.ProductName,
            this.Sizes,
            this.Quantity,
            this.Amount,
            this.Status,
            this.Category,
            this.ModifiedBy,
            this.CreatedBy,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionDataGridView.Location = new System.Drawing.Point(11, 53);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.RowHeadersVisible = false;
            this.transactionDataGridView.Size = new System.Drawing.Size(938, 470);
            this.transactionDataGridView.TabIndex = 68;
            this.transactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionDataGridView_CellContentClick);
            // 
            // TransactionNo
            // 
            this.TransactionNo.HeaderText = "Transaction No";
            this.TransactionNo.Name = "TransactionNo";
            this.TransactionNo.Width = 70;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.Width = 95;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 170;
            // 
            // Sizes
            // 
            this.Sizes.HeaderText = "Size";
            this.Sizes.Name = "Sizes";
            this.Sizes.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 60;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.HeaderText = "ModifiedBy";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Width = 80;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 80;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::CRPGarments.Properties.Resources.pen;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.Width = 40;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::CRPGarments.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 40;
            // 
            // lbl_transactionMenu
            // 
            this.lbl_transactionMenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_transactionMenu.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_transactionMenu.Location = new System.Drawing.Point(13, 8);
            this.lbl_transactionMenu.Name = "lbl_transactionMenu";
            this.lbl_transactionMenu.Size = new System.Drawing.Size(363, 43);
            this.lbl_transactionMenu.TabIndex = 51;
            this.lbl_transactionMenu.Text = "DAILY TRANSACTIONS";
            this.lbl_transactionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addTransaction
            // 
            this.btn_addTransaction.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_addTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_addTransaction.Location = new System.Drawing.Point(810, 535);
            this.btn_addTransaction.Name = "btn_addTransaction";
            this.btn_addTransaction.Size = new System.Drawing.Size(139, 33);
            this.btn_addTransaction.TabIndex = 50;
            this.btn_addTransaction.Text = "Add Transaction";
            this.btn_addTransaction.UseVisualStyleBackColor = false;
            this.btn_addTransaction.Click += new System.EventHandler(this.btn_addTransaction_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(678, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 26);
            this.txt_search.TabIndex = 49;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_searchText
            // 
            this.lbl_searchText.AutoSize = true;
            this.lbl_searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchText.Location = new System.Drawing.Point(600, 16);
            this.lbl_searchText.Name = "lbl_searchText";
            this.lbl_searchText.Size = new System.Drawing.Size(71, 20);
            this.lbl_searchText.TabIndex = 48;
            this.lbl_searchText.Text = "Search:";
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(960, 577);
            this.Load += new System.EventHandler(this.TransactionControl_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lbl_transactionMenu;
        private System.Windows.Forms.Button btn_addTransaction;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchText;
        public System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
