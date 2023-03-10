using CBM.Customs;
using FontAwesome.Sharp;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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

    public static List<CBMTextbox> GetAllCBMTextbox(Control.ControlCollection controls) {
      List<CBMTextbox> textBoxes = new List<CBMTextbox>();
      foreach (Control control in controls) {
        if (control is CBMTextbox) {
          textBoxes.Add((CBMTextbox) control);
        }
      }
      return textBoxes;
    }

    public static void CleanFields(Control.ControlCollection controls) {
      List<CBMTextbox> textBoxes = GetAllCBMTextbox(controls);
      foreach (CBMTextbox textbox in textBoxes) {
        textbox.Texts = string.Empty;
      }
    }

    #region Css

    public static void CssCreateBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }

    public static void CssSaveBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
      button.Text = "Save Changes";
    }

    public static void CssCancelBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
      button.Text = "Cancel";
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

      // !!! Add action column (Need to refactor this)
      DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
      btn.HeaderText = "Action";
      btn.Text = "Edit";
      btn.Name = "editBtn";
      btn.UseColumnTextForButtonValue = true;
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

    public static void CssInformationLabel(Label label) {
      label.ForeColor = ColorTranslator.FromHtml("#141414");
      label.Font = new Font(Constant.FONT_FAMILY, Constant.LARGE_FONT_SIZE, FontStyle.Bold);
    }

    public static void CssFieldLabel(Label label) {
      label.ForeColor = Color.Black;
      label.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }

    public static void CssTextbox(CBMTextbox textBox, string placeholderText) {
      //textBox.Multiline = true;
      textBox.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);

      textBox.PlaceholderText = placeholderText;
      textBox.BorderColor = ColorTranslator.FromHtml(Constant.PLACEHOLDER_COLOR);
      textBox.BorderSize = Constant.MIN_BORDER_SIZE;
      textBox.BorderRadius = Constant.MIN_BORDER_RADIUS;
      textBox.BorderFocusColor = Color.Black;
    }

    #endregion
  }
}
