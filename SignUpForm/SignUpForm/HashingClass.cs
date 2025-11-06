using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SignUpForm
{
    class HashingClass
    {

        public static string getHashedPassword(string password)
        {
            string HashedPass = ComputeSha256Hash(password); // calls the hashing method and returns the hashed password .


            return HashedPass; // Returns the hashed password to anywhere it called this method .
        }


        private  static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create()) // Creating an object from this kind of hashing .
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData)); // sending the password and change it to bytes and assign to array of bytes .

                StringBuilder builder = new StringBuilder(); // Creating a string builder object 

                foreach (byte b in bytes) // it is used to make one counter goes through the array of bytes 
                    builder.Append(b.ToString("x2")); // and every time it appends the single byte (x2) .

                return builder.ToString(); // then converting the string builder to a normal string and return it .
            }
        }
    }
}
