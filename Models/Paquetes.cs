﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Paquetes
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } 



    }
}
