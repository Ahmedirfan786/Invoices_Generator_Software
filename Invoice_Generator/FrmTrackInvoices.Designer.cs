namespace Invoice_Generator
{
    partial class FrmTrackInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrackInvoices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtInvoiceNumber = new System.Windows.Forms.Label();
            this.TxtInvoiceId = new System.Windows.Forms.Label();
            this.PrintInvoiceBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.InvoicesGridView = new System.Windows.Forms.DataGridView();
            this.InvoiceItemsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.LblFromDate = new System.Windows.Forms.Label();
            this.LblToDate = new System.Windows.Forms.Label();
            this.TxtSearchInvoice = new System.Windows.Forms.TextBox();
            this.LblSearchInvoice = new System.Windows.Forms.Label();
            this.DateFilterInvoicesBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtInvoiceNumber);
            this.panel1.Controls.Add(this.TxtInvoiceId);
            this.panel1.Controls.Add(this.PrintInvoiceBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-30, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1982, 172);
            this.panel1.TabIndex = 0;
            // 
            // TxtInvoiceNumber
            // 
            this.TxtInvoiceNumber.AutoSize = true;
            this.TxtInvoiceNumber.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoiceNumber.Location = new System.Drawing.Point(1432, 112);
            this.TxtInvoiceNumber.Name = "TxtInvoiceNumber";
            this.TxtInvoiceNumber.Size = new System.Drawing.Size(200, 32);
            this.TxtInvoiceNumber.TabIndex = 11;
            this.TxtInvoiceNumber.Text = "Invoice Number";
            // 
            // TxtInvoiceId
            // 
            this.TxtInvoiceId.AutoSize = true;
            this.TxtInvoiceId.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoiceId.Location = new System.Drawing.Point(1447, 58);
            this.TxtInvoiceId.Name = "TxtInvoiceId";
            this.TxtInvoiceId.Size = new System.Drawing.Size(128, 32);
            this.TxtInvoiceId.TabIndex = 10;
            this.TxtInvoiceId.Text = "Invoice Id";
            // 
            // PrintInvoiceBtn
            // 
            this.PrintInvoiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintInvoiceBtn.Location = new System.Drawing.Point(1695, 58);
            this.PrintInvoiceBtn.Name = "PrintInvoiceBtn";
            this.PrintInvoiceBtn.Size = new System.Drawing.Size(208, 86);
            this.PrintInvoiceBtn.TabIndex = 2;
            this.PrintInvoiceBtn.Text = "Print Invoice";
            this.PrintInvoiceBtn.UseVisualStyleBackColor = true;
            this.PrintInvoiceBtn.Click += new System.EventHandler(this.PrintInvoiceBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.DarkViolet;
            this.Title.Location = new System.Drawing.Point(273, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(399, 74);
            this.Title.TabIndex = 0;
            this.Title.Text = "Track Invoices";
            // 
            // InvoicesGridView
            // 
            this.InvoicesGridView.AllowUserToAddRows = false;
            this.InvoicesGridView.AllowUserToDeleteRows = false;
            this.InvoicesGridView.AllowUserToResizeColumns = false;
            this.InvoicesGridView.AllowUserToResizeRows = false;
            this.InvoicesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoicesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InvoicesGridView.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.InvoicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicesGridView.Location = new System.Drawing.Point(27, 411);
            this.InvoicesGridView.Name = "InvoicesGridView";
            this.InvoicesGridView.ReadOnly = true;
            this.InvoicesGridView.RowHeadersVisible = false;
            this.InvoicesGridView.RowHeadersWidth = 62;
            this.InvoicesGridView.RowTemplate.Height = 28;
            this.InvoicesGridView.Size = new System.Drawing.Size(825, 468);
            this.InvoicesGridView.TabIndex = 1;
            this.InvoicesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoicesGridView_CellClick);
            // 
            // InvoiceItemsGridView
            // 
            this.InvoiceItemsGridView.AllowUserToAddRows = false;
            this.InvoiceItemsGridView.AllowUserToDeleteRows = false;
            this.InvoiceItemsGridView.AllowUserToResizeColumns = false;
            this.InvoiceItemsGridView.AllowUserToResizeRows = false;
            this.InvoiceItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceItemsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InvoiceItemsGridView.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.InvoiceItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItemsGridView.Location = new System.Drawing.Point(894, 411);
            this.InvoiceItemsGridView.Name = "InvoiceItemsGridView";
            this.InvoiceItemsGridView.RowHeadersVisible = false;
            this.InvoiceItemsGridView.RowHeadersWidth = 62;
            this.InvoiceItemsGridView.RowTemplate.Height = 28;
            this.InvoiceItemsGridView.Size = new System.Drawing.Size(1009, 468);
            this.InvoiceItemsGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(896, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invoice Items";
            // 
            // FromDateDTPicker
            // 
            this.FromDateDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FromDateDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateDTPicker.Location = new System.Drawing.Point(36, 319);
            this.FromDateDTPicker.Name = "FromDateDTPicker";
            this.FromDateDTPicker.Size = new System.Drawing.Size(200, 30);
            this.FromDateDTPicker.TabIndex = 4;
            // 
            // ToDateDTPicker
            // 
            this.ToDateDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ToDateDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateDTPicker.Location = new System.Drawing.Point(286, 319);
            this.ToDateDTPicker.Name = "ToDateDTPicker";
            this.ToDateDTPicker.Size = new System.Drawing.Size(200, 30);
            this.ToDateDTPicker.TabIndex = 5;
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromDate.Location = new System.Drawing.Point(36, 293);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(112, 25);
            this.LblFromDate.TabIndex = 6;
            this.LblFromDate.Text = "From Date";
            // 
            // LblToDate
            // 
            this.LblToDate.AutoSize = true;
            this.LblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToDate.Location = new System.Drawing.Point(282, 293);
            this.LblToDate.Name = "LblToDate";
            this.LblToDate.Size = new System.Drawing.Size(89, 25);
            this.LblToDate.TabIndex = 7;
            this.LblToDate.Text = "To Date";
            // 
            // TxtSearchInvoice
            // 
            this.TxtSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSearchInvoice.Location = new System.Drawing.Point(133, 368);
            this.TxtSearchInvoice.Name = "TxtSearchInvoice";
            this.TxtSearchInvoice.Size = new System.Drawing.Size(719, 30);
            this.TxtSearchInvoice.TabIndex = 8;
            this.TxtSearchInvoice.TextChanged += new System.EventHandler(this.TxtSearchInvoice_TextChanged);
            // 
            // LblSearchInvoice
            // 
            this.LblSearchInvoice.AutoSize = true;
            this.LblSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchInvoice.Location = new System.Drawing.Point(36, 368);
            this.LblSearchInvoice.Name = "LblSearchInvoice";
            this.LblSearchInvoice.Size = new System.Drawing.Size(81, 25);
            this.LblSearchInvoice.TabIndex = 9;
            this.LblSearchInvoice.Text = "Search";
            // 
            // DateFilterInvoicesBtn
            // 
            this.DateFilterInvoicesBtn.BackColor = System.Drawing.Color.Salmon;
            this.DateFilterInvoicesBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFilterInvoicesBtn.ForeColor = System.Drawing.Color.White;
            this.DateFilterInvoicesBtn.Location = new System.Drawing.Point(509, 306);
            this.DateFilterInvoicesBtn.Name = "DateFilterInvoicesBtn";
            this.DateFilterInvoicesBtn.Size = new System.Drawing.Size(176, 43);
            this.DateFilterInvoicesBtn.TabIndex = 10;
            this.DateFilterInvoicesBtn.Text = "Filter";
            this.DateFilterInvoicesBtn.UseVisualStyleBackColor = false;
            this.DateFilterInvoicesBtn.Click += new System.EventHandler(this.DateFilterInvoicesBtn_Click);
            // 
            // FrmTrackInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1924, 1024);
            this.Controls.Add(this.DateFilterInvoicesBtn);
            this.Controls.Add(this.LblSearchInvoice);
            this.Controls.Add(this.TxtSearchInvoice);
            this.Controls.Add(this.LblToDate);
            this.Controls.Add(this.LblFromDate);
            this.Controls.Add(this.ToDateDTPicker);
            this.Controls.Add(this.FromDateDTPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvoiceItemsGridView);
            this.Controls.Add(this.InvoicesGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTrackInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrackInvoices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTrackInvoices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView InvoicesGridView;
        private System.Windows.Forms.DataGridView InvoiceItemsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDateDTPicker;
        private System.Windows.Forms.DateTimePicker ToDateDTPicker;
        private System.Windows.Forms.Label LblFromDate;
        private System.Windows.Forms.Label LblToDate;
        private System.Windows.Forms.TextBox TxtSearchInvoice;
        private System.Windows.Forms.Label LblSearchInvoice;
        private System.Windows.Forms.Label TxtInvoiceId;
        private System.Windows.Forms.Label TxtInvoiceNumber;
        private System.Windows.Forms.Button PrintInvoiceBtn;
        private System.Windows.Forms.Button DateFilterInvoicesBtn;
    }
}