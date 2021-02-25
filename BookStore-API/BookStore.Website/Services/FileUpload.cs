using BlazorInputFile;
using BookStore.Website.Contracts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Website.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment environment;

        public FileUpload(IWebHostEnvironment env)
        {
            this.environment = env;
        }

        public async Task UploadFile(IFileListEntry file, string pictureName)
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    await file.Data.CopyToAsync(stream).ConfigureAwait(false);
                    var path = $"{environment.WebRootPath}\\uploads";

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        stream.WriteTo(fileStream);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
