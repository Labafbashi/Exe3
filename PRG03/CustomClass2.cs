using System;

class CustomClass2 : UserError
{
	public CustomClass2() { }

    public override string UEMessage()
    {
        return "This is a custome message for a custom class second.  \n \n  Custom Class 1";
    }
}
