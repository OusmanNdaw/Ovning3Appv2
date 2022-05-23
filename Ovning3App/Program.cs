using System;

public class Person
{

	// privata fält: age, fName, lName, height, weight
	int age, string fName, string lName, double height, double weight;
	Person(int age, string fName, string lName, double height, double weight)
	{

		/*
		 Kasta ett undantag av typen ArgumentException i varje property om dess
		 validering inte fullföljs, undantaget ska innehålla ett beskrivande
		 meddelande.
		 Se till att hantera undantagen i Program-klassen med en try-catch block.

		try 
		{
		  //  Block of code to try
			  ArgumentException
			  beskrivande meddelande
				if(){}

		}
		catch (Exception e)
		{
		  //  Block of code to handle errors
		}
		 */
		// Davids förändring
		/*
		 * example:
		try
		{
		  int[] myNumbers = {1, 2, 3};
		  Console.WriteLine(myNumbers[10]);
		}
		catch (Exception e)
		{
		  Console.WriteLine(e.Message);
		}
		 
		 
		 */

		public Person(int age)
		{
			this.age = age;
			int age > 0;


			try
			{
				// Block of code to try
				// ArgumentException
				// beskrivande meddelande
				if (age <= 0) { }

			}
			catch (Exception e)
			{
				//  Block of code to handle errors
			}

		}

		public Person(string lName)
		{
			this.lName = lName;
			/*
			 must count the letters in lname
			letters shouldnt be less than 3 and not longer than 15
			 */


			try
			{
				//  Block of code to implement
				// ArgumentException
				// beskrivande meddelande
				// if () { }

			}
			catch (Exception e)
			{
				//  Block of code to handle errors
			}

		}

		public Person(int height)
		{
			this.height = height;


			try
			{
				//  Block of code to try
				// ArgumentException
				// beskrivande meddelande
				//	if () { }

			}
			catch (Exception e)
			{
				//  Block of code to handle errors
			}

		}
		public Person(int weight)
		{
			this.weight = weight;

			try
			{
				//  Block of code to try
				//	ArgumentException
				//  beskrivande meddelande
				//	if () { }

			}
			catch (Exception e)
			{
				//  Block of code to handle errors
			}

		}
	}

	private static Person(ref int age, ref string fName, ref string lName, ref double height, ref double weight)
	{

		public int Person(age) { get { return age}; set{ age = value; } };

		public string Person(fNane) { get{ return fName}; set{ fName = value; } };

		public string Person(lName) { get{ return lName}; set{ lName = value; } };

		public int Person(height) get { { return height}; set{ height = value; } };

		public int Person(weight) get{ { return weight}; set{ weight = value; } };

	}

	private Person(string fName)
	{
		this.fName = fName;
		/* must count the letters in fName
         * letters shouldnt be less than 2 and not longer than 10
         */
		/*
        #if
         * 
        * how to count letters in c#
        * int numberOfLetters = yourWord.Length;
        */


		try
		{
			//  Block of code to try
			// ArgumentException
			// beskrivande meddelande
			//if () { }

		}
		catch (Exception e)
		{
			//  Block of code to handle errors
		}

	}

	public int age { get; private set; }
	public string fName { get; private set; }
}


