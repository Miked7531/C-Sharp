using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L08HandsOn.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieTitle { get; set; }

        //model for uploaded files
        public string PlayMovie { get; set; }

        public bool TimesPlayed { get; set; }

        //these two are for a sql connection later on.
        public string Vname { get; set; }

        public string Vpath { get; set; }
    }
}
