using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Test.Helpers
{
    public class UnitTestDatabase : SqLiteDatabase
    {
        public UnitTestDatabase()
            : base()
        { }
        public UnitTestDatabase(DbContextOptions options)
            : base(options)
        { }

    }
}
