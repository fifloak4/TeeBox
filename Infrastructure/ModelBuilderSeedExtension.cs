using Microsoft.EntityFrameworkCore;
using TeeBox.Infrastructure.Seed;

namespace TeeBox.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedSobienie();
        }
    }
}
