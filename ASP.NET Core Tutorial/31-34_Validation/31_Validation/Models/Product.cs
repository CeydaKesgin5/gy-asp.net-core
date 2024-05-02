using _31_Validation.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _31_Validation.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email {  get; set; }
    }
}
