namespace DZ_class
{
    class Program
    {
        static void Main()
        {
            IAnimal parrot = new Parrot("Kesha", "Denis", 4);
            IAnimal fish = new Fish("Nemo", "Liza", 2);
            IAnimal cat = new Cat("Sheldon", "Igor", 1);
            IAnimal horse = new Horse("Ferari", "Sabrina", 3);

            parrot.SayHello();
            fish.SayHello();
            cat.SayHello();
            horse.SayHello();
        }
    }

}