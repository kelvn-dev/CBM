using CBM.Presenters;
using CBM.Views;
using System;
using System.Windows.Forms;

namespace CBM {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //AdministratorView view = new AdministratorView();
      //AdministratorPresenter presenter = new AdministratorPresenter(view);

      Application.Run(new CommonView());
    }
  }
}
