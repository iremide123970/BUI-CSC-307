using System;

namespace MathMethods
{
    class Program
    {
        // 1) Area of a circle: πr²
        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Area of a triangle: ½bh
        static double AreaOfTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Area of a square: l²
        static double AreaOfSquare(double length)
        {
            return length * length;
        }

        // Area of a rectangle: l × b
        static double AreaOfRectangle(double length, double breadth)
        {
            return length * breadth;
        }

        // 2) Quadratic formula: (-b ± √(b² - 4ac)) / 2a
        static (double root1, double root2) QuadraticFormula(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("a cannot be 0 in a quadratic equation.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                throw new ArgumentException("No real roots: the discriminant b² - 4ac is negative.");

            double sqrt = Math.Sqrt(discriminant);
            double root1 = (-b + sqrt) / (2 * a);
            double root2 = (-b - sqrt) / (2 * a);

            return (root1, root2);
        }

        static void Main()
        {
            Console.WriteLine($"Circle    (r = 5):            {AreaOfCircle(5)}");
            Console.WriteLine($"Triangle  (b = 4, h = 3):     {AreaOfTriangle(4, 3)}");
            Console.WriteLine($"Square    (l = 4):            {AreaOfSquare(4)}");
            Console.WriteLine($"Rectangle (l = 6, b = 3):     {AreaOfRectangle(6, 3)}");

            var (root1, root2) = QuadraticFormula(1, -3, 2); // x² - 3x + 2 = 0
            Console.WriteLine($"Quadratic (a = 1, b = -3, c = 2): x1 = {root1}, x2 = {root2}");
        }
    }
}