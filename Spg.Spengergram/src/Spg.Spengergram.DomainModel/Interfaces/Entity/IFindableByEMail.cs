using Spg.Spengergram.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Interfaces.Entity
{
    public interface IFindableByEMail
    {
        public EMailAddress EMailAddress { get; }
    }
}
