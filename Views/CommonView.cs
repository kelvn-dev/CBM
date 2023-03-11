using CBM.Customs;
using CBM.Presenters;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class CommonView : Form {

    #region Css

    private void CssThis() {
      // Remove header
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);

      headerBar.BackColor = Color.White;
    }

    private void CssPanelSideBar() {
      panelSideBar.BackColor = Color.White;
    }
    private void CssPanelHeader() {
      panelHeader.BackColor = ColorTranslator.FromHtml(Constant.DARK_BLUE_COLOR);
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
    private void CssTab(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, Color.White, ColorTranslator.FromHtml(Constant.ICON_COLOR), Constant.NORMAL_ICON_SIZE);
      iconButton.ImageAlign = ContentAlignment.MiddleLeft;
      iconButton.TextAlign = ContentAlignment.MiddleLeft;
      iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
      iconButton.Padding = new Padding(left: 16, top: 0, right: 10, bottom: 0);
    }
    private void CssClickedTab(IconButton iconButton) {
      iconButton.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
      iconButton.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      iconButton.TextAlign = ContentAlignment.MiddleCenter;
      iconButton.IconColor = iconButton.ForeColor;
      iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      iconButton.ImageAlign = ContentAlignment.MiddleCenter;
    }
    private void CssSubTab(Panel panel) {
      panel.BackColor = this.BackColor;
      panel.ForeColor = ColorTranslator.FromHtml(Constant.ICON_COLOR);
      panel.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }
    private void CssSubTab(CBMButton button) {
      button.TextAlign = ContentAlignment.MiddleLeft;
      button.BackColor = this.BackColor;
      button.ForeColor = ColorTranslator.FromHtml(Constant.ICON_COLOR);
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
      button.Padding = new Padding(left: 16, top: 0, right: 10, bottom: 0);
    }
    private void CssClickedSubTab(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.BOLD_BG_COLOR);
      button.ForeColor = Color.Black;
      button.BorderSize = 6;
      button.BorderColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
      button.BorderRadius = 2;
    }
    private void CssLabelTitle(Label label) {
      label.ForeColor = ColorTranslator.FromHtml(Constant.BOLD_GRAY_COLOR);
      label.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }

    #endregion

    public CommonView() {
      InitializeComponent();
      CssThis();

      CssPanelSideBar();
      CssPanelHeader();
      CssPanelTitle();
      CssLabelTitle(labelTitle);
      CssLabelTitle(labelDetail);

      CssPanelShadow(panelShadow);
      CssPanelShadow(leftPanelShadow);

      CssPanelBg(panelBg);
      CssPanelBg(leftPanelBg);

      CssTitleIcon(iconTitle);

      CssHeaderIcon(iconButtonBell);
      CssHeaderIcon(iconButtonQuestion);
      CssHeaderIcon(iconButtonSearch);
      CssHeaderIcon(iconProfile);
      CssHeaderIcon(iconNotification);

      UserControlUtils.CssIconButton(closeBtn, Color.White, ColorTranslator.FromHtml(Constant.RED_COLOR));
      UserControlUtils.CssIconButton(restoreBtn, Color.White, ColorTranslator.FromHtml(Constant.YELLO_COLOR));
      UserControlUtils.CssIconButton(minBtn, Color.White, ColorTranslator.FromHtml(Constant.GREEN_COLOR));
      UserControlUtils.CssIconButton(iconTitle, Color.White, ColorTranslator.FromHtml(Constant.DARK_BLUE_COLOR), 50);

      CssTab(tabHome);
      CssTab(tabAdministrator);
      CssTab(tabCommonData);
      CssTab(tabAccountManagement);
      CssTab(tabUsedCar);
      CssTab(tabBidding);
      CssTab(tabCampaign);
      CssTab(tabBroadcast);
      CssTab(tabReportManagement);
      CssTab(tabSetting);

      CssSubTab(panelAdministrator);
      CssSubTab(panelCommonData);
      CssSubTab(panelAccountManagement);

      CssSubTab(tabUser);
      CssSubTab(tabGroup);
      CssSubTab(tabBrand);
      CssSubTab(tabModelVariant);
      CssSubTab(tabVehicleType);
      CssSubTab(tabFuelType);
      CssSubTab(tabCoe);
      CssSubTab(tabSubscriptionPlan);

      // Hide sub tabs
      hideAllSubTabs();

      AssociateEvents();
    }

    #region Common

    private void hideAllSubTabs() {
      panelAdministrator.Visible = false;
      panelCommonData.Visible = false;
      panelAccountManagement.Visible = false;
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

    private void ActivateSubtab(object senderTab) {
      if (senderTab != null) {
        DisableSubTab();
        currentSubTab = (CBMButton)senderTab;
        CssClickedSubTab(currentSubTab);
        labelTitle.Text = $"{currentTab.Text} / {currentSubTab.Text}";
      }
    }
    private void DisableSubTab() {
      if (this.currentSubTab != null) {
        CssSubTab(currentSubTab);
      }
    }

    private void ActivateTab(object senderTab) {
      if (senderTab != null) {
        DisableTab();
        //Button
        currentTab = (IconButton)senderTab;
        CssClickedTab(currentTab);
        //Current Child Form Icon
        iconTitle.IconChar = currentTab.IconChar;
        labelTitle.Text = currentTab.Text;
        labelDetail.Text = string.Empty;
      }
    }

    private void DisableTab() {
      if (currentTab != null) {
        CssTab(currentTab);
      }
    }

    #endregion

    #region Events

    private void AssociateEvents() {
      closeBtn.Click += CloseForm;
      restoreBtn.Click += RestoreForm;
      minBtn.Click += MinimizeForm;

      // Tabs
      tabHome.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabAdministrator.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelAdministrator);
      };
      tabCommonData.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelCommonData);
      };
      tabAccountManagement.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelAccountManagement);
      };
      tabUsedCar.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabBidding.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabCampaign.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabBroadcast.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabReportManagement.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabSetting.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };

      // Sub tabs
      tabUser.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Invite and manage all users of the Admin Portal";
        AdministratorForm form = new AdministratorForm();
        new AdministratorPresenter(form);
        OpenChildForm(form);
      };
      tabGroup.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all groups of the Admin Portal";
        OpenChildForm(new GroupForm());
      };
      tabBrand.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Brands of the Common Data";
      };
      tabModelVariant.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Models & Variants of the Common Data";
      };
      tabVehicleType.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Vehicle Type of the Common Data";
      };
      tabFuelType.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Fuel Type of the Common Data";
      };
      tabCoe.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Coe Category of the Common Data";
      };
      tabSubscriptionPlan.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Subscription Plan of the Common Data";
      };
      tabMember.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Members of CBM";
      };
      tabDealership.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = "Create and manage all Dealerships of CBM";
      };
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
    private void RestoreForm(object sender, EventArgs e) {
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

    #endregion

    #region Variables

    private IconButton currentTab;
    private CBMButton currentSubTab;
    private Form currentChildForm;

    #endregion
  }
}
