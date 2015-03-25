using DevComponents.DotNetBar.SuperGrid;
using PawnShopManager.Dto;
using PawnShopManager.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace PawnShopManager.GUI.BODY
{
    public partial class QlHangCam : DevComponents.DotNetBar.Metro.MetroForm
    {
        private double[] _tienLai_Chuoc = { 0, 0 };
        private double[] _tienLai_ThanhLy = { 0, 0 };
        private double _tienDongLaiTruoc = 0;
        private HopDongDto _hd = null;
        private bool _flag1 = false;
        private bool _flag2 = false;

        private DateTime _ngayThemTien = new DateTime();
        private int _tienThem = 0;

        public QlHangCam()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            dateTimeInputNgayBaoMat_BaoMat.Value = now;
            dateTimeInputNgayChuoc_ChuocDo.Value = now;
            dateTimeInputNgayLayThemTien_ThemTien.Value = now;
            dateTimeInputNgayThanhLy_ThanhLy.Value = now;
            dateTimeInputNgayTraLaiTruoc_DongLai.Value = now;
            dateTimeInput_Nam.Value = now;

            //source for AutoComplete
            string[] listAutoCompleteSource = Controller.Controller.getInstance().layTatCaMaBN();
            txtMaBN.AutoCompleteCustomSource.AddRange(listAutoCompleteSource);

            //superGridControl
            superGridControl_CTHC.DataBindingComplete += SuperGridControlDataBindingComplete;
            gridNhatKyGD.DataBindingComplete += GridNhatKyGD_DataBindingComplete;
        }

        #region Event
        #region Button

            #region Nút Hiển thị thông tin
        //ToDo cần kiểm tra khi thanh lý hoặc chuộc cần enable các control, kiểm tra tiền khi muốn trả lãi thêm
        private void btnHienThiThongTin_Click(object sender, EventArgs e)
        {
            if (dateTimeInput_Nam.IsEmpty)
            {
                MessageBox.Show("Yêu cầu nhập ngày tháng!");
                return;
            }
            if (!UtilCommon.validateInteger(txtMaBN.Text))
            {
                MessageBox.Show("Yêu cầu nhập số, không nhập chữ!");
                return;
            }
            int maBN = Int32.Parse(txtMaBN.Text);
            int nam = dateTimeInput_Nam.Value.Year;
            _hd = Controller.Controller.getInstance().layHD_TheoMaBN(maBN, nam);
            if (_hd == null)
            {
                //call reset and return
                return;
            }
            lblCMND.Text = _hd.cmnd;
            lblTenKH.Text = _hd.tenKH;
            lblTienCam.Text = String.Format("{0:0,0}", _hd.tienCam);
            lblTienChu.Text = Util.UtilCommon.docso(_hd.tienCam) + " đồng.";

            //update ngay cam do cua cac tab
            lblNgayCam_ChuocDo.Text = UtilCommon.formatNgay(_hd.ngayTao);
            lblNgayCam_BaoMat.Text = UtilCommon.formatNgay(_hd.ngayTao);
            lblNgayCam_DongLai.Text = UtilCommon.formatNgay(_hd.ngayTao);
            lblNgayCam_ThanhLy.Text = UtilCommon.formatNgay(_hd.ngayTao);
            lblNgayCam_ThemTien.Text = UtilCommon.formatNgay(_hd.ngayTao);

            bindingSuperDataGrid(_hd.hd_id);

            DateTime ngayChuoc = dateTimeInputNgayChuoc_ChuocDo.Value;
            _tienLai_Chuoc = Util.UtilCommon.tinhTienLai(_hd.ngayTao, ngayChuoc, _hd.tienCam, _hd.laiSuatThoaThuan, _hd.laiSuatQuaHan, _hd.thoiHan, _ngayThemTien, _tienThem);
            _tienDongLaiTruoc = Controller.Controller.getInstance().layTienTraLaiTruoc(_hd.hd_id);
            _tienLai_ThanhLy = (double[])_tienLai_Chuoc.Clone();

            updateChange_ChuocDo();
            updateChange_ThanhLy();

            if (_hd.trangThai == 2 || _hd.trangThai == 3)
            {
                _flag1 = true;
                chboxChuocHoacThanhLy.Checked = true;
            }
            if (_hd.baoMat)
            {
                _flag2 = true;
                chboxBaoMat.Checked = true;
            }

            //tab nhat ky giao dich
            gridNhatKyGD.PrimaryGrid.ClearAll();
            DataTable tblNhatKyGiaoDich = Controller.Controller.getInstance().getNhatKyGiaoDich(_hd.hd_id);
            gridNhatKyGD.PrimaryGrid.DataSource = tblNhatKyGiaoDich;
            gridNhatKyGD.PrimaryGrid.DataMember = "nhatKyGiaoDich";

            //save Session
            if (Global.SESSION.ContainsKey("QLHangCam_HopDong"))
            {
                Global.SESSION["QLHangCam_HopDong"] = _hd;
            }
            else
            {
                Global.SESSION.Add("QLHangCam_HopDong", _hd);
            }

        }
            #endregion

            #region Nút Hoàn thành báo mất
        private void btnHoanThanhBaoMat_Click(object sender, EventArgs e)
        {
            //ToDo validate
            if (_hd == null) return;
            DateTime ngayBaoMat = dateTimeInputNgayBaoMat_BaoMat.Value;
            bool result = Controller.Controller.getInstance().xuLy_BaoMatHD(_hd.hd_id, ngayBaoMat);
            if (result)
            {
                MessageBox.Show("Xác nhận báo mất");
            }
            else
            {
                MessageBox.Show("Có lỗi, không thể xử lý");
            }
        }
        #endregion

            #region Nút Hoàn thành thêm tiền
        private void btnHoanThanhThemTien_Click(object sender, EventArgs e)
        {
            //ToDo validate
            if (dateTimeInputNgayLayThemTien_ThemTien.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu chọn ngày!");
                return;
            }
            DateTime ngayThem = dateTimeInputNgayLayThemTien_ThemTien.Value;
            float tienThem = txtSoTienLayThem_ThemTien.Value;
            int hinhThuc = chboxTraLaiSau_ThemTien.Checked ? 1 : 0;
            float tienLai = 0;
            bool result = Controller.Controller.getInstance().XuLy_ThemTien(_hd.hd_id, ngayThem, tienLai, tienThem, hinhThuc);
            if (result)
            {
                MessageBox.Show("Thêm tiền thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tiền thất bại!");
            }
        }
        #endregion

            #region Nút Hoàn thành chuộc đồ
        private void btnHoanThanhChuocDo_Click(object sender, EventArgs e)
        {
            //ToDo validate
            DateTime ngayChuoc = dateTimeInputNgayChuoc_ChuocDo.Value;
            float tienTangGiam = float.Parse(txtTienTangGiam.Text.Trim());
            float tongTien = (float)_tienLai_Chuoc[0] + (float)_tienLai_Chuoc[1];
            bool result = Controller.Controller.getInstance().Xuly_ChuocDo(_hd.hd_id, ngayChuoc, (float)_tienLai_Chuoc[0], (float)_tienLai_Chuoc[1], tienTangGiam, tongTien);
            if (result)
            {
                MessageBox.Show("Chuộc thành công");
                //ToDo update view
            }
            else
            {
                MessageBox.Show("Có lỗi, không thể chuộc.");
            }
        }
        #endregion

            #region Nút Hoàn thành thanh lý
        private void btnHoanThanhThanhLy_Click(object sender, EventArgs e)
        {
            //ToDo validate txt, hd
            if (!UtilCommon.validateInteger(txtTienThanhLy_ThanhLy.Text))
            {
                MessageBox.Show("Yêu cầu nhập tiền là số!");
                return;
            }
            if (dateTimeInputNgayThanhLy_ThanhLy.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập ngày tháng!");
                return;
            }
            float tienThanhLy = float.Parse(txtTienThanhLy_ThanhLy.Text.Trim());
            DateTime ngayThanhLy = dateTimeInputNgayThanhLy_ThanhLy.Value;
            bool result = Controller.Controller.getInstance().XuLy_ThanhLy(_hd.hd_id, ngayThanhLy, tienThanhLy);
            if (result)
            {
                MessageBox.Show("Thanh lý thành công");
            }
            else
            {
                MessageBox.Show("Thanh lý thất bại");
            }
        }
        #endregion

            #region Nút Hoàn thành đóng lãi
        private void btnHoanThanhDongLai_Click(object sender, EventArgs e)
        {
            //ToDo kiểm tra tiền khi muốn trả lãi thêm
            //ToDo validate
            if (dateTimeInputNgayTraLaiTruoc_DongLai.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập ngày!");
                return;
            }
            int soNgayMuonTraLai = txtSoNgayMuonTraTruoc_DongLai.Value;
            DateTime ngayMuonTraLai = _hd.ngayTao.AddDays(soNgayMuonTraLai);
            DateTime ngayTraLai = dateTimeInputNgayTraLaiTruoc_DongLai.Value;
            double[] tienLaiHienTai = UtilCommon.tinhTienLai(_hd.ngayTao, ngayMuonTraLai, _hd.tienCam, _hd.laiSuatThoaThuan, _hd.laiSuatQuaHan, _hd.thoiHan, _ngayThemTien, _tienThem);
            double tongTien = tienLaiHienTai[0] + tienLaiHienTai[1];
            bool result = Controller.Controller.getInstance().Xuly_TraLaiTruoc(_hd.hd_id, ngayTraLai, soNgayMuonTraLai, (float)tongTien);

            if (result)
            {
                MessageBox.Show("Trả lãi trước thành công");
            }
            else
            {
                MessageBox.Show("Trả lãi trước thất bại");
            }
        }
        #endregion

        #endregion

        #region Checkbox
        private void chboxChuocHoacThanhLy_CheckedChanged(object sender, EventArgs e)
        {
            chboxChuocHoacThanhLy.Checked = _flag1;
        }

        private void chboxBaoMat_CheckedChanged(object sender, EventArgs e)
        {
            chboxBaoMat.Checked = _flag2;
        }
        #endregion

        #region DateTimeInput
        private void dateTimeInputNgayChuoc_ChuocDo_ValueChanged(object sender, EventArgs e)
        {
            if (_hd == null)
            {
                return;
            }
            DateTime ngayChuoc = dateTimeInputNgayChuoc_ChuocDo.Value;
            _tienLai_Chuoc = UtilCommon.tinhTienLai(_hd.ngayTao, ngayChuoc, _hd.tienCam, _hd.laiSuatThoaThuan, _hd.laiSuatQuaHan, _hd.thoiHan, _ngayThemTien, _tienThem);

            updateChange_ChuocDo();
        }

        private void dateTimeInputNgayThanhLy_ThanhLy_ValueChanged(object sender, EventArgs e)
        {
            if (_hd == null)
            {
                return;
            }
            DateTime ngayThanhLy = dateTimeInputNgayThanhLy_ThanhLy.Value;
            _tienLai_ThanhLy = UtilCommon.tinhTienLai(_hd.ngayTao, ngayThanhLy, _hd.tienCam, _hd.laiSuatThoaThuan, _hd.laiSuatQuaHan, _hd.thoiHan, _ngayThemTien, _tienThem);
            updateChange_ThanhLy();
        }
        #endregion

        #region Textbox
        private void txtTienTangGiam_TextChanged(object sender, EventArgs e)
        {
            updateChange_ChuocDo();
        }

        private void txtTienThanhLy_ThanhLy_TextChanged(object sender, EventArgs e)
        {
            updateChange_ThanhLy();
        }

        private void txtSoNgayMuonTraTruoc_DongLai_ValueChanged(object sender, EventArgs e)
        {
            //ToDo validate
            int soNgayMuonTraLai = txtSoNgayMuonTraTruoc_DongLai.Value;
            DateTime ngayMuonTraLai = _hd.ngayTao.AddDays(soNgayMuonTraLai);
            double[] tienLaiHienTai = UtilCommon.tinhTienLai(_hd.ngayTao, ngayMuonTraLai, _hd.tienCam, _hd.laiSuatThoaThuan, _hd.laiSuatQuaHan, _hd.thoiHan, _ngayThemTien, _tienThem);
            double tongTien = tienLaiHienTai[0] + tienLaiHienTai[1];

            lblThanhTienLoi_DongLai.Text = UtilCommon.formatTien(tongTien);
            lblTienChu_ThanhLy.Text = UtilCommon.docso(tongTien) + " đồng.";
        }
        #endregion

        #endregion

        #region Function
        private void bindingSuperDataGrid(int hd_id)
        {
            superGridControl_CTHC.PrimaryGrid.DataSource = Controller.Controller.getInstance().layCTHC_TheoHdId(hd_id);
        }

        void SuperGridControlDataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            panel.ColumnHeader.RowHeight = 30;

            panel.Columns["tenMH"].HeaderText = "Tên hàng cầm";
            panel.Columns["giaTri"].HeaderText = "Giá trị";
            panel.Columns["soLuong"].HeaderText = "Số lượng (chỉ)";
            panel.Columns["bienSo"].HeaderText = "Biển số xe";
            panel.Columns["chatLuong"].HeaderText = "Chất lượng";
            panel.Columns["loaiXe"].HeaderText = "Loại xe";
            panel.Columns["nhanSoXe"].HeaderText = "Nhãn số xe";

            panel.Columns["loai"].Visible = false;

            foreach (GridColumn column in panel.Columns)
            {
                column.ColumnSortMode = ColumnSortMode.Multiple;
                column.AutoSizeMode = ColumnAutoSizeMode.Fill;
            }

            if (panel.Rows.Count < 1)
            { //ko co mat hang nao
                visibleColumn(panel, 0);
                return;
            }
            int loaiMH = Int32.Parse(((GridRow)panel.Rows[0]).Cells["loai"].Value.ToString());
            visibleColumn(panel, loaiMH);
        }

        private void visibleColumn(GridPanel panel, int loai)
        {

            switch (loai)
            {
                case 0:
                    panel.Caption.Text = "Không có hàng cầm";
                    break;
                case 2: //vang
                case 3:
                case 4:
                    panel.Caption.Text = "Vàng";
                    panel.Columns["bienSo"].Visible = false;
                    panel.Columns["loaiXe"].Visible = false;
                    panel.Columns["nhanSoXe"].Visible = false;

                    panel.Columns["soLuong"].Visible = true;
                    break;
                case 1: //xe
                    panel.Caption.Text = "Xe";
                    panel.Columns["bienSo"].Visible = true;
                    panel.Columns["loaiXe"].Visible = true;
                    panel.Columns["nhanSoXe"].Visible = true;

                    panel.Columns["soLuong"].Visible = false;
                    break;
            }
        }

        private void updateChange_ChuocDo()
        {
            //tab chuộc đồ
            double tongTienLai = _tienLai_Chuoc[0] + _tienLai_Chuoc[1];
            lblTienLaiThoaThuan_ChuocDo.Text = UtilCommon.formatTien(_tienLai_Chuoc[0]);
            lblTienLaiQuaHan_ChuocDo.Text = UtilCommon.formatTien(_tienLai_Chuoc[1]);
            lblTongTienLai_ChuocDo.Text = UtilCommon.formatTien(tongTienLai);

            double tienDongLaiTruoc = Controller.Controller.getInstance().layTienTraLaiTruoc(_hd.hd_id);
            lblTienDongLaiTruoc_ChuocDo.Text = UtilCommon.formatTien(tienDongLaiTruoc);

            float tienTangGiam = 0;
            if (!txtTienTangGiam.Text.Trim().Equals("") && !txtTienTangGiam.Text.Trim().Equals("-"))
            {
                tienTangGiam = float.Parse(txtTienTangGiam.Text.Trim());
            }

            if (tienTangGiam == 0)
            {
                lblTangGiam.Text = "";
            }
            else if (tienTangGiam > 0)
            {
                lblTangGiam.Text = "tăng";
            }
            else if (tienTangGiam < 0)
            {
                lblTangGiam.Text = "giảm";
            }
            double tongTienPhaiTra = _hd.tienCam + tongTienLai - tienDongLaiTruoc + tienTangGiam;
            lblTongTienPhaiTra_ChuocDo.Text = UtilCommon.formatTien(tongTienPhaiTra);
            lblTienChu_ChuocDo.Text = UtilCommon.docso(tongTienPhaiTra) + " đồng.";
        }

        private void updateChange_ThanhLy()
        {
            //tab thanh lý
            DateTime ngayThayLy = dateTimeInputNgayThanhLy_ThanhLy.Value;
            int soNgayCam = ngayThayLy.Subtract(_hd.ngayTao).Days;
            double tongTienLai = _tienLai_ThanhLy[0] + _tienLai_ThanhLy[1];

            lblTongTienLai_ThanhLy.Text = UtilCommon.formatTien(tongTienLai);
            lblSoNgayCam_ThanhLy.Text = soNgayCam.ToString();
            lblTongTienVaVon_ThanhLy.Text = UtilCommon.formatTien(tongTienLai + _hd.tienCam);

            //ToDo validate tien thanh ly
            if (txtTienThanhLy_ThanhLy.Text.Trim().Equals(""))
            {
                return;
            }
            float tienThanhLy = float.Parse(txtTienThanhLy_ThanhLy.Text.Trim());
            float tienChenhLech = tienThanhLy - (float)(tongTienLai + _hd.tienCam);

            lblTienChenhLech_ThanhLy.Text = UtilCommon.formatTien(tienChenhLech);
            if (tienChenhLech >= 0)
            {
                lblTienChu_ThanhLy.Text = "Lời " + UtilCommon.docso(tienChenhLech) + " đồng.";
            }
            else
            {
                lblTienChu_ThanhLy.Text = "Lỗ " + UtilCommon.docso(tienChenhLech * -1) + " đồng.";
            }
        }

        void GridNhatKyGD_DataBindingComplete(
                   object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[0].GroupBoxEffects = GroupBoxEffects.None;
            panel.Columns["ngayGiaoDich"].HeaderText = "Ngày giao dịch";
            panel.Columns["loaiGiaoDich"].HeaderText = "Loại giao dịch";
            panel.Columns["soTienGiaoDich"].HeaderText = "Tiền giao dịch";
            panel.Columns["tongTienCam"].HeaderText = "Tổng tiền cầm";
        }
        #endregion
    }
}
