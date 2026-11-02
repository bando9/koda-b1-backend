using System.ComponentModel.DataAnnotations;

namespace Backend.Api.Models;

public sealed class Product
{
    [Required]
    public string ProductCode {get; set;}
    [Required]
    public string Name {get;set;}
    [Required]
    [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
    public decimal Price {get;set;}
    [Required]
    [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
    public int Stock {get;set;}
    [Required]
    public string Category {get;set;}

    public Product(string productCode, string name, decimal price, int stock,string category)
    {
        ProductCode=productCode;
        Name = name;
        Price = price;
        Stock=stock;
        Category=category.Trim();
    }



}