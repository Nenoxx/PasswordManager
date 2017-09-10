using System;
using System.Collections.Generic;

namespace Pwd_Manager
{
    public class Domain : IComparable<Domain>
    {
        #region Members
        private string _description;
        private string _domain;
        private List<User> _listUser;
        #endregion

        #region Properties
        public string Description
        {
            get { return _description; }
            set { if (value != null) _description = value; }
        }

        public string Domaine
        {
            get { return _domain; }
            set { if (value != null) _domain = value; }
        }

        public List<User> ListUser
        {
            get { return _listUser; }
        }
        #endregion

        #region Constructors
        public Domain()
        {
            Description = "";
            Domaine = "";
            _listUser = new List<User>();
        }

        public Domain(string Dom)
        {
            if ((object)Dom != null)
            {
                Description = "";
                Domaine = Dom;
                _listUser = new List<User>();
            }
            else
                throw new Exception("ERROR : Bad domain - can't be empty");
        }

        public Domain(string Dom, string Desc)
        {
            if ((object)Dom != null)
            {
                if ((object)Desc != null)
                {
                    Description = Desc;
                    Domaine = Dom;
                    _listUser = new List<User>();
                }
                else
                    throw new Exception("ERROR : Bad description - can't be empty");
            }
            else
                throw new Exception("ERROR : Bad domain - can't be empty");
        }

        public Domain(params User[] tab)
        {
            _listUser = new List<User>();

            foreach (User element in tab)
            {
                if ((object)element != null)
                {
                    _listUser.Add(element);
                }
            }
        }
        #endregion

        #region Functions
        public void AddUser(string Nick, string Pwd)
        {
            User tmp = new User(Nick, Pwd);
            _listUser.Add(tmp);
        }

        public int CompareTo(Domain other)
        {
            return this.Domaine.CompareTo(other.Domaine);
        }
        #endregion
    }
}
