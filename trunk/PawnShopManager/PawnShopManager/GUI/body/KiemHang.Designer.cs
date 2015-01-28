namespace PawnShopManager.GUI.BODY
{
   partial class KiemHang
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemHang));
         this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
         this.tabControl1 = new DevComponents.DotNetBar.TabControl();
         this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
         this.dataGridKiemHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
         this.colMaHD = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colTenKH = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colLoaiHang = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colTenMatHang = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colChatLuong = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colBienSo = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colLoaiXe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colTienCam = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colNgayCam = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colNgayToiHan = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colSoNgayCam = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.bntKiemHang = new DevComponents.DotNetBar.ButtonX();
         this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
         this.labelX2 = new DevComponents.DotNetBar.LabelX();
         this.cboTkTheo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
         this.cboItemNgay = new DevComponents.Editors.ComboItem();
         this.cboItemThang = new DevComponents.Editors.ComboItem();
         this.cboItemNam = new DevComponents.Editors.ComboItem();
         this.labelX1 = new DevComponents.DotNetBar.LabelX();
         this.tabTkHangChuoc = new DevComponents.DotNetBar.TabItem(this.components);
         this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
         this.tabTkHangTon = new DevComponents.DotNetBar.TabItem(this.components);
         this.panelEx1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabControlPanel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridKiemHang)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
         this.SuspendLayout();
         // 
         // panelEx1
         // 
         this.panelEx1.CanvasColor = System.Drawing.Color.Transparent;
         this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.panelEx1.Controls.Add(this.tabControl1);
         this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelEx1.Location = new System.Drawing.Point(0, 0);
         this.panelEx1.Name = "panelEx1";
         this.panelEx1.Size = new System.Drawing.Size(1282, 617);
         this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
         this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Transparent;
         this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
         this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
         this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
         this.panelEx1.Style.GradientAngle = 90;
         this.panelEx1.TabIndex = 0;
         // 
         // tabControl1
         // 
         this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControl1.BackColor = System.Drawing.Color.Transparent;
         this.tabControl1.CanReorderTabs = true;
         this.tabControl1.Controls.Add(this.tabControlPanel2);
         this.tabControl1.Controls.Add(this.tabControlPanel1);
         this.tabControl1.ForeColor = System.Drawing.Color.Black;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
         this.tabControl1.SelectedTabIndex = 1;
         this.tabControl1.Size = new System.Drawing.Size(1282, 617);
         this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
         this.tabControl1.TabIndex = 0;
         this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
         this.tabControl1.Tabs.Add(this.tabTkHangTon);
         this.tabControl1.Tabs.Add(this.tabTkHangChuoc);
         this.tabControl1.Text = "tabControl1";
         // 
         // tabControlPanel2
         // 
         this.tabControlPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.tabControlPanel2.Controls.Add(this.dataGridKiemHang);
         this.tabControlPanel2.Controls.Add(this.bntKiemHang);
         this.tabControlPanel2.Controls.Add(this.dateTimeInput1);
         this.tabControlPanel2.Controls.Add(this.labelX2);
         this.tabControlPanel2.Controls.Add(this.cboTkTheo);
         this.tabControlPanel2.Controls.Add(this.labelX1);
         this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
         this.tabControlPanel2.Name = "tabControlPanel2";
         this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
         this.tabControlPanel2.Size = new System.Drawing.Size(1282, 592);
         this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
         this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
         this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
         this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
         this.tabControlPanel2.Style.GradientAngle = 90;
         this.tabControlPanel2.TabIndex = 2;
         this.tabControlPanel2.TabItem = this.tabTkHangChuoc;
         // 
         // dataGridKiemHang
         // 
         this.dataGridKiemHang.AllowUserToAddRows = false;
         this.dataGridKiemHang.AllowUserToDeleteRows = false;
         this.dataGridKiemHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridKiemHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dataGridKiemHang.BackgroundColor = System.Drawing.Color.White;
         this.dataGridKiemHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridKiemHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridKiemHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridKiemHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenKH,
            this.colLoaiHang,
            this.colTenMatHang,
            this.colChatLuong,
            this.colBienSo,
            this.colLoaiXe,
            this.colTienCam,
            this.colNgayCam,
            this.colNgayToiHan,
            this.colSoNgayCam});
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridKiemHang.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridKiemHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
         this.dataGridKiemHang.Location = new System.Drawing.Point(21, 81);
         this.dataGridKiemHang.MultiSelect = false;
         this.dataGridKiemHang.Name = "dataGridKiemHang";
         this.dataGridKiemHang.ReadOnly = true;
         this.dataGridKiemHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridKiemHang.Size = new System.Drawing.Size(1249, 327);
         this.dataGridKiemHang.TabIndex = 5;
         // 
         // colMaHD
         // 
         this.colMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colMaHD.Frozen = true;
         this.colMaHD.HeaderText = "Mã HĐ";
         this.colMaHD.Name = "colMaHD";
         this.colMaHD.ReadOnly = true;
         this.colMaHD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colMaHD.Width = 110;
         // 
         // colTenKH
         // 
         this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colTenKH.Frozen = true;
         this.colTenKH.HeaderText = "Tên khách hàng";
         this.colTenKH.Name = "colTenKH";
         this.colTenKH.ReadOnly = true;
         this.colTenKH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colTenKH.Width = 110;
         // 
         // colLoaiHang
         // 
         this.colLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colLoaiHang.Frozen = true;
         this.colLoaiHang.HeaderText = "Loại Hàng";
         this.colLoaiHang.Name = "colLoaiHang";
         this.colLoaiHang.ReadOnly = true;
         this.colLoaiHang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colLoaiHang.Width = 109;
         // 
         // colTenMatHang
         // 
         this.colTenMatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colTenMatHang.Frozen = true;
         this.colTenMatHang.HeaderText = "Tên mặt hàng";
         this.colTenMatHang.Name = "colTenMatHang";
         this.colTenMatHang.ReadOnly = true;
         this.colTenMatHang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colTenMatHang.Width = 110;
         // 
         // colChatLuong
         // 
         this.colChatLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colChatLuong.Frozen = true;
         this.colChatLuong.HeaderText = "Chất lượng";
         this.colChatLuong.Name = "colChatLuong";
         this.colChatLuong.ReadOnly = true;
         this.colChatLuong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colChatLuong.Width = 110;
         // 
         // colBienSo
         // 
         this.colBienSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colBienSo.Frozen = true;
         this.colBienSo.HeaderText = "Biển số";
         this.colBienSo.Name = "colBienSo";
         this.colBienSo.ReadOnly = true;
         this.colBienSo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colBienSo.Width = 110;
         // 
         // colLoaiXe
         // 
         this.colLoaiXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colLoaiXe.Frozen = true;
         this.colLoaiXe.HeaderText = "Loại xe";
         this.colLoaiXe.Name = "colLoaiXe";
         this.colLoaiXe.ReadOnly = true;
         this.colLoaiXe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colLoaiXe.Width = 110;
         // 
         // colTienCam
         // 
         this.colTienCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colTienCam.Frozen = true;
         this.colTienCam.HeaderText = "Tiền cầm";
         this.colTienCam.Name = "colTienCam";
         this.colTienCam.ReadOnly = true;
         this.colTienCam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colTienCam.Width = 110;
         // 
         // colNgayCam
         // 
         this.colNgayCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colNgayCam.Frozen = true;
         this.colNgayCam.HeaderText = "Ngày cầm";
         this.colNgayCam.Name = "colNgayCam";
         this.colNgayCam.ReadOnly = true;
         this.colNgayCam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colNgayCam.Width = 109;
         // 
         // colNgayToiHan
         // 
         this.colNgayToiHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colNgayToiHan.Frozen = true;
         this.colNgayToiHan.HeaderText = "Ngày tới hạn";
         this.colNgayToiHan.Name = "colNgayToiHan";
         this.colNgayToiHan.ReadOnly = true;
         this.colNgayToiHan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colNgayToiHan.Width = 110;
         // 
         // colSoNgayCam
         // 
         this.colSoNgayCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colSoNgayCam.Frozen = true;
         this.colSoNgayCam.HeaderText = "Số ngày cầm";
         this.colSoNgayCam.Name = "colSoNgayCam";
         this.colSoNgayCam.ReadOnly = true;
         this.colSoNgayCam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colSoNgayCam.Width = 110;
         // 
         // bntKiemHang
         // 
         this.bntKiemHang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.bntKiemHang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
         this.bntKiemHang.FadeEffect = false;
         this.bntKiemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.bntKiemHang.Location = new System.Drawing.Point(593, 23);
         this.bntKiemHang.Name = "bntKiemHang";
         this.bntKiemHang.Size = new System.Drawing.Size(104, 32);
         this.bntKiemHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.bntKiemHang.TabIndex = 4;
         this.bntKiemHang.Text = "Kiểm hàng";
         // 
         // dateTimeInput1
         // 
         this.dateTimeInput1.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
         this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
         this.dateTimeInput1.ButtonDropDown.Visible = true;
         this.dateTimeInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
         this.dateTimeInput1.ForeColor = System.Drawing.Color.Black;
         this.dateTimeInput1.IsPopupCalendarOpen = false;
         this.dateTimeInput1.Location = new System.Drawing.Point(415, 23);
         // 
         // 
         // 
         this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
         this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
         // 
         // 
         // 
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
         this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
         this.dateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
         this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
         this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
         this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
         this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
         this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
         this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
         this.dateTimeInput1.Name = "dateTimeInput1";
         this.dateTimeInput1.Size = new System.Drawing.Size(143, 32);
         this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
         this.dateTimeInput1.TabIndex = 3;
         // 
         // labelX2
         // 
         this.labelX2.BackColor = System.Drawing.Color.Transparent;
         // 
         // 
         // 
         this.labelX2.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
         this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
         this.labelX2.ForeColor = System.Drawing.Color.Black;
         this.labelX2.Location = new System.Drawing.Point(287, 23);
         this.labelX2.Name = "labelX2";
         this.labelX2.Size = new System.Drawing.Size(122, 38);
         this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX2.SymbolColor = System.Drawing.Color.Transparent;
         this.labelX2.TabIndex = 2;
         this.labelX2.Text = "Chọn ngày:";
         // 
         // cboTkTheo
         // 
         this.cboTkTheo.DisplayMember = "Text";
         this.cboTkTheo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cboTkTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
         this.cboTkTheo.ForeColor = System.Drawing.Color.Black;
         this.cboTkTheo.FormattingEnabled = true;
         this.cboTkTheo.ItemHeight = 26;
         this.cboTkTheo.Items.AddRange(new object[] {
            this.cboItemNgay,
            this.cboItemThang,
            this.cboItemNam});
         this.cboTkTheo.Location = new System.Drawing.Point(175, 23);
         this.cboTkTheo.Name = "cboTkTheo";
         this.cboTkTheo.Size = new System.Drawing.Size(81, 32);
         this.cboTkTheo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.cboTkTheo.TabIndex = 1;
         // 
         // cboItemNgay
         // 
         this.cboItemNgay.Text = "Ngày";
         // 
         // cboItemThang
         // 
         this.cboItemThang.Text = "Tháng";
         // 
         // cboItemNam
         // 
         this.cboItemNam.Text = "Năm";
         // 
         // labelX1
         // 
         this.labelX1.BackColor = System.Drawing.Color.Transparent;
         // 
         // 
         // 
         this.labelX1.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
         this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
         this.labelX1.ForeColor = System.Drawing.Color.Black;
         this.labelX1.Location = new System.Drawing.Point(21, 17);
         this.labelX1.Name = "labelX1";
         this.labelX1.Size = new System.Drawing.Size(148, 38);
         this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.labelX1.SymbolColor = System.Drawing.Color.Transparent;
         this.labelX1.TabIndex = 0;
         this.labelX1.Text = "Thống kê theo:";
         // 
         // tabTkHangChuoc
         // 
         this.tabTkHangChuoc.AttachedControl = this.tabControlPanel2;
         this.tabTkHangChuoc.Name = "tabTkHangChuoc";
         this.tabTkHangChuoc.Text = "Thống kê hàng đã chuộc";
         // 
         // tabControlPanel1
         // 
         this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControlPanel1.Location = new System.Drawing.Point(0, 27);
         this.tabControlPanel1.Name = "tabControlPanel1";
         this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
         this.tabControlPanel1.Size = new System.Drawing.Size(1282, 590);
         this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
         this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
         this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
         this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
         this.tabControlPanel1.Style.GradientAngle = 90;
         this.tabControlPanel1.TabIndex = 1;
         this.tabControlPanel1.TabItem = this.tabTkHangTon;
         // 
         // tabTkHangTon
         // 
         this.tabTkHangTon.AttachedControl = this.tabControlPanel1;
         this.tabTkHangTon.Name = "tabTkHangTon";
         this.tabTkHangTon.Text = "Thống kê hàng tồn";
         // 
         // KiemHang
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1282, 617);
         this.ControlBox = false;
         this.Controls.Add(this.panelEx1);
         this.FlattenMDIBorder = false;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(1282, 582);
         this.Name = "KiemHang";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.panelEx1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabControlPanel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridKiemHang)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevComponents.DotNetBar.PanelEx panelEx1;
      private DevComponents.DotNetBar.TabControl tabControl1;
      private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
      private DevComponents.DotNetBar.LabelX labelX1;
      private DevComponents.DotNetBar.TabItem tabTkHangChuoc;
      private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
      private DevComponents.DotNetBar.TabItem tabTkHangTon;
      private DevComponents.DotNetBar.ButtonX bntKiemHang;
      private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
      private DevComponents.DotNetBar.LabelX labelX2;
      private DevComponents.DotNetBar.Controls.ComboBoxEx cboTkTheo;
      private DevComponents.Editors.ComboItem cboItemNgay;
      private DevComponents.Editors.ComboItem cboItemThang;
      private DevComponents.Editors.ComboItem cboItemNam;
      private DevComponents.DotNetBar.Controls.DataGridViewX dataGridKiemHang;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colMaHD;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colTenKH;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colLoaiHang;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colTenMatHang;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colChatLuong;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colBienSo;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colLoaiXe;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colTienCam;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colNgayCam;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colNgayToiHan;
      private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colSoNgayCam;

   }
}