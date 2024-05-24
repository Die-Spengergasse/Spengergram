using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IReadOnlyRepository<TEntity, TFilterBilder>
        where TEntity : class
        where TFilterBilder : IEntityFilterBuilder<TEntity>
    {
        TFilterBilder FilterBuilder { get; set; }
    }
}
