using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("admin")]
  public class Admin : BaseModel {

    public Admin() : base() { }

    public Admin(string name, int? age): base() {
      this.name = name;
      this.age = age;
    }

    private string _name;
    private int? _age;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Required field")]
    [DisplayName("NAME")]
    public string name {
      get => _name;
      set { _name = value; }
    }

    [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid number")]
    [DisplayName("AGE")]
    public int? age {
      get => _age;
      set => _age = value;
    }
  }
}
