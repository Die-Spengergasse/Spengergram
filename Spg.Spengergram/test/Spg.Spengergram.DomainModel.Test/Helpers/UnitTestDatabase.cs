﻿using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.Infrastructure;

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
