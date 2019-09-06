using Microsoft.EntityFrameworkCore;
using Recommend.API.Model;

namespace Recommend.API.Data
{
    public class RecommendDbContext : DbContext
    {
        public RecommendDbContext(DbContextOptions<RecommendDbContext> options) : base(options) { }

        public DbSet<ProjectRecommend> ProjectRecommends { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectRecommend>(b =>
                    b.ToTable("ProjectRecommends")
                    .HasKey(t => t.Id)
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
