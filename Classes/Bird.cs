namespace OOPLESSON.CLasses{
    public class Bird : Animal
    {
        public Bird(string name, int animalAge): base(name, animalAge) {
            // Name = name;
            // Age = animalAge;
        }

        public override void Greeting(string userName = "")
        {
            // base.Greeting(userName);
            if(userName == ""){
                Console.WriteLine("WoW Not name");
            }
            else{
                Console.WriteLine($"WoW {userName}");
            }
        }
    }
}
