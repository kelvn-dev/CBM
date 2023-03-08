using CBM.Models;
using CBM.Services;
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
  public partial class Base : Form {
    public Base() {
      InitializeComponent();
    }

    private void Base_Load(object sender, EventArgs e) {
      List<Administrator> administratorList = AdminService.GetPaginatedData(
        pageIndex: 0,
        keyword: null,
        orderBy: "createdTime",
        orderDirection: Enum.OrderDirection.ASC
       );
      BindingSource bindingSource = new BindingSource();
      bindingSource.DataSource = administratorList;
      dataGridView1.DataSource = bindingSource;
      UserControlUtils.CssDatagridView(dataGridView1);
    }
  }
}
