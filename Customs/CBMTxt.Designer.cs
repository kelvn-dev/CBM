﻿namespace CBM.Customs {
  partial class CBMTxt {
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
      this.textBox.Location = new System.Drawing.Point(61, 79);
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(100, 31);
      this.textBox.TabIndex = 0;
      // 
      // CBMTxt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBox);
      this.Name = "CBMTxt";
      this.Size = new System.Drawing.Size(300, 150);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox;
  }
}
