using System;

abstract class Animal
{
	private string name;
	private int age;
	private string generation;
	
	public Animal() { }
    public Animal(string name, int age, string gen)
    {
        this.name = name;
        this.age = age;
        this.generation = gen;
    }

    public string Name { get; set; }
	public string Generation { get; set; }
	public int Age { get; set; }

	public abstract string DoSound();
	public abstract bool IsPoisonous();
	public abstract bool IsDomestic();
	public string LifePlace(int num)
	{
		// 1. Jungle
		// 2. Field
		// 3. Sea
		// 4. Desert
		switch (num)
		{
			case 0: return "Jungle"; break;
			case 1: return "field"; break;
			case 2: return "Sea"; break;
			case 3: return "Desert"; break;
			default: return "Unknown"; break;
        }

	}



}
