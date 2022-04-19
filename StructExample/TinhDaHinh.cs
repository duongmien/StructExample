using System;
using System.Collections.Generic;
using System.Text;

namespace StructExample
{
    class TinhDaHinh
	{
		public static void Input(System.Collections.Generic.List<Polygons> List)
		{
			int CatchKey;
			do
			{
				Console.Write("\tPress 1 to input Quadrangle.\n");
				Console.Write("\tPress 2 to input Triangle.\n");
				Console.Write("\tPress 3 to input Parallelogram.\n");
				Console.Write("\tPress 4 to input RectAngle.\n");
				Console.Write("\tPress 5 to input Square.\n");
				Console.Write("\tPress 6 to back to the main menu.\n");
				while ((CatchKey && CatchKey != 1 && CatchKey != 2 && CatchKey != 3 && CatchKey != 4 && CatchKey != 5 && CatchKey != 6 = bool.Parse(ConsoleInput.ReadToWhiteSpace(true))).Length > 0)
				{
					Console.Write("Just Press in range 1,2,3,4,5,6. Again: ");
				}
				switch (CatchKey)
				{
					case 1:
						List.Add(new Quadrangle());
						List[List.Count - 1].Set();
						break;
					case 2:
						List.Add(new Triangle());
						List[List.Count - 1].Set();
						break;
					case 3:
						List.Add(new Parallelogram());
						List[List.Count - 1].Set();
						break;
					case 4:
						List.Add(new RectAngle());
						List[List.Count - 1].Set();
						break;
					case 5:
						List.Add(new Square());
						List[List.Count - 1].Set();
						break;
					default:
						break;
				}
			} while (CatchKey != 6);
		}
		public static void Print(System.Collections.Generic.List<Polygons> List)
		{
			Console.Write("-----Print List Polygons----\n");
			for (int i = 0; i < List.Count; i++)
			{
				List[i].Print();
				Console.Write("\n");
			}
			Console.Write("--------------------------\n");
		}
		public static void Move(System.Collections.Generic.List<Polygons> List)
		{
			Console.Write("Input vector(x,y) to move: ");
			int x;
			int y;
			x = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			y = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			for (int i = 0; i < List.Count; i++)
			{
				List[i].Move(x, y);
			}
		}
		internal static void Main()
		{
			List<Polygons> ListPolygons = new List<Polygons>();
			ListPolygons.Resize(0);
			int CatchKey;
			do
			{
				Console.Write("Manage Polygons: \n");
				Console.Write("\tPress 1 to input one kind Polygons.\n");
				Console.Write("\tPress 2 to print and move all list of Polygonss.\n");
				Console.Write("\tPress 3 to exit.\n");
				while ((CatchKey && CatchKey != 1 && CatchKey != 2 && CatchKey != 3 = bool.Parse(ConsoleInput.ReadToWhiteSpace(true))).Length > 0)
				{
					Console.Write("Just Press in range 1,2,3. Again: ");
				}
				switch (CatchKey)
				{
					case 1:
						Input(ListPolygons);
						break;
					case 2:
						Print(ListPolygons);
						char x;
						Console.Write("Move? (y,n): ");
						while ((x && x != 'n' && x != 'y' = bool.Parse(ConsoleInput.ReadToWhiteSpace(true))).Length > 0)
						{
							Console.Write("Just Press y or n!Again.\n");
						}
						if (x == 'y')
						{
							Move(ListPolygons);
						}
						break;
					default:
						break;
				}
			} while (CatchKey != 3);
			for (int i = 0; i < ListPolygons.Count; i++)
			{
				if (ListPolygons[i] != null)
				{
					ListPolygons[i].Dispose();
				}
			}
			Console.Write("Thanks!");
		}
	}

//Helper class added by C++ to C# Converter:

//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2022 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to convert some of the C++ std::vector methods to C#.
//----------------------------------------------------------------------------------------
internal static class VectorHelper
	{
		public static void Resize<T>(this List<T> list, int newSize, T value = default(T))
		{
			if (list.Count > newSize)
				list.RemoveRange(newSize, list.Count - newSize);
			else if (list.Count < newSize)
			{
				for (int i = list.Count; i < newSize; i++)
				{
					list.Add(value);
				}
			}
		}

		public static void Swap<T>(this List<T> list1, List<T> list2)
		{
			List<T> temp = new List<T>(list1);
			list1.Clear();
			list1.AddRange(list2);
			list2.Clear();
			list2.AddRange(temp);
		}

		public static List<T> InitializedList<T>(int size, T value)
		{
			List<T> temp = new List<T>();
			for (int count = 1; count <= size; count++)
			{
				temp.Add(value);
			}

			return temp;
		}

		public static List<List<T>> NestedList<T>(int outerSize, int innerSize)
		{
			List<List<T>> temp = new List<List<T>>();
			for (int count = 1; count <= outerSize; count++)
			{
				temp.Add(new List<T>(innerSize));
			}

			return temp;
		}

		public static List<List<T>> NestedList<T>(int outerSize, int innerSize, T value)
		{
			List<List<T>> temp = new List<List<T>>();
			for (int count = 1; count <= outerSize; count++)
			{
				temp.Add(InitializedList(innerSize, value));
			}

			return temp;
		}
	}

	//Helper class added by C++ to C# Converter:

	//----------------------------------------------------------------------------------------
	//	Copyright © 2006 - 2022 Tangible Software Solutions, Inc.
	//	This class can be used by anyone provided that the copyright notice remains intact.
	//
	//	This class provides the ability to convert basic C++ 'cin' and C 'scanf' behavior.
	//----------------------------------------------------------------------------------------
	internal static class ConsoleInput
	{
		private static bool goodLastRead = false;
		public static bool LastReadWasGood
		{
			get
			{
				return goodLastRead;
			}
		}

		public static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
		{
			string input = "";

			char nextChar;
			while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				//accumulate leading white space if skipLeadingWhiteSpace is false:
				if (!skipLeadingWhiteSpace)
					input += nextChar;
			}
			//the first non white space character:
			input += nextChar;

			//accumulate characters until white space is reached:
			while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				input += nextChar;
			}

			goodLastRead = input.Length > 0;
			return input;
		}

		public static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
		{
			string input = "";

			char nextChar;
			if (unwantedSequence != null)
			{
				nextChar = '\0';
				for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
				{
					if (char.IsWhiteSpace(unwantedSequence[charIndex]))
					{
						//ignore all subsequent white space:
						while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
						{
						}
					}
					else
					{
						//ensure each character matches the expected character in the sequence:
						nextChar = (char)System.Console.Read();
						if (nextChar != unwantedSequence[charIndex])
							return null;
					}
				}

				input = nextChar.ToString();
				if (maxFieldLength == 1)
					return input;
			}

			while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				input += nextChar;
				if (maxFieldLength == input.Length)
					return input;
			}

			return input;
		}
	}
}
}
