using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleDataProtectionConfig
    {
        IAuthModuleAESDataProtectorConfig AESConfig { get; }
    }
}
