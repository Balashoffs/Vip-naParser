using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VipassanaParser
{
    class ConnectConfig
    {
        public string Login { get { return login; } }
        private string login;
        public string Password { get { return password; } }
        private string password;
        public readonly string calmURL;

        public ConnectConfig(string login, string password)
        {
            this.login = login;
            this.password = password;
            calmURL = @"https://calm.dhamma.org";
        }

        public bool CheckConnectTOCalm()
        {
            bool isCheck = false;
            


            return isCheck;
        }
    }
}
