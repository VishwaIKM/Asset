using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagementVishwa.Model
{
    [Table("USR_MAIN")]
    public class LoginModel
    {
        //[Key]
        //[Required(ErrorMessage = "Please Enter UserId")]
        //[Display(Name = "Please Enter UserId")]
        [Column("USR_ID",Order =0)]
        public string Id { get; set; }

        //[Required(ErrorMessage = "Please Enter Password")]
        //[Display(Name = "Please Enter Password")]
        [Column("USR_NAME", Order = 1)]
        public string Name { get; set; }
        [Column("USR_PASSWORD", Order = 2)]
        public string Password { get; set; }
        [Column("USR_IS_ADMIN", Order = 3)]
        public int Privilege { get; set; }
    }
}
