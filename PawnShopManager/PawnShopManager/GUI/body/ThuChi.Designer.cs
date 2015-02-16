namespace PawnShopManager.GUI.BODY
{
    partial class ThuChi
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.labelX1 = new DevComponents.DotNetBar.LabelX();
         this.labelX2 = new DevComponents.DotNetBar.LabelX();
         this.cbHinhThuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
         this.Thu = new DevComponents.Editors.ComboItem();
         this.Chi = new DevComponents.Editors.ComboItem();
         this.labelX3 = new DevComponents.DotNetBar.LabelX();
         this.cbDateTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
         this.labelX4 = new DevComponents.DotNetBar.LabelX();
         this.tbTien = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.tbGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.labelX5 = new DevComponents.DotNetBar.LabelX();
         this.btnLuu = new DevComponents.DotNetBar.ButtonX();
         this.line1 = new DevComponents.DotNetBar.Controls.Line();
         this.labelX6 = new DevComponents.DotNetBar.LabelX();
         this.gvData = new DevComponents.DotNetBar.Controls.DataGridViewX();
         this.colTenVatCam = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colSoLuog = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colChatLuong = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.colThanhTien = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
         this.labelX7 = new DevComponents.DotNetBar.LabelX();
         this.cbLoaiThongKe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
         this.Ngày = new DevComponents.Editors.ComboItem();
         this.Tháng = new DevComponents.Editors.ComboItem();
         this.Năm = new DevComponents.Editors.ComboItem();
         this.labelX8 = new DevComponents.DotNetBar.LabelX();
         this.cbChonNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
         this.btnThongKe = new DevComponents.DotNetBar.ButtonX();
         ((System.ComponentModel.ISupportInitialize)(this.cbDateTime)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbChonNgay)).BeginInit();
         this.SuspendLayout();
         // 
         // labelX1
         // 
         this.labelX1.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX1.ForeColor = System.Drawing.Color.Black;
         this.labelX1.Location = new System.Drawing.Point(24, 20);
         this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX1.Name = "labelX1";
         this.labelX1.Size = new System.Drawing.Size(215, 45);
         this.labelX1.TabIndex = 0;
         this.labelX1.Text = "Bổ Sung Thu / Chi";
         this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
         // 
         // labelX2
         // 
         this.labelX2.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX2.ForeColor = System.Drawing.Color.Black;
         this.labelX2.Location = new System.Drawing.Point(24, 62);
         this.labelX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX2.Name = "labelX2";
         this.labelX2.Size = new System.Drawing.Size(136, 45);
         this.labelX2.TabIndex = 1;
         this.labelX2.Text = "Loại hình thức:";
         // 
         // cbHinhThuc
         // 
         this.cbHinhThuc.AutoCompleteCustomSource.AddRange(new string[] {
            "Thu",
            "Chi"});
         this.cbHinhThuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.cbHinhThuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cbHinhThuc.DisplayMember = "Text";
         this.cbHinhThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cbHinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbHinhThuc.ForeColor = System.Drawing.Color.Black;
         this.cbHinhThuc.FormattingEnabled = true;
         this.cbHinhThuc.ItemHeight = 28;
         this.cbHinhThuc.Items.AddRange(new object[] {
            this.Thu,
            this.Chi});
         this.cbHinhThuc.Location = new System.Drawing.Point(165, 70);
         this.cbHinhThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.cbHinhThuc.Name = "cbHinhThuc";
         this.cbHinhThuc.Size = new System.Drawing.Size(151, 34);
         this.cbHinhThuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.cbHinhThuc.TabIndex = 2;
         this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
         // 
         // Thu
         // 
         this.Thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.Thu.FontSize = 15.75F;
         this.Thu.Text = "Thu";
         this.Thu.Value = "1";
         // 
         // Chi
         // 
         this.Chi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.Chi.FontSize = 15.75F;
         this.Chi.Text = "Chi";
         this.Chi.Value = "2";
         // 
         // labelX3
         // 
         this.labelX3.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX3.ForeColor = System.Drawing.Color.Black;
         this.labelX3.Location = new System.Drawing.Point(24, 101);
         this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX3.Name = "labelX3";
         this.labelX3.Size = new System.Drawing.Size(136, 45);
         this.labelX3.TabIndex = 3;
         this.labelX3.Text = "Ngày:";
         this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
         // 
         // cbDateTime
         // 
         this.cbDateTime.AllowEmptyState = false;
         this.cbDateTime.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.cbDateTime.BackgroundStyle.Class = "DateTimeInputBackground";
         this.cbDateTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbDateTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
         this.cbDateTime.ButtonDropDown.Visible = true;
         this.cbDateTime.CustomFormat = "dd/MM/yyyy";
         this.cbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbDateTime.ForeColor = System.Drawing.Color.Black;
         this.cbDateTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
         this.cbDateTime.IsPopupCalendarOpen = false;
         this.cbDateTime.Location = new System.Drawing.Point(165, 110);
         this.cbDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         // 
         // 
         // 
         this.cbDateTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.cbDateTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbDateTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
         this.cbDateTime.MonthCalendar.ClearButtonVisible = true;
         // 
         // 
         // 
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
         this.cbDateTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbDateTime.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
         this.cbDateTime.MonthCalendar.MarkedDates = new System.DateTime[0];
         this.cbDateTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.cbDateTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
         this.cbDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
         this.cbDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
         this.cbDateTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbDateTime.MonthCalendar.TodayButtonVisible = true;
         this.cbDateTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
         this.cbDateTime.Name = "cbDateTime";
         this.cbDateTime.Size = new System.Drawing.Size(150, 28);
         this.cbDateTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
         this.cbDateTime.TabIndex = 4;
         // 
         // labelX4
         // 
         this.labelX4.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX4.ForeColor = System.Drawing.Color.Black;
         this.labelX4.Location = new System.Drawing.Point(24, 141);
         this.labelX4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX4.Name = "labelX4";
         this.labelX4.Size = new System.Drawing.Size(136, 45);
         this.labelX4.TabIndex = 5;
         this.labelX4.Text = "Số tiền:";
         // 
         // tbTien
         // 
         this.tbTien.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.tbTien.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.tbTien.Border.Class = "TextBoxBorder";
         this.tbTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.tbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbTien.ForeColor = System.Drawing.Color.Black;
         this.tbTien.Location = new System.Drawing.Point(165, 152);
         this.tbTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.tbTien.Name = "tbTien";
         this.tbTien.Size = new System.Drawing.Size(150, 28);
         this.tbTien.TabIndex = 6;
         // 
         // tbGhiChu
         // 
         this.tbGhiChu.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.tbGhiChu.Border.Class = "TextBoxBorder";
         this.tbGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbGhiChu.ForeColor = System.Drawing.Color.Black;
         this.tbGhiChu.Location = new System.Drawing.Point(478, 70);
         this.tbGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.tbGhiChu.MinimumSize = new System.Drawing.Size(300, 67);
         this.tbGhiChu.Name = "tbGhiChu";
         this.tbGhiChu.Size = new System.Drawing.Size(300, 67);
         this.tbGhiChu.TabIndex = 8;
         // 
         // labelX5
         // 
         this.labelX5.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX5.ForeColor = System.Drawing.Color.Black;
         this.labelX5.Location = new System.Drawing.Point(377, 61);
         this.labelX5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX5.Name = "labelX5";
         this.labelX5.Size = new System.Drawing.Size(97, 45);
         this.labelX5.TabIndex = 7;
         this.labelX5.Text = "Ghi chú:";
         // 
         // btnLuu
         // 
         this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
         this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLuu.Location = new System.Drawing.Point(830, 75);
         this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnLuu.Name = "btnLuu";
         this.btnLuu.Size = new System.Drawing.Size(161, 46);
         this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
         this.btnLuu.TabIndex = 9;
         this.btnLuu.Text = "Lưu Thông Tin";
         this.btnLuu.TextColor = System.Drawing.Color.Black;
         // 
         // line1
         // 
         this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.line1.BackColor = System.Drawing.Color.White;
         this.line1.ForeColor = System.Drawing.Color.Black;
         this.line1.Location = new System.Drawing.Point(-2, 191);
         this.line1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.line1.Name = "line1";
         this.line1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.line1.Size = new System.Drawing.Size(1269, 19);
         this.line1.TabIndex = 10;
         this.line1.Thickness = 2;
         // 
         // labelX6
         // 
         this.labelX6.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX6.ForeColor = System.Drawing.Color.Black;
         this.labelX6.Location = new System.Drawing.Point(24, 214);
         this.labelX6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX6.Name = "labelX6";
         this.labelX6.Size = new System.Drawing.Size(215, 45);
         this.labelX6.TabIndex = 11;
         this.labelX6.Text = "Thống Kê Thu / Chi";
         // 
         // gvData
         // 
         this.gvData.AllowUserToAddRows = false;
         this.gvData.AllowUserToDeleteRows = false;
         this.gvData.BackgroundColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenVatCam,
            this.colSoLuog,
            this.colChatLuong,
            this.colThanhTien});
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.gvData.DefaultCellStyle = dataGridViewCellStyle2;
         this.gvData.EnableHeadersVisualStyles = false;
         this.gvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
         this.gvData.Location = new System.Drawing.Point(17, 320);
         this.gvData.MultiSelect = false;
         this.gvData.Name = "gvData";
         this.gvData.ReadOnly = true;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.gvData.Size = new System.Drawing.Size(993, 250);
         this.gvData.TabIndex = 14;
         this.gvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
         // 
         // colTenVatCam
         // 
         this.colTenVatCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colTenVatCam.Frozen = true;
         this.colTenVatCam.HeaderText = "Loại Hình Thức";
         this.colTenVatCam.Name = "colTenVatCam";
         this.colTenVatCam.ReadOnly = true;
         this.colTenVatCam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colTenVatCam.TextAlignment = System.Drawing.StringAlignment.Center;
         this.colTenVatCam.Width = 238;
         // 
         // colSoLuog
         // 
         this.colSoLuog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colSoLuog.Frozen = true;
         this.colSoLuog.HeaderText = "Ngày";
         this.colSoLuog.Name = "colSoLuog";
         this.colSoLuog.ReadOnly = true;
         this.colSoLuog.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colSoLuog.TextAlignment = System.Drawing.StringAlignment.Center;
         this.colSoLuog.Width = 138;
         // 
         // colChatLuong
         // 
         this.colChatLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
         this.colChatLuong.Frozen = true;
         this.colChatLuong.HeaderText = "Số Tiền";
         this.colChatLuong.Name = "colChatLuong";
         this.colChatLuong.ReadOnly = true;
         this.colChatLuong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colChatLuong.TextAlignment = System.Drawing.StringAlignment.Center;
         this.colChatLuong.Width = 138;
         // 
         // colThanhTien
         // 
         this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.colThanhTien.HeaderText = "Ghi Chú";
         this.colThanhTien.Name = "colThanhTien";
         this.colThanhTien.ReadOnly = true;
         this.colThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.colThanhTien.TextAlignment = System.Drawing.StringAlignment.Center;
         // 
         // labelX7
         // 
         this.labelX7.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX7.ForeColor = System.Drawing.Color.Black;
         this.labelX7.Location = new System.Drawing.Point(17, 264);
         this.labelX7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX7.Name = "labelX7";
         this.labelX7.Size = new System.Drawing.Size(136, 45);
         this.labelX7.TabIndex = 15;
         this.labelX7.Text = "Thống kê theo:";
         // 
         // cbLoaiThongKe
         // 
         this.cbLoaiThongKe.AutoCompleteCustomSource.AddRange(new string[] {
            "Ngày",
            "Tháng",
            "Năm"});
         this.cbLoaiThongKe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.cbLoaiThongKe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cbLoaiThongKe.DisplayMember = "Text";
         this.cbLoaiThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.cbLoaiThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbLoaiThongKe.ForeColor = System.Drawing.Color.Black;
         this.cbLoaiThongKe.FormattingEnabled = true;
         this.cbLoaiThongKe.ItemHeight = 28;
         this.cbLoaiThongKe.Items.AddRange(new object[] {
            this.Ngày,
            this.Tháng,
            this.Năm});
         this.cbLoaiThongKe.Location = new System.Drawing.Point(165, 275);
         this.cbLoaiThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.cbLoaiThongKe.Name = "cbLoaiThongKe";
         this.cbLoaiThongKe.Size = new System.Drawing.Size(92, 34);
         this.cbLoaiThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
         this.cbLoaiThongKe.TabIndex = 16;
         this.cbLoaiThongKe.ValueMember = "Ngày , Tháng , Năm";
         // 
         // Ngày
         // 
         this.Ngày.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.Ngày.FontSize = 15.75F;
         this.Ngày.Text = "Ngày";
         // 
         // Tháng
         // 
         this.Tháng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.Tháng.FontSize = 15.75F;
         this.Tháng.Text = "Tháng";
         // 
         // Năm
         // 
         this.Năm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.Năm.FontSize = 15.75F;
         this.Năm.Text = "Năm";
         // 
         // labelX8
         // 
         this.labelX8.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX8.ForeColor = System.Drawing.Color.Black;
         this.labelX8.Location = new System.Drawing.Point(294, 264);
         this.labelX8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.labelX8.Name = "labelX8";
         this.labelX8.Size = new System.Drawing.Size(106, 45);
         this.labelX8.TabIndex = 17;
         this.labelX8.Text = "Chọn ngày:";
         // 
         // cbChonNgay
         // 
         this.cbChonNgay.AllowEmptyState = false;
         this.cbChonNgay.BackColor = System.Drawing.Color.White;
         // 
         // 
         // 
         this.cbChonNgay.BackgroundStyle.Class = "DateTimeInputBackground";
         this.cbChonNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbChonNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
         this.cbChonNgay.ButtonDropDown.Visible = true;
         this.cbChonNgay.CustomFormat = "dd/MM/yyyy";
         this.cbChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbChonNgay.ForeColor = System.Drawing.Color.Black;
         this.cbChonNgay.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
         this.cbChonNgay.IsPopupCalendarOpen = false;
         this.cbChonNgay.Location = new System.Drawing.Point(412, 275);
         this.cbChonNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         // 
         // 
         // 
         this.cbChonNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.cbChonNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbChonNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
         this.cbChonNgay.MonthCalendar.ClearButtonVisible = true;
         // 
         // 
         // 
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
         this.cbChonNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbChonNgay.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
         this.cbChonNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
         this.cbChonNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
         // 
         // 
         // 
         this.cbChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
         this.cbChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
         this.cbChonNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
         this.cbChonNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.cbChonNgay.MonthCalendar.TodayButtonVisible = true;
         this.cbChonNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
         this.cbChonNgay.Name = "cbChonNgay";
         this.cbChonNgay.Size = new System.Drawing.Size(150, 28);
         this.cbChonNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
         this.cbChonNgay.TabIndex = 18;
         // 
         // btnThongKe
         // 
         this.btnThongKe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
         this.btnThongKe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
         this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnThongKe.Location = new System.Drawing.Point(830, 262);
         this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnThongKe.Name = "btnThongKe";
         this.btnThongKe.Size = new System.Drawing.Size(161, 46);
         this.btnThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
         this.btnThongKe.TabIndex = 19;
         this.btnThongKe.Text = "Thống Kê";
         this.btnThongKe.TextColor = System.Drawing.Color.Black;
         // 
         // ThuChi
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1034, 616);
         this.ControlBox = false;
         this.Controls.Add(this.btnThongKe);
         this.Controls.Add(this.cbChonNgay);
         this.Controls.Add(this.labelX8);
         this.Controls.Add(this.cbLoaiThongKe);
         this.Controls.Add(this.labelX7);
         this.Controls.Add(this.gvData);
         this.Controls.Add(this.labelX6);
         this.Controls.Add(this.line1);
         this.Controls.Add(this.btnLuu);
         this.Controls.Add(this.tbGhiChu);
         this.Controls.Add(this.labelX5);
         this.Controls.Add(this.tbTien);
         this.Controls.Add(this.labelX4);
         this.Controls.Add(this.cbDateTime);
         this.Controls.Add(this.labelX3);
         this.Controls.Add(this.cbHinhThuc);
         this.Controls.Add(this.labelX2);
         this.Controls.Add(this.labelX1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ThuChi";
         this.RenderFormIcon = false;
         this.RenderFormText = false;
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
         this.Text = "ThuChi";
         this.Load += new System.EventHandler(this.ThuChi_Load);
         ((System.ComponentModel.ISupportInitialize)(this.cbDateTime)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbChonNgay)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHinhThuc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cbDateTime;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTien;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGhiChu;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvData;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colTenVatCam;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colSoLuog;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colChatLuong;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colThanhTien;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiThongKe;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cbChonNgay;
        private DevComponents.DotNetBar.ButtonX btnThongKe;
        private DevComponents.Editors.ComboItem Thu;
        private DevComponents.Editors.ComboItem Chi;
        private DevComponents.Editors.ComboItem Ngày;
        private DevComponents.Editors.ComboItem Tháng;
        private DevComponents.Editors.ComboItem Năm;
    }
}