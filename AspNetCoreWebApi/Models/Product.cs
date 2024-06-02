using System;
using System.Text.Json.Serialization;

namespace AspNetCoreWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public int CatId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}