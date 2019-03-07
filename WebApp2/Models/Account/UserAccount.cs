using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp2.Models.Account
{
    [Table("UserDetails", Schema = "WEBAPP2")]
    public class UserAccount
    {
        [Key]
        public int UserDetailId { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50)]
        [Compare(nameof(PassWordConfirm), ErrorMessage = "Passwords don't match.")]
        public string PassWord { get; set; }

        [Display(Name = "Password Confirmation")]
        [Required(ErrorMessage = "Password confirmation is required")]
        [StringLength(50)]
        [NotMapped]
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
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public bool PrefEmail { get; set; }

        [Display(Name = "Text Msg")]
        public bool PrefText { get; set; }


    }
}