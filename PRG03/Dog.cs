using System;

class Dog : Animal
{
	public Dog() { }

    public override string DoSound() { return "Woof"; }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return true; }
}
