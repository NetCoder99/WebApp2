using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class AddressDetails
    {

        public int AddressDetailsId { get; set; }

        [Required(ErrorMessage = "Address line 1 is required")]
        [StringLength(50)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [StringLength(50)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [StringLength(50)]
        [Display(Name = "City")]
        public string AddressCity { get; set; }

        [StringLength(50)]
        [Display(Name = "State")]
        public string AddressState { get; set; }

        [StringLength(10)]
        [Display(Name = "Zipcode")]
        public string AddressZip { get; set; }

    }
}