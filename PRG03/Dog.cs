using System;

class Dog : Animal
{
	public Dog() { }

    public override string DoSound() { return "Woof"; }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return true; }

    public void LovlyDog()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This is a lovely dog!!!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
