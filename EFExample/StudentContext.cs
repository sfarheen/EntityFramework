﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base("name=SchoolDBConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        //public DbSet<Standard> Standards { get; set; }
    }
}
