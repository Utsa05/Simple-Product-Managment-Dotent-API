using PRODUCTMANAGEMENTAPI.Data;
using PRODUCTMANAGEMENTAPI.DTOS;
using PRODUCTMANAGEMENTAPI.Interfaces;
using PRODUCTMANAGEMENTAPI.Models;

namespace PRODUCTMANAGEMENTAPI.Services;

public class ProudctService(AppDBContext context) : IProductInterface
{
    private readonly AppDBContext _context = context;

    public Product Create(ProductCreateDto dto)
    {
        var newProduct=new Product
        {
            Title= dto.Title,
            Quantity=dto.Quantity,
            Price=dto.Price,
            BrandName=dto.BrandName,
            Discount=dto.Discount

        };

        _context.Add(newProduct);
        _context.SaveChanges();
        return newProduct;
    }

    public bool Delete(int id)
    {
        var product=_context.Products.Find(id);
        if (product==null) return false;
        _context.Products.Remove(product);
        _context.SaveChanges();
        return true;
        
    }

    public List<Product> GetProducts()
    {
        return [.._context.Products];
    }

    public List<Product> SearchProducts(String query)
    {
        List<Product> searchedProducts= [.. _context.Products.Where(product=>product.Title.Contains(query, StringComparison.CurrentCultureIgnoreCase) 
        || product.BrandName.Contains(query, StringComparison.CurrentCultureIgnoreCase))];

        return searchedProducts;
    }

    public Product Update(int id, ProductUpdateDto dto)
    {
        var product = _context.Products.Find(id);
        if (product==null) return null;

        product.Title=dto.Title;
        product.BrandName=dto.BrandName;
        product.Discount=dto.Discount;
        product.Price=dto.Price;
        product.Quantity=dto.Quantity;

        _context.SaveChanges();

        return product;

    }
}