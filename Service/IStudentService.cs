using StudentSOA.DTO;
using StudentSOA.Model;
namespace StudentSOA.Service
{
    internal interface IStudentService
    {
        public void InsertStudent(StudentDTO studentDTO);
        public void UpdateStudent(long id, StudentDTO studentDTO);
        public void DeleteStudent(long id);
        public string GetStudentInfo(long id);

    }
}