using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Stock
{
    public static class ProductionRandomValidator
    {
        public static bool ValidateSerialKeyWithGUID(string guid_serialKey,string guid_ActivationKey)
        {
            byte[] guid_Hash_byte = GenerateSaltedHash(guid_serialKey);
            byte[] db_guid_Hash_byte = Convert.FromBase64String(guid_ActivationKey);
            //byte[] db_guid_Hash_byte = GenerateSaltedHash(db_guid_serialKey);

            return guid_Hash_byte.SequenceEqual(db_guid_Hash_byte);
        }
        public static string GenerateSerialKeyWithGUID(string guid_serialKey)
        {
            return Convert.ToBase64String(GenerateSaltedHash(guid_serialKey));
        }

        private static byte[] GenerateSaltedHash(string GUID_Serial)
        {
            byte[] plainText = Encoding.UTF8.GetBytes(GUID_Serial);
            byte[] salt = Encoding.UTF8.GetBytes("CM_Tech@4525555#^Tech%Telco%2092");
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

    }
}
