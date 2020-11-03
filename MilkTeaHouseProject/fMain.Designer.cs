﻿namespace MilkTeaHouseProject
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnCloseDesktop = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbButtonSelected = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.fpnControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStaff = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnOrder = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnContainName = new System.Windows.Forms.Panel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.panelBackground.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.fpnControl.SuspendLayout();
            this.pnContainName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.pnDesktop);
            this.panelBackground.Controls.Add(this.pnTool);
            this.panelBackground.Controls.Add(this.panelControl);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1378, 744);
            this.panelBackground.TabIndex = 0;
            // 
            // pnDesktop
            // 
            this.pnDesktop.AutoScroll = true;
            this.pnDesktop.BackColor = System.Drawing.Color.White;
            this.pnDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(290, 102);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1088, 642);
            this.pnDesktop.TabIndex = 3;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(220)))), ((int)(((byte)(253)))));
            this.pnTool.Controls.Add(this.btnCloseDesktop);
            this.pnTool.Controls.Add(this.lbButtonSelected);
            this.pnTool.Controls.Add(this.btnMinimize);
            this.pnTool.Controls.Add(this.btnZoom);
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTool.Location = new System.Drawing.Point(290, 0);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1088, 102);
            this.pnTool.TabIndex = 2;
            this.pnTool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnCloseDesktop
            // 
            this.btnCloseDesktop.AnimationHoverSpeed = 0.07F;
            this.btnCloseDesktop.AnimationSpeed = 0.03F;
            this.btnCloseDesktop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCloseDesktop.BorderColor = System.Drawing.Color.Black;
            this.btnCloseDesktop.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCloseDesktop.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCloseDesktop.CheckedForeColor = System.Drawing.Color.White;
            this.btnCloseDesktop.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCloseDesktop.CheckedImage")));
            this.btnCloseDesktop.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCloseDesktop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseDesktop.FocusedColor = System.Drawing.Color.Empty;
            this.btnCloseDesktop.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCloseDesktop.ForeColor = System.Drawing.Color.White;
            this.btnCloseDesktop.Image = null;
            this.btnCloseDesktop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCloseDesktop.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCloseDesktop.Location = new System.Drawing.Point(1, 60);
            this.btnCloseDesktop.Name = "btnCloseDesktop";
            this.btnCloseDesktop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCloseDesktop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCloseDesktop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCloseDesktop.OnHoverImage = null;
            this.btnCloseDesktop.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCloseDesktop.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseDesktop.Size = new System.Drawing.Size(46, 42);
            this.btnCloseDesktop.TabIndex = 0;
            this.btnCloseDesktop.Text = "X";
            this.btnCloseDesktop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCloseDesktop.Visible = false;
            this.btnCloseDesktop.Click += new System.EventHandler(this.btnCloseDesktop_Click);
            // 
            // lbButtonSelected
            // 
            this.lbButtonSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbButtonSelected.AutoSize = true;
            this.lbButtonSelected.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonSelected.ForeColor = System.Drawing.Color.White;
            this.lbButtonSelected.Location = new System.Drawing.Point(494, 26);
            this.lbButtonSelected.Name = "lbButtonSelected";
            this.lbButtonSelected.Size = new System.Drawing.Size(115, 45);
            this.lbButtonSelected.TabIndex = 9;
            this.lbButtonSelected.Text = "HOME";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(220)))), ((int)(((byte)(253)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(926, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 46);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(220)))), ((int)(((byte)(253)))));
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.Location = new System.Drawing.Point(980, 0);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(54, 46);
            this.btnZoom.TabIndex = 7;
            this.btnZoom.Text = "O";
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(220)))), ((int)(((byte)(253)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1034, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.panelControl.Controls.Add(this.fpnControl);
            this.panelControl.Controls.Add(this.pnContainName);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(290, 744);
            this.panelControl.TabIndex = 0;
            // 
            // fpnControl
            // 
            this.fpnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.fpnControl.Controls.Add(this.btnMenu);
            this.fpnControl.Controls.Add(this.btnStaff);
            this.fpnControl.Controls.Add(this.btnBill);
            this.fpnControl.Controls.Add(this.btnAccount);
            this.fpnControl.Controls.Add(this.btnOrder);
            this.fpnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnControl.Location = new System.Drawing.Point(0, 102);
            this.fpnControl.Name = "fpnControl";
            this.fpnControl.Size = new System.Drawing.Size(290, 642);
            this.fpnControl.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.AnimationHoverSpeed = 0.07F;
            this.btnMenu.AnimationSpeed = 0.03F;
            this.btnMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnMenu.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMenu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedForeColor = System.Drawing.Color.White;
            this.btnMenu.CheckedImage = null;
            this.btnMenu.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::MilkTeaHouseProject.Properties.Resources.restaurant_menu_64px;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenu.OnHoverImage = null;
            this.btnMenu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenu.Size = new System.Drawing.Size(290, 79);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnStaff
            // 
            this.btnStaff.AnimationHoverSpeed = 0.07F;
            this.btnStaff.AnimationSpeed = 0.03F;
            this.btnStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnStaff.BorderColor = System.Drawing.Color.Black;
            this.btnStaff.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnStaff.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStaff.CheckedForeColor = System.Drawing.Color.White;
            this.btnStaff.CheckedImage = null;
            this.btnStaff.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::MilkTeaHouseProject.Properties.Resources.account_50px;
            this.btnStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStaff.Location = new System.Drawing.Point(3, 88);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStaff.OnHoverImage = null;
            this.btnStaff.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnStaff.Size = new System.Drawing.Size(290, 79);
            this.btnStaff.TabIndex = 13;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedForeColor = System.Drawing.Color.White;
            this.btnBill.CheckedImage = null;
            this.btnBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::MilkTeaHouseProject.Properties.Resources.pos_terminal_50px;
            this.btnBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.Location = new System.Drawing.Point(3, 173);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(290, 79);
            this.btnBill.TabIndex = 12;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedForeColor = System.Drawing.Color.White;
            this.btnAccount.CheckedImage = null;
            this.btnAccount.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::MilkTeaHouseProject.Properties.Resources.settings_64px;
            this.btnAccount.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.Location = new System.Drawing.Point(3, 258);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Size = new System.Drawing.Size(290, 79);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AnimationHoverSpeed = 0.07F;
            this.btnOrder.AnimationSpeed = 0.03F;
            this.btnOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnOrder.BorderColor = System.Drawing.Color.Black;
            this.btnOrder.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnOrder.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnOrder.CheckedForeColor = System.Drawing.Color.White;
            this.btnOrder.CheckedImage = null;
            this.btnOrder.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::MilkTeaHouseProject.Properties.Resources.kawaii_coffee_64px;
            this.btnOrder.ImageSize = new System.Drawing.Size(40, 40);
            this.btnOrder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnOrder.Location = new System.Drawing.Point(3, 343);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOrder.OnHoverImage = null;
            this.btnOrder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnOrder.OnPressedColor = System.Drawing.Color.Black;
            this.btnOrder.Size = new System.Drawing.Size(290, 79);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Đặt món";
            this.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnContainName
            // 
            this.pnContainName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.pnContainName.Controls.Add(this.lbName);
            this.pnContainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainName.Location = new System.Drawing.Point(0, 0);
            this.pnContainName.Name = "pnContainName";
            this.pnContainName.Size = new System.Drawing.Size(290, 102);
            this.pnContainName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(34, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(225, 45);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "MilkTeaHouse";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.panelBackground);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBackground.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.fpnControl.ResumeLayout(false);
            this.pnContainName.ResumeLayout(false);
            this.pnContainName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.Label lbButtonSelected;
        private System.Windows.Forms.FlowLayoutPanel fpnControl;
        private Guna.UI.WinForms.GunaAdvenceButton btnMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnStaff;
        private Guna.UI.WinForms.GunaAdvenceButton btnBill;
        private Guna.UI.WinForms.GunaAdvenceButton btnAccount;
        private Guna.UI.WinForms.GunaAdvenceButton btnOrder;
        private System.Windows.Forms.Panel pnContainName;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaAdvenceButton btnCloseDesktop;
    }
}
