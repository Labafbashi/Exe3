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
        PrintDifferent(persTemp, person4, nameof(person4));

        

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

    private static void PrintDifferent(Person oldPerson, Person newPerson, string objName)
    {
        Console.Clear();
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