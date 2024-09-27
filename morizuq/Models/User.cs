namespace morizuq.Models
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
        public int PhoneNumber { get; set; }
    }
}
