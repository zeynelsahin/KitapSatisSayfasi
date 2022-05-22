using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapSatisSayfasi.Models.Configuration
{
    public class UyeCFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            Uye uye = (new Uye() { Id = 1,Ad = "Zeynel",Soyad = "Şahin",UserName = "Zeynel", NormalizedUserName = "Zeynel", Email = "zeynelsahin@zeynelsahin.com", NormalizedEmail = "zeynelsahin@zeynelsahin.com", EmailConfirmed = true, Adres = "Ümraniye" });
            PasswordHasher<Uye> hash = new PasswordHasher<Uye>();
            uye.PasswordHash = hash.HashPassword(uye, "admin");
            builder.HasData(uye);
            
            
        }
    }
}
