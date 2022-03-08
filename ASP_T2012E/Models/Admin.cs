using ASP_T2012E.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_T2012E.Models
{
    public class Admin
    {
        [DisplayName("Ma tai khoan")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Tai khoan")]
        public string Username { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})\b")]
        public string PhoneVietNam { get; set; }

        [Required]
        [Range(1,3)]
        public int Status { get; set; }

        public Admin()
        {

        }

        public Admin(AdminViewModel viewModel)
        {
            this.Email = viewModel.Email;
            this.Username = viewModel.Username;
            this.Password = viewModel.Password;
            this.PhoneVietNam = viewModel.PhoneVietNam;
            this.Status = viewModel.Status;
        }
    }
}