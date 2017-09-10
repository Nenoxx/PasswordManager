using System;

namespace Pwd_Manager
{
    public class User
    {
        #region Members
        private string _nickname;
        private string _password;
        #endregion

        #region Properties
        public string Nickname
        {
            get { return _nickname; }
            set { if (value != null) _nickname = value; }
        }

        public string Password
        {
            get { return _password; }
            set { if (value != null) _password = value; }
        }
        #endregion

        #region Constructors
        public User()
        {
            Nickname = "default";
            Password = "default";
        }

        public User(string Nck, string Pwd)
        {
            if ((object)Nck != null)
            {
                if ((object)Pwd != null)
                {
                    Nickname = Nck;
                    Password = Pwd;
                }
                else
                    throw new Exception("ERROR : Bad password");
            }
            else
                throw new Exception("ERROR : Bad nickname");
        }
        #endregion

        #region Functions
        public override string ToString()
        {
            return Nickname + ";" + Password;
        }
        #endregion
    }

}
