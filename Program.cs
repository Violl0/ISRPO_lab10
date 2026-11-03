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

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());


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

Console.WriteLine($"Количество Дюны до пополнения: {second.Count}");

second.Restock(3);
Console.WriteLine($"После пополнения на 3: {second.Count}");

second.Restock(-2);
Console.WriteLine($"После пополнения на -2: {second.Count}");