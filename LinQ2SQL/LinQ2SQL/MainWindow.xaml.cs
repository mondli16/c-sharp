using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using LinQ2SQL.PanjutorialsDBDataSetTableAdapters;

namespace LinQ2SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        linq2SQLDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinQ2SQL.Properties.Settings.PanjutorialsDBConnectionString"].ConnectionString;
            dataContext = new linq2SQLDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudets();
            //InsertLectures();
            //InsertStudentLectureAssociactions();
            //GetUniversityofTonie();
            //GetUniversityfromTonie();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithFemales();
            //GetLecturestaughtInDut();
            //UpdateToni();
            DeleteJames();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);
            University dut = new University();
            dut.Name = "Durban University of Technology";
            dataContext.Universities.InsertOnSubmit(dut);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudets()
        {
            University yale = dataContext.Universities.First(un=>un.Name.Equals("Yale"));
            University dut = dataContext.Universities.First(un => un.Name.Equals("Durban University of Technology"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "male", University = yale });
            students.Add(new Student { Name = "Leyla", Gender = "female", University = dut });
            students.Add(new Student { Name = "James", Gender = "male", University = dut });
            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "History" }); 
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociactions()
        {
            Student Carla = dataContext.Students.First(st=> st.Name.Equals("Carla"));
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            Student Leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student James = dataContext.Students.First(st => st.Name.Equals("James"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture() {Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture() { Student = Tonie, Lecture = Math });
            
            StudentLecture slToni = new StudentLecture();
            slToni.Student = Tonie;
            slToni.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture() { Student = Leyla, Lecture = History });
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityofTonie()
        {
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            University Toni =  Tonie.University;
            List<University> universities = new List<University>();
            universities.Add(Toni);
            MainDataGrid.ItemsSource = universities;

        }

        public void GetUniversityfromTonie()
        {
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            var tonilecture = from sl in Tonie.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonilecture;

        }

        public void GetAllStudentsFromYale()
        {
            var studentsfromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsfromYale;

        }

        public void GetAllUniversitiesWithFemales()
        { 
            var femaleuni = from student in dataContext.Students
                             join university in dataContext.Universities
                             on student.University equals university
                             where student.Gender == "female"
                             select university;
            MainDataGrid.ItemsSource = femaleuni;
        }
        public void GetLecturestaughtInDut()
        {
            var lecturedut = from sl in dataContext.StudentLectures
                            join student in dataContext.Students
                            on sl.StudentId equals student.Id
                            where student.University.Name == "Durban University of Technology"
                             select sl.Lecture;
            MainDataGrid.ItemsSource = lecturedut;
        }

        public void UpdateToni()
        {
            Student Tonie = dataContext.Students.FirstOrDefault(st => st.Name.Equals("Tonie"));
            Tonie.Name = "Anthony";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void DeleteJames()
        {
            Student Jame = dataContext.Students.FirstOrDefault(st => st.Name=="James");
            dataContext.Students.DeleteOnSubmit(Jame);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
        
    }
}
