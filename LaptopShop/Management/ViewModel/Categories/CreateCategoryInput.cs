using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Categories
{
    public class CreateCategoryInput
    {
        public string Name { get; set; }
        
    }
    public class UpdateCategoryInput : CreateCategoryInput
    {
        public int ID { get; set; }
    }
   

}
