using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models;

    public class Category
    {
        public int Id { get; set; }
        public string RolName { get; set; }

        public Category(string rolName)
        {
            RolName= rolName;
        }
    }

