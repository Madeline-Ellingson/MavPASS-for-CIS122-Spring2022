// Written by Madeline Ellingson
// 1/12/2022

// - Create an array of integers
// - Make a method ElimminateDuplicates that takes in an array
// and gets rid of any duplicate numbers
// - Create a method RemoveHigher that takes in an array
// and removes any number that is not lower than the one before it


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_1_19_FirstQuiz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// First make an array of numbers
			int[] myArray = new int[] {4, 2, 2, 5, 3, 3, 9, 2};

			// Now make a new array with the same length of the array without duplicates
			int[] aNewArray = new int[EliminateDuplicates(myArray).Length];

			// Call EliminateDuplicates and assign the resulting array to aNewArray
			aNewArray = EliminateDuplicates(myArray);

			// Display the array elements
			foreach (int num in aNewArray)
			{
				Console.WriteLine(num);
			}

			// Call RemoveHigher and assign it back to aNewArray
			aNewArray = RemoveHigher(aNewArray);

			// Used to make a space so you can tell the difference between the arrays
			Console.WriteLine();

			// Display the array elements 
			foreach (int num in aNewArray)
			{
				Console.WriteLine(num);
			}

			// This must be put at the end of Main!
			Console.ReadLine();
		}

		// Methods
		public static int[] EliminateDuplicates(int[] anArray)
		{
			// Create a new list because you can add as many things as you want
			// They aren't a set length
			List<int> aList = new List<int>();

			// Go through each element in the array
			foreach (int num in anArray)
			{
				// Go through each element again
				for(int i = 0; i < anArray.Length; i++)
				{
					// Compare each element with all other elements in the array
					// Individually
					if (num != anArray[i])
					{
						// Check to see if the new list already contains
						// that element
						if (aList.Contains(num))
						{

						}
						// Add the element to the list
						else
						{
							aList.Add(num);
						}
					}
				}
			}

			// Create a new array with the same length as our list
			int[] newArray = new int[aList.Count];

			// Used for counting
			int z = 0;

			// Go through each number in the list
			foreach (int y in aList)
			{
				// z is used to get the index position in the array
				// Then we assign each value from the list to those
				// positions
				newArray[z] = y;

				// Add to z in order to keep going through the array
				z++;
			}

			// Return the new array
			// The quiz question asked to use arrays which is why
			// I copied the list we created back into an array
			// In reality using a list would be just fine
			return newArray;

		}

		public static int[] RemoveHigher(int[] anArray)
		{
			// Create a new list
			List<int> aList = new List<int>();

			// Go through each element in the array and add it to the list
			// That way we will be able to remove elements from the list without
			// having to worry about copying things
			for(int i = 0; i < anArray.Length; i++)
			{
				aList.Add(anArray[i]);
			}

			// j is used for counting
			int j = 0;

			// Go through each element in the array
			for(int i = 0; i < anArray.Length - 1; i++)
			{
				// Check to see if an element is lower than the one after it
				// The reason why we have to use j is because if the first element 
				// was lower than the second we would want to removve the second element but keep the first
				// If we used i instead of j it would move on and compare the new second element
				// to the third and so on. This way we can keep the first element as needed. 
				if (anArray[j] < anArray[i + 1])
				{
					// Remove the higher value
					aList.Remove(anArray[i + 1]);
				}
				else
				{
					// Since the value of the next number was lower than the first
					// We can move on to the next index. 
					// We also have to check to see if j has reached the end of the array
					if(j < anArray.Length - 1)
					{
						j++;
					}
				}
			}

			//Create a new array with the same length as our list
			int[] newArray = new int[aList.Count];

			// Used for counting
			int z = 0;

			// Go through and add each element of the list to the array
			// Again this probably isnt necessary and could have just been kept as
			// a list
			foreach (int y in aList)
			{
				newArray[z] = y;
				z++;
			}

			// Return the new array
			return newArray;

		}
	}
}
