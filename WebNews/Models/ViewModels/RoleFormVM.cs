﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNews.Models.ViewModels
{
    public class RoleFormVM
    {
        [Required,StringLength(100)]
        public string Name { get; set; }
    }
}
