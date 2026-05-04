namespace PRODUCTMANAGEMENTAPI.Models;

public class Product{
    public Guid  Id{get;set;}=Guid.NewGuid();
    public required String Title{get;set;}
    public required int Quantity{get;set;}
    public required double Price{get;set;}
    public  int Discount{get;set;}
    public required String BrandName{get;set;}
    public  DateTime CreatedTime{get;set;} = DateTime.UtcNow;

}