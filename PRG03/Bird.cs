using System;

abstract class Bird : Animal
{
	public Bird() { }

    public abstract bool IsMigratory();
    public abstract bool CanSwim();
    public abstract int Maxfly();

}
