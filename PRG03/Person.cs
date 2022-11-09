
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class Person
{
	private string fname, lname;
	private int age;
	private double height, weight;

	public Person(string fname, string lname, int age, double height, double weight)
	{
        CheckValue('F', fname);
		CheckValue('L', lname);
		CheckValue('A', age.ToString());
		CheckValue('H', height.ToString());
		CheckValue('W',weight.ToString());



        this.fname = fname;
		this.lname = lname;
		this.age = age;
		this.height = height;
		this.weight = weight;
	}
	public Person()
	{
        this.fname = "default_fname";
        this.lname = "default_lname";
        this.age = 0;
        this.height = 0;
        this.weight = 0;
    }

    public string Fname   // property
	{
        get { return fname; }   // get method
        set { if (CheckValue('F', value)) fname = value; }  // set method
    }

	public string Lname
	{
		set { if (CheckValue('L', value)) lname = value; }
		get { return lname; }
	}

	public int Age
	{
		get { return age; }
		set { if (CheckValue('A', value.ToString())) age = value; }
	}

	public double Height
	{
		get { return height; }
		set { if (CheckValue('H', value.ToString())) height = value; }
	}
	
	public double Weight
	{
		get { return weight; }
		set { if (CheckValue('W', value.ToString())) weight = value; }
	}

	//by below method programm check the user sent a true value or not.
	
	private bool CheckValue (char code, string name) 
	{ 
		switch (code)
		{
			case 'F':
                if (name.Length > 2 && name.Length < 10)
                    return true;
                else
                    throw new ArgumentException($"'{nameof(name)}' cannot be null, empty or wrong lenght of First Name", nameof(name));
                break;
			case 'L':
                if (name.Length > 3 && name.Length < 15)
                    return true;
                else
                    throw new ArgumentException($"'{nameof(name)}' cannot be null, empty or wrong lenght of Last Name", nameof(name));
                break;
			case 'A':
				int age = Int32.Parse(name);
                if (age > 0 && age < 140) 
					return true; 
				else 
					throw new ArgumentException($"'{nameof(age)}' Wrong value, It's should between 0 to 140.", nameof(age));
                break;
			case 'H':
            case 'W':
                double height = double.Parse(name);
                if (height > 0 && height < 300)
                    return true;
                else
                    throw new ArgumentException($"'{nameof(height)}' Wrong value, It's should between 0 to 300.", nameof(height));
                break;
			default:
				return false;	

		}
		
		
	}

}
