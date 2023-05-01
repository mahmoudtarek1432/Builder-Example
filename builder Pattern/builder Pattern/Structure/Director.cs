using System;

public class Director
{
	public void construct( Builder builder )
	{
		builder.BuildPartA();
		builder.BuildPartB();
	}
}
