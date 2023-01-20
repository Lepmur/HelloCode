using Initiative015_EngineerSpock_Overload;

internal class Program
{
    private static void Main(string[] args)
    {
        double ab = 5;
        double bc = 6;
        double ca = 7;
        double h = 10;
        int corner = 30;

        Formules calc = new Formules();

        System.Console.WriteLine(calc.CalcSquare(ab, bc, ca));
        System.Console.WriteLine(calc.CalcSquare(ab, h));
        System.Console.WriteLine(calc.CalcSquare(ab, bc, corner));
    }
}
