using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Blog 

                var st = new Student  { StudentName = "Farheen" };
                db.Students.Add(st);
                db.SaveChanges();

            }
        }

    }
}
