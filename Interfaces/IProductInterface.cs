using PRODUCTMANAGEMENTAPI.DTOS;
using PRODUCTMANAGEMENTAPI.Models;

namespace PRODUCTMANAGEMENTAPI.Interfaces;

public interface IProductInterface
{
    List<Product>GetProducts();
    List<Product>SearchProducts();
    Product Create(ProductCreateDto dto);
    Product Update(int id,ProductUpdateDto dto);
    bool Delete(int id);
}

