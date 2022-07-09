using System.IO;

namespace Hekki
{
    internal class ScreenReader
    {
        private static DirectoryInfo di;
        private static int counter = 0;
        public static void Start(string[] args, int width, int heigth, int paddingLeft, int paddingTop)
        {
            args = new string[] { "y" };

            if (args[0] == "y")
            {
                di = new DirectoryInfo("C:\\ss");
                if (!di.Exists) { di.Create(); }

                PrintScreen ps = new PrintScreen();
                ps.CaptureScreenToFile(di + "\\screen" + counter.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png, width, heigth, paddingLeft, paddingTop);
            }
            counter++;
        }
    }

}

