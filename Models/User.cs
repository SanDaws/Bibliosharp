using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models
{
    public class User : Person
    {
        //Attributes
        public int Rol;
        private int DocumentType;
        private string DocumentNumber;
        private string Address;
        private string Phone;
        private string Email;
        private string Password;
        //constructors 
        public User(string firstName, string secondName, string firstLastName, string secondLastName,string addres, string phone,string email, string password ,Rol Rol,DocumentType DocumentType ) 
        : base(firstName, secondName, firstLastName, secondLastName)
        {
            //this.Rol= Rol.Id;
            this.DocumentType= DocumentType.Id;
            Address=addres;
            Phone=phone;
            Email=email;
            Password=password;
        }
        public User(string firstName, string secondName, string firstLastName, string secondLastName,string addres, string phone,string email, string password ,int rol,int documentType ) 
        : base(firstName, secondName, firstLastName, secondLastName)
        {
            this.Rol= rol;
            this.DocumentType= documentType;
            Address=addres;
            Phone=phone;
            Email=email;
            Password=password;
        }
    }
}