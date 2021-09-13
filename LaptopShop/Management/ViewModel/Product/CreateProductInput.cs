using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Product
{
    public class CreateProductInput 
    {
        public string Name { get; set; }

    }
    public class UpdateProductInput : CreateProductInput
    {

    }
}
