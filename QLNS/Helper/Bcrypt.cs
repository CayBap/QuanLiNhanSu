using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace QLNS.Helper
{
    public class Bcrypt
    {
        public string HashPass(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] a = md5.Hash;
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < a.Length; i++)
            {
                str.Append(a[i].ToString("X2"));
            }
            return str.ToString(); 
        }
    }
}
