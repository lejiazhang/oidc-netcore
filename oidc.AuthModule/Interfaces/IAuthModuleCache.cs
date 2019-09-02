using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Interfaces
{
    public interface IAuthModuleCache
    {
        IEnumerable<T> Get<T>(string key, Func<IEnumerable<T>> func, int timeInSeconds);
        T Get<T>(string key, Func<T> func, int timeInSeconds);
    }
}
