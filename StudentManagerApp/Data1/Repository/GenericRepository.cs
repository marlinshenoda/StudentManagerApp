
namespace StudentManagerApp.Data1.Repository
{
    public class StudentService : IStudentService
    {
        private List<Student> _students = new();
        public List<Student> GetStudents() => _students;
        private int _nextId = 1;


        public void AddStudent(Student student)
        {
            student.Id = _nextId++;

            _students.Add(student);
        }

        public void DeleteStudent(string name)
        {
            _students.RemoveAll(s => s.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }



        public void SortByGrade()
        {
            _students = _students.OrderByDescending(s => s.Grade).ToList();
        }

        public void SortByName()
        {
            _students = _students.OrderBy(s => s.Name).ToList();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Grade = student.Grade;
            }
        }
    }
}
