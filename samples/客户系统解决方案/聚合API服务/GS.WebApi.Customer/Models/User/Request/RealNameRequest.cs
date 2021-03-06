﻿using System.ComponentModel.DataAnnotations;

namespace Sikiro.WebApi.Customer.Models.User.Request
{
    public class RealNameRequest
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string RealName { get; set; }
    }
}
