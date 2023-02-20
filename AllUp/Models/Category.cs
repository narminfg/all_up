using System.ComponentModel.DataAnnotations;

namespace AllUp.Models
{
    public class Category:BaseEntity
    {
        [StringLength(1000)]
        public string? Name { get; set; }
        [StringLength(1000)]
        public string? Image { get; set; }
        public bool IsMain { get; set; }
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
    }
}
