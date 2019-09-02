using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleAESDataProtectorConfig
    {
        string Key { get; }
        string IV { get; }
    }
}
