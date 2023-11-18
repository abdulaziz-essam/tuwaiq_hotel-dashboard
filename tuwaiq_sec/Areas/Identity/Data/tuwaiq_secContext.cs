using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tuwaiq_sec.Areas.Identity.Data;

namespace tuwaiq_sec.Data;

public class tuwaiq_secContext : IdentityDbContext<tuwaiq_secUser>
{
    public tuwaiq_secContext(DbContextOptions<tuwaiq_secContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
