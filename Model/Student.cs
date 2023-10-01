namespace StudentSOA.Model
{
    internal class Student
    {
        public long Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address? StudentAddress { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {Firstname}, Lastname: {Lastname}\nAddress: {StudentAddress}";
        }

    }
}