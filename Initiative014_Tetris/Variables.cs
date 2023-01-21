using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative014_Tetris
{
    public class Variables
    {
        public int heidth = 20;           // задаём высоту поля
        public int width = 10;            // задаём ширину поля
        public char filling = '.';        // знак заполнение поля
        public char fillingFigure = '*';  // знак заполнения фигуры
        public int figurePosition = 1;    // положение фигуры при повороте, нужен глобально
        public int newFigureKey = 0;      // ключ фигуры в словаре, нужен глобально

        public char[,] figureL = { {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, fillingFigure} };
        public char[,] figureJ = { {filling, fillingFigure}, {filling, fillingFigure}, {fillingFigure, fillingFigure} };
        public char[,] figureI = { {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, filling}, {fillingFigure, filling}};
        public char[,] figureO = { {fillingFigure, fillingFigure}, {fillingFigure, fillingFigure}};
        public char[,] figureS = { {fillingFigure, filling}, {fillingFigure, fillingFigure}, {filling, fillingFigure} };
        public char[,] figureT = { {fillingFigure, filling}, {fillingFigure, fillingFigure}, {fillingFigure, filling} };
        public char[,] figureZ = { {filling, fillingFigure}, {fillingFigure, fillingFigure}, {fillingFigure, filling} };
        public Dictionary<int, char[,]> figures = new Dictionary<int, char[,]>(7) // словарь с фигурами
        {
            {1, figureI},
            {2, figureJ},
            {3, figureL},
            {4, figureO},
            {5, figureS},
            {6, figureT},
            {7, figureZ},
        };        
    }
}