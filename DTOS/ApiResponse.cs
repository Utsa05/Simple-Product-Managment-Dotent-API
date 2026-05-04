namespace PRODUCTMANAGEMENTAPI.DTOS;

public class ApiResponse<T>
{
    public required bool Success{get;set;}
    public required int StatusCode{get;set;}
    public required String Message{get;set;}
    public required T Data {get;set;}
}