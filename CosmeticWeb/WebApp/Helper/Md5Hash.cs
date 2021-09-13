using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApp.Helper
{
    public class Md5Hash
    {
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            //Convert the input string to byte array and compute the hash
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //Create a new Stringbulder to collect the bytes
            //and create a string
            StringBuilder sBuilder = new StringBuilder();

            //Loop through each byte of hashed data
            //and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //return the hexadecimal string
            return sBuilder.ToString();
        }

    }
}