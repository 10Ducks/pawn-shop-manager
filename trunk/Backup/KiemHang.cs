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
using DevComponents.DotNetBar.Controls;
using System.Collections;

namespace PawnShopManager.GUI.BODY
{
   public partial class KiemHang : DevComponents.DotNetBar.Metro.MetroForm
   {
      private List<string> MergedRowsInFirstColumn = new List<string>();
      private DataSet dataSet;
      private bool readyToMerge = false;

      public KiemHang()
      {
         InitializeComponent();
      }

      private void KiemHang_Load(object sender, EventArgs e)
      {
         cboTkTheo_Ton.SelectedIndex = 0;
         cboTkTheo_Chuoc.SelectedIndex = 0;
      }

      private void cboTkTheo_Ton_SelectedIndexChanged(object sender, EventArgs e)
      {
         int i = cboTkTheo_Ton.SelectedIndex;
         if (i == 0)
         { //chon Ngay
            datePicker_Ton.CustomFormat = "dd/MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = true;
            lblLoaiThongKe_Ton.Text = "Chọn ngày:";
         }else if(i == 1){ //chon Thang
            datePicker_Ton.CustomFormat = "MM/yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn tháng:";
         }else if(i == 2){ //chon Nam
            datePicker_Ton.CustomFormat = "yyyy";
            datePicker_Ton.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Ton.Text = "Chọn năm:";
         }
      }

      private void cboTkTheo_Chuoc_SelectedIndexChanged(object sender, EventArgs e)
      {
         int i = cboTkTheo_Chuoc.SelectedIndex;
         if (i == 0)
         { //chon Ngay
            datePicker_Chuoc.CustomFormat = "dd/MM/yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = true;
            lblLoaiThongKe_Chuoc.Text = "Chọn ngày:";
         }
         else if (i == 1)
         { //chon Thang
            datePicker_Chuoc.CustomFormat = "MM/yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Chuoc.Text = "Chọn tháng:";
         }
         else if (i == 2)
         { //chon Nam
            datePicker_Chuoc.CustomFormat = "yyyy";
            datePicker_Chuoc.ButtonDropDown.Visible = false;
            lblLoaiThongKe_Chuoc.Text = "Chọn năm:";
         }
      }

