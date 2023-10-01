using StudentSOA.Model;
namespace StudentSOA.DAO
{
    internal interface IStudentDAO
    {
        public void Insert(Student student);
        public void Update(long key, Student student);
        public void Delete(long key);
        public string GetStudent(long key);
        public bool StudentExists(long key);
    }
}