using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Customer
{
    public class CreateCustomerInput
    {
        public int Id { get; set; }
        public int? UserId { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public class UpdateCustomerInput:CreateCustomerInput
    {

    }
}
