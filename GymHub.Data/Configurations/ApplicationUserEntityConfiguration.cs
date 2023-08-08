using GymHub.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GymHub.Data.Models;

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
   
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        builder.HasData(this.SeedAdmin());
        builder.HasData(this.GenerateUsers());
      
    }

    private ApplicationUser SeedAdmin()
    {
        ApplicationUser adminUser;

        var hasher = new PasswordHasher<ApplicationUser>();

        adminUser = new ApplicationUser()
        {
            Id = Guid.Parse("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
            FirstName = "Martin",
            LastName = "Stoyanov",
            PhoneNumber = "359892334456",
            Email = AdminUser.AdminEmail,
            NormalizedEmail = AdminUser.AdminEmail.ToUpper(),
            UserName = AdminUser.AdminEmail,
            NormalizedUserName = AdminUser.AdminEmail.ToUpper(),
            SecurityStamp = "2a1a3367-022d-4969-a374-63b39b19ad3f",
            EmailConfirmed = false,

        };

        adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin1234");
       

        return adminUser;

    }

    private ApplicationUser[] GenerateUsers()
    {
        ICollection<ApplicationUser> users = new HashSet<ApplicationUser>();

        ApplicationUser user;
        //Password for testing all users is 123456

        
        user = new ApplicationUser()
        {
            Id = Guid.Parse("0fa5eb44-0f0b-455c-bc32-ed60a57f875e"),
            FirstName = "Sophia",
            LastName = "Nikolova",
            PhoneNumber = "359895998877",
            UserName = "sophia.nikolova@gmail.com",
            NormalizedUserName = "SOPHIA.NIKOLOVA@GMAIL.COM",
            Email = "sophia.nikolova@gmail.com",
            NormalizedEmail = "SOPHIA.NIKOLOVA@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEAiCCxi119P7Wdt5HACevTAKRJhISG5l+Mnkxp9TG2YpqF6KZdr8Vze+a8cyuxmEtQ==",
            SecurityStamp = "1e865714-af27-45a8-a9be-4b86b249e89b",
            ConcurrencyStamp = "83abe2ba-cd77-4d38-9183-6ec77987f9da",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("ea4bb973-7977-455a-a92d-6a2cb1dfcca3"),
            FirstName = "Olivia",
            LastName = "Parker",
            PhoneNumber = "447123456789",
            UserName = "olivia.parker@gmail.com",
            NormalizedUserName = "OLIVIA.PARKER@GMAIL.COM",
            Email = "olivia.parker@gmail.com",
            NormalizedEmail = "OLIVIA.PARKER@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEHtfzsAaVxrwVzmZinE9tgvi9jcwvbuQNeYsjc6VSdAWUZ0h1m8qwPcd//FhC0XU+w==",
            SecurityStamp = "2b39aeb0-bbc6-4c8e-9d6e-f0fd53fe0216",
            ConcurrencyStamp = "4adb2ede-4773-4283-8360-e22ca09e4253",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("bcd3cb31-dc3a-4c20-ad5f-79324bb62443"),
            FirstName = "Alexander",
            LastName = "Angelov",
            PhoneNumber = "359899112233",
            UserName = "alexander.angelov@gmail.com",
            NormalizedUserName = "ALEXANDER.ANGELOV@GMAIL.COM",
            Email = "alexander.angelov@gmail.com",
            NormalizedEmail = "ALEXANDER.ANGELOV@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEBfG0iOA8h5kvAMERijFVoP7HqiS1qGtWCMK2RAq0vjQJuNmSXuaei2j+KhamuvHAw==",
            SecurityStamp = "4b80ebde-264f-431e-a4a6-c1589b41e616",
            ConcurrencyStamp = "2b25f6df-6efc-4d16-9ef5-08b1418f11d0",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

       

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("5f28263d-a630-4364-8267-75307568014f"),
            FirstName = "Remi",
            LastName = "Leroy",
            PhoneNumber = "33612345678",
            UserName = "remi.leroy@yahoo.com",
            NormalizedUserName = "REMI.LEROY@YAHOO.COM",
            Email = "remi.leroy@yahoo.com",
            NormalizedEmail = "REMI.LEROY@YAHOO.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEDV+wZw8xv0hl14DORhzdJFEDQX9cLY8VPh/lLWswyo2x6ctW5YxJY9qYPM9T6ZEsg==",
            SecurityStamp = "886fa01d-8b34-4ab8-90c1-60dfcc8728b9",
            ConcurrencyStamp = "efcc1d34-06e3-4a27-ac83-191f06838a61",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };


        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("aeba13bb-2b27-4b1b-b702-5fd482830491"),
            FirstName = "Amelie",
            LastName = "Dupont",
            PhoneNumber = null,
            UserName = "amelie.dupont@gmail.com",
            NormalizedUserName = "AMELIE.DUPONT@GMAIL.COM",
            Email = "amelie.dupont@gmail.com",
            NormalizedEmail = "AMELIE.DUPONT@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEBb+L7aAA95liJYAxSbgfeFvX4kSakl/ffhxXlCs3ZEdOJ62V678ccZZsOhYyMPgkA==",
            SecurityStamp = "b226ebd8-f251-4e47-8ede-01b9ae0866eb",
            ConcurrencyStamp = "8609df25-1c9e-4633-bb76-bd3fddd98573",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

      

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("9f76fb38-94d6-4ba8-9069-fd078ca22ebf"),
            FirstName = "Yana",
            LastName = "Georgieva",
            PhoneNumber = "35987223344",
            UserName = "yana.georgieva@gmail.com",
            NormalizedUserName = "YANA.GEORGIEVA@GMAIL.COM",
            Email = "yana.georgieva@gmail.com",
            NormalizedEmail = "YANA.GEORGIEVA@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAELHTCK4lvQkj+qbWISvG4lGE3xlXkucQ3QgQDx3XdNMUZ86cI4tKLUE1wrFBgg3LqQ==",
            SecurityStamp = "60a77677-4454-4bf5-b05f-98024417f6c4",
            ConcurrencyStamp = "5a60110c-2001-4c33-ad49-b3c108102c10",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

       
        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("3a0c980b-98fe-4e88-a95e-8926dd775c68"),
            FirstName = "Ivan",
            LastName = "Petrov",
            PhoneNumber = "359899556677",
            UserName = "ivan.petrov@gmail.com",
            NormalizedUserName = "IVAN.PETROV@GMAIL.COM",
            Email = "ivan.petrov@gmail.com",
            NormalizedEmail = "IVAN.PETROV@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEPUoCG/lNTCHguHAzcXCCme1hosTeDQfk6/gmPEwMZr4GVeZ+cR9yv2i715XAMTqvA==",
            SecurityStamp = "1a4acdeb-7c12-4dc2-a027-47777ae76da9",
            ConcurrencyStamp = "3c06599b-894d-4154-b9a5-566c6d76e349",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

      

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("557c75b3-d089-46a0-9b71-c800aa685010"),
            FirstName = "Noah",
            LastName = "Sanchez",
            PhoneNumber = null,
            UserName = "noah.sanchez@gmail.com",
            NormalizedUserName = "NOAH.SANCHEZ@GMAIL.COM",
            Email = "noah.sanchez@gmail.com",
            NormalizedEmail = "NOAH.SANCHEZ@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEJ3myLaQis7wuEub+d6eb51OsRNv4AeG2UGivyYBq84r3cmWMufFtKF7fPkAYUEtbg==",
            SecurityStamp = "fba2ef14-58cd-4af6-9e54-a7e927395d86",
            ConcurrencyStamp = "caa59b17-30ba-4438-8723-4beebc34208c",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

      
        users.Add(user);

        user = new ApplicationUser()
        {
            Id = Guid.Parse("dbc5c34e-0e90-42c9-83db-9421948f8f44"),
            FirstName = "James",
            LastName = "Turner",
            PhoneNumber = null,
            UserName = "james.turner@gmail.com",
            NormalizedUserName = "JAMES.TURNER@GMAIL.COM",
            Email = "james.turner@gmail.com",
            NormalizedEmail = "JAMES.TURNER@GMAIL.COM",
            EmailConfirmed = false,
            PasswordHash = "AQAAAAEAACcQAAAAEAaMeejDsW7TTTRErnNkktE4HlK+xXCHgFiJZO5J7nTwJmAkFJM6myLFYSAGEoKBLg==",
            SecurityStamp = "14126ad6-1c4c-4a8a-a26d-2810ec96485d",
            ConcurrencyStamp = "6f3eb9fa-c6f4-44e7-adab-68b4d886b8cc",
            TwoFactorEnabled = false,
            PhoneNumberConfirmed = false
        };

      

        users.Add(user);

        return users.ToArray();
    }
}
