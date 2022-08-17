using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Authendication
{
    public class LoginModel
    {
        [Required(ErrorMessage ="User Name is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Passperd is Required")]

        public string Password { get; set; }
    }
}
