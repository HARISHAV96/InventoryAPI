//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryAPI.Models
{
    using SmartFormat.Core.Parsing;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Inventory
    {
  
        public string ItemId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        [RegularExpression(@"[A-Za-z]{1,20}", ErrorMessage = "Enter Valid Name")]
        [MaxLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is Required")]
        [MaxLength(100, ErrorMessage = "You have reached Maximum Limit")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category is Required")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Availability is Required")]
        [Display(Name = "Availability")]
        public string Availability { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Price is Required")]
        [RegularExpression(@"\d{0,8}(\.\d{1,4})?", ErrorMessage = "Enter Valid Price")]
        [Display(Name = "Price")]
        public string Price { get; set; }
    }
}

public enum Category
{
    Seasonal,
    Maintenance,
    Repair,
    Packing

}

