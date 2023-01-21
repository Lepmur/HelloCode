namespace Initiative014_Tetris
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Variables var = new Variables();
            Functions fun = new Functions();

            Console.Clear();
            char[,] field = fun.NullFieldGenerate(var.heidth, var.width, var.filling);
            fun.FieldPrint(field);

            char input;
            do
            {
                input = Convert.ToChar(Console.ReadLine()!);
                if (input == 's') fun.FigureFall(field);
                if (input == 'w') fun.GenerateNewFigure(field);
                if (input == 'a') fun.FigureToLeft(field);
                if (input == 'd') fun.FigureToRight(field);
                if (input == ' ') fun.FigureRoundLeft(field);
                Console.Clear();
                fun.FieldPrint(field);
            } while (true);
        }
    }
}
