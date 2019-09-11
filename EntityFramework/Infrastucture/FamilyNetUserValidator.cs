using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;
using EntityFramework.Identity;

namespace EntityFramework.Infrastucture
{
    public class FamilyNetUserValidator : UserValidator<ApplicationUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser applicationUser)
        {
            IdentityResult result = await base.ValidateAsync(manager, applicationUser);
            List<IdentityError> errors = result.Succeeded ?
                new List<IdentityError>() : result.Errors.ToList();
            // TO DO : Add normal regular expression

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
            
        }


    }
}
