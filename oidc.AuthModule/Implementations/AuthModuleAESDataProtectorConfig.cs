using oidc.AuthModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Implementations
{
    public class AuthModuleAESDataProtectorConfig : IAuthModuleAESDataProtectorConfig
    {
        private string _key;
        private string _iv;

        public AuthModuleAESDataProtectorConfig(string key, string iv)
        {
            _key = key;
            _iv = iv;
        }

        public string Key
        {
            get
            {
                return _key;
            }
        }

        public string IV
        {
            get
            {
                return _iv;
            }
        }
    }
}
