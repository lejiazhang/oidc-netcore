using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface ITokenGenerator
    {
        string GenerateToken(ClaimsIdentity identity, double expiresInSeconds);
        string GenerateApiToApiToken(string token, double expiresInSeconds, string applicationCode);
        string GenerateApiToApiToken(ClaimsIdentity identity, double expiresInSeconds, string applicationCode);
        ClaimsIdentity UnprotectToken(string token);
        string GenerateApiToApiToken(double expiresInSeconds, string applicationCode);
    }
}