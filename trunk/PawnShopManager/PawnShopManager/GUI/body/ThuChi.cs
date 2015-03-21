using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawnShopManager.Util;
using System.Text.RegularExpressions;

namespace PawnShopManager.GUI.BODY
{
    public partial class ThuChi : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ThuChi()
        {
            InitializeComponent();
            cbHinhThuc.SelectedIndex = 0;
            cbLoaiThongKe.SelectedIndex = 0;
            cbDateTime.Value = DateTime.Now;
        }
#region Event

        #region sự kiện thay đổi loại thu chi
        private void cbLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbLoaiThongKe.SelectedIndex;
            if (i == 0)
            { //chon Ngay
                datePicker_Ton.CustomFormat = "dd/MM/yyyy";
                datePicker_Ton.ButtonDropDown.Visible = true;
                lblChonLoai.Text = "Chọn ngày:";
            }
            else if (i == 1)
            { //chon Thang
                datePicker_Ton.CustomFormat = "MM/yyyy";
                datePicker_Ton.ButtonDropDown.Visible = false;
                lblChonLoai.Text = "Chọn tháng:";
            }
            else if (i == 2)
            { //chon Nam
                datePicker_Ton.CustomFormat = "yyyy";
                datePicker_Ton.ButtonDropDown.Visible = false;
                lblChonLoai.Text = "Chọn năm:";
            }
        }
        #endregion

        #region Sự kiện Lưu dữ liệu 
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (tbTien.Text.Trim().Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập số tiền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            }
            int loaiTC = Convert.ToInt32(cbHinhThuc.SelectedIndex);
            DateTime dateCreate = cbDateTime.Value;
            string note = tbGhiChu.Text.Trim();
            float tienCam = float.Parse(tbTien.Text.Trim());

            //them thu chi moi
            bool addSuccess = Controller.Controller.getInstance().themTC(loaiTC, dateCreate, tienCam,note);
            if (addSuccess)
            {
                //save
                MessageBox.Show("Thêm mới thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                EnableComponentAfterAdd();
            }
            else
            {
                MessageBox.Show("Không thể thêm mới thu chi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tự sinh dữ liệu tiền theo chữ
        private void tbTien_TextChanged(object sender, EventArgs e)
        {
            if (tbTien.Text.Trim().Equals(""))
            {
                return;
            }
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(tbTien.Text.Trim()))
            {
                lblTienChu.Text = "Yêu cầu không nhập chữ!";
                return;
            }
            lblTienChu.Text = Util.UtilCommon.docso(Double.Parse(tbTien.Text.Trim())) + " đồng.";
        }
        #endregion

        #region reset các Control sau khi thêm thành công thu chi
        private void EnableComponentAfterAdd()
        {
            tbTien.Text = "";
            tbGhiChu.Text = "";
            lblTienChu.Text = "";
        }
        #endregion

#endregion
        #region function

        #endregion

    }
}
