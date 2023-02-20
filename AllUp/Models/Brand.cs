using System.ComponentModel.DataAnnotations;

namespace AllUp.Models
{
    public class Brand:BaseEntity
    {
        [StringLength(1000)]
        public string Name { get; set; }
    }
}
