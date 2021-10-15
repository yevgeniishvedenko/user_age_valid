using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    [Validation(18)]
    public class User
    {
        [Required]
        [StringLength(50, MinimumLength=3)]
        public string Name { get; set; }
        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

    }
}