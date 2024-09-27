namespace morizuq.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime UpdateTime {  get; set; } 
    }
}
