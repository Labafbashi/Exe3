using System;

class Horse : Animal
{
    public Horse() { }

    public override string DoSound() { return "Neigh";  }
    public override bool IsPoisonous() { return false; }
    public override bool IsDomestic() { return true; }
    
    public string Usage(int num)
    {
        // 1. Champion
        // 2. Police
        // 3. Packhorse
        // 4. Wild
        switch (num)
        {
            case 0: return "Champion"; break;
            case 1: return "Police"; break;
            case 2: return "Packhorse"; break;
            case 3: return "Wild"; break;
            default: return "Unknown"; break;
        }
    }

}
