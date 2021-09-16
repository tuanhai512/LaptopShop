using System;
using System.Web;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace Management.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual Category Category { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }
    }
}
