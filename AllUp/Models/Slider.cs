using System.ComponentModel.DataAnnotations;

namespace AllUp.Models
{
    public class Slider: BaseEntity
    {
        [StringLength(1000)]
        public string SubTitle { get; set; }
        [StringLength(1000)]
        public string MainTitle { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Link { get; set; }
        [StringLength(1000)]
        public string  Image { get; set; }
    }
}
