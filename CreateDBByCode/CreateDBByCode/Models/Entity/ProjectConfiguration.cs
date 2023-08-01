using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project)).HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(p => p.Budget).HasColumnName("Budget").HasColumnType("money");
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasColumnType("datetime").HasMaxLength(7);
            builder.Property(p => p.ClientId).HasColumnName("ClientId").HasColumnType("int");

            builder.HasOne(p => p.Client)
                .WithOne(c => c.Project)
                .HasForeignKey<Client>(c => c.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Project>()
                {
                    new Project { ProjectId = 1, Name = "Short", Budget = 14.49m, StartedDate = new DateTime(2022, 12, 02), ClientId = 1 },
                    new Project { ProjectId = 2, Name = "Dress", Budget = 19.00m, StartedDate = new DateTime(2022, 12, 02), ClientId = 2 },
                    new Project { ProjectId = 3, Name = "T-Shirt", Budget = 9.99m, StartedDate = new DateTime(2022, 12, 02), ClientId = 5 },
                    new Project { ProjectId = 4, Name = "Jeans", Budget = 26.49m, StartedDate = new DateTime(2022, 12, 02), ClientId = 3 },
                    new Project { ProjectId = 5, Name = "Sneakers", Budget = 18.00m, StartedDate = new DateTime(2022, 12, 02), ClientId = 4 },
                });
        }
    }
}
