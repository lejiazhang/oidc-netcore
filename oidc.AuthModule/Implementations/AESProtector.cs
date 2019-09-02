using Microsoft.AspNetCore.DataProtection;
using oidc.AuthModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oidc.AuthModule.Implementations
{
    public class AESProtector : IDataProtector
    {
        private readonly IAuthModuleAESDataProtectorConfig _aesConfig;

        public AESProtector()
        {
            //_aesConfig = new AuthModule
        }

        public IDataProtector CreateProtector(string purpose)
        {
            throw new NotImplementedException();
        }

        public byte[] Protect(byte[] plaintext)
        {
            throw new NotImplementedException();
        }

        public byte[] Unprotect(byte[] protectedData)
        {
            throw new NotImplementedException();
        }
    }
}
