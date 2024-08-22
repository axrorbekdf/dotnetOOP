using OOPLESSON.CLasses;

Console.WriteLine("Yoshingizni kiriting:");
int age = Convert.ToInt32(Console.ReadLine());

Animal mushuk = new Animal(name: "Kescha", userAge: age, animalAge: 3);

mushuk.Age = 3;

Console.WriteLine($"Hayvon nomi: {mushuk.Name}");
Console.WriteLine($"Hayvon yoshi: {mushuk.Age}");
Console.WriteLine($"Sizning va Keschaning yoshi orasidagi farq: {mushuk.AgeDifference}");
