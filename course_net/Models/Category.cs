using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace course_net.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Need name")]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Number not acceptable")]
        public int DisplayOrder { get; set; }
    }
}