using CBM.Models;

namespace CBM.Views {
  partial class AdministratorView<T> where T: BaseModel {
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
      this.tabControl = new MetroFramework.Controls.MetroTabControl();
      this.listingTab = new MetroFramework.Controls.MetroTabPage();
      this.midPanel = new MetroFramework.Controls.MetroPanel();
      this.administratorList = new System.Windows.Forms.DataGridView();
      this.bottomPanel = new MetroFramework.Controls.MetroPanel();
      this.prePageBtn = new MetroFramework.Controls.MetroButton();
      this.pageLabel = new MetroFramework.Controls.MetroLabel();
      this.nextPageBtn = new MetroFramework.Controls.MetroButton();
      this.topPanel = new MetroFramework.Controls.MetroPanel();
      this.updateBtn = new MetroFramework.Controls.MetroButton();
      this.createBtn = new MetroFramework.Controls.MetroButton();
      this.deleteBtn = new MetroFramework.Controls.MetroButton();
      this.searchTxt = new MetroFramework.Controls.MetroTextBox();
      this.searchBtn = new MetroFramework.Controls.MetroButton();
      this.detailTab = new MetroFramework.Controls.MetroTabPage();
      this.cancelBtn = new MetroFramework.Controls.MetroButton();
      this.saveBtn = new MetroFramework.Controls.MetroButton();
      this.ageTxt = new System.Windows.Forms.NumericUpDown();
      this.nameTxt = new MetroFramework.Controls.MetroTextBox();
      this.searchTextBox1 = new CBM.Customs.SearchTextBox();
      this.tabControl.SuspendLayout();
      this.listingTab.SuspendLayout();
      this.midPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.administratorList)).BeginInit();
      this.bottomPanel.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.detailTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.tabControl.Controls.Add(this.listingTab);
      this.tabControl.Controls.Add(this.detailTab);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(20, 60);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1303, 786);
      this.tabControl.Style = MetroFramework.MetroColorStyle.White;
      this.tabControl.TabIndex = 0;
      this.tabControl.UseSelectable = true;
      // 
      // listingTab
      // 
      this.listingTab.Controls.Add(this.midPanel);
      this.listingTab.Controls.Add(this.bottomPanel);
      this.listingTab.Controls.Add(this.topPanel);
      this.listingTab.HorizontalScrollbarBarColor = true;
      this.listingTab.HorizontalScrollbarHighlightOnWheel = false;
      this.listingTab.HorizontalScrollbarSize = 10;
      this.listingTab.Location = new System.Drawing.Point(4, 41);
      this.listingTab.Name = "listingTab";
      this.listingTab.Size = new System.Drawing.Size(1295, 741);
      this.listingTab.TabIndex = 0;
      this.listingTab.Text = "metroTabPage1";
      this.listingTab.VerticalScrollbarBarColor = true;
      this.listingTab.VerticalScrollbarHighlightOnWheel = false;
      this.listingTab.VerticalScrollbarSize = 10;
      // 
      // midPanel
      // 
      this.midPanel.Controls.Add(this.administratorList);
      this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.midPanel.HorizontalScrollbarBarColor = true;
      this.midPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.midPanel.HorizontalScrollbarSize = 10;
      this.midPanel.Location = new System.Drawing.Point(0, 92);
      this.midPanel.Name = "midPanel";
      this.midPanel.Size = new System.Drawing.Size(1295, 580);
      this.midPanel.TabIndex = 13;
      this.midPanel.VerticalScrollbarBarColor = true;
      this.midPanel.VerticalScrollbarHighlightOnWheel = false;
      this.midPanel.VerticalScrollbarSize = 10;
      // 
      // administratorList
      // 
      this.administratorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.administratorList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.administratorList.Location = new System.Drawing.Point(0, 0);
      this.administratorList.Name = "administratorList";
      this.administratorList.RowHeadersWidth = 82;
      this.administratorList.RowTemplate.Height = 33;
      this.administratorList.Size = new System.Drawing.Size(1295, 580);
      this.administratorList.TabIndex = 2;
      // 
      // bottomPanel
      // 
      this.bottomPanel.Controls.Add(this.prePageBtn);
      this.bottomPanel.Controls.Add(this.pageLabel);
      this.bottomPanel.Controls.Add(this.nextPageBtn);
      this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.bottomPanel.HorizontalScrollbarBarColor = true;
      this.bottomPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.bottomPanel.HorizontalScrollbarSize = 10;
      this.bottomPanel.Location = new System.Drawing.Point(0, 672);
      this.bottomPanel.Name = "bottomPanel";
      this.bottomPanel.Size = new System.Drawing.Size(1295, 69);
      this.bottomPanel.TabIndex = 12;
      this.bottomPanel.VerticalScrollbarBarColor = true;
      this.bottomPanel.VerticalScrollbarHighlightOnWheel = false;
      this.bottomPanel.VerticalScrollbarSize = 10;
      // 
      // prePageBtn
      // 
      this.prePageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.prePageBtn.Location = new System.Drawing.Point(462, 0);
      this.prePageBtn.Name = "prePageBtn";
      this.prePageBtn.Size = new System.Drawing.Size(116, 69);
      this.prePageBtn.TabIndex = 8;
      this.prePageBtn.Text = "Pre page";
      this.prePageBtn.UseSelectable = true;
      // 
      // pageLabel
      // 
      this.pageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pageLabel.AutoSize = true;
      this.pageLabel.Location = new System.Drawing.Point(634, 28);
      this.pageLabel.Name = "pageLabel";
      this.pageLabel.Size = new System.Drawing.Size(36, 19);
      this.pageLabel.TabIndex = 10;
      this.pageLabel.Text = "0 / 0";
      // 
      // nextPageBtn
      // 
      this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.nextPageBtn.Location = new System.Drawing.Point(727, 0);
      this.nextPageBtn.Name = "nextPageBtn";
      this.nextPageBtn.Size = new System.Drawing.Size(116, 69);
      this.nextPageBtn.TabIndex = 9;
      this.nextPageBtn.Text = "Next page";
      this.nextPageBtn.UseSelectable = true;
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.searchTextBox1);
      this.topPanel.Controls.Add(this.updateBtn);
      this.topPanel.Controls.Add(this.createBtn);
      this.topPanel.Controls.Add(this.deleteBtn);
      this.topPanel.Controls.Add(this.searchTxt);
      this.topPanel.Controls.Add(this.searchBtn);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.HorizontalScrollbarBarColor = true;
      this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.topPanel.HorizontalScrollbarSize = 10;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Padding = new System.Windows.Forms.Padding(10);
      this.topPanel.Size = new System.Drawing.Size(1295, 92);
      this.topPanel.TabIndex = 11;
      this.topPanel.VerticalScrollbarBarColor = true;
      this.topPanel.VerticalScrollbarHighlightOnWheel = false;
      this.topPanel.VerticalScrollbarSize = 10;
      // 
      // updateBtn
      // 
      this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.updateBtn.Location = new System.Drawing.Point(1012, 10);
      this.updateBtn.Name = "updateBtn";
      this.updateBtn.Size = new System.Drawing.Size(116, 60);
      this.updateBtn.TabIndex = 5;
      this.updateBtn.Text = "Update";
      this.updateBtn.UseSelectable = true;
      // 
      // createBtn
      // 
      this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.createBtn.Location = new System.Drawing.Point(851, 10);
      this.createBtn.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
      this.createBtn.Name = "createBtn";
      this.createBtn.Size = new System.Drawing.Size(116, 60);
      this.createBtn.TabIndex = 4;
      this.createBtn.Text = "Create";
      this.createBtn.UseSelectable = true;
      // 
      // deleteBtn
      // 
      this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteBtn.Location = new System.Drawing.Point(1169, 10);
      this.deleteBtn.Name = "deleteBtn";
      this.deleteBtn.Size = new System.Drawing.Size(116, 60);
      this.deleteBtn.TabIndex = 3;
      this.deleteBtn.Text = "Delete";
      this.deleteBtn.UseSelectable = true;
      // 
      // searchTxt
      // 
      // 
      // 
      // 
      this.searchTxt.CustomButton.Image = null;
      this.searchTxt.CustomButton.Location = new System.Drawing.Point(185, 2);
      this.searchTxt.CustomButton.Name = "";
      this.searchTxt.CustomButton.Size = new System.Drawing.Size(67, 67);
      this.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.searchTxt.CustomButton.TabIndex = 1;
      this.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.searchTxt.CustomButton.UseSelectable = true;
      this.searchTxt.CustomButton.Visible = false;
      this.searchTxt.Dock = System.Windows.Forms.DockStyle.Left;
      this.searchTxt.Lines = new string[] {
        "metroTextBox1"};
      this.searchTxt.Location = new System.Drawing.Point(126, 10);
      this.searchTxt.MaxLength = 32767;
      this.searchTxt.Name = "searchTxt";
      this.searchTxt.PasswordChar = '\0';
      this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.searchTxt.SelectedText = "";
      this.searchTxt.SelectionLength = 0;
      this.searchTxt.SelectionStart = 0;
      this.searchTxt.ShortcutsEnabled = true;
      this.searchTxt.Size = new System.Drawing.Size(255, 72);
      this.searchTxt.TabIndex = 2;
      this.searchTxt.Text = "metroTextBox1";
      this.searchTxt.UseSelectable = true;
      this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // searchBtn
      // 
      this.searchBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.searchBtn.Location = new System.Drawing.Point(10, 10);
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.Size = new System.Drawing.Size(116, 72);
      this.searchBtn.TabIndex = 6;
      this.searchBtn.Text = "Search";
      this.searchBtn.UseSelectable = true;
      // 
      // detailTab
      // 
      this.detailTab.Controls.Add(this.cancelBtn);
      this.detailTab.Controls.Add(this.saveBtn);
      this.detailTab.Controls.Add(this.ageTxt);
      this.detailTab.Controls.Add(this.nameTxt);
      this.detailTab.HorizontalScrollbarBarColor = true;
      this.detailTab.HorizontalScrollbarHighlightOnWheel = false;
      this.detailTab.HorizontalScrollbarSize = 10;
      this.detailTab.Location = new System.Drawing.Point(4, 41);
      this.detailTab.Name = "detailTab";
      this.detailTab.Size = new System.Drawing.Size(1295, 741);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "metroTabPage2";
      this.detailTab.VerticalScrollbarBarColor = true;
      this.detailTab.VerticalScrollbarHighlightOnWheel = false;
      this.detailTab.VerticalScrollbarSize = 10;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Location = new System.Drawing.Point(443, 534);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(175, 68);
      this.cancelBtn.TabIndex = 5;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseSelectable = true;
      // 
      // saveBtn
      // 
      this.saveBtn.Location = new System.Drawing.Point(155, 534);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(175, 68);
      this.saveBtn.TabIndex = 4;
      this.saveBtn.Text = "Save";
      this.saveBtn.UseSelectable = true;
      // 
      // ageTxt
      // 
      this.ageTxt.Location = new System.Drawing.Point(218, 319);
      this.ageTxt.Name = "ageTxt";
      this.ageTxt.Size = new System.Drawing.Size(241, 31);
      this.ageTxt.TabIndex = 3;
      // 
      // nameTxt
      // 
      // 
      // 
      // 
      this.nameTxt.CustomButton.Image = null;
      this.nameTxt.CustomButton.Location = new System.Drawing.Point(175, 2);
      this.nameTxt.CustomButton.Name = "";
      this.nameTxt.CustomButton.Size = new System.Drawing.Size(65, 65);
      this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.nameTxt.CustomButton.TabIndex = 1;
      this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.nameTxt.CustomButton.UseSelectable = true;
      this.nameTxt.CustomButton.Visible = false;
      this.nameTxt.Lines = new string[] {
        "metroTextBox1"};
      this.nameTxt.Location = new System.Drawing.Point(168, 133);
      this.nameTxt.MaxLength = 32767;
      this.nameTxt.Name = "nameTxt";
      this.nameTxt.PasswordChar = '\0';
      this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.nameTxt.SelectedText = "";
      this.nameTxt.SelectionLength = 0;
      this.nameTxt.SelectionStart = 0;
      this.nameTxt.ShortcutsEnabled = true;
      this.nameTxt.Size = new System.Drawing.Size(243, 70);
      this.nameTxt.TabIndex = 2;
      this.nameTxt.Text = "metroTextBox1";
      this.nameTxt.UseSelectable = true;
      this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // AdministratorView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1343, 866);
      this.Controls.Add(this.tabControl);
      this.Name = "AdministratorView";
      this.Text = "AdministratorView";
      this.tabControl.ResumeLayout(false);
      this.listingTab.ResumeLayout(false);
      this.midPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.administratorList)).EndInit();
      this.bottomPanel.ResumeLayout(false);
      this.bottomPanel.PerformLayout();
      this.topPanel.ResumeLayout(false);
      this.detailTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTabControl tabControl;
    private MetroFramework.Controls.MetroTabPage listingTab;
    private MetroFramework.Controls.MetroButton nextPageBtn;
    private MetroFramework.Controls.MetroButton prePageBtn;
    private MetroFramework.Controls.MetroButton searchBtn;
    private MetroFramework.Controls.MetroButton updateBtn;
    private MetroFramework.Controls.MetroButton createBtn;
    private MetroFramework.Controls.MetroButton deleteBtn;
    private MetroFramework.Controls.MetroTextBox searchTxt;
    private MetroFramework.Controls.MetroTabPage detailTab;
    private MetroFramework.Controls.MetroButton cancelBtn;
    private MetroFramework.Controls.MetroButton saveBtn;
    private System.Windows.Forms.NumericUpDown ageTxt;
    private MetroFramework.Controls.MetroTextBox nameTxt;
    private MetroFramework.Controls.MetroLabel pageLabel;
    private MetroFramework.Controls.MetroPanel topPanel;
    private MetroFramework.Controls.MetroPanel midPanel;
    private System.Windows.Forms.DataGridView administratorList;
    private MetroFramework.Controls.MetroPanel bottomPanel;
    private Customs.SearchTextBox searchTextBox1;
  }
}