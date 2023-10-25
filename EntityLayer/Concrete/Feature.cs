﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FetureID { get; set; }
        public string Post1Name { get; set; }
        public string Description { get; set; }
        public string Post1Image { get; set; }
        public bool Status { get; set; }
    }
}
