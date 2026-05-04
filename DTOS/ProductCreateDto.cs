namespace PRODUCTMANAGEMENTAPI.DTOS;

public class ProductCreateDto
{
    public required String Title{get;set;}
    public required int Quantity{get;set;}
    public required double Price{get;set;}
    public  int Discount{get;set;}
    public required String BrandName{get;set;}
}