namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double d = b * b - 4 * a * c; // Diskriminan

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                return new double[] { };
            }
        }

        // Fungsi untuk mendapatkan hasil kuadrat dari persamaan berpangkat 1
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double hasil1 = a * a;
            double hasil2 = -2 * a * b;
            double hasil3 = b * b;

            return new double[] { hasil1, hasil2, hasil3 };
        }
    }
}
