using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace nianemisArtSite.Services
{
    public interface IImagesService
    {
        Task<IEnumerable<string>> GetImageListAsync(string directory);

        Task<byte[]> GetImageAsync(string dir, string name);
    }
}
