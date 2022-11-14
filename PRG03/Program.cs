using PRG03;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person(); // create a new object from Person class and using a default value.
        PrintStatusObject(person1, nameof(person1));

        Person person2 = new Person(); // create a new object from Person class and using a default value.
        person2.Fname = "Emmanuel"; //assign value with set method
        person2.Lname = "Munck"; //assign value with set method
        person2.Age = 21; //assign value with set method
        person2.Height = 178; //assign value with set method
        person2.Weight = 75.4; //assign value with set method
        PrintStatusObject(person2, nameof(person2));

        Person person3 = new Person("Mathias","Jansson",29,177,79); // create a new object from Person class and assign value directly
        PrintStatusObject(person3, nameof(person3));

        // Due to create a private class member, so we couldn't access directly to them so we need a public method to access.
        Person person4 = new Person("Test4", "4Test", 12, 100, 16);
        PrintStatusObject(person4, nameof(person4));

        Person persTemp = new Person();
        persTemp.Fname = person4.Fname;
        persTemp.Lname = person4.Lname;
        persTemp.Age = person4.Age; 
        persTemp.Height = person4.Height;
        persTemp.Weight = person4.Weight;

        // with Handler class change some property of other object.
        PersonHandler personhandler = new PersonHandler();
        personhandler.SetAge(person4, 32);
        PrintDifferent(persTemp, person4, nameof(person4),"Change person age");

        personhandler.SetWeight(person4, 98);
        PrintDifferent(persTemp, person4, nameof(person4),"Change person Weight");

        //*********************************************************************************
        //Polymorfism
        //*********************************************************************************

        NumericInputError nError = new NumericInputError();
        TextInputError tError = new TextInputError();
        
        Console.Clear();
        Console.WriteLine(nError.UEMessage()+"\n\n");
        Console.WriteLine(tError.UEMessage());
        Console.ReadKey();

        CustomClass1 cError1 = new CustomClass1();
        CustomClass2 cError2 = new CustomClass2();
        CustomClass3 cError3 = new CustomClass3();

        Console.Clear();
        Console.WriteLine(cError1.UEMessage() + "\n \n");
        Console.WriteLine(cError2.UEMessage() + "\n \n");
        Console.WriteLine(cError3.UEMessage() + "\n \n");
        Console.ReadKey();

        //*********************************************************************************
        //Inheritance
        //*********************************************************************************
        Horse horse = new Horse();
        horse.Name = "Horse";
        horse.Age = 7;
        horse.Generation = "Original";

        Console.Clear();
        Console.WriteLine("*************************** HORSE ***************************");
        Console.WriteLine("Animal Name: " + horse.Name);
        Console.WriteLine("Animal Age: " + horse.Age.ToString());
        Console.WriteLine("Animal Generation: " + horse.Generation);
        Console.WriteLine("Animal Sound: " + horse.DoSound());
        Console.WriteLine("Poisonous Status: " + horse.IsPoisonous());
        Console.WriteLine("Domestic Status: " + horse.IsDomestic());
        Console.WriteLine("Animal Usage: " + horse.Usage(2));
        Console.WriteLine("Life Place: " + horse.LifePlace(1));
        Console.ReadKey();

        Dog dog = new Dog();
        dog.Name = "Adolf";
        dog.Age = 3;
        dog.Generation = "German Shepherd";

        Console.Clear();
        Console.WriteLine("*************************** DOG ***************************");
        Console.WriteLine("Animal Name: " + dog.Name);
        Console.WriteLine("Animal Age: " + dog.Age.ToString());
        Console.WriteLine("Animal Generation: " + dog.Generation);
        Console.WriteLine("Animal Sound: " + dog.DoSound());
        Console.WriteLine("Poisonous Status: " + dog.IsPoisonous());
        Console.WriteLine("Domestic Status: " + dog.IsDomestic());
        Console.WriteLine("Life Place: " + dog.LifePlace(1));
        Console.ReadKey();

        Hedgehog hh = new Hedgehog();
        hh.Name = "Hedgehog";
        hh.Age = 4;
        hh.Generation = "Atelerix";

        Console.Clear();
        Console.WriteLine("*************************** Hedgehog ***************************");
        Console.WriteLine("Animal Name: " + hh.Name);
        Console.WriteLine("Animal Age: " + hh.Age.ToString());
        Console.WriteLine("Animal Generation: " + hh.Generation);
        Console.WriteLine("Animal Sound: " + hh.DoSound());
        Console.WriteLine("Poisonous Status: " + hh.IsPoisonous());
        Console.WriteLine("Domestic Status: " + hh.IsDomestic());
        Console.WriteLine("Life Place: " + hh.LifePlace(0));
        Console.ReadKey();

        Wolf wolf = new Wolf();
        wolf.Name = "Wolf";
        wolf.Age = 4;
        wolf.Generation = "Atelerix";

        Console.Clear();
        Console.WriteLine("*************************** Wolf ***************************");
        Console.WriteLine("Animal Name: " + wolf.Name);
        Console.WriteLine("Animal Age: " + wolf.Age.ToString());
        Console.WriteLine("Animal Generation: " + wolf.Generation);
        Console.WriteLine("Animal Sound: " + wolf.DoSound());
        Console.WriteLine("Poisonous Status: " + wolf.IsPoisonous());
        Console.WriteLine("Domestic Status: " + wolf.IsDomestic());
        Console.WriteLine("Life Place: " + wolf.LifePlace(0));
        Console.WriteLine("Is Hunter: " + wolf.IsHunter());
        Console.ReadKey();

        Pelican peli = new Pelican();
        peli.Name = "Pelican";
        peli.Age = 5;
        peli.Generation = "Brown";
        peli.UniqueWeight = 45.87;

        Console.Clear();
        Console.WriteLine("*************************** Pelican ***************************");
        Console.WriteLine("Animal Name: " + peli.Name);
        Console.WriteLine("Animal Age: " + peli.Age.ToString());
        Console.WriteLine("Animal Generation: " + peli.Generation);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Unique Properties (Weight): " + peli.UniqueWeight);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Animal Sound: " + peli.DoSound());
        Console.WriteLine("Poisonous Status: " + peli.IsPoisonous());
        Console.WriteLine("Domestic Status: " + peli.IsDomestic());
        Console.WriteLine("Life Place: " + peli.LifePlace(2));
        Console.WriteLine("Is Migratory: " + peli.IsMigratory());
        Console.WriteLine("Can Swim: " + peli.CanSwim());
        Console.WriteLine("Max Fly: " + peli.Maxfly().ToString() + " m");
        Console.ReadKey();

        Flamingo feli = new Flamingo();
        feli.Name = "Flamingo";
        feli.Age = 5;
        feli.Generation = "Brown";
        feli.UniqueLifeStyle = "Long Leg, Crooked Beak";

        Console.Clear();
        Console.WriteLine("*************************** Flamingo ***************************");
        Console.WriteLine("Animal Name: " + feli.Name);
        Console.WriteLine("Animal Age: " + feli.Age.ToString());
        Console.WriteLine("Animal Generation: " + feli.Generation);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Unique Properties (Life Style): " + feli.UniqueLifeStyle);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Animal Sound: " + feli.DoSound());
        Console.WriteLine("Poisonous Status: " + feli.IsPoisonous());
        Console.WriteLine("Domestic Status: " + feli.IsDomestic());
        Console.WriteLine("Life Place: " + feli.LifePlace(2));
        Console.WriteLine("Is Migratory: " + feli.IsMigratory());
        Console.WriteLine("Can Swim: " + feli.CanSwim());
        Console.WriteLine("Max Fly: " + feli.Maxfly().ToString() + " m");
        Console.ReadKey();

        Swan swan = new Swan();
        swan.Name = "Swan";
        swan.Age = 5;
        swan.Generation = "Brown";
        
        Console.Clear();
        Console.WriteLine("*************************** Swan ***************************");
        Console.WriteLine("Animal Name: " + swan.Name);
        Console.WriteLine("Animal Age: " + swan.Age.ToString());
        Console.WriteLine("Animal Generation: " + swan.Generation);
        Console.WriteLine("Animal Sound: " + swan.DoSound());
        Console.WriteLine("Poisonous Status: " + swan.IsPoisonous());
        Console.WriteLine("Domestic Status: " + swan.IsDomestic());
        Console.WriteLine("Life Place: " + swan.LifePlace(2));
        Console.WriteLine("Is Migratory: " + swan.IsMigratory());
        Console.WriteLine("Can Swim: " + swan.CanSwim());
        Console.WriteLine("Max Fly: " + swan.Maxfly().ToString() + " m");
        Console.ForegroundColor = ConsoleColor.Red;
        swan.RootWord();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();

        WolfMan wm = new WolfMan();
        wm.Name = "WolfMan";
        wm.Age = 4;
        wm.Generation = "Gray Wolf";

        Console.Clear();
        Console.WriteLine("*************************** Wolf Man ***************************");
        Console.WriteLine("Animal Name: " + wm.Name);
        Console.WriteLine("Animal Age: " + wm.Age.ToString());
        Console.WriteLine("Animal Generation: " + wm.Generation);
        Console.WriteLine("Animal Sound: " + wm.DoSound());
        Console.WriteLine("Poisonous Status: " + wm.IsPoisonous());
        Console.WriteLine("Domestic Status: " + wm.IsDomestic());
        Console.WriteLine("Life Place: " + wm.LifePlace(0));
        Console.WriteLine("Is Hunter: " + wm.IsHunter());
        Console.WriteLine("Interface IPerson Talk: \n");
        wm.Talk();
        Console.ReadKey();

        /* 
         * 13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
         * We should add new attributes in the Bird class.
         * 
         * 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
         * We should add new attributes in the Animal class.
         */

        Console.Clear();
        Console.WriteLine(">>>>> \t Show Animal Status \t <<<<<<");
        Console.WriteLine("Horse Status: " + horse.Stats());
        Console.WriteLine("Dog Status: " + dog.Stats());
        Console.WriteLine("Hedgehog Status: " + hh.Stats());
        Console.WriteLine("Wolf Status: " + wolf.Stats());
        Console.WriteLine("Pelican Status: " + peli.Stats());
        Console.WriteLine("Flamingo Status: " + feli.Stats());
        Console.WriteLine("Swan Status: " + swan.Stats());
        Console.WriteLine("Wolf Man Status: " + wm.Stats());
        Console.WriteLine("Wolf Status override method: " + wolf.Stats());

        /*
         * 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
         * Because they have a different type, we couldn't assign them to each other.
         * 
         * 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
         * It should be an Animal array then we can save all classes of animals.
         */

        Animal[] animal = { horse, dog, hh, feli, wolf, peli, swan, wm};
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("############ Show array of animals #########");
        foreach(Animal anim in animal)
        {
            Console.WriteLine(anim.Stats());
        }
        Console.ForegroundColor = ConsoleColor.Gray;

        /*
         * 13. F: Förklara vad det är som händer.
         * Because the Animal class is a parent and the other classes are a child so, the child classes inherit from their parents. 
         * For this reason, we can create an array from Animal and add all types of classes on each element of array.
         */

        Console.WriteLine("Call LovelyDog method from the dog identifier.");
        dog.LovlyDog();

        Console.WriteLine("Call LovelyDog method from the Animal identifier.");
        /* 
         * we couldn't access a child method from parents, if it's so then we can break inheritance rules.
         */


    }

    private static void PrintStatusObject(Person person0, string objName)
    {
        Console.Clear();
        Console.WriteLine($"******************* {objName} ************************");
        Console.WriteLine("{0,15} \t {1,15}", "First Name:",person0.Fname); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15}", "Last Name:",person0.Lname); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15}", "Age:",person0.Age); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15}", "Height:",person0.Height); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15}", "Weight:",person0.Weight); //return to value by get method
        Console.WriteLine("*********************************************************\n\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key to continue...");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }

    private static void PrintDifferent(Person oldPerson, Person newPerson, string objName, string hint)
    {
        Console.Clear();
        Console.WriteLine(hint);
        Console.WriteLine($"************************* {objName} ******************************");
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "", "Old Value", "New Value");
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "First Name:", oldPerson.Fname, newPerson.Fname); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "Last Name:", oldPerson.Lname, newPerson.Lname); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "Age:",oldPerson.Age, newPerson.Age); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "Height:",oldPerson.Height, newPerson.Height); //return to value by get method
        Console.WriteLine("{0,15} \t {1,15} \t {2,15}", "Weight:",oldPerson.Weight, newPerson.Weight); //return to value by get method
        Console.WriteLine("*********************************************************************\n\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key to continue...");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
}