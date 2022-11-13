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
        horse.Name = "AAAAAAAA";
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
        Console.ReadKey();

        Hedgehog hh = new Hedgehog();
        hh.Name = "BBBBBBB";
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
        Console.ReadKey();


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