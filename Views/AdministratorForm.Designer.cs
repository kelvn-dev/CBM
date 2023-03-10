using FontAwesome.Sharp;

namespace CBM.Views {
  partial class AdministratorForm {
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
      this.components = new System.ComponentModel.Container();
      this.usernameLabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.informationLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveBtn = new CBM.Customs.CBMButton();
      this.cancelBtn = new CBM.Customs.CBMButton();
      this.phoneLabel = new System.Windows.Forms.Label();
      this.addressLabel = new System.Windows.Forms.Label();
      this.avatarLabel = new System.Windows.Forms.Label();
      this.avatarPictureBox = new CBM.Customs.CBMPictureBox();
      this.zipcodeField = new CBM.Customs.CBMTextbox();
      this.addressField = new CBM.Customs.CBMTextbox();
      this.phoneField = new CBM.Customs.CBMTextbox();
      this.emailField = new CBM.Customs.CBMTextbox();
      this.usernameField = new CBM.Customs.CBMTextbox();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Location = new System.Drawing.Point(36, 489);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(110, 25);
      this.usernameLabel.TabIndex = 41;
      this.usernameLabel.Text = "Username";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Location = new System.Drawing.Point(36, 633);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(65, 25);
      this.emailLabel.TabIndex = 42;
      this.emailLabel.Text = "Email";
      // 
      // informationLabel
      // 
      this.informationLabel.AutoSize = true;
      this.informationLabel.Location = new System.Drawing.Point(36, 56);
      this.informationLabel.Name = "informationLabel";
      this.informationLabel.Size = new System.Drawing.Size(169, 25);
      this.informationLabel.TabIndex = 37;
      this.informationLabel.Text = "User Information";
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
      this.panel1.TabIndex = 43;
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
      // phoneLabel
      // 
      this.phoneLabel.AutoSize = true;
      this.phoneLabel.Location = new System.Drawing.Point(36, 766);
      this.phoneLabel.Name = "phoneLabel";
      this.phoneLabel.Size = new System.Drawing.Size(155, 25);
      this.phoneLabel.TabIndex = 47;
      this.phoneLabel.Text = "Phone Number";
      // 
      // addressLabel
      // 
      this.addressLabel.AutoSize = true;
      this.addressLabel.Location = new System.Drawing.Point(36, 896);
      this.addressLabel.Name = "addressLabel";
      this.addressLabel.Size = new System.Drawing.Size(91, 25);
      this.addressLabel.TabIndex = 48;
      this.addressLabel.Text = "Address";
      // 
      // avatarLabel
      // 
      this.avatarLabel.AutoSize = true;
      this.avatarLabel.Location = new System.Drawing.Point(36, 171);
      this.avatarLabel.Name = "avatarLabel";
      this.avatarLabel.Size = new System.Drawing.Size(74, 25);
      this.avatarLabel.TabIndex = 53;
      this.avatarLabel.Text = "Avatar";
      // 
      // avatarPictureBox
      // 
      this.avatarPictureBox.BackColor = System.Drawing.Color.White;
      this.avatarPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
      this.avatarPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
      this.avatarPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
      this.avatarPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      this.avatarPictureBox.BorderSize = 2;
      this.avatarPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.GradientAngle = 50F;
      this.avatarPictureBox.IconChar = FontAwesome.Sharp.IconChar.Upload;
      this.avatarPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
      this.avatarPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.avatarPictureBox.IconSize = 270;
      this.avatarPictureBox.Location = new System.Drawing.Point(557, 154);
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.Size = new System.Drawing.Size(270, 270);
      this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarPictureBox.TabIndex = 54;
      this.avatarPictureBox.TabStop = false;
      // 
      // zipcodeField
      // 
      this.zipcodeField.BackColor = System.Drawing.Color.White;
      this.zipcodeField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.zipcodeField.BorderFocusColor = System.Drawing.Color.Black;
      this.zipcodeField.BorderRadius = 0;
      this.zipcodeField.BorderSize = 2;
      this.zipcodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.zipcodeField.ForeColor = System.Drawing.Color.Black;
      this.zipcodeField.IsFocused = false;
      this.zipcodeField.Location = new System.Drawing.Point(1025, 882);
      this.zipcodeField.Margin = new System.Windows.Forms.Padding(4);
      this.zipcodeField.Multiline = true;
      this.zipcodeField.Name = "zipcodeField";
      this.zipcodeField.Padding = new System.Windows.Forms.Padding(20, 14, 14, 14);
      this.zipcodeField.PasswordChar = false;
      this.zipcodeField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.zipcodeField.PlaceholderText = "";
      this.zipcodeField.Size = new System.Drawing.Size(182, 70);
      this.zipcodeField.TabIndex = 51;
      this.zipcodeField.Texts = "";
      this.zipcodeField.UnderlinedStyle = false;
      // 
      // addressField
      // 
      this.addressField.BackColor = System.Drawing.Color.White;
      this.addressField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.addressField.BorderFocusColor = System.Drawing.Color.Black;
      this.addressField.BorderRadius = 0;
      this.addressField.BorderSize = 2;
      this.addressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addressField.ForeColor = System.Drawing.Color.Black;
      this.addressField.IsFocused = false;
      this.addressField.Location = new System.Drawing.Point(557, 882);
      this.addressField.Margin = new System.Windows.Forms.Padding(4);
      this.addressField.Multiline = true;
      this.addressField.Name = "addressField";
      this.addressField.Padding = new System.Windows.Forms.Padding(20, 14, 14, 14);
      this.addressField.PasswordChar = false;
      this.addressField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.addressField.PlaceholderText = "";
      this.addressField.Size = new System.Drawing.Size(441, 70);
      this.addressField.TabIndex = 50;
      this.addressField.Texts = "";
      this.addressField.UnderlinedStyle = false;
      // 
      // phoneField
      // 
      this.phoneField.BackColor = System.Drawing.Color.White;
      this.phoneField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.phoneField.BorderFocusColor = System.Drawing.Color.Black;
      this.phoneField.BorderRadius = 0;
      this.phoneField.BorderSize = 2;
      this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneField.ForeColor = System.Drawing.Color.Black;
      this.phoneField.IsFocused = false;
      this.phoneField.Location = new System.Drawing.Point(557, 752);
      this.phoneField.Margin = new System.Windows.Forms.Padding(4);
      this.phoneField.Multiline = true;
      this.phoneField.Name = "phoneField";
      this.phoneField.Padding = new System.Windows.Forms.Padding(20, 14, 14, 14);
      this.phoneField.PasswordChar = false;
      this.phoneField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.phoneField.PlaceholderText = "";
      this.phoneField.Size = new System.Drawing.Size(650, 70);
      this.phoneField.TabIndex = 49;
      this.phoneField.Texts = "";
      this.phoneField.UnderlinedStyle = false;
      // 
      // emailField
      // 
      this.emailField.BackColor = System.Drawing.Color.White;
      this.emailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.emailField.BorderFocusColor = System.Drawing.Color.Black;
      this.emailField.BorderRadius = 0;
      this.emailField.BorderSize = 2;
      this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailField.ForeColor = System.Drawing.Color.Black;
      this.emailField.IsFocused = false;
      this.emailField.Location = new System.Drawing.Point(557, 614);
      this.emailField.Margin = new System.Windows.Forms.Padding(4);
      this.emailField.Multiline = true;
      this.emailField.Name = "emailField";
      this.emailField.Padding = new System.Windows.Forms.Padding(20, 14, 14, 14);
      this.emailField.PasswordChar = false;
      this.emailField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.emailField.PlaceholderText = "";
      this.emailField.Size = new System.Drawing.Size(650, 70);
      this.emailField.TabIndex = 46;
      this.emailField.Texts = "";
      this.emailField.UnderlinedStyle = false;
      // 
      // usernameField
      // 
      this.usernameField.BackColor = System.Drawing.Color.White;
      this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
      this.usernameField.BorderFocusColor = System.Drawing.Color.Black;
      this.usernameField.BorderRadius = 0;
      this.usernameField.BorderSize = 2;
      this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameField.ForeColor = System.Drawing.Color.Black;
      this.usernameField.IsFocused = false;
      this.usernameField.Location = new System.Drawing.Point(557, 478);
      this.usernameField.Margin = new System.Windows.Forms.Padding(4);
      this.usernameField.Multiline = true;
      this.usernameField.Name = "usernameField";
      this.usernameField.Padding = new System.Windows.Forms.Padding(20, 14, 14, 14);
      this.usernameField.PasswordChar = false;
      this.usernameField.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
      this.usernameField.PlaceholderText = "";
      this.usernameField.Size = new System.Drawing.Size(650, 70);
      this.usernameField.TabIndex = 44;
      this.usernameField.Texts = "";
      this.usernameField.UnderlinedStyle = false;
      // 
      // errorProvider
      // 
      this.errorProvider.ContainerControl = this;
      // 
      // AdministratorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1501, 1069);
      this.Controls.Add(this.avatarPictureBox);
      this.Controls.Add(this.avatarLabel);
      this.Controls.Add(this.zipcodeField);
      this.Controls.Add(this.addressField);
      this.Controls.Add(this.phoneField);
      this.Controls.Add(this.addressLabel);
      this.Controls.Add(this.phoneLabel);
      this.Controls.Add(this.emailField);
      this.Controls.Add(this.usernameLabel);
      this.Controls.Add(this.emailLabel);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.usernameField);
      this.Name = "AdministratorForm";
      this.Text = "AdministratorForm";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.Label informationLabel;
    private System.Windows.Forms.Panel panel1;
    private Customs.CBMButton saveBtn;
    private Customs.CBMButton cancelBtn;
    private Customs.CBMTextbox usernameField;
    private Customs.CBMTextbox emailField;
    private System.Windows.Forms.Label phoneLabel;
    private System.Windows.Forms.Label addressLabel;
    private Customs.CBMTextbox phoneField;
    private Customs.CBMTextbox addressField;
    private Customs.CBMTextbox zipcodeField;
    private System.Windows.Forms.Label avatarLabel;
    private Customs.CBMPictureBox avatarPictureBox;
    private System.Windows.Forms.ErrorProvider errorProvider;
  }
}