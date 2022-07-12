using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadCrude.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string ProductsName { get; set; }
        [Required]
        [StringLength(20)]
        public string ProductsModel { get; set; }
        [Required]
        [StringLength(20)]
        public string Sku { get; set; }
        [Required]
        public int ProductsPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public Product()
        {

        }
    }
}
