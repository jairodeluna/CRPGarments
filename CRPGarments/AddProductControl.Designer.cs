namespace CRPGarments
{
    partial class AddProductControl
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
            this.cmb_sizes = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_imageLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_noOfStocks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_item = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveProducts = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.lbl_pageTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.cmb_sizes);
            this.ContentPanel.Controls.Add(this.cmb_status);
            this.ContentPanel.Controls.Add(this.btn_cancel);
            this.ContentPanel.Controls.Add(this.btn_browse);
            this.ContentPanel.Controls.Add(this.txt_imageLink);
            this.ContentPanel.Controls.Add(this.label3);
            this.ContentPanel.Controls.Add(this.label8);
            this.ContentPanel.Controls.Add(this.txt_noOfStocks);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.pic_item);
            this.ContentPanel.Controls.Add(this.label5);
            this.ContentPanel.Controls.Add(this.lbl_price);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.btn_saveProducts);
            this.ContentPanel.Controls.Add(this.txt_category);
            this.ContentPanel.Controls.Add(this.txt_price);
            this.ContentPanel.Controls.Add(this.txt_productName);
            this.ContentPanel.Controls.Add(this.lbl_pageTitle);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(960, 577);
            this.ContentPanel.TabIndex = 0;
            // 
            // cmb_sizes
            // 
            this.cmb_sizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sizes.FormattingEnabled = true;
            this.cmb_sizes.Location = new System.Drawing.Point(276, 267);
            this.cmb_sizes.Name = "cmb_sizes";
            this.cmb_sizes.Size = new System.Drawing.Size(165, 32);
            this.cmb_sizes.TabIndex = 3;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(35, 364);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(223, 32);
            this.cmb_status.TabIndex = 5;
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
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.SystemColors.Control;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.Black;
            this.btn_browse.Location = new System.Drawing.Point(873, 463);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(73, 33);
            this.btn_browse.TabIndex = 102;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_imageLink
            // 
            this.txt_imageLink.Enabled = false;
            this.txt_imageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imageLink.Location = new System.Drawing.Point(625, 467);
            this.txt_imageLink.Name = "txt_imageLink";
            this.txt_imageLink.Size = new System.Drawing.Size(242, 26);
            this.txt_imageLink.TabIndex = 101;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "No. of Stocks";
            // 
            // txt_noOfStocks
            // 
            this.txt_noOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noOfStocks.Location = new System.Drawing.Point(457, 269);
            this.txt_noOfStocks.MaxLength = 5;
            this.txt_noOfStocks.Name = "txt_noOfStocks";
            this.txt_noOfStocks.Size = new System.Drawing.Size(99, 31);
            this.txt_noOfStocks.TabIndex = 4;
            this.txt_noOfStocks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_noOfStocks_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Size";
            // 
            // pic_item
            // 
            this.pic_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.label5.Location = new System.Drawing.Point(31, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Category";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(330, 320);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(43, 19);
            this.lbl_price.TabIndex = 92;
            this.lbl_price.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Product Name";
            // 
            // btn_saveProducts
            // 
            this.btn_saveProducts.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_saveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveProducts.ForeColor = System.Drawing.Color.White;
            this.btn_saveProducts.Location = new System.Drawing.Point(807, 531);
            this.btn_saveProducts.Name = "btn_saveProducts";
            this.btn_saveProducts.Size = new System.Drawing.Size(139, 33);
            this.btn_saveProducts.TabIndex = 90;
            this.btn_saveProducts.Text = "Save";
            this.btn_saveProducts.UseVisualStyleBackColor = false;
            this.btn_saveProducts.Click += new System.EventHandler(this.btn_saveProducts_Click);
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(35, 269);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(223, 31);
            this.txt_category.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(334, 342);
            this.txt_price.MaxLength = 10;
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(223, 53);
            this.txt_price.TabIndex = 6;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(35, 177);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(522, 31);
            this.txt_productName.TabIndex = 1;
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
            this.lbl_pageTitle.Text = "ADD PRODUCTS";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "AddProductControl";
            this.Size = new System.Drawing.Size(960, 577);
            this.Load += new System.EventHandler(this.AddProductControl_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_imageLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_noOfStocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveProducts;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label lbl_pageTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_sizes;
    }
}
