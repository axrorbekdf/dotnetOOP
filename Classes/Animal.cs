using OOPLESSON.Enums;

namespace OOPLESSON.CLasses{
    public class Animal : IAnimal
    {
        // private int age;

        // public int Age{
        //     get{
        //         return age;
        //     }
        //     set{
        //         if(age > 0){
        //             age = value;
        //         }
        //     }
        // }

        public string Name{ get; set; }
        public int Age{ get; set; }
        public PetTypes  Type{ get; set; }

        public int AgeDifference{ get; set; }

        public DateTimeOffset HappyDay{get; set;}
        public string[,] Friends = new string[3, 2]{
                {"Kasee","2"},
                {"Vasya","3"},
                {"", ""},
            };

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            HappyDay = DateTimeOffset.Now;
        }

        public Animal(string name, int animalAge)
        {
            Name = name;
            Age = animalAge;
            HappyDay = DateTimeOffset.Now;
        }

        public Animal(string name, int userAge, int animalAge)
        {
            Name = name;
            Age = animalAge;
            // AgeDifference = CalculateAgeDifference(userAge: userAge, animalAge: animalAge);
            CalculateAgeDifferenceWithNoReturn(userAge: userAge, animalAge: animalAge);
            HappyDay = DateTimeOffset.Now;
        }

        public virtual void Greeting(string userName = ""){

            if(userName == ""){
                Console.WriteLine("Not name Hello!");
            }else{
                Console.WriteLine($"{userName} Hello!");
            }


        }

        public void CalculateAgeDifference(int userAge){
            AgeDifference = userAge - Age; 
        }

        private int CalculateAgeDifference(int userAge, int animalAge){
            return userAge - animalAge; 
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge){
            AgeDifference = userAge - animalAge;
        }

        public void CompareAges(int userAge){

            if(userAge > Age){
                Console.WriteLine($"Siz {Name}dan kattasiz!");
            }else if(userAge == Age){
                Console.WriteLine($"Siz {Name} bilan teng ekansiz");
            }else{
                Console.WriteLine($"Siz {Name}dan kichik ekansiz!");
            }
        }

        public void TellAboutFriends(string userName, int userAge){

            Friends[2,0] = userName;
            Friends[2,1] = Convert.ToString(userAge);
            for(int i=0; i< Friends.GetLength(0); i++){
                Console.WriteLine($"{Friends[i,0]} uning yoshi {Friends[i,1]}da!");
            }
        }

        public void PrintName(){
            Console.WriteLine($"Hayvon nomi: {Name}");
        }

        public void PrintAge(){
            Console.WriteLine($"Hayvon yoshi: {Age}");
        }

        public void PrintType(){
            Console.WriteLine($"Hayvon turi: {Type}");
        }

        public void PrintAgeDifference(){
            Console.WriteLine($"Sizning va Keschaning yoshi orasidagi farq: {AgeDifference}");
        }

        public void PrintInfo(){
            PrintName();
            PrintAge();
            PrintAgeDifference();
            PrintType();
        }
    }
}