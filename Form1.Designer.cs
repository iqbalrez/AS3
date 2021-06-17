
namespace SelfService
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.cBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Cart = new System.Windows.Forms.Label();
            this.btn_PilihPants = new System.Windows.Forms.Button();
            this.dgPants = new System.Windows.Forms.DataGridView();
            this.pBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PilihShirt = new System.Windows.Forms.Button();
            this.dgShirts = new System.Windows.Forms.DataGridView();
            this.sBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShirts)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_PilihPants);
            this.groupBox1.Controls.Add(this.dgPants);
            this.groupBox1.Controls.Add(this.btn_PilihShirt);
            this.groupBox1.Controls.Add(this.dgShirts);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(1284, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Produk:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.btn_Checkout);
            this.groupBox2.Controls.Add(this.dgCart);
            this.groupBox2.Controls.Add(this.lbl_Cart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 480);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(935, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.Control;
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove.Location = new System.Drawing.Point(799, 81);
            this.Remove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(134, 54);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Checkout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Checkout.Location = new System.Drawing.Point(799, 27);
            this.btn_Checkout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(134, 54);
            this.btn_Checkout.TabIndex = 3;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            this.dgCart.AllowUserToDeleteRows = false;
            this.dgCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBrand,
            this.cType,
            this.cSize,
            this.cPrice});
            this.dgCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgCart.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCart.Location = new System.Drawing.Point(2, 27);
            this.dgCart.Name = "dgCart";
            this.dgCart.ReadOnly = true;
            this.dgCart.Size = new System.Drawing.Size(797, 111);
            this.dgCart.TabIndex = 7;
            // 
            // cBrand
            // 
            this.cBrand.HeaderText = "Brand";
            this.cBrand.Name = "cBrand";
            this.cBrand.ReadOnly = true;
            // 
            // cType
            // 
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.HeaderText = "Size";
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Price";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // lbl_Cart
            // 
            this.lbl_Cart.AutoSize = true;
            this.lbl_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Cart.Location = new System.Drawing.Point(2, 14);
            this.lbl_Cart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cart.Name = "lbl_Cart";
            this.lbl_Cart.Size = new System.Drawing.Size(58, 13);
            this.lbl_Cart.TabIndex = 1;
            this.lbl_Cart.Text = "Keranjang:";
            // 
            // btn_PilihPants
            // 
            this.btn_PilihPants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PilihPants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PilihPants.Location = new System.Drawing.Point(2, 450);
            this.btn_PilihPants.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_PilihPants.Name = "btn_PilihPants";
            this.btn_PilihPants.Size = new System.Drawing.Size(935, 30);
            this.btn_PilihPants.TabIndex = 4;
            this.btn_PilihPants.Text = "Pilih";
            this.btn_PilihPants.UseVisualStyleBackColor = true;
            this.btn_PilihPants.Click += new System.EventHandler(this.btn_PilihPants_Click);
            // 
            // dgPants
            // 
            this.dgPants.AllowUserToAddRows = false;
            this.dgPants.AllowUserToDeleteRows = false;
            this.dgPants.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBrand,
            this.pType,
            this.pSize,
            this.pPrice,
            this.pStock});
            this.dgPants.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgPants.Location = new System.Drawing.Point(2, 247);
            this.dgPants.Margin = new System.Windows.Forms.Padding(2);
            this.dgPants.Name = "dgPants";
            this.dgPants.ReadOnly = true;
            this.dgPants.RowHeadersWidth = 62;
            this.dgPants.RowTemplate.Height = 28;
            this.dgPants.Size = new System.Drawing.Size(935, 203);
            this.dgPants.TabIndex = 8;
            // 
            // pBrand
            // 
            this.pBrand.HeaderText = "Brand";
            this.pBrand.MinimumWidth = 8;
            this.pBrand.Name = "pBrand";
            this.pBrand.ReadOnly = true;
            this.pBrand.Width = 150;
            // 
            // pType
            // 
            this.pType.HeaderText = "Type";
            this.pType.MinimumWidth = 8;
            this.pType.Name = "pType";
            this.pType.ReadOnly = true;
            this.pType.Width = 150;
            // 
            // pSize
            // 
            this.pSize.HeaderText = "Size";
            this.pSize.MinimumWidth = 8;
            this.pSize.Name = "pSize";
            this.pSize.ReadOnly = true;
            this.pSize.Width = 150;
            // 
            // pPrice
            // 
            this.pPrice.HeaderText = "Price";
            this.pPrice.MinimumWidth = 8;
            this.pPrice.Name = "pPrice";
            this.pPrice.ReadOnly = true;
            this.pPrice.Width = 150;
            // 
            // pStock
            // 
            this.pStock.HeaderText = "Stock";
            this.pStock.MinimumWidth = 8;
            this.pStock.Name = "pStock";
            this.pStock.ReadOnly = true;
            this.pStock.Width = 150;
            // 
            // btn_PilihShirt
            // 
            this.btn_PilihShirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PilihShirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PilihShirt.Location = new System.Drawing.Point(2, 215);
            this.btn_PilihShirt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_PilihShirt.Name = "btn_PilihShirt";
            this.btn_PilihShirt.Size = new System.Drawing.Size(935, 32);
            this.btn_PilihShirt.TabIndex = 5;
            this.btn_PilihShirt.Text = "Pilih";
            this.btn_PilihShirt.UseVisualStyleBackColor = true;
            this.btn_PilihShirt.Click += new System.EventHandler(this.btn_PilihShirt_Click);
            // 
            // dgShirts
            // 
            this.dgShirts.AllowUserToAddRows = false;
            this.dgShirts.AllowUserToDeleteRows = false;
            this.dgShirts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgShirts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShirts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sBrand,
            this.sType,
            this.sSize,
            this.sPrice,
            this.sStock});
            this.dgShirts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgShirts.Location = new System.Drawing.Point(2, 14);
            this.dgShirts.Margin = new System.Windows.Forms.Padding(2);
            this.dgShirts.Name = "dgShirts";
            this.dgShirts.ReadOnly = true;
            this.dgShirts.RowHeadersWidth = 62;
            this.dgShirts.RowTemplate.Height = 28;
            this.dgShirts.Size = new System.Drawing.Size(935, 201);
            this.dgShirts.TabIndex = 7;
            // 
            // sBrand
            // 
            this.sBrand.HeaderText = "Brand";
            this.sBrand.MinimumWidth = 8;
            this.sBrand.Name = "sBrand";
            this.sBrand.ReadOnly = true;
            this.sBrand.Width = 150;
            // 
            // sType
            // 
            this.sType.HeaderText = "Type";
            this.sType.MinimumWidth = 8;
            this.sType.Name = "sType";
            this.sType.ReadOnly = true;
            this.sType.Width = 150;
            // 
            // sSize
            // 
            this.sSize.HeaderText = "Size";
            this.sSize.MinimumWidth = 8;
            this.sSize.Name = "sSize";
            this.sSize.ReadOnly = true;
            this.sSize.Width = 150;
            // 
            // sPrice
            // 
            this.sPrice.HeaderText = "Price";
            this.sPrice.MinimumWidth = 8;
            this.sPrice.Name = "sPrice";
            this.sPrice.ReadOnly = true;
            this.sPrice.Width = 150;
            // 
            // sStock
            // 
            this.sStock.HeaderText = "Stock";
            this.sStock.MinimumWidth = 8;
            this.sStock.Name = "sStock";
            this.sStock.ReadOnly = true;
            this.sStock.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbQR);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(937, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(345, 608);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Struk";
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbQR.Location = new System.Drawing.Point(9, 458);
            this.pbQR.Margin = new System.Windows.Forms.Padding(2);
            this.pbQR.MaximumSize = new System.Drawing.Size(147, 143);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(147, 143);
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResult.Location = new System.Drawing.Point(2, 15);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(341, 589);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1284, 27);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apparel Store [Self-Service]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                           ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShirts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label lbl_Cart;
        private System.Windows.Forms.Button btn_PilihPants;
        private System.Windows.Forms.Button btn_PilihShirt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.DataGridView dgPants;
        private System.Windows.Forms.DataGridView dgShirts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn pType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn sType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStock;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
    }
}

