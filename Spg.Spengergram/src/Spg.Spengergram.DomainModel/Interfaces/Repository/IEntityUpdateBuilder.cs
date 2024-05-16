using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IEntityUpdateBuilder<TEntity>
        where TEntity : class
    {
        public TEntity Entity { get; set; }
        int Save();
    }
}
