using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Model
{
    public class Invitation
    {
        public int Id { get; set; }
        public User From { get; set; } = default!;
        public User To { get; set; } = default!;
        public DateTime CreationDateTime { get; set; }
    }
}
