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
            Animal mushuk = new Bird(name: "Kescha", animalAge: 3);
            // mushuk.Age = 3;
            mushuk.CalculateAgeDifference(userAge: userAge);
            mushuk.PrintInfo();
            mushuk.CompareAges(userAge: userAge);
            Console.WriteLine($"{mushuk.Name}ning do'stlari haqida aytib beraman!");
            mushuk.TellAboutFriends(userName: userName, userAge: userAge);


            Animal birdy = new Cat(name: "Kasee", animalAge: 5);
            birdy.CalculateAgeDifference(userAge: userAge);
            birdy.PrintInfo();
            birdy.CompareAges(userAge: userAge);
            Console.WriteLine($"{birdy.Name}ning do'stlari haqida aytib beraman!");
            birdy.TellAboutFriends(userName: userName, userAge: userAge);
        }
    }
}
