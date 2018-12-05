using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork500px.Models
{
    public class Category
    {
        [Key]
        public virtual int CategoyId { get; set; }

        public virtual string Name { get; set; }

        // public virtual CategoryImageFile Image { get; set; }
    }
}
