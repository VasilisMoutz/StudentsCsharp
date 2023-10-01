namespace StudentSOA.DTO
{
    internal class StudentDTO
    {
        public long Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public AddressDTO? StudentAddress { get; set; }
    }
}