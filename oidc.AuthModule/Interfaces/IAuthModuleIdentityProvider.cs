using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleIdentityProvider
    {
        bool IsAuthenticated { get; }
        long UserId { get; }
        string ApiToApiApplicationCode { get; }
    }
}