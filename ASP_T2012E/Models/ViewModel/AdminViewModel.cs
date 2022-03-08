using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_T2012E.Models.ViewModel
{
    public class AdminViewModel
    {
        [DisplayName("Ma tai khoan")]
        public int Id { get; set; }

        [Required(ErrorMessage = " Vui long nhap username")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Do dai toi thieu la 5")]
        [DisplayName("Tai khoan")]
        public string Username { get; set; }


        [Required(ErrorMessage = " Vui long nhap password")]
        [DisplayName("Mat Khau")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mat khau khong khop")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = " Vui long nhap email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui long nhap email dung dinh dang")]
        public string Email { get; set; }


        [Required(ErrorMessage = " Vui long nhap phone")]
        [RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Vui long nhap dien thoai cua ban")]
        public string PhoneVietNam { get; set; }

        [Required(ErrorMessage = " Vui long nhap trang thai")]
        [Range(1, 3, ErrorMessage = "Trang thai tai khoan phai co gia tri tu 1 den 3")]
        public int Status { get; set; }

        public AdminViewModel()
        {

        }

        public AdminViewModel(Admin admin)
        {
            this.Id = admin.Id;
            this.Username = admin.Username;
            this.Email = admin.Email;
            this.PhoneVietNam = admin.PhoneVietNam;
            this.Status = admin.Status;
        }
    }
}