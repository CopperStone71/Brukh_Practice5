using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashPassword
{
    public class Hash
    {
        public static class HashHelper
        {
            public static string HashPassword(string Password)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] soureBytePassw = Encoding.UTF8.GetBytes(Password);
                    byte[] hashSourceBytePassw = sha256Hash.ComputeHash(soureBytePassw);
                    string hashPassw = BitConverter.ToString(hashSourceBytePassw).Replace("-", String.Empty);
                    return hashPassw;
                }
            }

        }
    }
}
