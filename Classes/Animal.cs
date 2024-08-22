namespace OOPLESSON.CLasses{
    class Animal
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

        public int AgeDifference{ get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animal(string name, int userAge, int animalAge)
        {
            Name = name;
            AgeDifference = userAge - animalAge;
        }
    }
}