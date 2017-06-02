using System;

namespace _04_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());
            // for photo size:
            string sizeSufix = null;
            if (photoSize>1000000)
            {
                photoSize = photoSize / 1000000.0;
                sizeSufix = "MB";
            }
            else if (photoSize>1000)
            {
                photoSize = photoSize / 1000.0;
                sizeSufix = "KB";
            }
            else
            {
                sizeSufix = "B";
            }
            //resolution and orientation            
            string orientation = null;
            if (photoWidth == 5334 && photoHeight == 3006)
            {
                orientation = "landscape";
            }
            else if (photoWidth == 768 && photoHeight == 1024)
            {
                orientation = "portrait";
            }
            else if (photoWidth == 1000 && photoHeight == 1000)
            {
                orientation = "square";
            }
            //output
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{mins:d2}");
            Console.WriteLine($"Size: {photoSize}{sizeSufix}");
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
        }
    }
}
