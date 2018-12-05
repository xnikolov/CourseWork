using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseWork500px.Models
{
    public abstract class File
    {
        public virtual int FieldId { get; set; }

        public virtual string FileName { get; set; }
        public virtual string ContentType { get; set; }
        public virtual byte[] Content { get; set; }
    }

    public class CategoryImageFile : File { }
    public class UserImageFile : File { }



}
