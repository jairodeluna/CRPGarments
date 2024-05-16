namespace CRPGarments
{
    partial class AccountControl
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchText = new System.Windows.Forms.Label();
            this.userAccountDataGridView = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_transactionMenu = new System.Windows.Forms.Label();
            this.btn_addAccount = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.txt_search);
            this.ContentPanel.Controls.Add(this.lbl_searchText);
            this.ContentPanel.Controls.Add(this.userAccountDataGridView);
            this.ContentPanel.Controls.Add(this.lbl_transactionMenu);
            this.ContentPanel.Controls.Add(this.btn_addAccount);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(960, 577);
            this.ContentPanel.TabIndex = 0;
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
            // userAccountDataGridView
            // 
            this.userAccountDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userAccountDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.LastName,
            this.ContactNumber,
            this.Address,
            this.Username,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userAccountDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.userAccountDataGridView.Location = new System.Drawing.Point(11, 54);
            this.userAccountDataGridView.Name = "userAccountDataGridView";
            this.userAccountDataGridView.RowHeadersVisible = false;
            this.userAccountDataGridView.Size = new System.Drawing.Size(938, 470);
            this.userAccountDataGridView.TabIndex = 42;
            this.userAccountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userAccountDataGridView_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Full Name";
            this.LastName.Name = "LastName";
            this.LastName.Width = 215;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 220;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 170;
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
            this.lbl_transactionMenu.TabIndex = 46;
            this.lbl_transactionMenu.Text = "ACCOUNT MANAGEMENT";
            this.lbl_transactionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addAccount
            // 
            this.btn_addAccount.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_addAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAccount.ForeColor = System.Drawing.Color.White;
            this.btn_addAccount.Location = new System.Drawing.Point(810, 535);
            this.btn_addAccount.Name = "btn_addAccount";
            this.btn_addAccount.Size = new System.Drawing.Size(139, 33);
            this.btn_addAccount.TabIndex = 45;
            this.btn_addAccount.Text = "Add Account";
            this.btn_addAccount.UseVisualStyleBackColor = false;
            this.btn_addAccount.Click += new System.EventHandler(this.btn_addAccount_Click);
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(960, 577);
            this.Load += new System.EventHandler(this.AccountControl_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchText;
        public System.Windows.Forms.DataGridView userAccountDataGridView;
        private System.Windows.Forms.Label lbl_transactionMenu;
        private System.Windows.Forms.Button btn_addAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
