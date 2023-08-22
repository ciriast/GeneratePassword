using System.Security.Cryptography;

namespace GeneratePassword
{
    public class GeneratePassword
    {
        public static string GenerateRandomPassword()
        {
            var bytesToRandomString = new byte[32];

            var something = RandomNumberGenerator.Create();

            return "";
        }       
    }
}