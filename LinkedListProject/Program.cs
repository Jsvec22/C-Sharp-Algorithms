namespace LinkedListProject
{
    using System;
    using System.Security.Cryptography;

    class Program
    {
        static void Main(string[] args)
        {
            AesManaged aes = new AesManaged();
            ICryptoTransform encrypter = aes.CreateEncryptor();
            Console.WriteLine("Hello World!");
            
        }
    }
}
