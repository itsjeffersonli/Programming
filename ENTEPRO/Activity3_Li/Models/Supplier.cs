using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Activity3_Li.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string CompanyName { get; set; }

        public string Representative { get; set; }

        public string Code { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Address { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }

        [Display(Name = "Type")]
        public Types Types { get; set; }
    }

    public enum Types
    {
        Local = 1,
        International = 2
    }
}

