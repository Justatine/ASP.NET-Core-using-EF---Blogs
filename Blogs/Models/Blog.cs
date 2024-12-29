using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogs.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="nvarchar(50)")]
        [DisplayName("Title")]
        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }
        [DisplayName("Content")]
        [Column(TypeName = "text")]
        [Required(ErrorMessage ="This field is required")]
        public string Content{ get; set; }
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy hh:mm:ss tt}")]
        public DateTime Timestamp { get; set; }
    }
}
