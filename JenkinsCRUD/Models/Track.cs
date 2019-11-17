using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JenkinsCRUD.Models
{
    public class Track
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Price { get; set; }

        public string Genre { get; set; }
    }
}
