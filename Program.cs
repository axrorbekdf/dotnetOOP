using OOPLESSON.CLasses;

Console.WriteLine("Ismingizni kiriting:");
string name = Console.ReadLine();

Console.WriteLine("Yoshingizni kiriting:");
int age = Convert.ToInt32(Console.ReadLine());

Animal mushuk = new Animal(name: "Kescha", userAge: age, animalAge: 3);

// mushuk.Age = 3;

mushuk.PrintInfo();
mushuk.CompareAges(userAge: age);
Console.WriteLine("Men do'stlarim haqida aytib beraman!");
mushuk.TellAboutFriends(userName: name, userAge: age);
