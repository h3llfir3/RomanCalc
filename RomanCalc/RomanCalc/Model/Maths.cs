
namespace RomanCalc.Model
{
    class Maths
    {
        public static Equation2Solution SolveEquation2(double a, double b, double c)
        {
            Equation2Solution result = new Equation2Solution();

            double aux = b * b - 4.0 * a * c;
            double sq = System.Math.Sqrt(aux);

            result.solution1 = (-b + sq) / (2.0 * a);
            result.solution2 = (-b - sq) / (2.0 * a);

            return result;
        }
    }
}
