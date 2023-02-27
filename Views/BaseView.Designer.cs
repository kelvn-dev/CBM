using CBM.Models;

namespace CBM.Views {
  public partial class BaseView<T> where T : BaseModel {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tabControl = new MetroFramework.Controls.MetroTabControl();
      this.listingTab = new MetroFramework.Controls.MetroTabPage();
      this.searchBtn = new MetroFramework.Controls.MetroButton();
      this.searchTxt = new MetroFramework.Controls.MetroTextBox();
      this.metroButton1 = new MetroFramework.Controls.MetroButton();
      this.updateBtn = new MetroFramework.Controls.MetroButton();
      this.deleteBtn = new MetroFramework.Controls.MetroButton();
      this.createBtn = new MetroFramework.Controls.MetroButton();
      this.administratorList = new MetroFramework.Controls.MetroGrid();
      this.pageLabel = new MetroFramework.Controls.MetroLabel();
      this.nextPageBtn = new MetroFramework.Controls.MetroButton();
      this.prePageBtn = new MetroFramework.Controls.MetroButton();
      this.detailTab = new MetroFramework.Controls.MetroTabPage();
      this.saveBtn = new MetroFramework.Controls.MetroButton();
      this.cancelBtn = new MetroFramework.Controls.MetroButton();
      this.nameTxt = new MetroFramework.Controls.MetroTextBox();
      this.ageTxt = new System.Windows.Forms.NumericUpDown();
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
      this.tabControl.Location = new System.Drawing.Point(10, 60);
      this.tabControl.Margin = new System.Windows.Forms.Padding(2);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 1;
      this.tabControl.Size = new System.Drawing.Size(598, 309);
      this.tabControl.TabIndex = 0;
      this.tabControl.UseSelectable = true;
      // 
      // listingTab
      // 
      this.listingTab.Controls.Add(this.searchBtn);
      this.listingTab.Controls.Add(this.searchTxt);
      this.listingTab.Controls.Add(this.metroButton1);
      this.listingTab.Controls.Add(this.updateBtn);
      this.listingTab.Controls.Add(this.deleteBtn);
      this.listingTab.Controls.Add(this.createBtn);
      this.listingTab.Controls.Add(this.administratorList);
      this.listingTab.Controls.Add(this.pageLabel);
      this.listingTab.Controls.Add(this.nextPageBtn);
      this.listingTab.Controls.Add(this.prePageBtn);
      this.listingTab.HorizontalScrollbarBarColor = true;
      this.listingTab.HorizontalScrollbarHighlightOnWheel = false;
      this.listingTab.HorizontalScrollbarSize = 5;
      this.listingTab.Location = new System.Drawing.Point(4, 38);
      this.listingTab.Margin = new System.Windows.Forms.Padding(2);
      this.listingTab.Name = "listingTab";
      this.listingTab.Size = new System.Drawing.Size(590, 267);
      this.listingTab.TabIndex = 0;
      this.listingTab.Text = "metroTabPage1";
      this.listingTab.VerticalScrollbarBarColor = true;
      this.listingTab.VerticalScrollbarHighlightOnWheel = false;
      this.listingTab.VerticalScrollbarSize = 5;
      // 
      // searchBtn
      // 
      this.searchBtn.Location = new System.Drawing.Point(177, 13);
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.Size = new System.Drawing.Size(75, 23);
      this.searchBtn.TabIndex = 25;
      this.searchBtn.Text = "Search";
      this.searchBtn.UseSelectable = true;
      // 
      // searchTxt
      // 
      // 
      // 
      // 
      this.searchTxt.CustomButton.Image = null;
      this.searchTxt.CustomButton.Location = new System.Drawing.Point(162, 1);
      this.searchTxt.CustomButton.Name = "";
      this.searchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.searchTxt.CustomButton.TabIndex = 1;
      this.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.searchTxt.CustomButton.UseSelectable = true;
      this.searchTxt.CustomButton.Visible = false;
      this.searchTxt.Lines = new string[0];
      this.searchTxt.Location = new System.Drawing.Point(4, 13);
      this.searchTxt.MaxLength = 32767;
      this.searchTxt.Name = "searchTxt";
      this.searchTxt.PasswordChar = '\0';
      this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.searchTxt.SelectedText = "";
      this.searchTxt.SelectionLength = 0;
      this.searchTxt.SelectionStart = 0;
      this.searchTxt.ShortcutsEnabled = true;
      this.searchTxt.Size = new System.Drawing.Size(184, 23);
      this.searchTxt.TabIndex = 24;
      this.searchTxt.UseSelectable = true;
      this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroButton1
      // 
      this.metroButton1.Location = new System.Drawing.Point(4, 57);
      this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
      this.metroButton1.Name = "metroButton1";
      this.metroButton1.Size = new System.Drawing.Size(38, 12);
      this.metroButton1.TabIndex = 23;
      this.metroButton1.Text = "metroButton1";
      this.metroButton1.UseSelectable = true;
      // 
      // updateBtn
      // 
      this.updateBtn.Location = new System.Drawing.Point(393, 13);
      this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
      this.updateBtn.Name = "updateBtn";
      this.updateBtn.Size = new System.Drawing.Size(92, 29);
      this.updateBtn.TabIndex = 22;
      this.updateBtn.Text = "Update";
      this.updateBtn.UseSelectable = true;
      // 
      // deleteBtn
      // 
      this.deleteBtn.Location = new System.Drawing.Point(498, 13);
      this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
      this.deleteBtn.Name = "deleteBtn";
      this.deleteBtn.Size = new System.Drawing.Size(92, 29);
      this.deleteBtn.TabIndex = 21;
      this.deleteBtn.Text = "Delete";
      this.deleteBtn.UseSelectable = true;
      // 
      // createBtn
      // 
      this.createBtn.Location = new System.Drawing.Point(288, 13);
      this.createBtn.Margin = new System.Windows.Forms.Padding(2);
      this.createBtn.Name = "createBtn";
      this.createBtn.Size = new System.Drawing.Size(92, 29);
      this.createBtn.TabIndex = 20;
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
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.administratorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.administratorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.administratorList.DefaultCellStyle = dataGridViewCellStyle2;
      this.administratorList.EnableHeadersVisualStyles = false;
      this.administratorList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.administratorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.administratorList.Location = new System.Drawing.Point(0, 46);
      this.administratorList.Margin = new System.Windows.Forms.Padding(2);
      this.administratorList.Name = "administratorList";
      this.administratorList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.administratorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.administratorList.RowHeadersWidth = 82;
      this.administratorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.administratorList.RowTemplate.Height = 33;
      this.administratorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.administratorList.Size = new System.Drawing.Size(590, 207);
      this.administratorList.TabIndex = 19;
      // 
      // pageLabel
      // 
      this.pageLabel.AutoSize = true;
      this.pageLabel.Location = new System.Drawing.Point(274, 277);
      this.pageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.pageLabel.Name = "pageLabel";
      this.pageLabel.Size = new System.Drawing.Size(43, 19);
      this.pageLabel.TabIndex = 9;
      this.pageLabel.Text = "TEMP";
      // 
      // nextPageBtn
      // 
      this.nextPageBtn.Location = new System.Drawing.Point(322, 275);
      this.nextPageBtn.Margin = new System.Windows.Forms.Padding(2);
      this.nextPageBtn.Name = "nextPageBtn";
      this.nextPageBtn.Size = new System.Drawing.Size(38, 12);
      this.nextPageBtn.TabIndex = 8;
      this.nextPageBtn.Text = ">";
      this.nextPageBtn.UseSelectable = true;
      // 
      // prePageBtn
      // 
      this.prePageBtn.Location = new System.Drawing.Point(214, 275);
      this.prePageBtn.Margin = new System.Windows.Forms.Padding(2);
      this.prePageBtn.Name = "prePageBtn";
      this.prePageBtn.Size = new System.Drawing.Size(38, 12);
      this.prePageBtn.TabIndex = 7;
      this.prePageBtn.Text = "<";
      this.prePageBtn.UseSelectable = true;
      // 
      // detailTab
      // 
      this.detailTab.Controls.Add(this.ageTxt);
      this.detailTab.Controls.Add(this.nameTxt);
      this.detailTab.Controls.Add(this.cancelBtn);
      this.detailTab.Controls.Add(this.saveBtn);
      this.detailTab.HorizontalScrollbarBarColor = true;
      this.detailTab.HorizontalScrollbarHighlightOnWheel = false;
      this.detailTab.HorizontalScrollbarSize = 5;
      this.detailTab.Location = new System.Drawing.Point(4, 38);
      this.detailTab.Margin = new System.Windows.Forms.Padding(2);
      this.detailTab.Name = "detailTab";
      this.detailTab.Size = new System.Drawing.Size(590, 267);
      this.detailTab.TabIndex = 1;
      this.detailTab.Text = "metroTabPage2";
      this.detailTab.VerticalScrollbarBarColor = true;
      this.detailTab.VerticalScrollbarHighlightOnWheel = false;
      this.detailTab.VerticalScrollbarSize = 5;
      // 
      // saveBtn
      // 
      this.saveBtn.Location = new System.Drawing.Point(106, 164);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(75, 23);
      this.saveBtn.TabIndex = 2;
      this.saveBtn.Text = "Save";
      this.saveBtn.UseSelectable = true;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Location = new System.Drawing.Point(262, 164);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 23);
      this.cancelBtn.TabIndex = 3;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseSelectable = true;
      // 
      // nameTxt
      // 
      // 
      // 
      // 
      this.nameTxt.CustomButton.Image = null;
      this.nameTxt.CustomButton.Location = new System.Drawing.Point(130, 2);
      this.nameTxt.CustomButton.Name = "";
      this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.nameTxt.CustomButton.TabIndex = 1;
      this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.nameTxt.CustomButton.UseSelectable = true;
      this.nameTxt.CustomButton.Visible = false;
      this.nameTxt.Lines = new string[] {
        "metroTextBox1"};
      this.nameTxt.Location = new System.Drawing.Point(73, 35);
      this.nameTxt.MaxLength = 32767;
      this.nameTxt.Name = "nameTxt";
      this.nameTxt.PasswordChar = '\0';
      this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.nameTxt.SelectedText = "";
      this.nameTxt.SelectionLength = 0;
      this.nameTxt.SelectionStart = 0;
      this.nameTxt.ShortcutsEnabled = true;
      this.nameTxt.Size = new System.Drawing.Size(154, 26);
      this.nameTxt.TabIndex = 4;
      this.nameTxt.Text = "metroTextBox1";
      this.nameTxt.UseSelectable = true;
      this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // ageTxt
      // 
      this.ageTxt.Location = new System.Drawing.Point(73, 90);
      this.ageTxt.Name = "ageTxt";
      this.ageTxt.Size = new System.Drawing.Size(120, 20);
      this.ageTxt.TabIndex = 6;
      // 
      // BaseView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(618, 379);
      this.Controls.Add(this.tabControl);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "BaseView";
      this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
      this.Text = "form";
      this.tabControl.ResumeLayout(false);
      this.listingTab.ResumeLayout(false);
      this.listingTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.administratorList)).EndInit();
      this.detailTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    protected MetroFramework.Controls.MetroTabPage listingTab;
    protected MetroFramework.Controls.MetroTabControl tabControl;
    protected MetroFramework.Controls.MetroTabPage detailTab;
    protected MetroFramework.Controls.MetroButton nextPageBtn;
    protected MetroFramework.Controls.MetroButton prePageBtn;
    protected MetroFramework.Controls.MetroLabel pageLabel;
    protected MetroFramework.Controls.MetroButton searchBtn;
    protected MetroFramework.Controls.MetroTextBox searchTxt;
    protected MetroFramework.Controls.MetroButton metroButton1;
    protected MetroFramework.Controls.MetroButton updateBtn;
    protected MetroFramework.Controls.MetroButton deleteBtn;
    protected MetroFramework.Controls.MetroButton createBtn;
    protected MetroFramework.Controls.MetroGrid administratorList;
    private MetroFramework.Controls.MetroButton cancelBtn;
    private MetroFramework.Controls.MetroButton saveBtn;
    private MetroFramework.Controls.MetroTextBox nameTxt;
    private System.Windows.Forms.NumericUpDown ageTxt;
  }
}