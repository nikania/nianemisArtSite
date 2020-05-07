using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nianemisArtSite.Config
{
    public class ConfigContent : IConfigContent
    {
        public string Drawings { get; set; }

        public string Digital { get; set; }

        public string About { get; set; }
    }
}
