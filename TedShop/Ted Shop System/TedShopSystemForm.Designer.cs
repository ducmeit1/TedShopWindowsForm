namespace Ted_Shop_System
{
    partial class TedShopSystemForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedShopSystemForm));
            this.menuStripTedShopSystem = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabelStudent = new System.Windows.Forms.ToolStripStatusLabel();
            this.listProductPanel = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblListOfProducts = new System.Windows.Forms.Label();
            this.cbbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.toolStripOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelivery = new System.Windows.Forms.ToolStripButton();
            this.toolStripReport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deliveryPanel = new System.Windows.Forms.Panel();
            this.btnCancelDeliver = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.cbbStaffName = new System.Windows.Forms.ComboBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.deliverDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliverDate = new System.Windows.Forms.Label();
            this.deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.lblListOfOrderWaitingForDelivering = new System.Windows.Forms.Label();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportSelectDateTimeCalendar = new System.Windows.Forms.MonthCalendar();
            this.soldProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.lblListOfSoldProducts = new System.Windows.Forms.Label();
            this.lblTotalBenifitAmount = new System.Windows.Forms.Label();
            this.lblAmountReport = new System.Windows.Forms.Label();
            this.menuStripTedShopSystem.SuspendLayout();
            this.statusStripBar.SuspendLayout();
            this.listProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.deliveryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).BeginInit();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTedShopSystem
            // 
            this.menuStripTedShopSystem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTedShopSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStripTedShopSystem.Location = new System.Drawing.Point(0, 0);
            this.menuStripTedShopSystem.Name = "menuStripTedShopSystem";
            this.menuStripTedShopSystem.Size = new System.Drawing.Size(1146, 28);
            this.menuStripTedShopSystem.TabIndex = 0;
            this.menuStripTedShopSystem.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // statusStripBar
            // 
            this.statusStripBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabelStudent});
            this.statusStripBar.Location = new System.Drawing.Point(0, 594);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Size = new System.Drawing.Size(1146, 25);
            this.statusStripBar.TabIndex = 2;
            this.statusStripBar.Text = "statusStripBar";
            // 
            // tsStatusLabelStudent
            // 
            this.tsStatusLabelStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsStatusLabelStudent.Name = "tsStatusLabelStudent";
            this.tsStatusLabelStudent.Size = new System.Drawing.Size(234, 20);
            this.tsStatusLabelStudent.Text = "Hồ Trọng Đức - SE61924 - SE1012";
            // 
            // listProductPanel
            // 
            this.listProductPanel.Controls.Add(this.dataGridViewProducts);
            this.listProductPanel.Controls.Add(this.btnDetail);
            this.listProductPanel.Controls.Add(this.lblListOfProducts);
            this.listProductPanel.Controls.Add(this.cbbProductType);
            this.listProductPanel.Controls.Add(this.lblProductTypeName);
            this.listProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProductPanel.Location = new System.Drawing.Point(0, 75);
            this.listProductPanel.Name = "listProductPanel";
            this.listProductPanel.Size = new System.Drawing.Size(1146, 519);
            this.listProductPanel.TabIndex = 3;
            this.listProductPanel.Visible = false;
            this.listProductPanel.VisibleChanged += new System.EventHandler(this.listProductPanel_VisibleChanged);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(30, 113);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(553, 243);
            this.dataGridViewProducts.TabIndex = 4;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Enabled = false;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(477, 52);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(106, 33);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Detail...";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblListOfProducts
            // 
            this.lblListOfProducts.AutoSize = true;
            this.lblListOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfProducts.Location = new System.Drawing.Point(26, 65);
            this.lblListOfProducts.Name = "lblListOfProducts";
            this.lblListOfProducts.Size = new System.Drawing.Size(131, 20);
            this.lblListOfProducts.TabIndex = 2;
            this.lblListOfProducts.Text = "List of products:";
            // 
            // cbbProductType
            // 
            this.cbbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductType.FormattingEnabled = true;
            this.cbbProductType.Location = new System.Drawing.Point(220, 12);
            this.cbbProductType.Name = "cbbProductType";
            this.cbbProductType.Size = new System.Drawing.Size(363, 28);
            this.cbbProductType.TabIndex = 1;
            this.cbbProductType.SelectedValueChanged += new System.EventHandler(this.cbbProductType_SelectedValueChanged);
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeName.Location = new System.Drawing.Point(26, 16);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(154, 20);
            this.lblProductTypeName.TabIndex = 0;
            this.lblProductTypeName.Text = "Product type name:";
            // 
            // toolStripOrder
            // 
            this.toolStripOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOrder.Image")));
            this.toolStripOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOrder.Name = "toolStripOrder";
            this.toolStripOrder.Size = new System.Drawing.Size(44, 44);
            this.toolStripOrder.Text = "Order";
            this.toolStripOrder.Click += new System.EventHandler(this.toolStripOrder_Click);
            // 
            // toolStripDelivery
            // 
            this.toolStripDelivery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDelivery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelivery.Image")));
            this.toolStripDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelivery.Name = "toolStripDelivery";
            this.toolStripDelivery.Size = new System.Drawing.Size(44, 44);
            this.toolStripDelivery.Text = "Delivery";
            this.toolStripDelivery.Click += new System.EventHandler(this.toolStripDelivery_Click);
            // 
            // toolStripReport
            // 
            this.toolStripReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReport.Image")));
            this.toolStripReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(44, 44);
            this.toolStripReport.Text = "Report";
            this.toolStripReport.Click += new System.EventHandler(this.toolStripReport_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOrder,
            this.toolStripDelivery,
            this.toolStripReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1146, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // deliveryPanel
            // 
            this.deliveryPanel.Controls.Add(this.btnCancelDeliver);
            this.deliveryPanel.Controls.Add(this.btnDeliver);
            this.deliveryPanel.Controls.Add(this.cbbStaffName);
            this.deliveryPanel.Controls.Add(this.lblStaffName);
            this.deliveryPanel.Controls.Add(this.deliverDateTimePicker);
            this.deliveryPanel.Controls.Add(this.lblDeliverDate);
            this.deliveryPanel.Controls.Add(this.deliveryDataGridView);
            this.deliveryPanel.Controls.Add(this.lblListOfOrderWaitingForDelivering);
            this.deliveryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryPanel.Location = new System.Drawing.Point(0, 75);
            this.deliveryPanel.Name = "deliveryPanel";
            this.deliveryPanel.Size = new System.Drawing.Size(1146, 519);
            this.deliveryPanel.TabIndex = 5;
            this.deliveryPanel.Visible = false;
            this.deliveryPanel.VisibleChanged += new System.EventHandler(this.deliveryPanel_VisibleChanged);
            // 
            // btnCancelDeliver
            // 
            this.btnCancelDeliver.Enabled = false;
            this.btnCancelDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelDeliver.Location = new System.Drawing.Point(967, 246);
            this.btnCancelDeliver.Name = "btnCancelDeliver";
            this.btnCancelDeliver.Size = new System.Drawing.Size(120, 38);
            this.btnCancelDeliver.TabIndex = 7;
            this.btnCancelDeliver.Text = "Cancel";
            this.btnCancelDeliver.UseVisualStyleBackColor = true;
            this.btnCancelDeliver.Click += new System.EventHandler(this.btnCancelDeliver_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Enabled = false;
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeliver.Location = new System.Drawing.Point(661, 246);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(120, 38);
            this.btnDeliver.TabIndex = 6;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // cbbStaffName
            // 
            this.cbbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbStaffName.FormattingEnabled = true;
            this.cbbStaffName.Location = new System.Drawing.Point(783, 138);
            this.cbbStaffName.Name = "cbbStaffName";
            this.cbbStaffName.Size = new System.Drawing.Size(304, 28);
            this.cbbStaffName.TabIndex = 5;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStaffName.Location = new System.Drawing.Point(666, 146);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(95, 20);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Staff name:";
            // 
            // deliverDateTimePicker
            // 
            this.deliverDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deliverDateTimePicker.Location = new System.Drawing.Point(783, 84);
            this.deliverDateTimePicker.Name = "deliverDateTimePicker";
            this.deliverDateTimePicker.Size = new System.Drawing.Size(304, 26);
            this.deliverDateTimePicker.TabIndex = 3;
            // 
            // lblDeliverDate
            // 
            this.lblDeliverDate.AutoSize = true;
            this.lblDeliverDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeliverDate.Location = new System.Drawing.Point(657, 90);
            this.lblDeliverDate.Name = "lblDeliverDate";
            this.lblDeliverDate.Size = new System.Drawing.Size(104, 20);
            this.lblDeliverDate.TabIndex = 2;
            this.lblDeliverDate.Text = "Deliver date:";
            // 
            // deliveryDataGridView
            // 
            this.deliveryDataGridView.AllowUserToAddRows = false;
            this.deliveryDataGridView.AllowUserToDeleteRows = false;
            this.deliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDataGridView.Location = new System.Drawing.Point(51, 89);
            this.deliveryDataGridView.MultiSelect = false;
            this.deliveryDataGridView.Name = "deliveryDataGridView";
            this.deliveryDataGridView.ReadOnly = true;
            this.deliveryDataGridView.RowTemplate.Height = 24;
            this.deliveryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deliveryDataGridView.Size = new System.Drawing.Size(562, 358);
            this.deliveryDataGridView.TabIndex = 1;
            this.deliveryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveryDataGridView_CellClick);
            this.deliveryDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.deliveryDataGridView_DataBindingComplete);
            // 
            // lblListOfOrderWaitingForDelivering
            // 
            this.lblListOfOrderWaitingForDelivering.AutoSize = true;
            this.lblListOfOrderWaitingForDelivering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblListOfOrderWaitingForDelivering.Location = new System.Drawing.Point(48, 40);
            this.lblListOfOrderWaitingForDelivering.Name = "lblListOfOrderWaitingForDelivering";
            this.lblListOfOrderWaitingForDelivering.Size = new System.Drawing.Size(263, 20);
            this.lblListOfOrderWaitingForDelivering.TabIndex = 0;
            this.lblListOfOrderWaitingForDelivering.Text = "List of order waiting for delivering:";
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.lblAmountReport);
            this.reportPanel.Controls.Add(this.lblTotalBenifitAmount);
            this.reportPanel.Controls.Add(this.lblListOfSoldProducts);
            this.reportPanel.Controls.Add(this.soldProductsDataGridView);
            this.reportPanel.Controls.Add(this.reportSelectDateTimeCalendar);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.Location = new System.Drawing.Point(0, 75);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1146, 519);
            this.reportPanel.TabIndex = 8;
            this.reportPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(187, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select From date and To date:";
            // 
            // reportSelectDateTimeCalendar
            // 
            this.reportSelectDateTimeCalendar.Location = new System.Drawing.Point(450, 9);
            this.reportSelectDateTimeCalendar.Name = "reportSelectDateTimeCalendar";
            this.reportSelectDateTimeCalendar.TabIndex = 2;
            this.reportSelectDateTimeCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.reportSelectDateTimeCalendar_DateSelected);
            // 
            // soldProductsDataGridView
            // 
            this.soldProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldProductsDataGridView.Location = new System.Drawing.Point(51, 265);
            this.soldProductsDataGridView.MultiSelect = false;
            this.soldProductsDataGridView.Name = "soldProductsDataGridView";
            this.soldProductsDataGridView.RowTemplate.Height = 24;
            this.soldProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soldProductsDataGridView.Size = new System.Drawing.Size(1036, 186);
            this.soldProductsDataGridView.TabIndex = 3;
            this.soldProductsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.soldProductsDataGridView_DataBindingComplete);
            // 
            // lblListOfSoldProducts
            // 
            this.lblListOfSoldProducts.AutoSize = true;
            this.lblListOfSoldProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblListOfSoldProducts.Location = new System.Drawing.Point(52, 227);
            this.lblListOfSoldProducts.Name = "lblListOfSoldProducts";
            this.lblListOfSoldProducts.Size = new System.Drawing.Size(167, 20);
            this.lblListOfSoldProducts.TabIndex = 4;
            this.lblListOfSoldProducts.Text = "List of sold products:";
            // 
            // lblTotalBenifitAmount
            // 
            this.lblTotalBenifitAmount.AutoSize = true;
            this.lblTotalBenifitAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBenifitAmount.Location = new System.Drawing.Point(545, 466);
            this.lblTotalBenifitAmount.Name = "lblTotalBenifitAmount";
            this.lblTotalBenifitAmount.Size = new System.Drawing.Size(182, 20);
            this.lblTotalBenifitAmount.TabIndex = 5;
            this.lblTotalBenifitAmount.Text = "Total benifit amount:";
            // 
            // lblAmountReport
            // 
            this.lblAmountReport.AutoSize = true;
            this.lblAmountReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountReport.Location = new System.Drawing.Point(779, 466);
            this.lblAmountReport.Name = "lblAmountReport";
            this.lblAmountReport.Size = new System.Drawing.Size(19, 20);
            this.lblAmountReport.TabIndex = 6;
            this.lblAmountReport.Text = "0";
            // 
            // TedShopSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 619);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.deliveryPanel);
            this.Controls.Add(this.listProductPanel);
            this.Controls.Add(this.statusStripBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripTedShopSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripTedShopSystem;
            this.Name = "TedShopSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ted Shop System";
            this.menuStripTedShopSystem.ResumeLayout(false);
            this.menuStripTedShopSystem.PerformLayout();
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.listProductPanel.ResumeLayout(false);
            this.listProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.deliveryPanel.ResumeLayout(false);
            this.deliveryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTedShopSystem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripBar;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabelStudent;
        private System.Windows.Forms.Panel listProductPanel;
        private System.Windows.Forms.ComboBox cbbProductType;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblListOfProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ToolStripButton toolStripOrder;
        private System.Windows.Forms.ToolStripButton toolStripDelivery;
        private System.Windows.Forms.ToolStripButton toolStripReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel deliveryPanel;
        private System.Windows.Forms.Button btnCancelDeliver;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.ComboBox cbbStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.DateTimePicker deliverDateTimePicker;
        private System.Windows.Forms.Label lblDeliverDate;
        private System.Windows.Forms.DataGridView deliveryDataGridView;
        private System.Windows.Forms.Label lblListOfOrderWaitingForDelivering;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Label lblAmountReport;
        private System.Windows.Forms.Label lblTotalBenifitAmount;
        private System.Windows.Forms.Label lblListOfSoldProducts;
        private System.Windows.Forms.DataGridView soldProductsDataGridView;
        private System.Windows.Forms.MonthCalendar reportSelectDateTimeCalendar;
        private System.Windows.Forms.Label label1;
    }
}

