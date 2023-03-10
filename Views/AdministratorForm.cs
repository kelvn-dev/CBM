using CBM.Models;
using CBM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class AdministratorForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
    }
    private void CssLabel() {
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(avatarLabel);
      UserControlUtils.CssFieldLabel(usernameLabel);
      UserControlUtils.CssFieldLabel(emailLabel);
      UserControlUtils.CssFieldLabel(phoneLabel);
      UserControlUtils.CssFieldLabel(addressLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(usernameField, "Enter your username");
      UserControlUtils.CssTextbox(emailField, "Enter your email");
      UserControlUtils.CssTextbox(phoneField, "Enter your phone number");
      UserControlUtils.CssTextbox(addressField, "Enter your address");
      UserControlUtils.CssTextbox(zipcodeField, "Zip Code");
    }
    private void CssIconPictureBox() {
      avatarPictureBox.Click += UploadAvatar;
      avatarPictureBox.IconColor = ColorTranslator.FromHtml("#183153");
      avatarPictureBox.ForeColor = ColorTranslator.FromHtml("#183153");
    }

    #endregion

    public AdministratorForm() {
      InitializeComponent();

      CssBtn();
      CssLabel();
      CssTextbox();
      CssIconPictureBox();

      AssociateEvents();
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = new Administrator();
      errorProvider.DataSource = bindingSource;
    }

    #region Common

    //private void SwitchToListingTab() {
    //  tabControl.TabPages.Remove(detailTab);
    //  tabControl.TabPages.Add(listingTab);
    //}

    //private void SwitchToDetailTab() {
    //  tabControl.TabPages.Remove(listingTab);
    //  tabControl.TabPages.Add(detailTab);
    //}

    #endregion

    #region Events

    private void AssociateEvents() {
      saveBtn.Click += delegate {
        SaveEvent?.Invoke(this, EventArgs.Empty);
        //SwitchToListingTab();
        MessageBox.Show(message);
      };

      cancelBtn.Click += delegate {
        UserControlUtils.CleanFields(this.Controls);
        //SwitchToListingTab();
      };
    }

    public event EventHandler CreateEvent;
    public event EventHandler SaveEvent;

    private void UploadAvatar(object sender, EventArgs e) {
      OpenFileDialog opnfd = new OpenFileDialog();
      opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
      if (opnfd.ShowDialog() == DialogResult.OK) {
        avatarPictureBox.Image = new Bitmap(opnfd.FileName);
      }
    }
    //private void

    #endregion

    #region Variables

    private bool _isUpdate;
    private bool _isSuccessful;
    private string _message;

    public bool isUpdate {
      get => _isUpdate;
      set => _isUpdate = value;
    }
    public bool isSuccessful {
      get => _isSuccessful;
      set => _isSuccessful = value;
    }
    public string message {
      get => _message;
      set => _message = value;
    }

    public string username {
      get => usernameField.Texts;
      set => usernameField.Texts = value;
    }
    public string email {
      get => emailField.Texts;
      set => emailField.Texts = value;
    }
    public string phone {
      get => phoneField.Texts;
      set => phoneField.Texts = value;
    }
    public string address {
      get => addressField.Texts;
      set => addressField.Texts = value;
    }
    public string zipcode {
      get => zipcodeField.Texts;
      set => zipcodeField.Texts = value;
    }

    #endregion
  }
}
