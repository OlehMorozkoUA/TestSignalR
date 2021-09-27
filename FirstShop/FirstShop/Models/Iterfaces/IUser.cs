using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Models.Iterfaces
{
    public interface IUser
    {
        string Login { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        Status Status { get; set; }
    }

    public enum Status
    {
        User,
        Admin
    }
}
