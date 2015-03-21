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
using PawnShopManager.Controller;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;

namespace PawnShopManager.GUI.BODY
{
   public partial class Test_Datagrid : Form
   {
      public Test_Datagrid()
      {
         InitializeComponent();

         GridRow drow = new GridRow("Row 1");
         drow.RowHeight = 0;
         drow.RowsUnresolved = true;
         drow.Tag = "Tag Row 1";
         drow.Cells[0].Value = "aaaaa";
         superGridControl_Tree.PrimaryGrid.Rows.Add(drow);

         drow = new GridRow("Row 2");
         drow.RowHeight = 0;
         drow.RowsUnresolved = true;
         drow.Tag = "Tag Row 2";
         drow.Cells[0].Value = "bbbb";
         superGridControl_Tree.PrimaryGrid.Rows.Add(drow);
      }

      int ngay = 0, thang = 0, nam = 2011;
      private void buttonX1_Click(object sender, EventArgs e)
      {
         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc_List(ngay, thang, nam);
         dataGridViewX.RowCount = 0;
         for (int i = 1; i < listThongKe.Count; i++)
         {
            TkChuocDto dto = listThongKe[i];
            dataGridViewX.Rows.Add(dto.maHD, dto.tenKH, dto.loaiXe);
         }
      }

      private void buttonX3_Click(object sender, EventArgs e)
      {
         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc_List(ngay, thang, nam);
         dataGridView.RowCount = 0;
         for (int i = 1; i < listThongKe.Count; i++)
         {
            TkChuocDto dto = listThongKe[i];
            dataGridView.Rows.Add(dto.maHD, dto.tenKH, dto.loaiXe);
         }
      }

      private void buttonX2_Click(object sender, EventArgs e)
      {
         List<TkChuocDto> listThongKe = Controller.Controller.getInstance().thongKe_Chuoc_List(ngay, thang, nam);
         for (int i = 1; i < listThongKe.Count; i++)
         {
            TkChuocDto dto = listThongKe[i];
         }
      }

      private void Test_Datagrid_Load(object sender, EventArgs e)
      {
         dataGridViewX_Merge.Rows.Add("0", "1", "2");
         dataGridViewX_Merge.Rows.Add("0", "2", "3");
         dataGridViewX_Merge.Rows.Add("0", "3", "4");
         dataGridViewX_Merge.Rows.Add("3", "4", "5");
         dataGridViewX_Merge.Paint += new PaintEventHandler(dataGrid_Paint);
      }
      bool readyToMerge = false;
      private void dataGrid_Paint(object sender, PaintEventArgs e)
      {
         if (readyToMerge)
         {
            Merge();
         }
      }
      private void Merge()
      {
         int Column = 0;
         int RowId1 = 0;
         int RowId2 = 2;
         DataGridViewX dataGrid = dataGridViewX_Merge;
         bool isSelected = false;

         Graphics g = dataGrid.CreateGraphics();
         Pen gridPen = new Pen(dataGrid.GridColor);

         //Cells Rectangles
         Rectangle CellRectangle1 = dataGrid.GetCellDisplayRectangle(Column, RowId1, true);
         Rectangle CellRectangle2 = dataGrid.GetCellDisplayRectangle(Column, RowId2, true);

         int rectHeight = 0;
         string MergedRows = String.Empty;

         for (int i = RowId1; i <= RowId2; i++)
         {
            rectHeight += dataGrid.GetCellDisplayRectangle(Column, i, false).Height;
         }

         Rectangle newCell = new Rectangle(CellRectangle1.X, CellRectangle1.Y, CellRectangle1.Width, rectHeight);

         g.FillRectangle(new SolidBrush(isSelected ? dataGrid.DefaultCellStyle.SelectionBackColor : dataGrid.DefaultCellStyle.BackColor), newCell);

         g.DrawRectangle(gridPen, newCell);

         g.DrawString(dataGrid.Rows[RowId1].Cells[Column].Value.ToString(), dataGrid.DefaultCellStyle.Font, new SolidBrush(isSelected ? dataGrid.DefaultCellStyle.SelectionForeColor : dataGrid.DefaultCellStyle.ForeColor), newCell.X + newCell.Width / 3, newCell.Y + newCell.Height / 3);
      }
      private void buttonX4_Click(object sender, EventArgs e)
      {
         Merge();
         readyToMerge = true;
      }
   }
}
