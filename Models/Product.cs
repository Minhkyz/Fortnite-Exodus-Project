using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mydemo.Models
{
    public class Product
    {
        [Key]
        [Display(Name="Product ID")]
        public int id{get; set;}

        [Display(Name="Product Name")]
        public string name{get; set;}

        [Display(Name="Product Quanlity")]
        public int quan{get; set;}
        
        [Display(Name="Category ID")]
        public int cat_id{get; set;}

        [ForeignKey("cat_id")]
        public virtual Category category { get; set; }
    }

}