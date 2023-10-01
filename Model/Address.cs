namespace StudentSOA.Model 
{
    internal class Address
    {
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? ZipCode { get; set; }

        public override string ToString()
        {
            return $"Street: {Street}, Number: {Number}, ZipCode: {ZipCode}";
        }
    }
}