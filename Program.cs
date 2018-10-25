using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace SmartLens
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagesVault = @"..\..\AppData";
            DirectoryInfo directoryInfo = new DirectoryInfo(imagesVault);
            FileInfo[] Files = directoryInfo.GetFiles("**");
            string imagePath = "";
            foreach (FileInfo file in Files)
            {
                imagePath = imagesVault + @"\" + file.Name;
                Bitmap image = new Bitmap(imagePath);
                TesseractEngine ocr = new TesseractEngine(@"D:\GitHub\SmartLens\SmartLens\tessdata", "ron", EngineMode.Default);
                var page = ocr.Process(image);
                var text = page.GetText().Replace("\n", "");
                Console.WriteLine(text);
            }

        }
        
    }
}
