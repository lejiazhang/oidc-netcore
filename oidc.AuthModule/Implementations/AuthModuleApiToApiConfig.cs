using oidc.AuthModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Implementations
{
    public class AuthModuleApiToApiConfig : IAuthModuleApiToApiConfig
    {
        private List<string> _allowedApps;

        public AuthModuleApiToApiConfig(IEnumerable<string> allowedApps)
        {
            if (allowedApps == null)
                throw new ArgumentNullException(nameof(allowedApps));

            _allowedApps = new List<string>(allowedApps);
        }

        public IEnumerable<string> AllowedApps
        {
            get
            {
                return _allowedApps;
            }
        }
    }
}