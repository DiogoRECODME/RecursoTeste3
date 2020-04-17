using System;
using System.Linq;

namespace GrupoIII
{
    public class Exercicio04
    {
        private static void ValidarInput(string animalName)
        {
            animalName = animalName.ToUpper();
            var animals = new string[] { "DOG", "CAT", "BIRD", "MOUSE", "COW", "FROG", "ELEPHANT", "DUCK", "FISH", "SEAL" };
            if (animalName == "") throw new EmptyStringException();
            if (animalName == "FOX") throw new FoxException();
            if (animalName == "MUSIC") throw new TwoThousandThirteenMemeException();
            if (!animals.Contains(animalName)) throw new AnimalDoesNotExistException();
        }

        public static void AnimalClock(string animal)
        {
            try
            {
                ValidarInput(animal);
            }
            catch (EmptyStringException)
            {
                Console.WriteLine("No animal inputted");
            }
            catch (FoxException)
            {
                Console.WriteLine("What does the fox say?");
            }
            catch (TwoThousandThirteenMemeException)
            {
                Console.WriteLine("Your teacher is so old, he's using 2013 memes");
            }
            catch (AnimalDoesNotExistException)
            {
                Console.WriteLine("The inputted animal does not exist");
            }


            switch (animal)
            {
                case "Dog":
                    Console.WriteLine($"{animal} goes Woof");
                    break;

                case "Cat":
                    Console.WriteLine($"{animal} goes Meow");
                    break;

                case "Bird":
                    Console.WriteLine($"{animal} goes Tweet");
                    break;

                case "Mouse":
                    Console.WriteLine($"{animal} goes Squee");
                    break;

                case "Cow":
                    Console.WriteLine($"{animal} goes Moo");
                    break;

                case "Frog":
                    Console.WriteLine($"{animal} goes Croak");
                    break;

                case "Elephant":
                    Console.WriteLine($"{animal} goes Toot");
                    break;

                case "Duck":
                    Console.WriteLine($"{animal} goes Quack");
                    break;

                case "Fish":
                    Console.WriteLine($"{animal} goes Blub");
                    break;

                case "Seal":
                    Console.WriteLine($"{animal} goes Ow ow ow");
                    break;

                default:
                    break;
            }
        }

        /*public static void AnimalClock(string animal)
        {
            switch (animal)
            {
                case "Dog":
                    Console.WriteLine($"{animal} goes Woof");
                    break;

                case "Cat":
                    Console.WriteLine($"{animal} goes Meow");
                    break;

                case "Bird":
                    Console.WriteLine($"{animal} goes Tweet");
                    break;

                case "Mouse":
                    Console.WriteLine($"{animal} goes Squee");
                    break;

                case "Cow":
                    Console.WriteLine($"{animal} goes Moo");
                    break;

                case "Frog":
                    Console.WriteLine($"{animal} goes Croak");
                    break;

                case "Elephant":
                    Console.WriteLine($"{animal} goes Toot");
                    break;

                case "Duck":
                    Console.WriteLine($"{animal} goes Quack");
                    break;

                case "Fish":
                    Console.WriteLine($"{animal} goes Blub");
                    break;

                case "Seal":
                    Console.WriteLine($"{animal} goes Ow ow ow");
                    break;

                default:
                    Console.WriteLine("Animal doesn't exist");
                    break;
            }
        }*/
    }
}
