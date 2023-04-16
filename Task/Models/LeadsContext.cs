using Microsoft.EntityFrameworkCore;
using Task.Models;

public class LeadsContext : DbContext
{
    public LeadsContext(DbContextOptions<LeadsContext> options) : base(options)
    {
    }
    public DbSet<Lead> Leads { get; set; }
}