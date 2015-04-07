using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawnShopManager.Dto;

namespace PawnShopManager.GUI.BODY
{
    public partial class QLGiaoDich : DevComponents.DotNetBar.Metro.MetroForm
    {
        public QLGiaoDich()
        {
            InitializeComponent();

            cboTkTheo.SelectedIndex = 0;
            cboLoaiGiaoDich.SelectedIndex = 0;
            datePicker_ChonNgay.Value = DateTime.Now;
        }

        private void QLGiaoDich_Load(object sender, EventArgs e)
        {
            ThongKeGdDto thongKeDto = new ThongKeGdDto();
            thongKeDto = Controller.Controller.getInstance().thongKeGiaoDich(DateTime.Now);

            lblTongVonChuocDo.Text = Util.UtilCommon.formatTien(thongKeDto.tongVonChuocDo);
            lblTongLaiTraTruoc.Text = Util.UtilCommon.formatTien(thongKeDto.tongLaiTraTruoc);
            lblTongLaiThanhLy.Text = Util.UtilCommon.formatTien(thongKeDto.tongLaiThanhLy);
            lblTongTienThuKhac.Text = Util.UtilCommon.formatTien(thongKeDto.tongTienThuKhac);

            lblTongTienCamDo.Text = Util.UtilCommon.formatTien(thongKeDto.tongTienCamDo);
            lblTongTienLayThem.Text = Util.UtilCommon.formatTien(thongKeDto.tongTienLayThem);
            lblTongTienChiKhac.Text = Util.UtilCommon.formatTien(thongKeDto.tongTienChiKhac);

            double thuHomNay = 0;
            double chiHomNay = 0;
            double thuChiConLai = 0;

            thuHomNay = thongKeDto.tongVonChuocDo + thongKeDto.tongLaiTraTruoc + thongKeDto.tongLaiThanhLy + thongKeDto.tongTienThuKhac;
            chiHomNay = thongKeDto.tongTienCamDo + thongKeDto.tongTienLayThem + thongKeDto.tongTienChiKhac;
            thuChiConLai =  thuHomNay - chiHomNay;

            lblThuHomNay.Text = Util.UtilCommon.formatTien(thuHomNay);
            lblChiHomNay.Text = Util.UtilCommon.formatTien(chiHomNay);
            lblThuChiConLai.Text = Util.UtilCommon.formatTien(thuChiConLai);

            DateTime homQua = DateTime.Now.AddDays(-1);
            ThongKeGdDto thongKe_HomQua = Controller.Controller.getInstance().thongKeGiaoDich(homQua);

            double tongTienConLai_HomQua = 0;
            double thuHomQua = 0;
            double chiHomQua = 0;

            thuHomQua = thongKe_HomQua.tongVonChuocDo + thongKe_HomQua.tongLaiTraTruoc + thongKe_HomQua.tongLaiThanhLy + thongKe_HomQua.tongTienThuKhac;
            chiHomQua = thongKe_HomQua.tongTienCamDo + thongKe_HomQua.tongTienLayThem + thongKe_HomQua.tongTienChiKhac;
            tongTienConLai_HomQua = thuHomQua - chiHomQua;

            lblTongTienConLai_HomNay.Text = Util.UtilCommon.formatTien(thuChiConLai);
            lblTongTienConLai_NgayTruoc.Text = Util.UtilCommon.formatTien(tongTienConLai_HomQua);

            tabControl1.SelectedTab = tabTkChiTiet;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int loai = 0;
            int index = cboTkTheo.SelectedIndex;
            switch (index)
            {
                case 0:
                    ngay = datePicker_ChonNgay.Value.Day;
                    thang = datePicker_ChonNgay.Value.Month;
                    nam = datePicker_ChonNgay.Value.Year;
                    break;
                case 1:
                    thang = datePicker_ChonNgay.Value.Month;
                    nam = datePicker_ChonNgay.Value.Year;
                    break;
                case 2:
                    nam = datePicker_ChonNgay.Value.Year;
                    break;
            }

            loai = cboLoaiGiaoDich.SelectedIndex;

            DataTable table = Controller.Controller.getInstance().ThongKeGiaoDich_Table(ngay, thang, nam, loai);
            superGridControl_ThongKe.PrimaryGrid.DataSource = table;
            superGridControl_ThongKe.PrimaryGrid.DataMember = "ThongKeGiaoDich_Table";
        }

        private void cboTkTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboTkTheo.SelectedIndex;
            switch (index)
            {
                case 0:
                    datePicker_ChonNgay.CustomFormat = "dd/MM/yyyy";
                    break;
                case 1:
                    datePicker_ChonNgay.CustomFormat = "MM/yyyy";
                    break;
                case 2:
                    datePicker_ChonNgay.CustomFormat = "yyyy";
                    break;
            }
        }
    }
}
