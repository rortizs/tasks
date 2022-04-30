using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.API.Data.Entities
{
    public class Note
    {
        public int id { get; set; }
        public bool isImportant { get; set; }
        public int number { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage ="This {0} is required")]
        public string title { get; set; }

        [Display(Name ="Description")]
        [RegularExpression(@"[a-zA-]", ErrorMessage ="Error")]
        [Required(ErrorMessage ="This {0} is required")]
        [MaxLength(20, ErrorMessage ="The field canot have more than {0}20 characters ")]
        public string description { get; set; }
        public DateTime createdTime { get; set; }
    }
}
