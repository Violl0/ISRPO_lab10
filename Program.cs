Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");


book first  = new book("Мастер и Маргарита",5,"роман",1290);
book second = new book("Дюна",3,"фантастика",1590);
book third  = new book("Шерлок Холмс",7,"детектив",890);

Console.WriteLine(">>> Книга1 <<<");
Console.WriteLine($"Название: {first.Name}");
Console.WriteLine($"Наличие: {first.Availability}");
Console.WriteLine($"Количество: {first.Count}");
Console.WriteLine($"Жанр: {first.Genre}");
Console.WriteLine($"Цена: {first.Price}");

Console.WriteLine(">>> Книга2 <<<");
Console.WriteLine($"Название: {second.Name}");
Console.WriteLine($"Наличие: {second.Availability}");
Console.WriteLine($"Количество: {second.Count}");
Console.WriteLine($"Жанр: {second.Genre}");
Console.WriteLine($"Цена: {second.Price}");

Console.WriteLine(">>> Книга3 <<<");
Console.WriteLine($"Название: {third.Name}");
Console.WriteLine($"Наличие: {third.Availability}");
Console.WriteLine($"Количество: {third.Count}");
Console.WriteLine($"Жанр: {third.Genre}");
Console.WriteLine($"Цена: {third.Price}");