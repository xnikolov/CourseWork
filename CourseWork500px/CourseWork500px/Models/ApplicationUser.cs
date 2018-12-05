using System.ComponentModel.DataAnnotations;

namespace CourseWork500px.Models
{
    public class ApplicationUser
    {
        [Key]
        public virtual int UserId { get; set; }
    }
}