using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Interfaces
{
    public interface IAddress
    {
        Address Address { get; set; }
    }
}
