using EntityFramework.Identity;
using EntityFramework.Infrastucture;
using Microsoft.AspNetCore.Identity;

namespace EntityFramework.Interfaces
{
    public interface IIdentityAsync
    {

        IUserValidator<ApplicationUser> UserValidator { get; }

        IPasswordValidator<ApplicationUser> PasswordValidator { get; }

        IPasswordHasher<ApplicationUser> PasswordHasher { get; }

        FamilyNetPhoneValidator PhoneValidator { get; }

        UserManager<ApplicationUser> UserManager { get; }

        SignInManager<ApplicationUser> SignInManager { get; }

        RoleManager<IdentityRole> RoleManager { get; }



    }
}