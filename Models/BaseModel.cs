using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CBM.Models {
  public class BaseModel: IDataErrorInfo {

    public BaseModel() {
      id = Guid.NewGuid();
    }

    [Browsable(false)]
    public string this[string property] {
      get {
        var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
        if (propertyDescriptor == null)
          return string.Empty;

        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(
                                  propertyDescriptor.GetValue(this),
                                  new ValidationContext(this, null, null) { MemberName = property },
                                  results);
        if (!result)
          return results.First().ErrorMessage;
        return string.Empty;
      }
    }

    [Browsable(false)]
    public string Error {
      get {
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateObject(this,
            new ValidationContext(this, null, null), results, true);
        if (!result)
          return string.Join("\n", results.Select(x => x.ErrorMessage));
        else
          return null;
      }
    }

    public object this[string propertyName] {
      get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
      set {
        value = value == DBNull.Value ? null : value;
        this.GetType().GetProperty(propertyName).SetValue(this, value, null);
      }
    }

    private Guid _id;
    private DateTime _createdTime;

    public Guid id {
      get => _id;
      set => _id = value;
    }

    public DateTime? createdTime {
      get => _createdTime;
      set => _createdTime = (DateTime) value;
    }
  }
}
