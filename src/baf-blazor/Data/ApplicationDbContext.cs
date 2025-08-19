using Avolutions.Baf.Core;
using Microsoft.EntityFrameworkCore;

namespace Baf.BlazorApp.Data;

public class ApplicationDbContext : BafDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}