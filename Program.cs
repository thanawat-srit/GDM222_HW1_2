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

        double[] xy = XY(x_1, y_1, x_2, y_2, r, radians, ref n);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0}", xy[i]);
        }

    }


    static double[] XY(double x_1, double y_1, double x_2, double y_2, double r, double radians, ref int n)
    {
        double[] xy = { x_1, y_1, x_2, y_2 };
        double dx = r * Math.Cos(radians);
        double dy = r * Math.Sin(radians);
        if (n != 0)
        {
            n--;

            if (x_2 > x_1 && y_2 > y_1)
            {
                xy = XY(x_1 - dx / 2, y_1 + dy / 2, x_1 - dy, y_1 + dx, r / 2, radians + Math.PI / 2, ref n);

            }
            else if (x_2 < x_1 && y_2 > y_1)
            {
                xy = XY(x_1 - dx / 2, y_1 - dy / 2, x_1 - dy, y_1 - dx, r / 2, radians + Math.PI / 2, ref n);

            }
            else if (x_2 < x_1 && y_2 < y_1)
            {
                xy = XY(x_1 + dx / 2, y_1 - dy / 2, x_1 + dy, y_1 - dx, r / 2, radians + Math.PI / 2, ref n);

            }
            else if (x_2 < x_1 && y_2 > y_1)
            {
                xy = XY(x_1 + dx / 2, y_1 + dy / 2, x_1 + dy, y_1 + dx, r / 2, radians + Math.PI / 2, ref n);

            }
        }
        return xy;
    }
}