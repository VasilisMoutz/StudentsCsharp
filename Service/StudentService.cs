using StudentSOA.Model;
using StudentSOA.DTO;
using StudentSOA.DAO;
namespace StudentSOA.Service
{
    internal class StudentService : IStudentService
    {
        StudentDAO dao = new();
        /// <summary>
        /// Create a Student Object With DTO'S info
        /// Send it through the DAO to Database.
        /// </summary>
        /// <param name="studentDTO">Student Data</param>
        /// <returns>True if insertion was successfull, False otherwise</returns>
        public void InsertStudent(StudentDTO studentDTO)
        {
            //Check Null Reference for studentDTO
            if (studentDTO == null) return;

            //Check Student's ID originality
            if (dao.StudentExists(studentDTO.Id))
            {
                System.Console.WriteLine($"Could not insert, User with id {studentDTO.Id} already exist's");
                return;
            }
            
            //Create a student Instance and map DTO's info to it.
            Student student = new();
            MapStudent(student, studentDTO);
            
            //Insert Student 
            dao.Insert(student);
            System.Console.WriteLine("Successful Insert");
        }

        public void UpdateStudent(long id, StudentDTO studentDTO)
        {
            //Check Null Reference for studentDTO
            if (studentDTO == null) return;

            //Check that the given id and the DTO's id are a match
            if (id != studentDTO.Id)
            {
                System.Console.WriteLine("Id to update must be the same with given Student..");
                return;
            }

            //Student must exist to update
            if (!dao.StudentExists(studentDTO.Id))
            {
                System.Console.WriteLine("Could not find student to update..");
                return;
            } 
            
            //Map student
            Student student = new();
            MapStudent(student, studentDTO);

            dao.Update(id, student);
            System.Console.WriteLine("Successful Update");
        }

        public void DeleteStudent(long id)
        {
            //A student must exist in order to be deleted
            if (!dao.StudentExists(id))
            {
                System.Console.WriteLine("Student must exist in order to be deleted..");
            }

            dao.Delete(id);
            System.Console.WriteLine("Successful Delete");
        }

        public string GetStudentInfo(long id)
        {
            return dao.GetStudent(id);
        }

        private void MapStudent(Student student, StudentDTO studentDTO)
        {
            //Map Basic Info
            student.Id = studentDTO.Id;
            student.Firstname = studentDTO.Firstname;
            student.Lastname = studentDTO.Lastname;
            
            //Map Address if any
            if (studentDTO.StudentAddress != null)
            {
                Address address = new() 
                {
                    Street = studentDTO.StudentAddress.Street,
                    Number = studentDTO.StudentAddress.Number,
                    ZipCode = studentDTO.StudentAddress.ZipCode
                };
                //Append to student Object
                student.StudentAddress = address;
            }
        }
    }
}