namespace CRPGarments
{
    partial class ReportControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchText = new System.Windows.Forms.Label();
            this.dateToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
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
            this.lbl_totalSalesAmountValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(678, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 26);
            this.txt_search.TabIndex = 44;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_searchText
            // 
            this.lbl_searchText.AutoSize = true;
            this.lbl_searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchText.Location = new System.Drawing.Point(600, 16);
            this.lbl_searchText.Name = "lbl_searchText";
            this.lbl_searchText.Size = new System.Drawing.Size(71, 20);
            this.lbl_searchText.TabIndex = 43;
            this.lbl_searchText.Text = "Search:";
            // 
            // dateToTimePicker
            // 
            this.dateToTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.dateToTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToTimePicker.Location = new System.Drawing.Point(355, 18);
            this.dateToTimePicker.Name = "dateToTimePicker";
            this.dateToTimePicker.Size = new System.Drawing.Size(182, 22);
            this.dateToTimePicker.TabIndex = 49;
            // 
            // dateFromTimePicker
            // 
            this.dateFromTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.dateFromTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromTimePicker.Location = new System.Drawing.Point(93, 18);
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            this.dateFromTimePicker.Size = new System.Drawing.Size(182, 22);
            this.dateFromTimePicker.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Date From:";
            // 
            // btn_filter
            // 
            this.btn_filter.BackgroundImage = global::CRPGarments.Properties.Resources.search;
            this.btn_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_filter.Location = new System.Drawing.Point(544, 13);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(30, 30);
            this.btn_filter.TabIndex = 50;
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.CreatedBy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.transactionDataGridView.Location = new System.Drawing.Point(11, 53);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.RowHeadersVisible = false;
            this.transactionDataGridView.Size = new System.Drawing.Size(938, 484);
            this.transactionDataGridView.TabIndex = 69;
            // 
            // TransactionNo
            // 
            this.TransactionNo.HeaderText = "Transaction No";
            this.TransactionNo.Name = "TransactionNo";
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
            this.ProductName.Width = 180;
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
            this.Quantity.Width = 70;
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
            this.Category.Width = 120;
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
            // lbl_totalSalesAmountValue
            // 
            this.lbl_totalSalesAmountValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalSalesAmountValue.Location = new System.Drawing.Point(498, 543);
            this.lbl_totalSalesAmountValue.Name = "lbl_totalSalesAmountValue";
            this.lbl_totalSalesAmountValue.Size = new System.Drawing.Size(450, 23);
            this.lbl_totalSalesAmountValue.TabIndex = 51;
            this.lbl_totalSalesAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transactionDataGridView);
            this.Controls.Add(this.lbl_totalSalesAmountValue);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dateToTimePicker);
            this.Controls.Add(this.dateFromTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_searchText);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(960, 577);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchText;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker dateToTimePicker;
        private System.Windows.Forms.DateTimePicker dateFromTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label lbl_totalSalesAmountValue;
    }
}
