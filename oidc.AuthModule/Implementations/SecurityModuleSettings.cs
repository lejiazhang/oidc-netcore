using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Implementations
{
    public class DataProtectionSettings
    {
        public string Key { get; set; }
        public string IV { get; set; }
    }
    public class AllowedAppsSettings
    {
        public string Name { get; set; }
    }

    public class SecurityModuleSettings
    {
        public string ApplicationCode { get; set; }
        public string AuthApiUrl { get; set; }

        public DataProtectionSettings AESDataProtection { get; set; }

        public IEnumerable<AllowedAppsSettings> AllowedApps { get; set; }
    }
}
