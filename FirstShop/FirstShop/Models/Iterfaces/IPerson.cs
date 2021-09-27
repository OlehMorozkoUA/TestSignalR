using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Models.Iterfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
    }
}
