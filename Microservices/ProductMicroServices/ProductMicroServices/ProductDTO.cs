using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductMicroServices
{
    public class ProductDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string PName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
