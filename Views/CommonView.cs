using CBM.Customs;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class CommonView : Form {

    private IconButton currentTab;
    private Form currentChildForm;

    private void CssThis() {
      // Remove header
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.BackColor = ColorTranslator.FromHtml("#f5f7fa");
    }

    private void CssPanelSideBar() {
      panelSideBar.BackColor = Color.White;
    }
    private void CssPanelHeader() {
      panelHeader.BackColor = ColorTranslator.FromHtml("#001529");
      panelHeader.MouseDown += DragForm;
    }
    private void CssPanelTitle() {
      panelTitle.BackColor = Color.White;
    }
    private void CssPanelShadow(Panel panel) {
      panel.BackColor = ColorTranslator.FromHtml("#f0f2f5");
    }
    private void CssPanelBg(Panel panel) {
      panel.BackColor = this.BackColor;
    }
    private void CssHeaderIcon(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, panelHeader.BackColor, Color.White, Constant.NORMAL_ICON_SIZE);
    }
    private void CssTitleIcon(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, Color.White, ColorTranslator.FromHtml("#001529"), 50);
    }
    private void CssTabSideBar(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, Color.White, ColorTranslator.FromHtml(Constant.ICON_COLOR), Constant.NORMAL_ICON_SIZE);
      iconButton.ImageAlign = ContentAlignment.MiddleLeft;
      iconButton.TextAlign = ContentAlignment.MiddleLeft;
      iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
      iconButton.Padding = new Padding(left: 16, top: 0, right: 10, bottom: 0);
    }
    private void CssSubTab(Panel panel) {
      panel.BackColor = this.BackColor;
    }
    private void CssChildTab(CBMButton button) {
      button.BackColor = 
    }

    public CommonView() {
      InitializeComponent();
      CssThis();

      CssPanelSideBar();
      CssPanelHeader();
      CssPanelTitle();

      CssPanelShadow(panelShadow);
      CssPanelShadow(leftPanelShadow);

      CssPanelBg(panelBg);
      CssPanelBg(leftPanelBg);

      CssTitleIcon(iconTitle);

      CssHeaderIcon(iconButtonBell);
      CssHeaderIcon(iconButtonQuestion);
      CssHeaderIcon(iconButtonSearch);

      UserControlUtils.CssIconButton(closeBtn, panelHeader.BackColor, ColorTranslator.FromHtml(Constant.RED_COLOR));
      UserControlUtils.CssIconButton(maxBtn, panelHeader.BackColor, ColorTranslator.FromHtml(Constant.YELLO_COLOR));
      UserControlUtils.CssIconButton(minBtn, panelHeader.BackColor, ColorTranslator.FromHtml(Constant.GREEN_COLOR));

      CssTabSideBar(tabHome);
      CssTabSideBar(tabAdministrator);

      CssSubTab(panelAdministrator);

      // Hide sub tabs
      hideAllSubTabs();

      // Event
      closeBtn.Click += CloseForm;
      maxBtn.Click += MaximizeForm;
      minBtn.Click += MinimizeForm;

      tabHome.Click += delegate (object sender, EventArgs e) {
        ActivateButton(sender);
      };
      tabAdministrator.Click += delegate (object sender, EventArgs e) {
        ActivateButton(sender);
        showSubTab(panelAdministrator);
      };
      //tabAccountManagement.Click += delegate (object sender, EventArgs e) {
      //  ActivateButton(sender);
      //};
      //tabListingManagement.Click += delegate (object sender, EventArgs e) {
      //  ActivateButton(sender);
      //};
      //tabSettings.Click += delegate (object sender, EventArgs e) {
      //  ActivateButton(sender);
      //};
    }

    private void hideAllSubTabs() {
      panelAdministrator.Visible = false;
    }
    private void showSubTab(Panel subTab) {
      // Toggle sub tab
      if (subTab.Visible == false) {
        hideAllSubTabs();
        subTab.Visible = true;
      }
      else
        subTab.Visible = false;
    }

    private void ActivateButton(object senderTab) {
      if (senderTab != null) {
        DisableButton();
        //Button
        currentTab = (IconButton)senderTab;
        currentTab.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
        currentTab.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
        currentTab.TextAlign = ContentAlignment.MiddleCenter;
        currentTab.IconColor = currentTab.ForeColor;
        currentTab.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentTab.ImageAlign = ContentAlignment.MiddleRight;

        //Current Child Form Icon
        iconTitle.IconChar = currentTab.IconChar;
        labelTitle.Text = currentTab.Text;
      }
    }

    private void DisableButton() {
      if (currentTab != null) {
        currentTab.BackColor = Color.White;
        currentTab.TextAlign = ContentAlignment.MiddleLeft;
        currentTab.IconColor = ColorTranslator.FromHtml(Constant.ICON_COLOR);
        currentTab.ForeColor = currentTab.IconColor;
        currentTab.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentTab.ImageAlign = ContentAlignment.MiddleLeft;
      }
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void DragForm(object sender, MouseEventArgs e) {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void OpenChildForm(Form childForm) {
      //open only form
      if (currentChildForm != null) {
        currentChildForm.Close();
      }
      currentChildForm = childForm;
      //End
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      panelForm.Controls.Add(childForm);
      panelForm.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }
    
    private void CloseForm(object sender, EventArgs e) {
      this.Close();
    }
    private void MaximizeForm(object sender, EventArgs e) {
      if (WindowState == FormWindowState.Normal) {
        WindowState = FormWindowState.Maximized;
      }  
      else {
        WindowState = FormWindowState.Normal;
      }
    }
    private void MinimizeForm(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }
  }
}
