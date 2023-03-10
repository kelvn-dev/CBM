namespace CBM.Views {
  partial class GroupForm {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.nameLabel = new System.Windows.Forms.Label();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.informationLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.descriptionTxt = new CBM.Customs.CBMTextbox();
      this.nameTxt = new CBM.Customs.CBMTextbox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(45, 241);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(133, 25);
      this.nameLabel.TabIndex = 35;
      this.nameLabel.Text = "Group Name";
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(45, 348);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
      this.descriptionLabel.TabIndex = 36;
      this.descriptionLabel.Text = "Description";
      // 
      // informationLabel
      // 
      this.informationLabel.AutoSize = true;
      this.informationLabel.Location = new System.Drawing.Point(36, 56);
      this.informationLabel.Name = "informationLabel";
      this.informationLabel.Size = new System.Drawing.Size(183, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "Group Information";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.saveBtn);
      this.panel1.Controls.Add(this.cancelBtn);
      this.panel1.Controls.Add(this.informationLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1501, 134);
      this.panel1.TabIndex = 38;
      // 
      // saveBtn
      // 
      this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.saveBtn.BorderColor = System.Drawing.Color.Empty;
      this.saveBtn.BorderRadius = 0;
      this.saveBtn.BorderSize = 0;
      this.saveBtn.FlatAppearance.BorderSize = 0;
      this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.saveBtn.Location = new System.Drawing.Point(1190, 22);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(280, 93);
      this.saveBtn.TabIndex = 32;
      this.saveBtn.Text = "Save Changes";
      this.saveBtn.UseVisualStyleBackColor = true;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelBtn.BorderColor = System.Drawing.Color.Empty;
      this.cancelBtn.BorderRadius = 0;
      this.cancelBtn.BorderSize = 0;
      this.cancelBtn.FlatAppearance.BorderSize = 0;
      this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBtn.Location = new System.Drawing.Point(963, 22);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(184, 93);
      this.cancelBtn.TabIndex = 33;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // descriptionTxt
      // 
      this.descriptionTxt.BackColor = System.Drawing.Color.White;
      this.descriptionTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.descriptionTxt.BorderFocusColor = System.Drawing.Color.Black;
      this.descriptionTxt.BorderRadius = 0;
      this.descriptionTxt.BorderSize = 2;
      this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionTxt.ForeColor = System.Drawing.Color.Black;
      this.descriptionTxt.IsFocused = false;
      this.descriptionTxt.Location = new System.Drawing.Point(542, 348);
      this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionTxt.Multiline = true;
      this.descriptionTxt.Name = "descriptionTxt";
      this.descriptionTxt.Padding = new System.Windows.Forms.Padding(14);
      this.descriptionTxt.PasswordChar = false;
      this.descriptionTxt.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.descriptionTxt.PlaceholderText = "";
      this.descriptionTxt.Size = new System.Drawing.Size(558, 240);
      this.descriptionTxt.TabIndex = 40;
      this.descriptionTxt.Texts = "";
      this.descriptionTxt.UnderlinedStyle = false;
      // 
      // nameTxt
      // 
      this.nameTxt.BackColor = System.Drawing.Color.White;
      this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.nameTxt.BorderFocusColor = System.Drawing.Color.Black;
      this.nameTxt.BorderRadius = 0;
      this.nameTxt.BorderSize = 2;
      this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameTxt.ForeColor = System.Drawing.Color.Black;
      this.nameTxt.IsFocused = false;
      this.nameTxt.Location = new System.Drawing.Point(542, 231);
      this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
      this.nameTxt.Multiline = true;
      this.nameTxt.Name = "nameTxt";
      this.nameTxt.Padding = new System.Windows.Forms.Padding(14);
      this.nameTxt.PasswordChar = false;
      this.nameTxt.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.nameTxt.PlaceholderText = "";
      this.nameTxt.Size = new System.Drawing.Size(558, 59);
      this.nameTxt.TabIndex = 39;
      this.nameTxt.Texts = "";
      this.nameTxt.UnderlinedStyle = false;
      // 
      // GroupForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1164);
      this.Controls.Add(this.descriptionTxt);
      this.Controls.Add(this.nameTxt);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.descriptionLabel);
      this.Name = "GroupForm";
      this.Text = "GroupForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.Label informationLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMTextbox nameTxt;
    private Customs.CBMTextbox descriptionTxt;
  }
}