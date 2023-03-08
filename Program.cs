using CBM.Presenters;
using CBM.Views;
using CBM.Models;
using System;
using System.Windows.Forms;
using CBM.Models;

namespace CBM {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //AdministratorView<Administrator> view = new AdministratorView<Administrator>();
      //AdministratorPresenter presenter = new AdministratorPresenter(view);

      Application.Run(new CommonView());
    }
  }
}
