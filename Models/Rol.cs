using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models;

public class Rol
{
    public int Id { get; set; }
    public string RolName { get; set; }
    public Rol(string rolName)
    {
        RolName = rolName;
    }
}
