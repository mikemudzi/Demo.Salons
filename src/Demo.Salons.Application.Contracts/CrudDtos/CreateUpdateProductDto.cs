using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateProductDto
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
    }
}
