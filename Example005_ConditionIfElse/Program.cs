Console.Write("Введите ваше имя и нажмите Enter ");
string name = Console.ReadLine()!;
if (name.ToLower() == "sergei") {
    Console.Write("Здорова, Серега!!!");
    } 
    else Console.Write($"Приятно познакомиться, {name}! А где Серега?!");
