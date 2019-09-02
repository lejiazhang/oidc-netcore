using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleConfig
    {
        string AuthApiUrl { get; }
        string ApplicationCode { get; }

        IAuthModuleDataProtectionConfig DataProtectionConfig { get; }

        IAuthModuleApiToApiConfig ApiToApiConfig { get; }
    }
}
