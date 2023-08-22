using System.Security.Cryptography;
using System.Text;

namespace GeneratePassword
{
    public class GeneratePassword
    {
        public static string GenerateRandomPassword()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var bytesToRandomString = new byte[32];

            var something = RandomNumberGenerator.Create();

            return "";
        }       
    }
}