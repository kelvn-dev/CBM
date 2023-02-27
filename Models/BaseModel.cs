using System;

namespace CBM.Models {
  public class BaseModel {

    public BaseModel() {
      id = Guid.NewGuid();
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
