﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.Tests.TestClasses
{
    /// <summary>
    /// TestDbContext
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class TestDbContext: DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDbContext"/> class.
        /// </summary>
        public TestDbContext()
            : base("TestDb")
        {
        }

        /// <summary>
        /// Gets or sets the test datas.
        /// </summary>
        /// <value>
        /// The test datas.
        /// </value>
        public DbSet<TestData> TestDatas { get; set; }
    }
}
