namespace Invoice_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblShopTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAdminId = new System.Windows.Forms.Label();
            this.LblAdminUsername = new System.Windows.Forms.Label();
            this.ManageProfileBtn = new System.Windows.Forms.Button();
            this.ManageShopBtn = new System.Windows.Forms.Button();
            this.TrackInvoicesBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LblShopPhone2 = new System.Windows.Forms.Label();
            this.LblShopPhone1 = new System.Windows.Forms.Label();
            this.LblShopAddress = new System.Windows.Forms.Label();
            this.ShopLogo = new System.Windows.Forms.PictureBox();
            this.TxtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtItemPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtItemQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OptionItemUnit = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveInvoiceBtn = new System.Windows.Forms.Button();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.LblShopCurrency = new System.Windows.Forms.Label();
            this.SaveAndPrintInvoiceBtn = new System.Windows.Forms.Button();
            this.TxtItemId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LblShopTitle
            // 
            this.LblShopTitle.AutoSize = true;
            this.LblShopTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.LblShopTitle.Location = new System.Drawing.Point(330, 38);
            this.LblShopTitle.Name = "LblShopTitle";
            this.LblShopTitle.Size = new System.Drawing.Size(481, 67);
            this.LblShopTitle.TabIndex = 7;
            this.LblShopTitle.Text = "Texonware Gaming";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.LblAdminId);
            this.panel1.Controls.Add(this.LblAdminUsername);
            this.panel1.Controls.Add(this.ManageProfileBtn);
            this.panel1.Controls.Add(this.ManageShopBtn);
            this.panel1.Controls.Add(this.TrackInvoicesBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.LblShopPhone2);
            this.panel1.Controls.Add(this.LblShopPhone1);
            this.panel1.Controls.Add(this.LblShopAddress);
            this.panel1.Controls.Add(this.ShopLogo);
            this.panel1.Controls.Add(this.LblShopTitle);
            this.panel1.Location = new System.Drawing.Point(-22, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1982, 242);
            this.panel1.TabIndex = 8;
            // 
            // LblAdminId
            // 
            this.LblAdminId.AutoSize = true;
            this.LblAdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminId.ForeColor = System.Drawing.Color.Blue;
            this.LblAdminId.Location = new System.Drawing.Point(1717, 183);
            this.LblAdminId.Name = "LblAdminId";
            this.LblAdminId.Size = new System.Drawing.Size(97, 25);
            this.LblAdminId.TabIndex = 18;
            this.LblAdminId.Text = "Admin Id";
            // 
            // LblAdminUsername
            // 
            this.LblAdminUsername.AutoSize = true;
            this.LblAdminUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminUsername.Location = new System.Drawing.Point(1470, 176);
            this.LblAdminUsername.Name = "LblAdminUsername";
            this.LblAdminUsername.Size = new System.Drawing.Size(211, 32);
            this.LblAdminUsername.TabIndex = 17;
            this.LblAdminUsername.Text = "Admin Username";
            // 
            // ManageProfileBtn
            // 
            this.ManageProfileBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.ManageProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ManageProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.ManageProfileBtn.Location = new System.Drawing.Point(1476, 27);
            this.ManageProfileBtn.Name = "ManageProfileBtn";
            this.ManageProfileBtn.Size = new System.Drawing.Size(216, 52);
            this.ManageProfileBtn.TabIndex = 16;
            this.ManageProfileBtn.Text = "Manage Profile";
            this.ManageProfileBtn.UseVisualStyleBackColor = false;
            this.ManageProfileBtn.Click += new System.EventHandler(this.ManageProfileBtn_Click);
            // 
            // ManageShopBtn
            // 
            this.ManageShopBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ManageShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageShopBtn.ForeColor = System.Drawing.Color.White;
            this.ManageShopBtn.Location = new System.Drawing.Point(1476, 93);
            this.ManageShopBtn.Name = "ManageShopBtn";
            this.ManageShopBtn.Size = new System.Drawing.Size(216, 53);
            this.ManageShopBtn.TabIndex = 15;
            this.ManageShopBtn.Text = "Manage Shop";
            this.ManageShopBtn.UseVisualStyleBackColor = false;
            this.ManageShopBtn.Click += new System.EventHandler(this.ManageShopBtn_Click);
            // 
            // TrackInvoicesBtn
            // 
            this.TrackInvoicesBtn.BackColor = System.Drawing.Color.Yellow;
            this.TrackInvoicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackInvoicesBtn.ForeColor = System.Drawing.Color.Black;
            this.TrackInvoicesBtn.Location = new System.Drawing.Point(1698, 93);
            this.TrackInvoicesBtn.Name = "TrackInvoicesBtn";
            this.TrackInvoicesBtn.Size = new System.Drawing.Size(236, 53);
            this.TrackInvoicesBtn.TabIndex = 14;
            this.TrackInvoicesBtn.Text = "Track Invoices";
            this.TrackInvoicesBtn.UseVisualStyleBackColor = false;
            this.TrackInvoicesBtn.Click += new System.EventHandler(this.TrackInvoicesBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(1698, 26);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(235, 53);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "Close / Logout";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LblShopPhone2
            // 
            this.LblShopPhone2.AutoSize = true;
            this.LblShopPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblShopPhone2.Location = new System.Drawing.Point(668, 168);
            this.LblShopPhone2.Name = "LblShopPhone2";
            this.LblShopPhone2.Size = new System.Drawing.Size(183, 29);
            this.LblShopPhone2.TabIndex = 12;
            this.LblShopPhone2.Text = "+923452881927";
            // 
            // LblShopPhone1
            // 
            this.LblShopPhone1.AutoSize = true;
            this.LblShopPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblShopPhone1.Location = new System.Drawing.Point(348, 168);
            this.LblShopPhone1.Name = "LblShopPhone1";
            this.LblShopPhone1.Size = new System.Drawing.Size(183, 29);
            this.LblShopPhone1.TabIndex = 11;
            this.LblShopPhone1.Text = "+923452881927";
            // 
            // LblShopAddress
            // 
            this.LblShopAddress.AutoSize = true;
            this.LblShopAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblShopAddress.Location = new System.Drawing.Point(348, 117);
            this.LblShopAddress.Name = "LblShopAddress";
            this.LblShopAddress.Size = new System.Drawing.Size(725, 29);
            this.LblShopAddress.TabIndex = 10;
            this.LblShopAddress.Text = "Store G-155/156 Naz Digital Plaza M.A Jinnah Road Sadar Karachi.";
            // 
            // ShopLogo
            // 
            this.ShopLogo.Image = ((System.Drawing.Image)(resources.GetObject("ShopLogo.Image")));
            this.ShopLogo.Location = new System.Drawing.Point(72, 38);
            this.ShopLogo.Name = "ShopLogo";
            this.ShopLogo.Size = new System.Drawing.Size(225, 182);
            this.ShopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShopLogo.TabIndex = 9;
            this.ShopLogo.TabStop = false;
            // 
            // TxtInvoiceNumber
            // 
            this.TxtInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtInvoiceNumber.Location = new System.Drawing.Point(1542, 260);
            this.TxtInvoiceNumber.Name = "TxtInvoiceNumber";
            this.TxtInvoiceNumber.ReadOnly = true;
            this.TxtInvoiceNumber.Size = new System.Drawing.Size(350, 39);
            this.TxtInvoiceNumber.TabIndex = 10;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(1293, 262);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(243, 38);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "Invoice Number :";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtCustomerName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtCustomerName.Location = new System.Drawing.Point(902, 260);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(370, 39);
            this.TxtCustomerName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer Name :";
            // 
            // TxtItemName
            // 
            this.TxtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtItemName.Location = new System.Drawing.Point(176, 488);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(370, 39);
            this.TxtItemName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name :";
            // 
            // TxtItemPrice
            // 
            this.TxtItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtItemPrice.Location = new System.Drawing.Point(176, 571);
            this.TxtItemPrice.Name = "TxtItemPrice";
            this.TxtItemPrice.Size = new System.Drawing.Size(370, 39);
            this.TxtItemPrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price :";
            // 
            // TxtItemQty
            // 
            this.TxtItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtItemQty.Location = new System.Drawing.Point(176, 649);
            this.TxtItemQty.Name = "TxtItemQty";
            this.TxtItemQty.Size = new System.Drawing.Size(370, 39);
            this.TxtItemQty.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 649);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 38);
            this.label7.TabIndex = 17;
            this.label7.Text = "Qty :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 729);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit :";
            // 
            // OptionItemUnit
            // 
            this.OptionItemUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OptionItemUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OptionItemUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OptionItemUnit.FormattingEnabled = true;
            this.OptionItemUnit.Items.AddRange(new object[] {
            "Pc",
            "Kg",
            "g",
            "mg",
            "L",
            "ml",
            "Bottle",
            "Carton",
            "Dozen",
            "Set",
            "Roll"});
            this.OptionItemUnit.Location = new System.Drawing.Point(176, 728);
            this.OptionItemUnit.Name = "OptionItemUnit";
            this.OptionItemUnit.Size = new System.Drawing.Size(370, 40);
            this.OptionItemUnit.TabIndex = 20;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(176, 828);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(160, 55);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(176, 828);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(344, 55);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(176, 889);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(160, 55);
            this.DeleteBtn.TabIndex = 23;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(358, 889);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(160, 55);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(38, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 67);
            this.label9.TabIndex = 13;
            this.label9.Text = "Manage Items";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AllowUserToResizeColumns = false;
            this.ItemsDataGridView.AllowUserToResizeRows = false;
            this.ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(606, 355);
            this.ItemsDataGridView.MultiSelect = false;
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.RowHeadersWidth = 62;
            this.ItemsDataGridView.RowTemplate.Height = 28;
            this.ItemsDataGridView.Size = new System.Drawing.Size(1286, 520);
            this.ItemsDataGridView.TabIndex = 25;
            this.ItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellClick);
            // 
            // SaveInvoiceBtn
            // 
            this.SaveInvoiceBtn.BackColor = System.Drawing.Color.Pink;
            this.SaveInvoiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInvoiceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveInvoiceBtn.Location = new System.Drawing.Point(1234, 902);
            this.SaveInvoiceBtn.Name = "SaveInvoiceBtn";
            this.SaveInvoiceBtn.Size = new System.Drawing.Size(302, 82);
            this.SaveInvoiceBtn.TabIndex = 26;
            this.SaveInvoiceBtn.Text = "Save Invoice (Without Print)";
            this.SaveInvoiceBtn.UseVisualStyleBackColor = false;
            this.SaveInvoiceBtn.Click += new System.EventHandler(this.SaveInvoiceBtn_Click);
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.LblTotalPrice.Location = new System.Drawing.Point(604, 902);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(173, 67);
            this.LblTotalPrice.TabIndex = 28;
            this.LblTotalPrice.Text = "Total :";
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtTotalPrice.ForeColor = System.Drawing.Color.Blue;
            this.TxtTotalPrice.Location = new System.Drawing.Point(902, 921);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.ReadOnly = true;
            this.TxtTotalPrice.Size = new System.Drawing.Size(288, 48);
            this.TxtTotalPrice.TabIndex = 29;
            // 
            // LblShopCurrency
            // 
            this.LblShopCurrency.AutoSize = true;
            this.LblShopCurrency.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblShopCurrency.ForeColor = System.Drawing.Color.Red;
            this.LblShopCurrency.Location = new System.Drawing.Point(768, 915);
            this.LblShopCurrency.Name = "LblShopCurrency";
            this.LblShopCurrency.Size = new System.Drawing.Size(71, 54);
            this.LblShopCurrency.TabIndex = 30;
            this.LblShopCurrency.Text = "RS";
            // 
            // SaveAndPrintInvoiceBtn
            // 
            this.SaveAndPrintInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SaveAndPrintInvoiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndPrintInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.SaveAndPrintInvoiceBtn.Location = new System.Drawing.Point(1562, 902);
            this.SaveAndPrintInvoiceBtn.Name = "SaveAndPrintInvoiceBtn";
            this.SaveAndPrintInvoiceBtn.Size = new System.Drawing.Size(333, 82);
            this.SaveAndPrintInvoiceBtn.TabIndex = 27;
            this.SaveAndPrintInvoiceBtn.Text = "Save Invoice ( With Print )";
            this.SaveAndPrintInvoiceBtn.UseVisualStyleBackColor = false;
            this.SaveAndPrintInvoiceBtn.Click += new System.EventHandler(this.SaveAndPrintInvoiceBtn_Click);
            // 
            // TxtItemId
            // 
            this.TxtItemId.AutoSize = true;
            this.TxtItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtItemId.ForeColor = System.Drawing.Color.Red;
            this.TxtItemId.Location = new System.Drawing.Point(44, 435);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Size = new System.Drawing.Size(104, 37);
            this.TxtItemId.TabIndex = 31;
            this.TxtItemId.Text = "ItemId";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.TxtItemId);
            this.Controls.Add(this.LblShopCurrency);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.SaveAndPrintInvoiceBtn);
            this.Controls.Add(this.SaveInvoiceBtn);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.OptionItemUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtItemQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtItemPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtInvoiceNumber);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblShopTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblShopPhone1;
        private System.Windows.Forms.Label LblShopAddress;
        private System.Windows.Forms.PictureBox ShopLogo;
        private System.Windows.Forms.Label LblShopPhone2;
        private System.Windows.Forms.TextBox TxtInvoiceNumber;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtItemPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtItemQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox OptionItemUnit;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.Label LblShopCurrency;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveAndPrintInvoiceBtn;
        private System.Windows.Forms.Button SaveInvoiceBtn;
        private System.Windows.Forms.Label TxtItemId;
        private System.Windows.Forms.Button ManageProfileBtn;
        private System.Windows.Forms.Button ManageShopBtn;
        private System.Windows.Forms.Button TrackInvoicesBtn;
        private System.Windows.Forms.Label LblAdminId;
        private System.Windows.Forms.Label LblAdminUsername;
    }
}