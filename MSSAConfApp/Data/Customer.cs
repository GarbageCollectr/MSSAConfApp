using System;
using System.Collections.Generic;

namespace MSSAConfApp.Data
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Event { get; set; }
    }
}
