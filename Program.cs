using System.Security.Principal;
using Microsoft.VisualBasic;
using OOPLESSON.CLasses;

namespace KESCHA{
    class Program{
        static void Main(){

            try{
                string userName = "";
                Console.WriteLine("Ismingizni kiriting:");
                userName = Console.ReadLine();

                Console.WriteLine("Yoshingizni kiriting:");
                int userAge = Convert.ToInt32(Console.ReadLine());
                
                // Animal mushuk = new Animal(name: "Kescha", userAge: age, animalAge: 3);
                Animal mushuk = new Cat(name: "Kescha", animalAge: 3);
                Animal birdy = new Bird(name: "Kasee", animalAge: 5);


                // mushuk.Age = 3;
                mushuk.CalculateAgeDifference(userAge: userAge);
                mushuk.Greeting(userName: userName);
                mushuk.PrintInfo();
                mushuk.CompareAges(userAge: userAge);
                Console.WriteLine($"{mushuk.Name}ning do'stlari haqida aytib beraman!");
                mushuk.TellAboutFriends(userName: userName, userAge: userAge);


                Console.WriteLine("\n");


                birdy.CalculateAgeDifference(userAge: userAge);
                birdy.Greeting(userName: userName);
                birdy.PrintInfo();
                birdy.CompareAges(userAge: userAge);
                Console.WriteLine($"{birdy.Name}ning do'stlari haqida aytib beraman!");
                birdy.TellAboutFriends(userName: userName, userAge: userAge);
            }catch(FormatException error){
                Console.WriteLine($"{error.Message}");
            }catch(Exception errors){
                Console.WriteLine($"{errors.Message}");
            }
        }
    }
}
