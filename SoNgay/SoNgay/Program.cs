// See https://aka.ms/new-console-template for more information


namespace SoNgay
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            //string[] input = Console.ReadLine().Split(','); Split đọc phần tử cảu chuỗi trên màn hình được bằng dấu ","
            int month = int.Parse(input[0]);
            int year = int.Parse(input[1]);

            if (month < 1 || month > 12 || year <= 0)
            {
                Console.WriteLine("INVALID");
                return;
            }

            int day = 0;

            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    day = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    day = 30;
                    break;
                case 2:
                    if (year % 4 == 0)
                        day = 29;
                    else
                        day = 28;
                break;
            }

            Console.WriteLine(day);
        }

    }

}
