using Microsoft.Extensions.Configuration;
using oidc.AuthModule.Interfaces;
using System;
using System.Linq;
using System.Configuration;

namespace oidc.AuthModule.Implementations
{
    public class AuthModuleConfig : IAuthModuleConfig
    {
        public string AuthApiUrl { get; private set; }
        public string ApplicationCode { get; private set; }

        public IAuthModuleDataProtectionConfig DataProtectionConfig { get; private set; }
        public IAuthModuleApiToApiConfig ApiToApiConfig { get; private set; }

        public AuthModuleConfig(IConfiguration configuration)
        {
            var section = configuration.GetSection("SecurityModule") as SecurityModuleSettings;

            if (section == null)
            {
                throw new ConfigurationErrorsException("Missing securityModule section");
            }

            AuthApiUrl = section.AuthApiUrl;
            ApplicationCode = section.ApplicationCode;

            if (section?.AESDataProtection != null)
            {
                var aesConfig = new AuthModuleAESDataProtectorConfig(section.AESDataProtection.Key, section.AESDataProtection.IV);
                DataProtectionConfig = new AuthModuleDataProtectionConfig(aesConfig);
            }

            if (section.AllowedApps != null)
            {
                var allowedApps = section.AllowedApps.Select(app => app.Name);

                if (allowedApps != null)
                    ApiToApiConfig = new AuthModuleApiToApiConfig(allowedApps);
            }
        }
    }
}
