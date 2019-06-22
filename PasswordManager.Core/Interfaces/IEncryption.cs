using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Interfaces
{
    public interface IEncryption
    {
        string Encrypt(string password);
        string Decrypt(string password);
    }
}
