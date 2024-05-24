﻿using Spg.Spengergram.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IReadOnlyUserRepository : IReadOnlyRepository<User, IUserFilterBuilder>
    { }
}
