using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MQ_Assign.Data
{
    public class Blog
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public Nullable<Guid> UserId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public System.DateTime DatePosted { get; set; }

        public virtual User User { get; set; }
    }
}
