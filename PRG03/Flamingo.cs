using System;

class Flamingo : Bird
{
    private string uniqueLifeStyle;
    public Flamingo() { }
    public string UniqueLifeStyle {get; set;}

    public override string DoSound() { return "chalkboard screeching"; }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return false; }
    public override bool IsMigratory() { return true; }
    public override bool CanSwim() { return true; }
    public override int Maxfly() { return 200; }

}
