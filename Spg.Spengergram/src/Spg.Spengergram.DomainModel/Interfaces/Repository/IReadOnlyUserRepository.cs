﻿using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IReadOnlyUserRepository : IReadOnlyRepository<User, IUserFilterBuilder>
    { }
}
