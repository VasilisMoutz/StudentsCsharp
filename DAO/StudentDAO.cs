using System.Collections.Generic;
using StudentSOA.Model;
namespace StudentSOA.DAO
{
    internal class StudentDAO : IStudentDAO
    {
        Dictionary<long, Student> studentsDB = new Dictionary<long, Student>();

        public void Insert(Student student)
        {
            long key = student.Id;
            studentsDB.Add(key, student);
        }

        public void Update(long key, Student student)
        {
            studentsDB[key] = student;
        }

        public void Delete(long key)
        {
            studentsDB.Remove(key);
        }

        public string GetStudent(long key)
        {
            return studentsDB[key].ToString();
        }

        public bool StudentExists(long key)
        {
            if (studentsDB.ContainsKey(key)) 
                return true;
            else
                return false;
        }



    }
}