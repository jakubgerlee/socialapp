using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Social.Dal;

public class DataContext : IdentityDbContext 
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<UserProfile>
}
