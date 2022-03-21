using System;
using System.Collections.Generic;
using System.Text;

namespace B10756051_1
{
    class FileServiceA : IFileService
    {
        public void UploadFile()
        {
            Console.WriteLine("上傳AWS S3");
        }
    }
}
