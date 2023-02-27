using CBM.Models;
using CBM.Services;
using CBM.Utilities;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class AdministratorPresenter {

    private AdministratorView view;
    private BindingSource bindingSource;

    public AdministratorPresenter(AdministratorView view) {
      this.view = view;
      this.bindingSource = new BindingSource();

      LoadListingData();
      this.view.MapDataSource(bindingSource);
      this.view.Show();

      this.view.CreateEvent += delegate (object sender, EventArgs e) { this.view.isUpdate = false; };
      this.view.SaveEvent += Save;
      this.view.UpdateEvent += LoadSelectedData;
      this.view.DeleteEvent += DeleteSelectedData;
      this.view.GetPrePageEvent += LoadPrePageData;
      this.view.GetNextPageEvent += LoadNextPageData;
      this.view.SortEvent += LoadSortedData;
      this.view.SearchEvent += LoadSearchedData;
      this.view.CancelEvent += CleanFields;
    }

    private void CleanFields(object sender = null, EventArgs e = null) {
      view.name = string.Empty;
      view.age = 0;
    }

    private void LoadPrePageData(object sender, EventArgs e) {
      --view.currentPage;
      LoadListingData();
    }

    private void LoadNextPageData(object sender, EventArgs e) {
      ++view.currentPage;
      LoadListingData();
    }

    private void LoadSortedData(object sender, EventArgs e) {
      LoadListingData();
    }

    private void LoadSearchedData(object sender, EventArgs e) {
      LoadListingData();
    }

    private void LoadListingData() {
      List<Admin> administratorList = AdminService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = administratorList;
    }

    private void UpdatePageLabel() {
      view.totalPages = AdminService.GetTotalPages();
      Label pageLabel = view.GetPageLabel();
      pageLabel.Text = $"{view.currentPage} / {view.totalPages}";
    }

    private void CheckAvailabilityNavigatingPage() {
      Button prePageBtn = view.GetPrePageBtn();
      Button nextPageBtn = view.GetNextPageBtn();
      if (view.currentPage == 1) {
        prePageBtn.Enabled = false;
      }
      else {
        prePageBtn.Enabled = true;
      }

      if (view.currentPage == view.totalPages) {
        nextPageBtn.Enabled = false;
      }
      else {
        nextPageBtn.Enabled = true;
      }
    }

    private void LoadSelectedData(object sender, EventArgs e) {
      Admin admin = bindingSource.Current as Admin;
      view.id = admin.id;
      view.name = admin.name;
      view.age = (int)admin.age;
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Admin admin = bindingSource.Current as Admin;
      AdminService.DeleteById(admin.id);
      LoadListingData();
    }

    private void Save(object sender, EventArgs e) {
      Admin admin = new Admin {
        name = view.name,
        age = Convert.ToInt32(view.age),
      };

      try {
        ModelValidation.Validate(admin);
        if (view.isUpdate) {
          Admin beforeUpdatedAdmin = bindingSource.Current as Admin;
          admin.id = beforeUpdatedAdmin.id;
          AdminService.Update(admin);
          view.message = "Updated successfully";
        }
        else {
          AdminService.Create(admin);
          view.message = "Created successfully";
        }
        view.isSuccessful = true;
        CleanFields();
        LoadListingData();
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }
  }
}
