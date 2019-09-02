using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleCacheProvider
    {
        T Get<T>(string key);
        void Add<T>(string key, T retrieve, int timeInSeconds);
    }
}