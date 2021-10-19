using System.ComponentModel.DataAnnotations;

namespace Mydemo.Models
{
    public class Category
    {
        [Key]
        [Display(Name="Category ID")]
        public int id{get; set;}

        [Display(Name="Category Name")]
        public string name{get; set;}
    }
}