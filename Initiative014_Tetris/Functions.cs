using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative014_Tetris
{
    public class Functions
    {
        Variables var = new Variables();
        public char[,] NullFieldGenerate(int rows, int cols, char filling) // генерирует пустое поле
        {
            char[,] field = new char[rows, cols];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = filling;
                }
            }
            return field;
        }

        public void FieldPrint(char[,] field) // выводит текущее поле на экран
        {
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        Console.Write($"{field[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void GenerateNewFigure(char[,] field) // генерирует новую случайную фигуру на поле
        {
            var.newFigureKey = new Random().Next(1, 8);
            char[,] newFigure = var.figures[var.newFigureKey];
            var.figurePosition = 1;
            for (int i = 0; i < newFigure.GetLength(0); i++)
            {
                for (int j = 0; j < newFigure.GetLength(1); j++)
                {
                    field[i, field.GetLength(1)/2 - 1 + j] = newFigure[i,j];
                }
            }
        }

        public bool IsThereFigure(char[,] field) // есть ли уже падающая фигура на поле
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == var.fillingFigure)
                        return true;
                }
            }
            return false;
        }

        public void FigureFall(char[,] field) // изменяет положение фигуры на 1 клетку вниз
        {
            for (int i = field.GetLength(0) - 2; i >= 0; i--)
            {
                for (int j = field.GetLength(1) - 1; j >= 0; j--)
                {
                    if (field[i, j] == var.fillingFigure)
                    {
                        field[i + 1, j] = var.fillingFigure;
                        field[i, j] = var.filling;
                    }
                }
            }
        }

        public void FigureToRight(char[,] field) // смещает фигуру вправо на 1 клетку
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (field[i, field.GetLength(1) - 1] == var.fillingFigure)
                    return;
            }
            for (int i = field.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = field.GetLength(1) - 2; j >= 0; j--)
                {
                    if (field[i, j] == var.fillingFigure)
                    {
                        field[i, j + 1] = var.fillingFigure;
                        field[i, j] = var.filling;
                    }
                }
            }
        }

        public void FigureToLeft(char[,] field) // смещает фигуру влево на 1 клетку
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (field[i, 0] == var.fillingFigure)
                    return;
            }
            for (int i = field.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 1; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == var.fillingFigure)
                    {
                        field[i, j - 1] = var.fillingFigure;
                        field[i, j] = var.filling;
                    }
                }
            }
        }

        public void FigureRoundLeft(char[,] field) // поворачивает фигуру против часовой стрелки
        {
            if (var.newFigureKey == 6)
                RoundT(field);
            if (var.newFigureKey == 3)
                RoundL(field);
        }

        public void RoundT(char[,] field) // поворот T
        {
            if (var.figurePosition == 1)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    if (field[i, 0] == var.fillingFigure)
                        FigureToRight(field);
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i + 2, j] = var.filling;
                            field[i + 1, j - 1] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 2)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[field.GetLength(0) - 1, j] == var.fillingFigure)
                        return;
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i + 1, j + 1] = var.filling;
                            field[i + 2, j] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 3)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    if (field[i, field.GetLength(1) - 1] == var.fillingFigure)
                        FigureToLeft(field);
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i, j] = var.filling;
                            field[i + 1, j + 1] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 4)
            {
                for (int i = 0; i < field.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < field.GetLength(1) - 2; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i, j] = var.filling;
                            field[i - 1, j + 1] = var.fillingFigure;
                            var.figurePosition = 1;
                            return;
                        }
                    }
                }
            }
        }

        public void RoundL(char[,] field) // поворот L
        {
            if (var.figurePosition == 1)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    if (field[i, 0] == var.fillingFigure)
                        FigureToRight(field);
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i, j] = var.filling;
                            field[i + 1, j - 1] = var.fillingFigure;
                            field[i + 2, j] = var.filling;
                            field[i + 1, j + 1] = var.fillingFigure;
                            field[i + 2, j + 1] = var.filling;
                            field[i, j + 1] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 2)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[field.GetLength(0) - 1, j] == var.fillingFigure)
                        return;
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i + 1, j - 1] = var.filling;
                            field[i + 2, j] = var.fillingFigure;
                            field[i + 1, j - 2] = var.filling;
                            field[i, j - 1] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 3)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    if (field[i, field.GetLength(1) - 1] == var.fillingFigure)
                        FigureToLeft(field);
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 1; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i + 1, j + 1] = var.filling;
                            field[i + 1, j] = var.fillingFigure;
                            field[i + 2, j + 1] = var.filling;
                            field[i, j + 2] = var.fillingFigure;
                            var.figurePosition++;
                            return;
                        }
                    }
                }
            }
            else if (var.figurePosition == 4)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[field.GetLength(0) - 1, j] == var.fillingFigure)
                        return;
                }
                for (int i = 0; i < field.GetLength(0) - 2; i++)
                {
                    for (int j = 0; j < field.GetLength(1) - 2; j++)
                    {
                        if (field[i, j] == var.fillingFigure)
                        {
                            field[i, j] = var.filling;
                            field[i + 1, j + 1] = var.fillingFigure;
                            field[i + 1, j] = var.filling;
                            field[i + 2, j + 1] = var.fillingFigure;
                            field[i, j + 2] = var.filling;
                            field[i + 2, j + 2] = var.fillingFigure;
                            var.figurePosition = 1;
                            return;
                        }
                    }
                }
            }
        }
    }
}
