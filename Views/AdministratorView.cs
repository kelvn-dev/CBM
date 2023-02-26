using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using static CBM.Enum.Enum;

namespace CBM.Views {
  public partial class AdministratorView : MetroForm {

    public event EventHandler CreateEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler GetPrePageEvent;
    public event EventHandler GetNextPageEvent;
    
    private Guid _id;
    private bool _isUpdate;
    private bool _isSuccessful;
    private string _message;
    private int _currentPage;
    private int _totalPages;
    private string _orderBy;
    private OrderDirection _orderDirection;

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

    public Guid id {
      get => _id; 
      set => _id = value;
    }

    public string name {
      get => nameTxt.Text;
      set => nameTxt.Text = value;
    }

    public int age {
      get => (int) ageTxt.Value;
      set => ageTxt.Value = value;
    }

    public int currentPage {
      get => _currentPage; 
      set => _currentPage = value;
    }

    public int totalPages {
      get => _totalPages;
      set => _totalPages = value;
    }

    public string orderBy {
      get => _orderBy;
      set => _orderBy = value;
    }

    public OrderDirection orderDirection {
      get => _orderDirection;
      set => _orderDirection = value;
    }

    public AdministratorView() {
      InitializeComponent();
      tabControl.TabPages.Remove(detailTab);
      currentPage = 1;

      createBtn.Click += delegate {
        CreateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
      };

      updateBtn.Click += delegate {
        this.isUpdate = true;
        UpdateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
      };

      deleteBtn.Click += delegate {
        DeleteEvent?.Invoke(this, EventArgs.Empty);
      };

      saveBtn.Click += delegate {
        SaveEvent?.Invoke(this, EventArgs.Empty);
        if (isSuccessful) {
          SwitchToListingTab();
        }
        MessageBox.Show(message);
      };

      deleteBtn.Click += delegate {
        DeleteEvent?.Invoke(this, EventArgs.Empty);
      };

      prePageBtn.Click += delegate { 
        GetPrePageEvent?.Invoke(this, EventArgs.Empty);
      };
      nextPageBtn.Click += delegate { 
        GetNextPageEvent?.Invoke(this, EventArgs.Empty);
      };

      administratorList.ColumnHeaderMouseClick += delegate (object sender, DataGridViewCellMouseEventArgs e) {
        string clickedHeaderText = administratorList.Columns[e.ColumnIndex].HeaderText;
        if (clickedHeaderText != orderBy) {
          orderDirection = OrderDirection.ASC;
        }
        else {
          switch (orderDirection) {
            case OrderDirection.ASC:
              orderDirection = OrderDirection.DESC;
            break;
            case OrderDirection.DESC:
              orderDirection = OrderDirection.DESC;
            orderBy = "createdTime";
            break;
            default:
              orderDirection = OrderDirection.ASC;
            break;
          }
        }
      };
    }

    public Button GetPrePageBtn() {
      return prePageBtn;
    }

    public Button GetNextPageBtn() {
      return nextPageBtn;
    }

    public Label GetPageLabel() {
      return pageLabel;
    }

    public void MapDataSource(BindingSource bindingSource) {
      administratorList.DataSource = bindingSource;
    }

    public void TEST() {
      foreach (DataGridViewColumn i in administratorList.Columns) {
        Console.WriteLine(i.HeaderText);
      }
    }

    private void SwitchToListingTab() {
      tabControl.TabPages.Remove(detailTab);
      tabControl.TabPages.Add(listingTab);
    }

    private void SwitchToDetailTab() {
      tabControl.TabPages.Remove(listingTab);
      tabControl.TabPages.Add(detailTab);
    }
  }
}
