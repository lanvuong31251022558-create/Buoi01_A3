/*
 * Bài: Buoi01_A3 - Vẽ hình bằng ký tự
 * Sinh viên: Vương Thục Lan
 * MSSV: 31251022558
 * Ngày: 17/10/2026
*/

namespace Buoi01_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("================================");
            Console.WriteLine("   VẼ HÌNH BẰNG KÝ TỰ ĐẶC BIỆT   ");
            Console.WriteLine("=================================");

            // Hình 1: Ngôi nhà đơn giản
            Console.WriteLine("  /\\  ");
            Console.WriteLine(" /  \\");
            Console.WriteLine("/___ \\");
            Console.WriteLine("| [] |");
            Console.WriteLine("|____|");

            Console.WriteLine();

            // Hình 2: Cây thông Noel
            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
            Console.WriteLine("   |||   ");

            Console.WriteLine();
            Console.WriteLine("====================================");
        }
    }
}
