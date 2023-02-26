namespace CBM.Views {
  partial class AdministratorView {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tabControl = new MetroFramework.Controls.MetroTabControl();
      this.listingTab = new MetroFramework.Controls.MetroTabPage();
      this.pageLabel = new MetroFramework.Controls.MetroLabel();
      this.nextPageBtn = new MetroFramework.Controls.MetroButton();
      this.prePageBtn = new MetroFramework.Controls.MetroButton();
      this.metroButton1 = new MetroFramework.Controls.MetroButton();
      this.updateBtn = new MetroFramework.Controls.MetroButton();
      this.deleteBtn = new MetroFramework.Controls.MetroButton();
      this.createBtn = new MetroFramework.Controls.MetroButton();
      this.administratorList = new MetroFramework.Controls.MetroGrid();
      this.detailTab = new MetroFramework.Controls.MetroTabPage();
      this.ageTxt = new System.Windows.Forms.NumericUpDown();
      this.ageLabel = new MetroFramework.Controls.MetroLabel();
      this.nameLabel = new MetroFramework.Controls.MetroLabel();
      this.nameTxt = new MetroFramework.Controls.MetroTextBox();
      this.cancelBtn = new MetroFramework.Controls.MetroButton();
      this.saveBtn = new MetroFramework.Controls.MetroButton();
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.administratorList)).BeginInit();
      this.detailTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.listingTab);
      this.tabControl.Controls.Add(this.detailTab);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(20, 60);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1195, 649);
      this.tabControl.TabIndex = 0;
      this.tabControl.UseSelectable = true;
      // 
      // listingTab
      // 
      this.listingTab.Controls.Add(this.pageLabel);
      this.listingTab.Controls.Add(this.nextPageBtn);
      this.listingTab.Controls.Add(this.prePageBtn);
      this.listingTab.Controls.Add(this.metroButton1);
      this.listingTab.Controls.Add(this.updateBtn);
      this.listingTab.Controls.Add(this.deleteBtn);
      this.listingTab.Controls.Add(this.createBtn);
      this.listingTab.Controls.Add(this.administratorList);
      this.listingTab.HorizontalScrollbarBarColor = true;
      this.listingTab.HorizontalScrollbarHighlightOnWheel = false;
      this.listingTab.HorizontalScrollbarSize = 10;
      this.listingTab.Location = new System.Drawing.Point(8, 41);
      this.listingTab.Name = "listingTab";
      this.listingTab.Size = new System.Drawing.Size(1179, 600);
      this.listingTab.TabIndex = 0;
      this.listingTab.Text = "metroTabPage1";
      this.listingTab.VerticalScrollbarBarColor = true;
      this.listingTab.VerticalScrollbarHighlightOnWheel = false;
      this.listingTab.VerticalScrollbarSize = 10;
      // 
      // pageLabel
      // 
      this.pageLabel.AutoSize = true;
      this.pageLabel.Location = new System.Drawing.Point(547, 532);
      this.pageLabel.Name = "pageLabel";
      this.pageLabel.Size = new System.Drawing.Size(43, 19);
      this.pageLabel.TabIndex = 9;
      this.pageLabel.Text = "TEMP";
      // 
      // nextPageBtn
      // 
      this.nextPageBtn.Location = new System.Drawing.Point(644, 528);
      this.nextPageBtn.Name = "nextPageBtn";
      this.nextPageBtn.Size = new System.Drawing.Size(75, 23);
      this.nextPageBtn.TabIndex = 8;
      this.nextPageBtn.Text = ">";
      this.nextPageBtn.UseSelectable = true;
      // 
      // prePageBtn
      // 
      this.prePageBtn.Location = new System.Drawing.Point(427, 528);
      this.prePageBtn.Name = "prePageBtn";
      this.prePageBtn.Size = new System.Drawing.Size(75, 23);
      this.prePageBtn.TabIndex = 7;
      this.prePageBtn.Text = "<";
      this.prePageBtn.UseSelectable = true;
      // 
      // metroButton1
      // 
      this.metroButton1.Location = new System.Drawing.Point(8, 109);
      this.metroButton1.Name = "metroButton1";
      this.metroButton1.Size = new System.Drawing.Size(75, 23);
      this.metroButton1.TabIndex = 6;
      this.metroButton1.Text = "metroButton1";
      this.metroButton1.UseSelectable = true;
      // 
      // updateBtn
      // 
      this.updateBtn.Location = new System.Drawing.Point(786, 25);
      this.updateBtn.Name = "updateBtn";
      this.updateBtn.Size = new System.Drawing.Size(184, 55);
      this.updateBtn.TabIndex = 5;
      this.updateBtn.Text = "Update";
      this.updateBtn.UseSelectable = true;
      // 
      // deleteBtn
      // 
      this.deleteBtn.Location = new System.Drawing.Point(995, 25);
      this.deleteBtn.Name = "deleteBtn";
      this.deleteBtn.Size = new System.Drawing.Size(184, 55);
      this.deleteBtn.TabIndex = 4;
      this.deleteBtn.Text = "Delete";
      this.deleteBtn.UseSelectable = true;
      // 
      // createBtn
      // 
      this.createBtn.Location = new System.Drawing.Point(576, 25);
      this.createBtn.Name = "createBtn";
      this.createBtn.Size = new System.Drawing.Size(184, 55);
      this.createBtn.TabIndex = 3;
      this.createBtn.Text = "Create";
      this.createBtn.UseSelectable = true;
      // 
      // administratorList
      // 
      this.administratorList.AllowUserToResizeRows = false;
      this.administratorList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.administratorList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.administratorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.administratorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.administratorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.administratorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.administratorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.administratorList.DefaultCellStyle = dataGridViewCellStyle8;
      this.administratorList.EnableHeadersVisualStyles = false;
      this.administratorList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.administratorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.administratorList.Location = new System.Drawing.Point(0, 101);
      this.administratorList.Name = "administratorList";
      this.administratorList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.administratorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.administratorList.RowHeadersWidth = 82;
      this.administratorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.administratorList.RowTemplate.Height = 33;
      this.administratorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.administratorList.Size = new System.Drawing.Size(1179, 411);
      this.administratorList.TabIndex = 2;
      // 
      // detailTab
      // 
      this.detailTab.Controls.Add(this.ageTxt);
      this.detailTab.Controls.Add(this.ageLabel);
      this.detailTab.Controls.Add(this.nameLabel);
      this.detailTab.Controls.Add(this.nameTxt);
      this.detailTab.Controls.Add(this.cancelBtn);
      this.detailTab.Controls.Add(this.saveBtn);
      this.detailTab.HorizontalScrollbarBarColor = true;
      this.detailTab.HorizontalScrollbarHighlightOnWheel = false;
      this.detailTab.HorizontalScrollbarSize = 10;
      this.detailTab.Location = new System.Drawing.Point(8, 41);
      this.detailTab.Name = "detailTab";
      this.detailTab.Size = new System.Drawing.Size(1179, 600);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "metroTabPage2";
      this.detailTab.VerticalScrollbarBarColor = true;
      this.detailTab.VerticalScrollbarHighlightOnWheel = false;
      this.detailTab.VerticalScrollbarSize = 10;
      // 
      // ageTxt
      // 
      this.ageTxt.Location = new System.Drawing.Point(93, 193);
      this.ageTxt.Name = "ageTxt";
      this.ageTxt.Size = new System.Drawing.Size(158, 31);
      this.ageTxt.TabIndex = 8;
      // 
      // ageLabel
      // 
      this.ageLabel.AutoSize = true;
      this.ageLabel.Location = new System.Drawing.Point(82, 162);
      this.ageLabel.Name = "ageLabel";
      this.ageLabel.Size = new System.Drawing.Size(33, 19);
      this.ageLabel.TabIndex = 7;
      this.ageLabel.Text = "Age";
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(82, 68);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(45, 19);
      this.nameLabel.TabIndex = 6;
      this.nameLabel.Text = "Name";
      // 
      // nameTxt
      // 
      // 
      // 
      // 
      this.nameTxt.CustomButton.Image = null;
      this.nameTxt.CustomButton.Location = new System.Drawing.Point(251, 1);
      this.nameTxt.CustomButton.Name = "";
      this.nameTxt.CustomButton.Size = new System.Drawing.Size(43, 43);
      this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.nameTxt.CustomButton.TabIndex = 1;
      this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.nameTxt.CustomButton.UseSelectable = true;
      this.nameTxt.CustomButton.Visible = false;
      this.nameTxt.Lines = new string[0];
      this.nameTxt.Location = new System.Drawing.Point(82, 90);
      this.nameTxt.MaxLength = 32767;
      this.nameTxt.Name = "nameTxt";
      this.nameTxt.PasswordChar = '\0';
      this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.nameTxt.SelectedText = "";
      this.nameTxt.SelectionLength = 0;
      this.nameTxt.SelectionStart = 0;
      this.nameTxt.ShortcutsEnabled = true;
      this.nameTxt.Size = new System.Drawing.Size(295, 45);
      this.nameTxt.TabIndex = 4;
      this.nameTxt.UseSelectable = true;
      this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // cancelBtn
      // 
      this.cancelBtn.Location = new System.Drawing.Point(246, 334);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(131, 59);
      this.cancelBtn.TabIndex = 3;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseSelectable = true;
      // 
      // saveBtn
      // 
      this.saveBtn.Location = new System.Drawing.Point(82, 334);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(131, 59);
      this.saveBtn.TabIndex = 2;
      this.saveBtn.Text = "Save";
      this.saveBtn.UseSelectable = true;
      // 
      // AdministratorView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1235, 729);
      this.Controls.Add(this.tabControl);
      this.Name = "AdministratorView";
      this.Text = "form";
      this.tabControl.ResumeLayout(false);
      this.listingTab.ResumeLayout(false);
      this.listingTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.administratorList)).EndInit();
      this.detailTab.ResumeLayout(false);
      this.detailTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTabControl tabControl;
    private MetroFramework.Controls.MetroTabPage listingTab;
    private MetroFramework.Controls.MetroTabPage detailTab;
    private MetroFramework.Controls.MetroGrid administratorList;
    private MetroFramework.Controls.MetroLabel ageLabel;
    private MetroFramework.Controls.MetroLabel nameLabel;
    private MetroFramework.Controls.MetroTextBox nameTxt;
    private MetroFramework.Controls.MetroButton cancelBtn;
    private MetroFramework.Controls.MetroButton saveBtn;
    private MetroFramework.Controls.MetroButton updateBtn;
    private MetroFramework.Controls.MetroButton deleteBtn;
    private MetroFramework.Controls.MetroButton createBtn;
    private System.Windows.Forms.NumericUpDown ageTxt;
    private MetroFramework.Controls.MetroButton nextPageBtn;
    private MetroFramework.Controls.MetroButton prePageBtn;
    private MetroFramework.Controls.MetroButton metroButton1;
    private MetroFramework.Controls.MetroLabel pageLabel;
  }
}