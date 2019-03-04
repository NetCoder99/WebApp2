using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp2.Models.Account
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50)]
        public string PassWord { get; set; }

        [Display(Name = "Password Confirmation")]
        [Required(ErrorMessage = "Password confirmation is required")]
        [StringLength(50)]
        public string PassWordConfirm { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Display Name")]
        [StringLength(50)]
        public string DisplayName { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public bool PrefEmail { get; set; }

        [Display(Name = "Text Msg")]
        public bool PrefText { get; set; }


    }
}