using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Categories
{
    public sealed class CategorySingleton
    {
        public static CategorySingleton Instance { get; } = new CategorySingleton();
        public List<CategoryDTO> listCategory { get; } = new List<CategoryDTO>();
        private CategorySingleton(){}

        public void Init(QLWBLTContext _context)
        {
            if (listCategory.Count == 0)
            {
                var query = from c in _context.Categories
                            select new CategoryDTO
                            {
                                ID = c.Id,
                                Name = c.Name
                            };
                foreach( var item in query )
                {
                    listCategory.Add(item);
                }    
            }
        }
       
    }
}
