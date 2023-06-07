using System;
using System.Collections.Generic;

#nullable disable

namespace Products_Task.Models
{
    public partial class Producttbl
    {
        public int Sn { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
    }
}
