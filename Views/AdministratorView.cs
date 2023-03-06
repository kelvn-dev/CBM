using CBM.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CBM.Enum;

namespace CBM.Views {
  public partial class AdministratorView<T> : MetroForm where T: BaseModel{
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

    public void CssForm() {
      //this.Width = Constant.INNER_FORM_WIDTH;
      //this.Height = Constant.INNER_FORM_HEIGHT;
      this.Padding = new Padding(
          left: Constant.INNER_FORM_PADDING_LEFT,
          top: Constant.INNER_FORM_PADDING_TOP,
          right: Constant.INNER_FORM_PADDING_RIGHT,
          bottom: Constant.INNER_FORM_PADDING_BOTTOM
        );
      this.BackColor = Color.FromName(Constant.INNER_FORM_BACKGROUND);
    }

    public void CssSearch() {
      this.searchTxt.Width = Constant.SEARCH_TXT_WIDTH;
      this.searchTxt.Height = Constant.SEARCH_TXT_HEIGHT;
      this.searchTxt.Padding = new Padding(Constant.SEARCH_TXT_PADDING);
      this.searchTxt.BackColor = Color.FromName(Constant.SEARCH_TXT_BACKGROUND);
      //this.searchTxt.bor
    }

    public AdministratorView() {
      InitializeComponent();
      tabControl.TabPages.Remove(detailTab);
      tabControl.ItemSize = new Size(0, 1); // Hide header of tabcontrol
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

      searchBtn.Click += delegate {
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

      searchBtn.Click += delegate {
        DeleteEvent?.Invoke(this, EventArgs.Empty);
      };

      prePageBtn.Click += delegate {
        GetPrePageEvent?.Invoke(this, EventArgs.Empty);
      };
      nextPageBtn.Click += delegate {
        GetNextPageEvent?.Invoke(this, EventArgs.Empty);
      };

      deleteBtn.Click += delegate {
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
