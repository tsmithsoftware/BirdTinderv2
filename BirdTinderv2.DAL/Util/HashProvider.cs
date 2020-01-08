using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdTinder.API.Helpers
{
    public static class HashProvider
    {
        public static String sha256(String password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash; 
        }
    }
}
