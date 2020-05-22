using nianemisArtSite.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace nianemisArtSite.Services
{
    public class ImagesService : IImagesService
    {
        private readonly IConfigContent _configContent;

        public ImagesService(IConfigContent configContent)
        {
            _configContent = configContent;
        }

        public async Task<byte[]> GetImageAsync(string dir, string name)
        {
            switch(dir.ToLower())
            {
                case "about":
                    using (var file = File.ReadAllBytesAsync(_configContent.About + "\\" + name))
                    {
                        return await file;
                    }
                case "drawings":
                    using (var file = File.ReadAllBytesAsync(_configContent.Drawings + "\\" + name))
                    {
                        return await file;
                    }
                case "digital":
                    using (var file = File.ReadAllBytesAsync(_configContent.Digital + "\\" + name))
                    {
                        return await file;
                    }
                default:
                    throw new NotImplementedException();
            }
        }

        public async Task<byte[]> GetImagePreviewAsync(string dir, string name, int number)
        {

            switch (dir.ToLower())
            {
                case "drawings":
                    using (var file = File.ReadAllBytesAsync(_configContent.Drawings + "\\"+ number.ToString()+ "\\" + name))
                    {
                        return await file;
                    }
                case "digital":
                    using (var file = File.ReadAllBytesAsync(_configContent.Digital + "\\" + number.ToString() + "\\" + name))
                    {
                        return await file;
                    }
                default:
                    throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<string>> GetImageListAsync(string directory)
        {
            await Task.CompletedTask;
            switch(directory.ToLower())
            {
                case "about":
                    return Directory.EnumerateFiles(_configContent.About).Select( x => x.Substring(_configContent.About.Length + 1));
                case "drawings":
                    return Directory.EnumerateFiles(_configContent.Drawings).Select(x => x.Substring(_configContent.Drawings.Length + 1));
                case "digital":
                    return Directory.EnumerateFiles(_configContent.Digital).Select(x => x.Substring(_configContent.Digital.Length + 1));
                default:
                    throw new NotImplementedException();
            }
             
        }


    }
}
