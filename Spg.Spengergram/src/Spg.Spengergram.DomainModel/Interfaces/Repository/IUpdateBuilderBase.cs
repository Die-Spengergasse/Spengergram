using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IUpdateBuilderBase<TEntity, TUpdateBuilder>
            where TEntity : class
            where TUpdateBuilder : class
    {
        TUpdateBuilder WithEntity(TEntity photo);
    }
}
