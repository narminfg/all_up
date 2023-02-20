using System.ComponentModel.DataAnnotations;

namespace AllUp.Models
{
    public class Tag:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
