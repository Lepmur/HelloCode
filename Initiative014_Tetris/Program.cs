//=============================переменные=настроек===========================================
int heidth = 20;           // задаём высоту поля
int width = 10;            // задаём ширину поля
char filling = '.';        // знак заполнение поля
char fillingFigure = '*';  // знак заполнения фигуры
int figurePosition = 1;    // положение фигуры при повороте, нужен глобально
int newFigureKey = 0;      // ключ фигуры в словаре, нужен глобально
//==============================================фигуры============================================
char[,] figureL = { {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, fillingFigure} };
char[,] figureJ = { {filling, fillingFigure}, {filling, fillingFigure}, {fillingFigure, fillingFigure} };
char[,] figureI = { {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, filling}};
char[,] figureO = { {fillingFigure, fillingFigure}, {fillingFigure, fillingFigure}};
char[,] figureS = { {fillingFigure, filling}, {fillingFigure, fillingFigure}, {filling, fillingFigure} };
char[,] figureT = { {fillingFigure, filling}, {fillingFigure, fillingFigure}, {fillingFigure, filling} };
char[,] figureZ = { {filling, fillingFigure}, {fillingFigure, fillingFigure}, {fillingFigure, filling} };
var figures = new Dictionary<int, char[,]>(7) // словарь с фигурами
{
    {1, figureI},
    {2, figureJ},
    {3, figureL},
    {4, figureO},
    {5, figureS},
    {6, figureT},
    {7, figureZ},
};

//===========================================функции=========================================
char[,] NullFieldGenerate(int rows, int cols, char filling) // генерирует пустое поле
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

void FieldPrint(char[,] field) // выводит текущее поле на экран
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

void GenerateNewFigure(char[,] field) // генерирует новую случайную фигуру на поле
{
    newFigureKey = new Random().Next(1, 8);
    char[,] newFigure = figures[newFigureKey];
    figurePosition = 1;
    for (int i = 0; i < newFigure.GetLength(0); i++)
    {
        for (int j = 0; j < newFigure.GetLength(1); j++)
        {
            field[i, field.GetLength(1)/2 - 1 + j] = newFigure[i,j];
        }
    }
}

bool IsThereFigure(char[,] field) // есть ли уже падающая фигура на поле
{
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if (field[i, j] == fillingFigure)
                return true;
        }
    }
    return false;
}

void FigureFall(char[,] field) // изменяет положение фигуры на 1 клетку вниз
{
    for (int i = field.GetLength(0) - 2; i >= 0; i--)
    {
        for (int j = field.GetLength(1) - 1; j >= 0; j--)
        {
            if (field[i, j] == fillingFigure)
            {
                field[i + 1, j] = fillingFigure;
                field[i, j] = filling;
            }
        }
    }
}

void FigureToRight(char[,] field) // смещает фигуру вправо на 1 клетку
{
    for (int i = 0; i < field.GetLength(0); i++)
    {
        if (field[i, field.GetLength(1) - 1] == fillingFigure)
            return;
    }
    for (int i = field.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = field.GetLength(1) - 2; j >= 0; j--)
        {
            if (field[i, j] == fillingFigure)
            {
                field[i, j + 1] = fillingFigure;
                field[i, j] = filling;
            }
        }
    }
}

void FigureToLeft(char[,] field) // смещает фигуру влево на 1 клетку
{
    for (int i = 0; i < field.GetLength(0); i++)
    {
        if (field[i, 0] == fillingFigure)
            return;
    }
    for (int i = field.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 1; j < field.GetLength(1); j++)
        {
            if (field[i, j] == fillingFigure)
            {
                field[i, j - 1] = fillingFigure;
                field[i, j] = filling;
            }
        }
    }
}

void FigureRoundLeft(char[,] field) // поворачивает фигуру против часовой стрелки
{
    if (newFigureKey == 6)
        RoundT(field);
}

void RoundT(char[,] field) // поворот T
{
    if (figurePosition == 1)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            if (field[i, 0] == fillingFigure)
                FigureToRight(field);
        }
        for (int i = 0; i < field.GetLength(0) - 2; i++)
        {
            for (int j = 1; j < field.GetLength(1) - 1; j++)
            {
                if (field[i, j] == fillingFigure)
                {
                    field[i + 2, j] = filling;
                    field[i + 1, j - 1] = fillingFigure;
                    figurePosition++;
                    return;
                }
            }
        }
    }
    else if (figurePosition == 2)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if (field[field.GetLength(0) - 1, j] == fillingFigure)
                return;
        }
        for (int i = 0; i < field.GetLength(0) - 2; i++)
        {
            for (int j = 1; j < field.GetLength(1) - 1; j++)
            {
                if (field[i, j] == fillingFigure)
                {
                    field[i + 1, j + 1] = filling;
                    field[i + 2, j] = fillingFigure;
                    figurePosition++;
                    return;
                }
            }
        }
    }
    else if (figurePosition == 3)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            if (field[i, field.GetLength(1) - 1] == fillingFigure)
                FigureToLeft(field);
        }
        for (int i = 0; i < field.GetLength(0) - 2; i++)
        {
            for (int j = 1; j < field.GetLength(1) - 1; j++)
            {
                if (field[i, j] == fillingFigure)
                {
                    field[i, j] = filling;
                    field[i + 1, j + 1] = fillingFigure;
                    figurePosition++;
                    return;
                }
            }
        }
    }
    else if (figurePosition == 4)
    {
        for (int i = 0; i < field.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < field.GetLength(1) - 2; j++)
            {
                if (field[i, j] == fillingFigure)
                {
                    field[i, j] = filling;
                    field[i - 1, j + 1] = fillingFigure;
                    figurePosition = 1;
                    return;
                }
            }
        }
    }
}

//=======================================исполняемый=код=======================================
Console.Clear();
char[,] field = NullFieldGenerate(heidth, width, filling);
FieldPrint(field);

char input;
do
{
    input = Convert.ToChar(Console.ReadLine());
    if (input == 's') FigureFall(field);
    if (input == 'w') GenerateNewFigure(field);
    if (input == 'a') FigureToLeft(field);
    if (input == 'd') FigureToRight(field);
    if (input == ' ') FigureRoundLeft(field);
    Console.Clear();
    FieldPrint(field);
} while (true);






