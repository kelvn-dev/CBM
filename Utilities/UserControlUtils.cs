using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBM.Customs;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CBM.Utilities {
  public class UserControlUtils {
    public static GraphicsPath GetFigurePath(Rectangle rect, int radius) {
      GraphicsPath path = new GraphicsPath();
      float curveSize = radius * 2F;
      path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
      path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
      path.CloseFigure();
      return path;
    }

    public static void CssSaveBtn(CBMButton button) {
      button.Size = new Size(158, 40);
      button.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR); ;
      button.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR); ;
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR); ;
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
      button.Text = "Save Changes";
    }

    public static void CssCancelBtn(CBMButton button) {
      button.Size = new Size(90, 40);
      button.BackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.BLACK_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.GRAY_COLOR);
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
      button.Text = "Cancel";
    }

    public static void CssClickedTabButton(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.BOLD_BG_COLOR);
      button.ForeColor = Color.Black;
      button.BorderSize = 3;
      button.BorderColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
      button.BorderRadius = 2;
    }

    public static void CssDatagridView(DataGridView dataGridView) {
      DataGridViewCellStyle headerDataGridViewCellStyle = new DataGridViewCellStyle();
      headerDataGridViewCellStyle.BackColor = ColorTranslator.FromHtml("#362f4b");
      headerDataGridViewCellStyle.ForeColor = Color.White;
      headerDataGridViewCellStyle.Font = new Font("Poppins", 12);

      DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
      dataGridViewCellStyle.BackColor = Color.White; ;
      dataGridViewCellStyle.ForeColor = ColorTranslator.FromHtml("#959595");
      dataGridViewCellStyle.SelectionBackColor = dataGridViewCellStyle.BackColor;
      dataGridViewCellStyle.SelectionForeColor = dataGridViewCellStyle.ForeColor;
      dataGridViewCellStyle.Font = new Font("Poppins", 12);

      DataGridViewCellStyle alternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
      alternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f6f6f6");
      alternatingRowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#959595");
      alternatingRowsDefaultCellStyle.SelectionBackColor = alternatingRowsDefaultCellStyle.BackColor;
      alternatingRowsDefaultCellStyle.SelectionForeColor = alternatingRowsDefaultCellStyle.ForeColor;
      alternatingRowsDefaultCellStyle.Font = new Font("Poppins", 12);

      dataGridView.ColumnHeadersDefaultCellStyle = headerDataGridViewCellStyle;
      dataGridView.DefaultCellStyle = dataGridViewCellStyle;
      dataGridView.EnableHeadersVisualStyles = false;
      dataGridView.AlternatingRowsDefaultCellStyle = alternatingRowsDefaultCellStyle;

      dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
      dataGridView.BorderStyle = BorderStyle.None;

      dataGridView.RowHeadersVisible = false;
      dataGridView.AllowUserToAddRows = false;

      dataGridView.ColumnHeadersHeight = 55;
      dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      
      dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      // Adjust height automatically
      int height = dataGridView.ColumnHeadersHeight;
      foreach (DataGridViewRow row in dataGridView.Rows) {
        height += row.Height;
      }
      dataGridView.Height = height;

      DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
      btn.HeaderText = "Action";
      btn.Text = "Edit";
      btn.Name = "editBtn";
      btn.UseColumnTextForButtonValue= true;
      dataGridView.Columns.Add(btn);
      
    }

    public static void CssIconButton(IconButton iconButton, Color backColor, Color color, int size = Constant.NORMAL_ICON_SIZE) {
      iconButton.FlatStyle = FlatStyle.Flat;
      iconButton.FlatAppearance.BorderSize = 0;
      iconButton.BackColor = backColor;
      iconButton.ForeColor = color;
      iconButton.IconColor = iconButton.ForeColor;
      iconButton.IconSize = size;
      iconButton.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }
  }
}
