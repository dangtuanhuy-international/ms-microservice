using Microsoft.AspNetCore.Mvc;
using Product.API.Models;
using Product.API.Services;

namespace Product.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService productService;

    public ProductsController(IProductService _productService)
    {
        productService = _productService;
    }

    [HttpGet]
    public IEnumerable<Products> ProductList()
    {
        var productList = productService.GetProductList();
        return productList;
    }

    [HttpGet("{id}")]
    public Products GetProductById(int id)
    {
        return productService.GetProductById(id);
    }

    [HttpPost]
    public Products AddProduct(Products product)
    {
        return productService.AddProduct(product);
    }

    [HttpPatch]
    public Products UpdateProduct(Products product)
    {
        return productService.UpdateProduct(product);
    }

    [HttpDelete("{id}")]
    public bool DeleteProduct(int id)
    {
        return productService.DeleteProduct(id);
    }
}