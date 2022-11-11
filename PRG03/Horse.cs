using System;

class Horse : Animal
{
	public Horse()
	{
	}

	public override string DoSound()
	{
		return "neigh";
	}

	public override bool IsPoisonous()
	{
		throw new NotImplementedException();
	}
}
