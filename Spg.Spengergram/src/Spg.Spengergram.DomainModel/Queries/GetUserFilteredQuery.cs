using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Queries
{
    public record GetUserFilteredQuery(string? Filter = null, string? Order = null, int? Page = null, int? Size = null);
}
