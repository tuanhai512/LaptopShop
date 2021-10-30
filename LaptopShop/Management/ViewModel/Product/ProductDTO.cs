using Management.Models;
using Management.ViewModel.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Product
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }

       
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        //hmmmmm
      

       

    }
}
