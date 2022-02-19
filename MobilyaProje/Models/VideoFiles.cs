using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class VideoFiles
    {
        public int id { get; set; }
        public string Resim { get; set; }
        public Nullable<int> FileBoyut { get; set; }
        public string Media { get; set; }
    }
}
