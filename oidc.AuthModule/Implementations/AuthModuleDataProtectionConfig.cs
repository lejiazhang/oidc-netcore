using oidc.AuthModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Implementations
{
    public class AuthModuleDataProtectionConfig : IAuthModuleDataProtectionConfig
    {
        private readonly IAuthModuleAESDataProtectorConfig _aesConfig;

        public AuthModuleDataProtectionConfig(IAuthModuleAESDataProtectorConfig aesConfig)
        {
            _aesConfig = aesConfig;
        }

        public IAuthModuleAESDataProtectorConfig AESConfig
        {
            get
            {
                return _aesConfig;
            }
        }
    }
}
