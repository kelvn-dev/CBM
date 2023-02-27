using CBM.Models;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using static CBM.Enum;

namespace CBM.Views {
  public partial class BaseView<T> : Form where T : BaseModel {

    public event EventHandler CreateEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler GetPrePageEvent;
    public event EventHandler GetNextPageEvent;
    public event EventHandler SortEvent;
    public event EventHandler SearchEvent;
    public event EventHandler CancelEvent;
    
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
      get => (int)ageTxt.Value;
      set => ageTxt.Value = value;
    }

    public string keyword {
      get => searchTxt.Text;
      set => searchTxt.Text = value;
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

    public BaseView() {
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

      cancelBtn.Click += delegate {
        SwitchToListingTab();
        CancelEvent?.Invoke(this, EventArgs.Empty);
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

      searchBtn.Click += delegate {
        SearchEvent?.Invoke(this, EventArgs.Empty);
      };
      searchTxt.LostFocus += delegate {
        if (string.IsNullOrEmpty(searchTxt.Text)) {
          searchTxt.Text = Constant.PLACEHOLDER_SEARCH_TXT;
          SearchEvent?.Invoke(this, EventArgs.Empty);
        }
      };
      searchTxt.GotFocus += delegate {
        searchTxt.Text = string.Empty;
      };
      searchTxt.Text = Constant.PLACEHOLDER_SEARCH_TXT;

      administratorList.ColumnHeaderMouseClick += delegate (object sender, DataGridViewCellMouseEventArgs e) {
        string clickedHeaderText = administratorList.Columns[e.ColumnIndex].HeaderText;
        if (clickedHeaderText != orderBy) {
          orderBy = clickedHeaderText;
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
        SortEvent?.Invoke(this, EventArgs.Empty);
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
