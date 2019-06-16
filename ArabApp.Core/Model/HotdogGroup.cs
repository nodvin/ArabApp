using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabApp.Core.Model
{
    public class HotdogGroup
    {
        public int HotdogGroupId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<Hotdog> Hotdogs { get; set; }
    }
}
