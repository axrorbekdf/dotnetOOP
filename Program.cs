using OOPLESSON.CLasses;

namespace KESCHA{
    class Program{
        static void Main(){
            string userName = "";
            Console.WriteLine("Ismingizni kiriting:");
            userName = Console.ReadLine();

            Console.WriteLine("Yoshingizni kiriting:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // Animal mushuk = new Animal(name: "Kescha", userAge: age, animalAge: 3);
            Animal mushuk = new Animal(name: "Kescha", animalAge: 3);

            // mushuk.Age = 3;
            mushuk.CalculateAgeDifference(userAge: userAge);
            mushuk.PrintInfo();
            mushuk.CompareAges(userAge: userAge);
            Console.WriteLine($"{mushuk.Name}ning do'stlari haqida aytib beraman!");
            mushuk.TellAboutFriends(userName: userName, userAge: userAge);
        }
    }
}
