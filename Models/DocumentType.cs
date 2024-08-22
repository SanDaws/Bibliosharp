using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models
{
    public class DocumentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abreviation { get; set; }

        public DocumentType(string name, string abreviation)
    {
        Name = name;
       Abreviation = abreviation;
    }
}
    }

    