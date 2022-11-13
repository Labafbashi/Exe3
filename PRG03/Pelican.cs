using System;

class Pelican : Bird
{
    private double uniqueWeight;
    public Pelican() { }
    public double UniqueWeight { get; set; }

    public override string DoSound() { return "Squawk";  }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return false; }
    public override bool IsMigratory() { return true; }
    public override bool CanSwim() { return true; }
    public override int Maxfly() { return 200; }

    
}
