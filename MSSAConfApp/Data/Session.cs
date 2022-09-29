using System.Text.Json;
using System;
using System.Collections.Generic;

namespace MSSAConfApp.Data
{
    public partial class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Keyspeaker { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public int Seats { get; set; }
        public string Imageurl { get; set; }
        //public List<Speakers>[] Speakers { get; set; }



        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }


}
