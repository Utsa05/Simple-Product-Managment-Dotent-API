using Microsoft.EntityFrameworkCore;
using PRODUCTMANAGEMENTAPI.Models;

namespace PRODUCTMANAGEMENTAPI.Data;


public class AppDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products {get;set;}
}