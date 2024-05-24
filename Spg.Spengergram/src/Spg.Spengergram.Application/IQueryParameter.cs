using Spg.Spengergram.DomainModel.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application
{
    public interface IQueryParameter
    {
        IUserFilterBuilder Compile(string queryParameter);
    }
}
