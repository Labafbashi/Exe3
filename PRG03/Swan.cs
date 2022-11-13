using System;

class Swan : Bird
{
	public Swan() { }

    public override string DoSound() { return "oh-OH"; }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return false; }
    public override bool IsMigratory() { return true; }
    public override bool CanSwim() { return true; }
    public override int Maxfly() { return 300; }

    public void RootWord()
    {
        Console.WriteLine("\t ############# Unique Method ##############");
        Console.WriteLine("\t English  ==>  Swan");
        Console.WriteLine("\t German  ==>  Schwan");
        Console.WriteLine("\t Dutch  ==>  Zwaan");
        Console.WriteLine("\t Swedish  ==>  Svan");
        Console.WriteLine("\t Indo-European  ==>  Swen");
        Console.WriteLine("\t Old French  ==>  Cigne or Cisne");
        Console.WriteLine("\t Latin  ==>  Cygnus");
        Console.WriteLine("\t Greek  ==>  κύκνος kýknos");
    }
}
