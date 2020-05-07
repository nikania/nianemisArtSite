using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nianemisArtSite.Config
{
    public interface IConfigContent
    {
        string Drawings { get; }
        string Digital { get; }
        string About { get; }


    }
}
