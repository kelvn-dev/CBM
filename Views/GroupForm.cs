using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class GroupForm : Form {

    private void CssInformationLabel() {

    }

    public GroupForm() {
      InitializeComponent();
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(nameLabel);
      UserControlUtils.CssFieldLabel(descriptionLabel);
      UserControlUtils.CssTextbox(nameTxt, "Enter group name");
      UserControlUtils.CssTextbox(descriptionTxt, "Enter group description");
    }
  }
}
