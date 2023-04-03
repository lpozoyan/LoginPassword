using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoginPassword
{
    internal class AuthService
    {
        public bool IsValid(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                throw new System.ArgumentException("Логин или пароль пустые");
            }
            if (login == "adm" && password == "132")
            {
                return true;
            }
            else return false;
        }
    }
}
