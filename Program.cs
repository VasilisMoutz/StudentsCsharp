using StudentSOA.Model;
using StudentSOA.DTO;
using StudentSOA.Service;

namespace StudentSOA
{
    internal class StudentSOA
    {
        static void Main(string[] args)
        {
            //Create a Service Instance
            StudentService service = new();


            StudentDTO studentDTO = new() 
            {
                 Id = 1,
                 Firstname = "Bob",
                 Lastname = "Dylan"
            };

            AddressDTO addressDTO = new()
            {
                Street = "Volanaki",
                Number = "3",
                ZipCode = "11526"
            };

            StudentDTO student1DTO = new() 
            {
                 Id = 1,
                 Firstname = "BobY",
                 Lastname = "Dylan"
            };

            AddressDTO address1DTO = new()
            {
                Street = "Volanaki",
                Number = "3",
                ZipCode = "11526"
            };
            
            System.Console.WriteLine("\nTESTING :  ");

            studentDTO.StudentAddress = addressDTO;
            student1DTO.StudentAddress = address1DTO;

            System.Console.WriteLine("\nAttempting Insert");
            service.InsertStudent(studentDTO);
            System.Console.WriteLine(service.GetStudentInfo(1));

            System.Console.WriteLine("\nAttempting Update");
            service.UpdateStudent(1, student1DTO);
            System.Console.WriteLine(service.GetStudentInfo(1));

            System.Console.WriteLine("\nAttempting Update Error");
            service.UpdateStudent(2, student1DTO);

            System.Console.WriteLine("\nAttempting Delete");
            service.DeleteStudent(1);
        }
    }
}