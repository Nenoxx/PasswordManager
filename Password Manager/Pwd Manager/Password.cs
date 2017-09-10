using System;
using System.Text;

namespace Pwd_Manager
{
    public class Password
    {
        private string _password;

        public string Pwd
        {
            get { return _password; }
            set { if (value != null) _password = value; }
        }

        public Password(int length)
        {
            Pwd = CreateRandomPassword(length);
        }

        public string CreateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ012345678&éè!çà@#";
            StringBuilder res = new StringBuilder();
            Random Rand = new Random();

            while (length > 0)
            {
                res.Append(validChars[Rand.Next(validChars.Length)]);
                length--;
            }

            return res.ToString();
        }
    }
}
