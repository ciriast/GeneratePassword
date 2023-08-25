using System.Security.Cryptography;
using System.Text;

namespace GeneratePassword
{
    public class PasswordGenerator
    {
        // Create a random password of the specified length
        public static string RandomPassword(int length)
        {
            StringBuilder password = new StringBuilder();

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                foreach (byte randomByte in randomBytes)
                {
                    int randomIndex = randomByte % CharPool.ValidChars.Length;
                    password.Append(CharPool.ValidChars[randomIndex]);
                }
            }

            return password.ToString();
        }       
    }
}