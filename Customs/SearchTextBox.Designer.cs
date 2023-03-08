namespace CBM.Customs {
  partial class SearchTextBox {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.textBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox
      // 
      this.textBox.Location = new System.Drawing.Point(49, 24);
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(219, 31);
      this.textBox.TabIndex = 0;
      // 
      // SearchTextBox
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.textBox);
      this.Name = "SearchTextBox";
      this.Size = new System.Drawing.Size(383, 122);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox;
  }
}
