using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleHttpWrapper
    {
        string GetHeaderValue(string key);
        T Get<T>(string configAuthApiUrl, Dictionary<string, string> headers);
    }
}