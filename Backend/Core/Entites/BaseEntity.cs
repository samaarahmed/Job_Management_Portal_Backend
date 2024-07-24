using System.ComponentModel.DataAnnotations;

namespace Backend.Core.Entites
{
    public abstract class BaseEntity
    {
        [Key]
        public long ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } 
        public bool IsActive {  get; set; } = true;



    }
}
