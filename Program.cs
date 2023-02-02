class Program
{
    static void Main(string[] args)
    {
        double x_1 = double.Parse(Console.ReadLine());
        double y_1 = double.Parse(Console.ReadLine());
        double x_2 = double.Parse(Console.ReadLine());
        double y_2 = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double r = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2));
        double radians = Math.Atan((y_2 - y_1) / (x_2 - x_1));
        
        double[] xy = X_1(x_1, y_1, x_2, y_2, r, radians, n);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(xy[i]);
        }

    }


    static double[] X_1(double x_1, double y_1, double x_2, double y_2, double r, double radians, int n)
    {
        double[] xy = { x_1, y_1, x_2, y_2 };
        double dx = r * Math.Cos(radians) / 2;
        double dy = r * Math.Sin(radians) / 2;
        if (n != 0)
        {
            n--;
            if (x_2 > x_1 && y_2 > y_1)
            {
                xy = X_1(x_1 - dx, y_1 + dy, x_1 - (x_2 - x_1), y_2, r / 2, radians, n--);

            }
            else if (x_2 < x_1 && y_2 > y_1)
            {
                xy = X_1(x_1 - dx, y_1 - dy, x_2, y_1 - (y_2 - y_1), r / 2, radians, n--);

            }
            else if (x_2 < x_1 && y_2 < y_1)
            {
                xy = X_1(x_1 + dx, y_1 - dy, x_1 + (x_2 - x_1), y_2, r / 2, radians, n--);

            }
            else if (x_2 < x_1 && y_2 > y_1)
            {
                xy = X_1(x_1 + dx, y_1 + dy, x_2, y_1 + (y_2 - y_1), r / 2, radians, n--);

            }
        }
        return xy;
    }
}