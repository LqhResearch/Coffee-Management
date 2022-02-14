
namespace CoffeeManagement
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLine = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNumDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSwitchTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMergeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.fpnlTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.btnAddNumDrink = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nudNumDrink = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cboDrink = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dgvBillInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbTableList = new System.Windows.Forms.GroupBox();
            this.grbSelectedTable = new System.Windows.Forms.GroupBox();
            this.cboMergeTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMergeTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPayment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.msMenu.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.grbTableList.SuspendLayout();
            this.grbSelectedTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(191)))), ((int)(((byte)(248)))));
            this.msMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManage,
            this.tsmiFunction,
            this.tsmiAccountProfile});
            this.msMenu.Location = new System.Drawing.Point(0, 50);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(990, 25);
            this.msMenu.TabIndex = 0;
            // 
            // tsmiManage
            // 
            this.tsmiManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBill,
            this.tsmiTableDrink,
            this.tsmiCategory,
            this.tsmiDrink,
            this.tsmiLine,
            this.tsmiAccount});
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(64, 21);
            this.tsmiManage.Text = "&Quản lý";
            // 
            // tsmiBill
            // 
            this.tsmiBill.Name = "tsmiBill";
            this.tsmiBill.Size = new System.Drawing.Size(180, 22);
            this.tsmiBill.Text = "Doanh thu";
            this.tsmiBill.Click += new System.EventHandler(this.tsmiBill_Click);
            // 
            // tsmiTableDrink
            // 
            this.tsmiTableDrink.Name = "tsmiTableDrink";
            this.tsmiTableDrink.Size = new System.Drawing.Size(180, 22);
            this.tsmiTableDrink.Text = "Bàn";
            this.tsmiTableDrink.Click += new System.EventHandler(this.tsmiTableDrink_Click);
            // 
            // tsmiCategory
            // 
            this.tsmiCategory.Name = "tsmiCategory";
            this.tsmiCategory.Size = new System.Drawing.Size(180, 22);
            this.tsmiCategory.Text = "Danh mục";
            this.tsmiCategory.Click += new System.EventHandler(this.tsmiCategory_Click);
            // 
            // tsmiDrink
            // 
            this.tsmiDrink.Name = "tsmiDrink";
            this.tsmiDrink.Size = new System.Drawing.Size(180, 22);
            this.tsmiDrink.Text = "Thức uống";
            this.tsmiDrink.Click += new System.EventHandler(this.tsmiDrink_Click);
            // 
            // tsmiLine
            // 
            this.tsmiLine.Name = "tsmiLine";
            this.tsmiLine.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAccount
            // 
            this.tsmiAccount.Name = "tsmiAccount";
            this.tsmiAccount.Size = new System.Drawing.Size(180, 22);
            this.tsmiAccount.Text = "Tài khoản";
            this.tsmiAccount.Click += new System.EventHandler(this.tsmiAccount_Click);
            // 
            // tsmiFunction
            // 
            this.tsmiFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNumDrink,
            this.tsmiLine1,
            this.tsmiSwitchTable,
            this.tsmiMergeTable,
            this.tsmiLine2,
            this.tsmiPayment});
            this.tsmiFunction.Name = "tsmiFunction";
            this.tsmiFunction.Size = new System.Drawing.Size(82, 21);
            this.tsmiFunction.Text = "&Chức năng";
            // 
            // tsmiAddNumDrink
            // 
            this.tsmiAddNumDrink.Name = "tsmiAddNumDrink";
            this.tsmiAddNumDrink.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.tsmiAddNumDrink.Size = new System.Drawing.Size(188, 22);
            this.tsmiAddNumDrink.Text = "Thêm món";
            this.tsmiAddNumDrink.Click += new System.EventHandler(this.tsmiAddNumDrink_Click);
            // 
            // tsmiLine1
            // 
            this.tsmiLine1.Name = "tsmiLine1";
            this.tsmiLine1.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiSwitchTable
            // 
            this.tsmiSwitchTable.Name = "tsmiSwitchTable";
            this.tsmiSwitchTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.tsmiSwitchTable.Size = new System.Drawing.Size(188, 22);
            this.tsmiSwitchTable.Text = "Chuyển bàn";
            this.tsmiSwitchTable.Click += new System.EventHandler(this.tsmiSwitchTable_Click);
            // 
            // tsmiMergeTable
            // 
            this.tsmiMergeTable.Name = "tsmiMergeTable";
            this.tsmiMergeTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmiMergeTable.Size = new System.Drawing.Size(188, 22);
            this.tsmiMergeTable.Text = "Gộp bàn";
            this.tsmiMergeTable.Click += new System.EventHandler(this.tsmiMergeTable_Click);
            // 
            // tsmiLine2
            // 
            this.tsmiLine2.Name = "tsmiLine2";
            this.tsmiLine2.Size = new System.Drawing.Size(185, 6);
            // 
            // tsmiPayment
            // 
            this.tsmiPayment.Name = "tsmiPayment";
            this.tsmiPayment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.tsmiPayment.Size = new System.Drawing.Size(188, 22);
            this.tsmiPayment.Text = "Thanh toán";
            this.tsmiPayment.Click += new System.EventHandler(this.tsmiPayment_Click);
            // 
            // tsmiAccountProfile
            // 
            this.tsmiAccountProfile.Name = "tsmiAccountProfile";
            this.tsmiAccountProfile.Size = new System.Drawing.Size(132, 21);
            this.tsmiAccountProfile.Text = "&Thông tin tài khoản";
            this.tsmiAccountProfile.Click += new System.EventHandler(this.tsmiAccountProfile_Click);
            // 
            // fpnlTableList
            // 
            this.fpnlTableList.AutoScroll = true;
            this.fpnlTableList.Location = new System.Drawing.Point(6, 24);
            this.fpnlTableList.Name = "fpnlTableList";
            this.fpnlTableList.Size = new System.Drawing.Size(445, 425);
            this.fpnlTableList.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTitle.Controls.Add(this.lblExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(990, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(940, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(50, 50);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(399, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý quán cà phê";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BorderRadius = 3;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategory.FocusedState.Parent = this.cboCategory;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.HoverState.Parent = this.cboCategory;
            this.cboCategory.ItemHeight = 19;
            this.cboCategory.ItemsAppearance.Parent = this.cboCategory;
            this.cboCategory.Location = new System.Drawing.Point(87, 24);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.ShadowDecoration.Parent = this.cboCategory;
            this.cboCategory.Size = new System.Drawing.Size(216, 25);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboSwitchTable
            // 
            this.cboSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cboSwitchTable.BorderRadius = 3;
            this.cboSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSwitchTable.DropDownWidth = 100;
            this.cboSwitchTable.FocusedColor = System.Drawing.Color.Empty;
            this.cboSwitchTable.FocusedState.Parent = this.cboSwitchTable;
            this.cboSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSwitchTable.ForeColor = System.Drawing.Color.Black;
            this.cboSwitchTable.FormattingEnabled = true;
            this.cboSwitchTable.HoverState.Parent = this.cboSwitchTable;
            this.cboSwitchTable.ItemHeight = 19;
            this.cboSwitchTable.ItemsAppearance.Parent = this.cboSwitchTable;
            this.cboSwitchTable.Location = new System.Drawing.Point(5, 394);
            this.cboSwitchTable.Name = "cboSwitchTable";
            this.cboSwitchTable.ShadowDecoration.Parent = this.cboSwitchTable;
            this.cboSwitchTable.Size = new System.Drawing.Size(95, 25);
            this.cboSwitchTable.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(8, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Danh mục: ";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(8, 59);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(77, 17);
            this.lblDrink.TabIndex = 0;
            this.lblDrink.Text = "Thức uống: ";
            // 
            // btnAddNumDrink
            // 
            this.btnAddNumDrink.BorderRadius = 3;
            this.btnAddNumDrink.CheckedState.Parent = this.btnAddNumDrink;
            this.btnAddNumDrink.CustomImages.Parent = this.btnAddNumDrink;
            this.btnAddNumDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnAddNumDrink.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnAddNumDrink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumDrink.ForeColor = System.Drawing.Color.Black;
            this.btnAddNumDrink.HoverState.Parent = this.btnAddNumDrink;
            this.btnAddNumDrink.Location = new System.Drawing.Point(309, 24);
            this.btnAddNumDrink.Name = "btnAddNumDrink";
            this.btnAddNumDrink.ShadowDecoration.Parent = this.btnAddNumDrink;
            this.btnAddNumDrink.Size = new System.Drawing.Size(75, 25);
            this.btnAddNumDrink.TabIndex = 3;
            this.btnAddNumDrink.Text = "Thêm món";
            this.btnAddNumDrink.Click += new System.EventHandler(this.btnAddNumDrink_Click);
            // 
            // nudNumDrink
            // 
            this.nudNumDrink.BackColor = System.Drawing.Color.Transparent;
            this.nudNumDrink.BorderRadius = 3;
            this.nudNumDrink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumDrink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNumDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudNumDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudNumDrink.DisabledState.Parent = this.nudNumDrink;
            this.nudNumDrink.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudNumDrink.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudNumDrink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudNumDrink.FocusedState.Parent = this.nudNumDrink;
            this.nudNumDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumDrink.ForeColor = System.Drawing.Color.Black;
            this.nudNumDrink.Location = new System.Drawing.Point(309, 55);
            this.nudNumDrink.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudNumDrink.Name = "nudNumDrink";
            this.nudNumDrink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudNumDrink.ShadowDecoration.Parent = this.nudNumDrink;
            this.nudNumDrink.Size = new System.Drawing.Size(75, 25);
            this.nudNumDrink.TabIndex = 3;
            this.nudNumDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiscount
            // 
            this.nudDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nudDiscount.BorderRadius = 3;
            this.nudDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudDiscount.DisabledState.Parent = this.nudDiscount;
            this.nudDiscount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudDiscount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudDiscount.FocusedState.Parent = this.nudDiscount;
            this.nudDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscount.ForeColor = System.Drawing.Color.Black;
            this.nudDiscount.Location = new System.Drawing.Point(207, 424);
            this.nudDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.ShadowDecoration.Parent = this.nudDiscount;
            this.nudDiscount.Size = new System.Drawing.Size(70, 25);
            this.nudDiscount.TabIndex = 5;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(212, 398);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(60, 17);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // cboDrink
            // 
            this.cboDrink.BackColor = System.Drawing.Color.Transparent;
            this.cboDrink.BorderRadius = 3;
            this.cboDrink.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrink.FocusedColor = System.Drawing.Color.Empty;
            this.cboDrink.FocusedState.Parent = this.cboDrink;
            this.cboDrink.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDrink.ForeColor = System.Drawing.Color.Black;
            this.cboDrink.FormattingEnabled = true;
            this.cboDrink.HoverState.Parent = this.cboDrink;
            this.cboDrink.ItemHeight = 19;
            this.cboDrink.ItemsAppearance.Parent = this.cboDrink;
            this.cboDrink.Location = new System.Drawing.Point(87, 55);
            this.cboDrink.Name = "cboDrink";
            this.cboDrink.ShadowDecoration.Parent = this.cboDrink;
            this.cboDrink.Size = new System.Drawing.Size(216, 25);
            this.cboDrink.TabIndex = 2;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlTitle;
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBillInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillInfo.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillInfo.EnableHeadersVisualStyles = false;
            this.dgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.Location = new System.Drawing.Point(5, 86);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.ReadOnly = true;
            this.dgvBillInfo.RowHeadersVisible = false;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(487, 302);
            this.dgvBillInfo.TabIndex = 7;
            this.dgvBillInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBillInfo.ThemeStyle.ReadOnly = true;
            this.dgvBillInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(283, 424);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 25);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbTableList
            // 
            this.grbTableList.Controls.Add(this.fpnlTableList);
            this.grbTableList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTableList.Location = new System.Drawing.Point(12, 87);
            this.grbTableList.Name = "grbTableList";
            this.grbTableList.Size = new System.Drawing.Size(457, 455);
            this.grbTableList.TabIndex = 9;
            this.grbTableList.TabStop = false;
            this.grbTableList.Text = "Danh sách bàn";
            // 
            // grbSelectedTable
            // 
            this.grbSelectedTable.Controls.Add(this.lblCategory);
            this.grbSelectedTable.Controls.Add(this.cboCategory);
            this.grbSelectedTable.Controls.Add(this.txtTotalPrice);
            this.grbSelectedTable.Controls.Add(this.cboDrink);
            this.grbSelectedTable.Controls.Add(this.dgvBillInfo);
            this.grbSelectedTable.Controls.Add(this.cboMergeTable);
            this.grbSelectedTable.Controls.Add(this.cboSwitchTable);
            this.grbSelectedTable.Controls.Add(this.nudDiscount);
            this.grbSelectedTable.Controls.Add(this.lblDrink);
            this.grbSelectedTable.Controls.Add(this.nudNumDrink);
            this.grbSelectedTable.Controls.Add(this.lblTotalPrice);
            this.grbSelectedTable.Controls.Add(this.lblDiscount);
            this.grbSelectedTable.Controls.Add(this.btnSwitchTable);
            this.grbSelectedTable.Controls.Add(this.btnMergeTable);
            this.grbSelectedTable.Controls.Add(this.btnAddNumDrink);
            this.grbSelectedTable.Controls.Add(this.btnPayment);
            this.grbSelectedTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelectedTable.Location = new System.Drawing.Point(475, 87);
            this.grbSelectedTable.Name = "grbSelectedTable";
            this.grbSelectedTable.Size = new System.Drawing.Size(498, 455);
            this.grbSelectedTable.TabIndex = 10;
            this.grbSelectedTable.TabStop = false;
            this.grbSelectedTable.Text = "Bàn ?";
            // 
            // cboMergeTable
            // 
            this.cboMergeTable.BackColor = System.Drawing.Color.Transparent;
            this.cboMergeTable.BorderRadius = 3;
            this.cboMergeTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMergeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMergeTable.DropDownWidth = 100;
            this.cboMergeTable.FocusedColor = System.Drawing.Color.Empty;
            this.cboMergeTable.FocusedState.Parent = this.cboMergeTable;
            this.cboMergeTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMergeTable.ForeColor = System.Drawing.Color.Black;
            this.cboMergeTable.FormattingEnabled = true;
            this.cboMergeTable.HoverState.Parent = this.cboMergeTable;
            this.cboMergeTable.ItemHeight = 19;
            this.cboMergeTable.ItemsAppearance.Parent = this.cboMergeTable;
            this.cboMergeTable.Location = new System.Drawing.Point(106, 394);
            this.cboMergeTable.Name = "cboMergeTable";
            this.cboMergeTable.ShadowDecoration.Parent = this.cboMergeTable;
            this.cboMergeTable.Size = new System.Drawing.Size(95, 25);
            this.cboMergeTable.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(317, 398);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(63, 17);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BorderRadius = 3;
            this.btnSwitchTable.CheckedState.Parent = this.btnSwitchTable;
            this.btnSwitchTable.CustomImages.Parent = this.btnSwitchTable;
            this.btnSwitchTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnSwitchTable.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchTable.HoverState.Parent = this.btnSwitchTable;
            this.btnSwitchTable.Location = new System.Drawing.Point(5, 424);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.ShadowDecoration.Parent = this.btnSwitchTable;
            this.btnSwitchTable.Size = new System.Drawing.Size(95, 25);
            this.btnSwitchTable.TabIndex = 3;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.BorderRadius = 3;
            this.btnMergeTable.CheckedState.Parent = this.btnMergeTable;
            this.btnMergeTable.CustomImages.Parent = this.btnMergeTable;
            this.btnMergeTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnMergeTable.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnMergeTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTable.ForeColor = System.Drawing.Color.Black;
            this.btnMergeTable.HoverState.Parent = this.btnMergeTable;
            this.btnMergeTable.Location = new System.Drawing.Point(106, 424);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.ShadowDecoration.Parent = this.btnMergeTable;
            this.btnMergeTable.Size = new System.Drawing.Size(95, 25);
            this.btnMergeTable.TabIndex = 3;
            this.btnMergeTable.Text = "Gộp bàn";
            this.btnMergeTable.Click += new System.EventHandler(this.btnMergeTable_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BorderRadius = 5;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnPayment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(419, 394);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(75, 55);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.grbSelectedTable);
            this.Controls.Add(this.grbTableList);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cà phê";
            this.Load += new System.EventHandler(this.Main_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.grbTableList.ResumeLayout(false);
            this.grbSelectedTable.ResumeLayout(false);
            this.grbSelectedTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountProfile;
        private System.Windows.Forms.FlowLayoutPanel fpnlTableList;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cboSwitchTable;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDrink;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNumDrink;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumDrink;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2GradientButton btnPayment;
        private Guna.UI2.WinForms.Guna2ComboBox cboDrink;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiBill;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableDrink;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrink;
        private System.Windows.Forms.ToolStripSeparator tsmiLine;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.GroupBox grbTableList;
        private System.Windows.Forms.GroupBox grbSelectedTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnSwitchTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnMergeTable;
        private Guna.UI2.WinForms.Guna2ComboBox cboMergeTable;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem tsmiFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNumDrink;
        private System.Windows.Forms.ToolStripSeparator tsmiLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwitchTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiMergeTable;
        private System.Windows.Forms.ToolStripSeparator tsmiLine2;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayment;
    }
}

