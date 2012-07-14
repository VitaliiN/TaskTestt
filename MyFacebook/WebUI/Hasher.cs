using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Cryptography;
using System.Security;

namespace WebUI
{
    public class Hasher : IHasher
    {
        private readonly HashAlgorithm hasher = new SHA1CryptoServiceProvider();
        public string GetHash(string password)
        {
            StringBuilder stringBuilder = new StringBuilder();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] hash;
            hash = hasher.ComputeHash(enc.GetBytes(password));

            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("x2"));
            }
            return stringBuilder.ToString();

        }
    }
}