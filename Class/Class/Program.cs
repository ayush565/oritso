using System;

public class Person
{
	private string name;
	private Int16 age;
	private string sex;

	public string Name
	{
		get { return this.name; }
		set { this.name = value; }
	}
	public Int16 Age
	{
		get { return this.age; }
		set { this.age = value; }
	}
	public string Sex
	{
		get { return this.sex; }
		set { this.sex = value; }
	}
}

public class class2
{
	static void Main(string[] args)
	{
		Person p = new Person();
		p.Age = 21;
		p.Name = "Ayush";
		p.Sex = "Male";
		Console.WriteLine("The person {0} is {1} years old {2}.", p.Name, p.Age, p.Sex);
	}
}
