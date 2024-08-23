using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models
{
    public abstract class Person
    {
        
        public int Id;
        public string FirstName;
        public string SecondName;
        public string FirstLastName;
        public string SecondLastName;

        public Person(string FirstName,string SecondName,string FirstLastName,string SecondLastName){
            this.FirstName=FirstName;
            this.SecondName=SecondName;
            this.FirstLastName=FirstLastName;
            this.SecondLastName=SecondLastName;
        }
    }
}