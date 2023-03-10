using CBM.Models;
using CBM.Services;
using CBM.Utilities;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class AdministratorPresenter {

    private AdministratorForm view;
    //private BindingSource bindingSource;

    public AdministratorPresenter(AdministratorForm view) {
      this.view = view;
      //this.bindingSource = new BindingSource();

      //LoadListingData();
      //this.view.MapDataSource(bindingSource);
      //this.view.Show();

      this.view.CreateEvent += delegate (object sender, EventArgs e) { this.view.isUpdate = false; };
      this.view.SaveEvent += Save;
      //this.view.UpdateEvent += LoadSelectedData;
      //this.view.DeleteEvent += DeleteSelectedData;
      //this.view.GetPrePageEvent += LoadPrePageData;
      //this.view.GetNextPageEvent += LoadNextPageData;
      //this.view.SortEvent += LoadSortedData;
      //this.view.SearchEvent += LoadSearchedData;
    }

    private void Save(object sender, EventArgs e) {
      Console.WriteLine(view.username);
      Console.WriteLine(view.email);
      Console.WriteLine(view.phone);
      Console.WriteLine(view.address);
      Console.WriteLine(view.zipcode);
      Administrator admin = new Administrator {
        username  = view.username,
        email     = view.email,
        phone     = view.phone,
        address   = view.address,
        zipcode   = view.zipcode
        //age = Convert.ToInt32(view.age),
      };
      try {
        //ModelValidation.Validate(admin);
        if (view.isUpdate) {
          //Administrator beforeUpdatedAdmin = bindingSource.Current as Administrator;
          //admin.id = beforeUpdatedAdmin.id;
          //AdminService.Update(admin);
          //view.message = "Updated successfully";
        }
        else {
          AdminService.Create(admin);
          view.message = "Created successfully";
        }
        view.isSuccessful = true;
        UserControlUtils.CleanFields(view.Controls);
        //LoadListingData();
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }

    //private void LoadPrePageData(object sender, EventArgs e) {
    //  --view.currentPage;
    //  LoadListingData();
    //}

    //private void LoadNextPageData(object sender, EventArgs e) {
    //  ++view.currentPage;
    //  LoadListingData();
    //}

    //private void LoadSortedData(object sender, EventArgs e) {
    //  LoadListingData();
    //}

    //private void LoadSearchedData(object sender, EventArgs e) {
    //  LoadListingData();
    //}

    //private void LoadListingData() {
    //  List<Administrator> administratorList = AdminService.GetPaginatedData(
    //    pageIndex: view.currentPage - 1,
    //    keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
    //    orderBy: view.orderBy,
    //    orderDirection: view.orderDirection
    //   );
    //  UpdatePageLabel();
    //  CheckAvailabilityNavigatingPage();
    //  bindingSource.DataSource = administratorList;
    //}

    //private void UpdatePageLabel() {
    //  view.totalPages = AdminService.GetTotalPages();
    //  Label pageLabel = view.GetPageLabel();
    //  pageLabel.Text = $"{view.currentPage} / {view.totalPages}";
    //}

    //private void CheckAvailabilityNavigatingPage() {
    //  Button prePageBtn = view.GetPrePageBtn();
    //  Button nextPageBtn = view.GetNextPageBtn();
    //  if (view.currentPage == 1) {
    //    prePageBtn.Enabled = false;
    //  }
    //  else {
    //    prePageBtn.Enabled = true;
    //  }

    //  if (view.currentPage == view.totalPages) {
    //    nextPageBtn.Enabled = false;
    //  }
    //  else {
    //    nextPageBtn.Enabled = true;
    //  }
    //}

    //private void LoadSelectedData(object sender, EventArgs e) {
    //  Administrator admin = bindingSource.Current as Administrator;
    //  view.id = admin.id;
    //  view.name = admin.name;
    //  view.age = (int)admin.age;
    //}

    //private void DeleteSelectedData(object sender, EventArgs e) {
    //  Administrator admin = bindingSource.Current as Administrator;
    //  AdminService.DeleteById(admin.id);
    //  LoadListingData();
    //}
  }
}
