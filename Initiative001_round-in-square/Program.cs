int asq = 5;
while (asq != 0) {
    Console.Clear();
    Console.WriteLine("Что будем считать?");
    Console.WriteLine();
    Console.WriteLine("Площадь круга и квадрата - введите 1");
    Console.WriteLine("Поместится ли круг в квадрат и наоборот - введите 2");
    Console.WriteLine("Для выхода из программы введите 0");
    Console.WriteLine();
    Console.Write("Ваш ответ: ");
    asq = int.Parse(Console.ReadLine()!);
    if (asq == 0) {
        Console.WriteLine();
        Console.WriteLine("Пока! :)");
        Console.WriteLine();
    }
    else {
        if (asq == 1) {       // если ответ 1 - считаем площади
            Console.Clear();
            Console.Write("Введите сторону квадрата: ");
            int sideSquare = int.Parse(Console.ReadLine()!);
            Console.Write("Введите радиус круга: ");
            int radiusRound = int.Parse(Console.ReadLine()!);
            int sRound = Convert.ToInt32(Math.PI * Math.Pow(radiusRound, 2));     // Из-за конвертации S круга считается не точно - исправить
            int sSquare = Convert.ToInt32(Math.Pow(sideSquare, 2));
            Console.WriteLine();
            Console.WriteLine($"Площадь круга = {sRound}");
            Console.WriteLine($"Площадь квадрата = {sSquare}");
        } 
        else {               // если ответ 2 - считаем поместится ли одно в другое 
            if (asq == 2) {
                Console.Clear();
                Console.Write("Введите площадь круга: ");
                int sRound = int.Parse(Console.ReadLine()!);
                Console.Write("Введите площадь квадрата: ");
                int sSquare = int.Parse(Console.ReadLine()!);
                int radiusRound = Convert.ToInt32(Math.Sqrt(sRound / Math.PI));                                    // вычисление радиуса круга
                int sideSquare = Convert.ToInt32(Math.Sqrt(sSquare));                                              // вычисление стороны квадрата
                int diagonalSquare = Convert.ToInt32(Math.Sqrt(sSquare * 2));                                      // вычисление диагонали квадрата
                Console.WriteLine();
                if (radiusRound * 2 <= sideSquare)                            // поместится ли круг в квадрат
                    Console.WriteLine("Круг поместится в квадрат!");
                else 
                    Console.WriteLine("Круг не поместится в квадрат!"); 
                if (diagonalSquare <= radiusRound * 2)                        // поместится ли квадрат в круг
                    Console.WriteLine("Квадрат поместится в круг!");
                else
                    Console.WriteLine("Квадрат не поместится в круг!");
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Не не, ты не понял)). Нужно выбрать: 0 или 1 или 2. Ок?");
            }
        }
    Console.WriteLine();
    Console.Write("press enter to continue...");
    Console.ReadLine();
    }         
}
