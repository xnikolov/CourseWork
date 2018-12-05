using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork500px.Models
{
    public class Image
    {
        [Key]
        public virtual int ImageId { get; set; }

        public virtual string Name { get; set; }

        [Key]
        public virtual UserImageFile UserImage { get; set; }
        public virtual Category Category { get; set; }
        public virtual ApplicationUser UploadedBy { get; set; }
    }
}
