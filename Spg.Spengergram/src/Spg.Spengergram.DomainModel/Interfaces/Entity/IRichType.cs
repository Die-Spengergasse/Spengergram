using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Entity
{
    public interface IRichType<TId>
    {
        public TId Value { get; }
    }
}
