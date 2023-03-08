using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("admin")]
  public class Administrator : BaseModel {

    public Administrator() : base() { }

    public Administrator(string name, int? age): base() {
      this.name = name;
      this.age = age;
    }

    private string _name;
    private int? _age;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Required field")]
    [DisplayName("Name")]
    public string name {
      get => _name;
      set { _name = value; }
    }

    [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid number")]
    [DisplayName("Age")]
    public int? age {
      get => _age;
      set => _age = value;
    }
  }
}
