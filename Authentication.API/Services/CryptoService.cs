using Authentication.API.Models.ModelsDto;
using Authentication.API.Repository.Contracts;
using Authentication.API.Repository.Entity;
using Authentication.API.Services.Contracts;
using System.Security.Cryptography;

namespace Authentication.API.Services
{
    public class CryptoService : ICryptoService
    {
        private const int saltSize = 16;
        private const int keySize = 32;
        private const int iterations = 10000;

        public async Task<string> HashPassword(AccountDto password)
        {
            return await Task.Run(() =>
            {
                using var algorithm = new Rfc2898DeriveBytes(password.Password, saltSize, iterations, HashAlgorithmName.SHA512);
                var key = Convert.ToBase64String(algorithm.GetBytes(keySize));
                var salt = Convert.ToBase64String(algorithm.Salt);

                return $"{iterations}.{salt}.{key}";
            });
        }

        public async Task<bool> Verify(AccountDto password, Account hashedPassword)
        {
            return await Task.Run(() =>
            {
                var parts = hashedPassword.Password.Split('.', 3);

                if (parts.Length != 3)
                    throw new FormatException("Unexpected hash format. " +
                                              "Should be formatted as `{iterations}.{salt}.{hash}`");

                var iterations = Convert.ToInt32(parts[0]);
                var salt = Convert.FromBase64String(parts[1]);
                var key = Convert.FromBase64String(parts[2]);

                using var algorithm = new Rfc2898DeriveBytes(password.Password, salt, iterations, HashAlgorithmName.SHA512);
                var keyToCheck = algorithm.GetBytes(keySize);

                return keyToCheck.SequenceEqual(key);
            });
        }
    }
}
