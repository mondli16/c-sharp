using System.Runtime.CompilerServices;

namespace LINQToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudent();
            um.FemaleStudent();
            um.SortStudentByAge();
            um.AllStudentsFromBeijingTech();
            um.InputUniversityId();
            um.StudentAndUniversityNameCOllection();

            Console.ReadKey();
        }
        class UniversityManager
        {
            public List<University> universities = new List<University>();
            public List<Student> students = new List<Student>(); 

            public UniversityManager()
            {
                universities.Add(new University{ Id = 1, Name = "Yale" });
                universities.Add(new University { Id = 2, Name = "Beijing Tech" });

                students.Add(new Student { Id = 1, Name="Carla", Gender = "female", Age = 17, UniversityId = 1 });
                students.Add(new Student { Id = 2, Name="Toni", Gender = "male", Age = 21, UniversityId = 1 });
                students.Add(new Student { Id = 3, Name="Leyla", Gender = "female", Age = 19, UniversityId = 2 });
                students.Add(new Student { Id = 4, Name="James", Gender = "male", Age = 25, UniversityId =2 });
                students.Add(new Student { Id = 5, Name ="Linda", Gender = "female", Age = 22, UniversityId = 2 });
            }

            public void MaleStudent()
            {
                IEnumerable<Student>  maleStudents = from student in students where student.Gender == "male" select student;
                Console.WriteLine("Male Student");
                foreach (Student student in maleStudents)
                {
                    student.Print();
                }
            }

            public void FemaleStudent()
            {
                IEnumerable<Student> maleStudents = from student in students where student.Gender == "female" select student;
                Console.WriteLine("female Student");
                foreach (Student student in maleStudents)
                {
                    student.Print();
                }
            }

            public void SortStudentByAge()
            {
                var sortedStudents = from student in students orderby student.Age select student;

                Console.WriteLine("Student Sorted by age:");

                foreach (var item in sortedStudents)
                {
                    item.Print();
                }
            }

            public void AllStudentsFromBeijingTech()
            {
                IEnumerable<Student> bjtStudents = from student in students
                                                   join university in universities on student.UniversityId equals university.Id
                                                   where university.Name == "Beijing Tech"
                                                   select student;
                Console.WriteLine("Beijing Tech Student");
                foreach (Student student in bjtStudents)
                {
                    student.Print();
                }
            }

            
            public void InputUniversityId()
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());

                IEnumerable<Student> bjtStudents = from student in students
                                                   where student.UniversityId == input
                                                   select student;
                var uniName = (from university in universities
                              where university.Id == input
                              select university.Name).SingleOrDefault();

                
                    Console.WriteLine($"{uniName} Students");
                    foreach (Student student in bjtStudents)
                    {
                        student.Print();
                    }
                }
                catch
                {
                    Console.WriteLine("Not a valid number");
                }
                
            }

            public void StudentAndUniversityNameCOllection()
            {
                var newCollection = from student in students
                                    join university in universities on student.UniversityId equals university.Id
                                    orderby student.Name
                                    select new { StudentName = student.Name, UniversityName = university.Name };

                Console.WriteLine($"New Collection");
                foreach (var student in newCollection)
                {
                    Console.WriteLine("Student {0} from University {1}",student.StudentName, student.UniversityName );
                }
            }
        }
        class University
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Print()
            {
                Console.WriteLine("University {0} student number {1}", Name, Id);
            }

        }
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Gender { get; set; }

            public int Age { get; set; }

            public int UniversityId { get; set; }

            public void Print()
            {
                Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from the university with the Id {4}", Name, Id, Gender, Age, UniversityId);
            }
        }
    }
}
