﻿using BlazorInputFile;
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
            environment = env;
        }

        public void RemoveFile(string picName)
        {
            var path = $"{environment.WebRootPath}\\uploads\\{picName}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task UploadFile(IFileListEntry file, string picName)
        {
            try
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);

                var path = $"{environment.WebRootPath}\\uploads\\{picName}";

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    ms.WriteTo(fs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UploadFile(IFileListEntry file, MemoryStream msFile, string picName)
        {
            try
            {
                var path = $"{environment.WebRootPath}\\uploads\\{picName}";

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    msFile.WriteTo(fs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
