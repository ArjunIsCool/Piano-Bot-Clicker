using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;

namespace Csharp_Experiments
{
    class Program
    {
        [DllImport("user32.dll",EntryPoint ="SetCursorPos")]
        public static extern bool SetCursorPos(int x, int y);


        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtrainfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;

        private const int MOUSEEVENTF_LEFTUP = 0x02;

        private static int x, y;

        static Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        public static async Task Click()
        {
            //Console.WriteLine("I just clicked");
            SetCursorPos(x, y);
            Application.DoEvents();
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            Task.Delay(10).Wait(10);
            //Thread.Sleep(10);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        

        static void Main()
        {
            DoTheWorkBro();
            Console.WriteLine("Wow Im really here");
        }

        static async void DoTheWorkBro()
        {
            await DoWorkAsync();
            Console.WriteLine("Wow Im here");
        }
        static async Task DoWorkAsync()
        {
            Point point1 = new Point(525, 500);
            Point point2 = new Point(625, 500);
            Point point3 = new Point(730, 500);
            Point point4 = new Point(830, 500);
            while (Button.IsKeyLocked(Keys.CapsLock) == false)
            {

                if (GetPixel(point1).R <= 28)
                {
                    x = point1.X;
                    y = point1.Y;
                    await Click();
                }
                else if (GetPixel(point2).R <= 28)
                {
                    x = point2.X;
                    y = point2.Y;
                    await Click();
                }
                else if (GetPixel(point3).R <= 28)
                {
                    x = point3.X;
                    y = point3.Y;
                    await Click();
                }
                else if (GetPixel(point4).R <= 28)
                {
                    x = point4.X;
                    y = point4.Y;
                    await Click();
                }
               
            }
        }
    }
}
