using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUI
{
    public interface IHasher
    {
         string GetHash(string password);
    }
}
