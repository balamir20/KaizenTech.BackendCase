using System.Security.Cryptography;
using System.Text;

namespace QuestionOne.CouponGenerator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            FirstStep();
        }
        private static void FirstStep()
        {
            Console.WriteLine("What do you want to do? (G/C/E)");
            Console.WriteLine("     G: Generate New Coupon Code");
            Console.WriteLine("     C: Check code is valid");
            Console.WriteLine("     E: Exit.");
            var mainChoice = Console.ReadLine();
            switch (mainChoice?.ToLower())
            {
                case "g":
                    ChoiceCouponType();
                    break;

                case "c":
                    Console.WriteLine("Checking...");
                    CheckCouponIsValid();
                    Console.WriteLine("Check finished.");
                    break;

                case "e":
                    return;

                default:
                    Console.WriteLine("Please enter a valid choice...");
                    FirstStep();
                    break;
            }
        }
        private static void ChoiceCouponType()
        {
            Console.WriteLine("Please select the type you want to generate");
            Console.WriteLine("     1: Android/IOS");
            Console.WriteLine("     2: SMS");
            Console.WriteLine("     3: WEB");
            Console.WriteLine("     4: IVR");
            var choiceCouponType = Console.ReadLine();
            switch (choiceCouponType?.ToLower())
            {
                case "1":
                    GenerateCouponCode("App");
                    break;
                case "2":
                    GenerateCouponCode("Sms");
                    break;
                case "3":
                    GenerateCouponCode("Web");
                    break;
                case "4":
                    GenerateCouponCode("Ivr");
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice...");
                    ChoiceCouponType();
                    break;
            }
        }

        private static void GenerateCouponCode(string couponType)
        {
            Console.WriteLine("Generating...");
            int maxSize = 7;
            for (int i = 0; i < 10000; i++)
            {
                string characters = "ACDEFGHKLMNPRTXYZ234579";
                char[]? chars = characters.ToCharArray();
                int size = maxSize;
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new();
                crypto.GetNonZeroBytes(data);
                data = new byte[size];
                crypto.GetNonZeroBytes(data);
                StringBuilder result = new(size);
                foreach (byte b in data)
                {
                    result.Append(chars[b % 23]);
                }
                
                var generatedCouponCode = string.Concat(couponType.ToString().ToUpper().Substring(0, 1), result.ToString().ToUpper());
                Console.WriteLine(generatedCouponCode);
                var encryptedCoupon = EncryptString(generatedCouponCode);
                Console.WriteLine("The coupon is encrypted " + encryptedCoupon);
                var decryptedCoupon = DecryptString(encryptedCoupon);
                Console.WriteLine("The coupon is decrypted " + decryptedCoupon);

            }
            Console.WriteLine("Coupons are generated.");
        }

        private static string EncryptString(string generatedCouponCode)
        {
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("!Muhammet_Balamir-@Encrypt_keY#?");
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using MemoryStream memoryStream = new();
                using CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write);
                using (StreamWriter streamWriter = new(cryptoStream))
                {
                    streamWriter.Write(generatedCouponCode);
                }
                array = memoryStream.ToArray();
            }
            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string encryptedCoupon)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(encryptedCoupon);
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes("!Muhammet_Balamir-@Encrypt_keY#?");
            aes.IV = iv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using MemoryStream memoryStream = new(buffer);
            using CryptoStream cryptoStream = new(memoryStream, decryptor, CryptoStreamMode.Read);
            using StreamReader streamReader = new(cryptoStream);
            return streamReader.ReadToEnd();
        }

        private static void CheckCouponIsValid()
        {
            Console.WriteLine();
        }
    }
}