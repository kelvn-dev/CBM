using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("administrator")]
  public class Administrator : BaseModel {

    public Administrator() : base() { }

    public Administrator(string username, string email, string phone, string address, string zipcode): base() {
      _username = username;
      _email = email;
      _phone = phone;
      _address = address;
      _zipcode = zipcode;
    }

    private string _username;
    private string _email;
    private string _phone;
    private string _address;
    private string _zipcode;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Required Username")]
    [DisplayName("Username")]
    [Column("username")]
    public string username {
      get => _username; 
      set => _username = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Required Email")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [DisplayName("Email")]
    [Column("email")]
    public string email { 
      get => _email;
      set => _email = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Required Phone Number")]
    [DisplayName("Phone Number")]
    [Column("phone")]
    public string phone {
      get => _phone;
      set => _phone = value; 
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Required Address")]
    [DisplayName("Address")]
    [Column("address")]
    public string address { 
      get => _address;
      set => _address = value;
    }
    [DisplayName("Zip Code")]
    [Column("zipcode")]
    public string zipcode {
      get => _zipcode;
      set => _zipcode = value; 
    }

    //[RegularExpression("^[0-9]+$", ErrorMessage = "Invalid number")]
    //[DisplayName("Age")]
    //public int? age {
    //  get => _age;
    //  set => _age = value;
    //}
  }
}
