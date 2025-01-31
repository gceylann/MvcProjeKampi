﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiyLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriteSurname { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }


        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents{ get; set; }

    }
}
