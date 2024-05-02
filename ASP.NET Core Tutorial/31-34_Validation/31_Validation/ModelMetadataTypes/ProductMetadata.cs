using System.ComponentModel.DataAnnotations;

namespace _31_Validation.ModelMetadataTypes
{
    public class ProductMetadata
    {
        [Required(ErrorMessage = "Lütfen Product name'i giriniz.")]
        [StringLength(100, ErrorMessage = "Lütfen product name'i en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi girin")]
        public string Email { get; set; }
    }
}
