using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Pixeval.AutoUpdater
{
    public static class Cipher
    {
        public static string Checksum<T>(this Stream stream) where T : HashAlgorithm, new()
        {
            using var crypt = new T(); 
            var hashBytes = crypt.ComputeHash(stream);
            stream.Position = 0L;
            return hashBytes.Select(b => b.ToString("x2")).Aggregate((s1, s2) => s1 + s2);
        }
    }
}