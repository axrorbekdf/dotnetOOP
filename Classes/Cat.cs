namespace OOPLESSON.CLasses{
    public class Cat : Animal
    {
        public Cat(string name, int animalAge):base(name, animalAge){

        }

        public override void Greeting(string userName = "")
        {
            // base.Greeting(userName);
            if(userName == ""){
                Console.WriteLine("Miao Not name");
            }
            else{
                Console.WriteLine($"Miao {userName}");
            }
        }
    }
}
