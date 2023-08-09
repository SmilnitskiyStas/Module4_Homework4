using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable(nameof(Client)).HasKey(c => c.ClientId);
            builder.Property(c => c.ClientId).HasColumnName("ClientId").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar(50)");
            builder.Property(c => c.LastName).HasColumnName("LastName").HasColumnType("nvarchar(50)");
            builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").HasColumnType("nvarchar(20)");
            builder.Property(c => c.Email).HasColumnName("Email").HasColumnType("nvarchar(50)");
            builder.Property(c => c.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("datetime");

            builder.HasData(new List<Client>()
            {
                new Client { ClientId = 1, FirstName = "Oleg", LastName = "Olegof", PhoneNumber = "+380502728429", Email = "oleg@gmail.com", DateOfBirth = new DateTime(1988, 10, 26), ProjectId = 1 },
                new Client { ClientId = 2, FirstName = "Olga", LastName = "Ruf", PhoneNumber = "+380952841523", Email = "olga@gmail.com", DateOfBirth = new DateTime(1986, 11, 25), ProjectId = 2 },
                new Client { ClientId = 3, FirstName = "Sasha", LastName = "Saha", PhoneNumber = "+380668871456", Email = "sasha@gmail.com", DateOfBirth = new DateTime(1994, 8, 20), ProjectId = 4 },
                new Client { ClientId = 4, FirstName = "Maksim", LastName = "Maksi", PhoneNumber = "+380509587412", Email = "maksim@gmail.com", DateOfBirth = new DateTime(1990, 11, 26), ProjectId = 5 },
                new Client { ClientId = 5, FirstName = "Anastasia", LastName = "Sminitska", PhoneNumber = "+380505254745", Email = "anastasia@gmail.com", DateOfBirth = new DateTime(1996, 07, 31), ProjectId = 3 },
            });
        }
    }
}
