using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tuan2.Models
{
    public class Category
    {
    
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }

        internal static object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}

