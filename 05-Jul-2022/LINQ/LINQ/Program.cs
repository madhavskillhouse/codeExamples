
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {

             new Student { Branch = "Computer Science", CollegeName = "SIT", Id = 1, Name = "VRAJ" },

             new Student { Branch = "Computer Science", CollegeName = "SIT", Id = 2, Name = "Ganesh" },

             new Student { Branch = "Computer Science", CollegeName = "SIT", Id = 3, Name = "Hemanth" },

             new Student { Branch = "Computer Science", CollegeName = "SIT", Id = 4, Name = "Bharathesh" },

             new Student { Branch = "E&C", CollegeName = "SIT", Id = 5, Name = "Harish" },

             new Student { Branch = "E&C", CollegeName = "SIT", Id = 6, Name = "Navneeth" },

             new Student { Branch = "Computer Science", CollegeName = "PACE", Id = 1, Name = "George" },
        };

            var csStudents = (from student in students
                             where student.Branch == "Computer Science" && student.CollegeName =="SIT"
                             select student).ToList();

            var sitStudents= from student in students
                             where student.CollegeName=="SIT"
                             select student;

            var ecStudents = from student in students
                             where student.Branch == "E&C" && student.CollegeName == "SIT"
                             select student;

            var paStudents= from student in students
                            where student.Branch == "Computer Science" && (student.CollegeName == "PACE" || student.CollegeName == "SIT")
                            select student;


            var csStudentsLambda = students.Where(student => student.Branch == "Computer Science" && student.CollegeName == "SIT");
            
            bool checkStJoseph = students.Where(st => st.CollegeName == "ST Joseph").Count() > 0;

            bool checkStJoseph1 = students.Any(st => st.CollegeName == "ST Joseph");

            var std = students.Where(std=> std.Id == 1).SingleOrDefault();

            students.SingleOrDefault(std => std.Id == 1);

            var std1 = students.Where(std => std.Id == 1).FirstOrDefault();
            students.FirstOrDefault(a => a.Id == 1);

            students.All(a => a.CollegeName == "SIT");


        }
    }
}
