namespace VirtueelVerzamelen.Models.ClassModels
{
    public class Collection
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        
        public User? UserUser { get; set; }
        public virtual ICollection<Item>? Items { get; set; }

    }
}
