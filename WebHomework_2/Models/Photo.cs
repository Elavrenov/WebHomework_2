using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHomework_2.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        [Display(Name = "Thumb Path")]
        public string ThumbPath { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }
}