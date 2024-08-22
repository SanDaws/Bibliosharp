using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models;
public class Author : Person
{
    public Author(string firstName, string secondName, string firstLastName, string secondLastName) : base(firstName, secondName, firstLastName, secondLastName)
    { }
}
