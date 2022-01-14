using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Core.Services.Token
{
    public interface IJWTTokenGenerator
    {
        string GenerateToken(IdentityUser user, IList<string> role, IList<Claim> claims);
        
    }
}