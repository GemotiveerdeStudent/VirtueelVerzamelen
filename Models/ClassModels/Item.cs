using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtueelVerzamelen.Models.ClassModels
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? price { get; set; }  
        
        public User? User { get; set; }
        public Collection? Collection { get; set; }
        public int? UserId { get; set; }
        public int? CollectionId { get; set; }


        public Item()
        {

        }
    }
}
