using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class RepositoryContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Employee>? Employees { get; set; }
}
