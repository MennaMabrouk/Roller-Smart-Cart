﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart.Application.Dto.Product
{
    public class RemoveOfferDto
    {
        [Required]
        public int ProductId { get; set; }

    }
}
