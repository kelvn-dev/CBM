using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CBM.Customs {
  public partial class CBMTxt : UserControl {

    private Color borderColor = ColorTranslator.FromHtml(Constant.GRAY_COLOR);
    private Color focusedBorderColor = ColorTranslator.FromHtml(Constant.BLACK_COLOR);
    private int borderSize = Constant.MIN_BORDER_SIZE;
    private int borderRadius = 20;
    private bool underlinedStyle = false;

    private Color placeHolderColor = ColorTranslator.FromHtml(Constant.GRAY_COLOR);
    private string placeholderText = "";
    private bool isPasswordChar = false;
    private bool isPlaceholder = false;


    public Color BorderColor {
      get => borderColor;
      set {
        borderColor = value;
        this.Invalidate();
      }
    }

    public Color FocusedBorderColor {
      get => focusedBorderColor;
      set => focusedBorderColor = value;
    }

    public int BorderSize {
      get => borderSize;
      set {
        borderSize = value;
        this.Invalidate();
      }
    }
    public int BorderRadius {
      get => borderRadius;
      set {
        if (value >= 0) {
          borderRadius = value;
          this.Invalidate();
        }
      }
    }

    public bool UnderlinedStyle {
      get => underlinedStyle;
      set {
        underlinedStyle = value;
        this.Invalidate();
      }
    }


    public bool PasswordChar {
      get => isPasswordChar;
      set {
        isPasswordChar = value;
        if (!isPlaceholder)
          textBox.UseSystemPasswordChar = value;
      }
    }

    public bool Multiline {
      get => textBox.Multiline;
      set => textBox.Multiline = value;
    }

    public override Color BackColor {
      get => base.BackColor;
      set {
        base.BackColor = value;
        textBox.BackColor = value;
      }
    }

    public override Color ForeColor {
      get => base.ForeColor;
      set {
        base.ForeColor = value;
        textBox.ForeColor = value;
      }
    }

    public override Font Font {
      get => base.Font;
      set {
        base.Font = value;
        textBox.Font = value;
        if (this.DesignMode) {
          UpdateControlHeight();
        }
      }
    }

    public string Texts {
      get {
        if (isPlaceholder) {
          return "";
        }
        return textBox.Text;
      }
      set {
        textBox.Text = value;
        SetPlaceholder();
      }
    }
    public Color PlaceHolderColor {
      get => placeHolderColor;
      set {
        placeHolderColor = value;
        if (isPlaceholder) {
          textBox.ForeColor = value;
        }
      }
    }
    public string PlaceholderText {
      get => placeholderText;
      set {
        placeholderText = value;
        textBox.Text = string.Empty;
        SetPlaceholder();
      }
    }

    private void SetPlaceholder() {
      if (string.IsNullOrWhiteSpace(textBox.Text) && !string.IsNullOrEmpty(placeholderText)) {
        isPlaceholder = true;
        textBox.Text = placeholderText;
        textBox.ForeColor = placeHolderColor;
        if (isPasswordChar) {
          textBox.UseSystemPasswordChar = false;
        }
      }
    }

    private void RemovePlaceholder() {
      if (isPlaceholder && !string.IsNullOrEmpty(placeholderText)) {
        isPlaceholder = false;
        textBox.Text = string.Empty;
        textBox.ForeColor = this.ForeColor;
        if (isPasswordChar) {
          textBox.UseSystemPasswordChar = true;
        }
      }
    }
    public CBMTxt() {
      InitializeComponent();
      CssUserControl();
      CssTextBox();
      textBox.Enter += EnterEvent;
      textBox.Leave += LeaveEvent;
    }

    public void CssUserControl() {
      this.Padding = new Padding(12);
      this.BackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    }

    public void CssTextBox() {
      this.textBox.Dock = DockStyle.Fill;
      this.textBox.BorderStyle = BorderStyle.None;
      this.BackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      Graphics graph = e.Graphics;
      if (borderRadius > 1) {
        var rectBorderSmooth = this.ClientRectangle;
        var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
        int smoothSize = borderSize > 0 ? borderSize : 1;
        using (GraphicsPath pathBorderSmooth = UserControlUtils.GetFigurePath(rectBorderSmooth, borderRadius))
        using (GraphicsPath pathBorder = UserControlUtils.GetFigurePath(rectBorder, borderRadius - borderSize))
        using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(this.textBox.Focused ? focusedBorderColor : borderColor, borderSize)) {
          //-Drawing
          this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
          if (BorderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
          graph.SmoothingMode = SmoothingMode.AntiAlias;
          penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
          if (underlinedStyle) { //Line Style 
                                 //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            //Draw border
            graph.SmoothingMode = SmoothingMode.None;
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          }
          else { //Normal Style
                 //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            //Draw border
            graph.DrawPath(penBorder, pathBorder);
          }
        }
      }
      else {
        using (Pen penBorder = new Pen(borderColor, borderSize)) {
          this.Region = new Region(this.ClientRectangle);
          penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
          if (this.textBox.Focused) penBorder.Color = focusedBorderColor;
          if (underlinedStyle) //Line Style
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          else //Normal Style
            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }
      }
    }

    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      if (this.DesignMode) {
        UpdateControlHeight();
      }
    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);
      UpdateControlHeight();
    }

    private void UpdateControlHeight() {
      if (!textBox.Multiline) {
        int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        textBox.Multiline = true;
        textBox.MinimumSize = new Size(0, txtHeight);
        textBox.Multiline = false;

        this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }

    private void SetTextBoxRoundedRegion() {
      GraphicsPath pathTxt;
      pathTxt = UserControlUtils.GetFigurePath(textBox.ClientRectangle, Multiline ? (BorderRadius - BorderSize) : (BorderSize * 2));
      textBox.Region = new Region(pathTxt);
      pathTxt.Dispose();
    }

    private void EnterEvent(object sender, EventArgs e) {
      this.Invalidate();
      RemovePlaceholder();
    }

    private void LeaveEvent(object sender, EventArgs e) {
      this.Invalidate();
      SetPlaceholder();
    }

  }
}
