using Microsoft.AspNetCore.Mvc;
using PRODUCTMANAGEMENTAPI.DTOS;
using PRODUCTMANAGEMENTAPI.Interfaces;

namespace PRODUCTMANAGEMENTAPI.Controllers;

 [ApiController]
 [Route("api/[controller]")]
public class ProductController(IProductInterface productInterface): ControllerBase{
    private readonly IProductInterface _productInterface=productInterface;

   
    [HttpGet]
    public IActionResult GetProducts()
    {
        var response=_productInterface.GetProducts();

        if(response==null) return NotFound();
        return Ok(
           response
        );
    }

    [HttpGet("search")]
    public IActionResult Search(String query)
    {
        var response=_productInterface.SearchProducts(query);

        if(response==null) return NotFound();
        return Ok(
           response
        );
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var response= _productInterface.Delete(id);

        if (response==false) return NotFound(new ApiResponse<object>
        {
            Message="Product Not Found",
            StatusCode=404,
            Success=false,
            Data=null,
        });

        return Ok(new ApiResponse<object>
        {
            Message="Product deleted successfully",
            StatusCode=200,
            Success=true,
            Data=true,
        });
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id,ProductUpdateDto dto)
    {
        var response= _productInterface.Update(id,dto);

        if (response==null) return NotFound(new ApiResponse<object>
        {
            Message="Product Not Found",
            StatusCode=404,
            Success=false,
            Data=null,
        });

        return Ok(new ApiResponse<object>
        {
            Message="Product updated successfully",
            StatusCode=200,
            Success=true,
            Data=response,
        });
    }
    
    [HttpPost()]
    public IActionResult Create(ProductCreateDto dto)
    {
        var response= _productInterface.Create(dto);

        if (response==null) return NotFound(new ApiResponse<object>
        {
            Message="Product not created",
            StatusCode=400,
            Success=false,
            Data=null,
        });

        return Ok(new ApiResponse<object>
        {
            Message="Product created successfully",
            StatusCode=201,
            Success=true,
            Data=response,
        });
    }
    
}
    