      private void btnKiemHang_Chuoc_Click(object sender, EventArgs e)
      {
         int index = cboTkTheo_Chuoc.SelectedIndex;         
         int ngay = 0, thang = 0, nam = 0;

         if (index == 0)
         { //chon theo ngay
            ngay = Int16.Parse(datePicker_Chuoc.Value.Day.ToString());
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (index == 1) //chon theo thang
         {
            thang = Int16.Parse(datePicker_Chuoc.Value.Month.ToString());
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         else if (index == 2) //chon theo nam
         {
            nam = Int16.Parse(datePicker_Chuoc.Value.Year.ToString());
         }
         
         
         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc_List(ngay, thang, nam);
         dataGridKiemHang_Chuoc.RowCount = 0; //reset dataGridView
         //khoi tao cac bien dem
         int dem_18k = 0, dem_24k = 0, dem_trang = 0, dem_xe = 0, dem_khac = 0;
         double tongSoTien = 0;
         int chiVang18k = 0, chiVang24k = 0, chiVangTrang = 0;
   
         Hashtable hashHD = new Hashtable();

         for(int i=1; i<listThongKe.Count; i++){
            TkChuocDto dto = listThongKe[i];
            string loaiHang = "";
            
            switch (dto.loaiHang){
               case "1":
                  loaiHang = "Xe";
                  dem_xe++;
                  break;
               case "2":
                  loaiHang = "Vàng 18k";
                  dem_18k++;
                  chiVang18k += dto.soLuong;
                  break;
               case "3":
                  loaiHang = "Vàng 24k";
                  dem_24k++;
                  chiVang24k += dto.soLuong;
                  break;
               case "4":
                  loaiHang = "Vàng trắng";
                  dem_trang++;
                  chiVangTrang += dto.soLuong;
                  break;
               case "5":
                  loaiHang = "Khác";
                  dem_khac++;
                  break;
            }

            dataGridKiemHang_Chuoc.Rows.Add( dto.maHD,      
                                             dto.tenKH,
                                             loaiHang,
                                             dto.tenMatHang,
                                             dto.chatLuong,
                                             dto.bienSo,
                                             dto.loaiXe,
                                             String.Format("{0:0,0}", dto.tienCam),
                                             dto.ngayCam,
                                             dto.ngayHetHan,
                                             dto.soNgayCam);
            if(!hashHD.ContainsKey(dto.maHD)){
               hashHD.Add(dto.maHD, dto.tienCam);
               tongSoTien += dto.tienCam;
            }

         }

         lblTongSoMon_Chuoc.Text = dataGridKiemHang_Chuoc.RowCount.ToString();
         //lbl18k_Chuoc.Text = dem_18k.ToString();
         //lbl24k_Chuoc.Text = dem_24k.ToString();
         //lblVangTrang_Chuoc.Text = dem_trang.ToString();
         lbl18k_Chuoc.Text = chiVang18k.ToString();
         lbl24k_Chuoc.Text = chiVang24k.ToString();
         lblVangTrang_Chuoc.Text = chiVangTrang.ToString();
         lblXeMay_Chuoc.Text = dem_xe.ToString();
         lblTongSoTien_Chuoc.Text = String.Format("{0:0,0}", tongSoTien);

         DataTable dataTable = Controller.Controller.getInstance().thongKe_Chuoc_DataTable(ngay, thang, nam);
         dataSet = new DataSet();
         dataSet.Tables.Add(dataTable);
            
         dataGridKiemHang_Chuoc.Paint += new PaintEventHandler(dataGrid_Paint);
         //merge Cell
         Merge();
         readyToMerge = true;
      }


//-----------------------------------
      private void dataGrid_Paint(object sender, PaintEventArgs e)
      {
         if (readyToMerge)
         {
            Merge();
         }
      }

      private bool isSelectedCell(int[] Rows, int ColumnIndex)
      {
         if (dataGridKiemHang_Chuoc.SelectedCells.Count > 0)
         {
            for (int iCell = Rows[0]; iCell <= Rows[1]; iCell++)
            {
               for (int iSelCell = 0; iSelCell < dataGridKiemHang_Chuoc.SelectedCells.Count; iSelCell++)
               {
                  if (dataGridKiemHang_Chuoc.Rows[iCell].Cells[ColumnIndex] == dataGridKiemHang_Chuoc.SelectedCells[iSelCell])
                  {
                     return true;
                  }
               }
            }
            return false;
         }
         else
         {
            return false;
         }
      }

      private void Merge()
      {
         int[] RowsToMerge = new int[2];
         RowsToMerge[0] = -1;

         //Merge first column at first
         for (int i = 0; i < dataSet.Tables["ThongKeChuoc"].Rows.Count - 1; i++)
         {
            if (dataSet.Tables["ThongKeChuoc"].Rows[i][0] == dataSet.Tables["ThongKeChuoc"].Rows[i + 1][0])
            {
               if (RowsToMerge[0] == -1)
               {
                  RowsToMerge[0] = i;
                  RowsToMerge[1] = i + 1;
               }
               else
               {
                  RowsToMerge[1] = i + 1;
               }
            }
            else
            {
               MergeCells(RowsToMerge[0], RowsToMerge[1], dataGridKiemHang_Chuoc.Columns[0].Index, isSelectedCell(RowsToMerge, dataGridKiemHang_Chuoc.Columns[0].Index) ? true : false);
               CollectMergedRowsInFirstColumn(RowsToMerge[0], RowsToMerge[1]);
               RowsToMerge[0] = -1;
            }
            if (i == dataSet.Tables["ThongKeChuoc"].Rows.Count - 2)
            {
               MergeCells(RowsToMerge[0], RowsToMerge[1], dataGridKiemHang_Chuoc.Columns[0].Index, isSelectedCell(RowsToMerge, dataGridKiemHang_Chuoc.Columns[0].Index) ? true : false);
               CollectMergedRowsInFirstColumn(RowsToMerge[0], RowsToMerge[1]);
               RowsToMerge[0] = -1;
            }
         }
         if (RowsToMerge[0] != -1)
         {
            MergeCells(RowsToMerge[0], RowsToMerge[1], dataGridKiemHang_Chuoc.Columns[0].Index, isSelectedCell(RowsToMerge, dataGridKiemHang_Chuoc.Columns[0].Index) ? true : false);
            RowsToMerge[0] = -1;
         }

         //merge all other columns
         for (int iColumn = 1; iColumn < dataSet.Tables["ThongKeChuoc"].Columns.Count - 1; iColumn++)
         {
            for (int iRow = 0; iRow < dataSet.Tables["ThongKeChuoc"].Rows.Count - 1; iRow++)
            {
               if ((dataSet.Tables["ThongKeChuoc"].Rows[iRow][iColumn] == dataSet.Tables["ThongKeChuoc"].Rows[iRow + 1][iColumn]) &&
                    (isRowsHaveOneCellInFirstColumn(iRow, iRow + 1)))
               {
                  if (RowsToMerge[0] == -1)
                  {
                     RowsToMerge[0] = iRow;
                     RowsToMerge[1] = iRow + 1;
                  }
                  else
                  {
                     RowsToMerge[1] = iRow + 1;
                  }
               }
               else
               {
                  if (RowsToMerge[0] != -1)
                  {
                     MergeCells(RowsToMerge[0], RowsToMerge[1], iColumn, isSelectedCell(RowsToMerge, iColumn) ? true : false);
                     RowsToMerge[0] = -1;
                  }
               }
            }
            if (RowsToMerge[0] != -1)
            {
               MergeCells(RowsToMerge[0], RowsToMerge[1], iColumn, isSelectedCell(RowsToMerge, iColumn) ? true : false);
               RowsToMerge[0] = -1;
            }
         }
      }

      private bool isRowsHaveOneCellInFirstColumn(int RowId1, int RowId2)
      {

         foreach (string rowsCollection in MergedRowsInFirstColumn)
         {
            string[] RowsNumber = rowsCollection.Split(';');

            if ((isStringInArray(RowsNumber, RowId1.ToString())) &&
                (isStringInArray(RowsNumber, RowId2.ToString())))
            {
               return true;
            }
         }
         return false;
      }

      private bool isStringInArray(string[] Array, string value)
      {
         foreach (string item in Array)
         {
            if (item == value)
            {
               return true;
            }

         }
         return false;
      }

      private void CollectMergedRowsInFirstColumn(int RowId1, int RowId2)
      {
         string MergedRows = String.Empty;

         for (int i = RowId1; i <= RowId2; i++)
         {
            MergedRows += i.ToString() + ";";
         }
         MergedRowsInFirstColumn.Add(MergedRows.Remove(MergedRows.Length - 1, 1));
      }

      private void MergeCells(int RowId1, int RowId2, int Column, bool isSelected)
      {
         Graphics g = dataGridKiemHang_Chuoc.CreateGraphics();
         Pen gridPen = new Pen(dataGridKiemHang_Chuoc.GridColor);

         //Cells Rectangles
         Rectangle CellRectangle1 = dataGridKiemHang_Chuoc.GetCellDisplayRectangle(Column, RowId1, true);
         Rectangle CellRectangle2 = dataGridKiemHang_Chuoc.GetCellDisplayRectangle(Column, RowId2, true);

         int rectHeight = 0;
         string MergedRows = String.Empty;

         for (int i = RowId1; i <= RowId2; i++)
         {
            rectHeight += dataGridKiemHang_Chuoc.GetCellDisplayRectangle(Column, i, false).Height;
         }

         Rectangle newCell = new Rectangle(CellRectangle1.X, CellRectangle1.Y, CellRectangle1.Width, rectHeight);

         g.FillRectangle(new SolidBrush(isSelected ? dataGridKiemHang_Chuoc.DefaultCellStyle.SelectionBackColor : dataGridKiemHang_Chuoc.DefaultCellStyle.BackColor), newCell);

         g.DrawRectangle(gridPen, newCell);

         g.DrawString(dataGridKiemHang_Chuoc.Rows[RowId1].Cells[Column].Value.ToString(), dataGridKiemHang_Chuoc.DefaultCellStyle.Font, new SolidBrush(isSelected ? dataGridKiemHang_Chuoc.DefaultCellStyle.SelectionForeColor : dataGridKiemHang_Chuoc.DefaultCellStyle.ForeColor), newCell.X + newCell.Width / 3, newCell.Y + newCell.Height / 3);
      }
   }
}
