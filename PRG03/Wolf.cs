using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Wolf : Animal
{
    public override string DoSound() { return "a-oooooo"; }
    public override bool IsDomestic() { return false; }
    public override bool IsPoisonous() { return false; }
    
    public Wolf() { }
    public bool IsHunter() { return true; }

    public override string Stats()
    {
        return "This is Override method for Wolf class. =====> " + Name + " " + Age.ToString() + " " + Generation;
    }
}
