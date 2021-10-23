using Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Categories
{
    public class CreateCategoryInput
    {
        [Required]
        [Display(Name = "Tên loại")]
        public string Name { get; set; }
        
    }
    public class UpdateCategoryInput : CreateCategoryInput
    {
        public int ID { get; set; }
    }
   

}
