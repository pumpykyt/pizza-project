using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context
{
    public class EFContext : IdentityDbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
    }
}