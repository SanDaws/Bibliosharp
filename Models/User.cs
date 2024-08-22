using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models
{
    public class User : Person
    {
        public int Rol;
        private int DocumentType;
        private string DocumentNumber;
        private string address;
        private string phone;
        private string email;
        private string password;
        public User(string firstName, string secondName, string firstLastName, string secondLastName,string addres, string phone,string email, string password ,Rol Rol,DocumentType DocumentType ) 
        : base(firstName, secondName, firstLastName, secondLastName)
        {
            this.Rol= Rol.Id;
            
        }
    }
}