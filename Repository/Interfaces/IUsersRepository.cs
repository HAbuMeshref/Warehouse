﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IUsersRepository: IRepository<User>
    {

       public User GetByEmail(string email);
    }
}
