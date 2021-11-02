using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(55)]
        public string FirstName { get; set; }

        [StringLength(55)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(55)]
        public string Pwd { get; set; }

        public string PhoneNum { get; set; }
        public DateTime Dob { get; set; }
        public string Size { get; set; }
    }
}
