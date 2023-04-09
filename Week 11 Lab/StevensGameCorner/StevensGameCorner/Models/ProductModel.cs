using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace StevensGameCorner.Models
{
    public class ProductModel
    {

//        2. Add the following data validation to the fields in the ProductModel, (Be sure to include the DataAnnotations namespace)
//ProductName – required and include a custom error message.
//ProductDescription – required and include a custom error message.
//    ProductImage – required and include a custom error message.
//ProductPrice – use the DataType attribute to apply Currency to the ProductPrice field.
//(See https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-6.0 for an example)
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string ProductName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a description.")]
        public string ProductDescription { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please input an image.")]
        public string ProductImage { get; set; } = string.Empty;
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
    }
}
