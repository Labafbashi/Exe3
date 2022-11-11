using System;

abstract class Animal
{
	private string name;
	private int age;
	private string generation;


	public string Name { get; set; }
	public string Generation { get; set; }
	public int Age { get; set; }


	public abstract string DoSound() { get(); }
	public abstract bool IsPoisonous() { }

}
