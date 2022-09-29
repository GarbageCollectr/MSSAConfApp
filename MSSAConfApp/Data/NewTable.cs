using System;
using System.Collections.Generic;

namespace MSSAConfApp.Data
{
    public partial class NewTable
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Location { get; set; }
        public string? Keyspeaker { get; set; }
        public string? Track1 { get; set; }
        public string? Track2 { get; set; }
        public int? Seats { get; set; }
        public string? Imageurl { get; set; }
    }
}
