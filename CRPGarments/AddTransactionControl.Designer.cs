namespace CRPGarments
{
    partial class AddTransactionControl
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_noOfStocks = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_productName = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_item = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveTransaction = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_pageTitle = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(960, 577);
            this.ContentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_noOfStocks);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.cmb_size);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.cmb_productName);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_status);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pic_item);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_saveTransaction);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.lbl_pageTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 577);
            this.panel1.TabIndex = 1;
            // 
            // lbl_noOfStocks
            // 
            this.lbl_noOfStocks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noOfStocks.Location = new System.Drawing.Point(330, 303);
            this.lbl_noOfStocks.Name = "lbl_noOfStocks";
            this.lbl_noOfStocks.Size = new System.Drawing.Size(227, 19);
            this.lbl_noOfStocks.TabIndex = 108;
            this.lbl_noOfStocks.Text = "test";
            this.lbl_noOfStocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(334, 269);
            this.txt_quantity.MaxLength = 5;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(223, 31);
            this.txt_quantity.TabIndex = 4;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // cmb_size
            // 
            this.cmb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(35, 269);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(223, 33);
            this.cmb_size.TabIndex = 3;
            this.cmb_size.SelectedIndexChanged += new System.EventHandler(this.cmb_size_SelectedIndexChanged);
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(35, 197);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(522, 33);
            this.cmb_category.TabIndex = 2;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // cmb_productName
            // 
            this.cmb_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmb_productName.FormattingEnabled = true;
            this.cmb_productName.Location = new System.Drawing.Point(35, 111);
            this.cmb_productName.Name = "cmb_productName";
            this.cmb_productName.Size = new System.Drawing.Size(522, 33);
            this.cmb_productName.TabIndex = 1;
            this.cmb_productName.SelectedIndexChanged += new System.EventHandler(this.cmb_productName_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(15, 531);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 33);
            this.btn_cancel.TabIndex = 103;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(35, 364);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(223, 31);
            this.txt_status.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Size";
            // 
            // pic_item
            // 
            this.pic_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_item.Location = new System.Drawing.Point(625, 111);
            this.pic_item.Name = "pic_item";
            this.pic_item.Size = new System.Drawing.Size(321, 339);
            this.pic_item.TabIndex = 94;
            this.pic_item.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 92;
            this.label4.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Product Name";
            // 
            // btn_saveTransaction
            // 
            this.btn_saveTransaction.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_saveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_saveTransaction.Location = new System.Drawing.Point(807, 531);
            this.btn_saveTransaction.Name = "btn_saveTransaction";
            this.btn_saveTransaction.Size = new System.Drawing.Size(139, 33);
            this.btn_saveTransaction.TabIndex = 90;
            this.btn_saveTransaction.Text = "Save";
            this.btn_saveTransaction.UseVisualStyleBackColor = false;
            this.btn_saveTransaction.Click += new System.EventHandler(this.btn_saveTransaction_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.txt_amount.Location = new System.Drawing.Point(334, 364);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(223, 53);
            this.txt_amount.TabIndex = 88;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // lbl_pageTitle
            // 
            this.lbl_pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pageTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pageTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_pageTitle.Location = new System.Drawing.Point(21, 12);
            this.lbl_pageTitle.Name = "lbl_pageTitle";
            this.lbl_pageTitle.Size = new System.Drawing.Size(363, 43);
            this.lbl_pageTitle.TabIndex = 86;
            this.lbl_pageTitle.Text = "ADD TRANSACTIONS";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "AddTransactionControl";
            this.Size = new System.Drawing.Size(960, 577);
            this.Load += new System.EventHandler(this.AddTransactionControl_Load);
            this.ContentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveTransaction;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_pageTitle;
        private System.Windows.Forms.ComboBox cmb_productName;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label lbl_noOfStocks;
    }
}
