using System;

class Hedgehog : Animal
{
    public Hedgehog() { }

    public override string DoSound() { return "Chirping"; }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return false; }
}

