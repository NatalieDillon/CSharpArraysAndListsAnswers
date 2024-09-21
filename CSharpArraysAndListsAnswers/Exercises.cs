using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysAndLists
{
	public static class Exercises
	{
		// 1: Student Options
		// Create an array of five strings to contain a student's option choices
		// Using a for loop take user input to populate each of the choices
		// Then output them to the console
		public static void StudentOptions()
		{
			string[] options = new string[5];
			for (int i = 0; i < options.Length; i++)
			{
				Console.Write("Please enter an option: ");
				string option = Console.ReadLine() ?? string.Empty;
				options[i] = option;
			}
			Console.WriteLine("Your options are: " + string.Join(", ", options));
		}


		// 2: Weekly Attendence
		// Create a two dimensional array to represent student attendance data for a school of 980 pupils
		// The data is as follows
		// Week 1: 968, 890, 960, 950, 901
		// Week 2: 977, 923, 923, 950, 900
		// Week 3: 970, 956, 976, 960, 897
		// Week 4: 912, 942, 959, 970, 888
		//
		// Note that to initialise a two dimensional array curly brackets are required as illustrated below</br>
		// int[,] numbers = { { 4, 5 }, { 9, 3 }, { 6, 2 }, { 8, 13 } };
		//
		// Make the following options available to the user
		// 1. Find the attendance for a particular week and day 
		// 2. Find the average attendance for a particular week
		// 3. Find the average attendance for a particular day
		// Please break this task down into sub programs
		// You will need a procedure for the main task and one for each menu option
		// No need to worry about validating the user input unless you wish to
		public static void StudentAttendance()
		{
			int[,] attendance = { { 968, 890, 960, 950, 901},
				{ 977, 923, 923, 950, 900 },
				{ 970, 956, 976, 960, 897 },
				{ 912, 942, 959, 970, 888 } };
			Console.WriteLine(" Please select: ");
			Console.WriteLine("1. To find the attendance for a particular week and day");
			Console.WriteLine("2. To find the average attendance for a particular week");
			Console.WriteLine("3. To find the average attendance for a particular day");
			int userInput = int.Parse(Console.ReadLine() ?? string.Empty);
			switch (userInput)
			{
				case 1:
					FindAttendance(attendance);
					break;
				case 2:
					FindWeeklyAverage(attendance);
					break;
				case 3:
					FindDailyAverage(attendance);
					break;
				default:
					Console.WriteLine("Option not recognised");
					break;
			}
		}

		private static void FindAttendance(int[,] attendanceRecords)
		{
			Console.Write(" Please enter the week number: ");
			int weekInput = int.Parse(Console.ReadLine() ?? string.Empty);
			Console.Write(" Please enter the day number: ");
			int dayInput = int.Parse(Console.ReadLine() ?? string.Empty);
			int attendance = attendanceRecords[weekInput - 1, dayInput - 1];
			Console.WriteLine($"Attendance in week {weekInput} and day {dayInput} is: {attendance}");
		}

		private static void FindWeeklyAverage(int[,] attendanceRecords)
		{
			Console.Write(" Please enter the week number: ");
			int weekInput = int.Parse(Console.ReadLine() ?? string.Empty);
			double weeklyTotal = 0;
			for (int i = 0; i < attendanceRecords.GetLength(1); i++)
			{
				weeklyTotal += attendanceRecords[weekInput - 1, i];
			}
			double average = weeklyTotal / attendanceRecords.GetLength(1);
			Console.WriteLine($"The average attendance in week {weekInput} is: {average:0.##}");
		}

		private static void FindDailyAverage(int[,] attendanceRecords)
		{
			Console.Write(" Please enter the day number: ");
			int dailyInput = int.Parse(Console.ReadLine() ?? string.Empty);
			double dailyTotal = 0;
			for (int i = 0; i < attendanceRecords.GetLength(0); i++)
			{
				dailyTotal += attendanceRecords[i, dailyInput - 1];
			}
			double average = dailyTotal / attendanceRecords.GetLength(1);
			Console.WriteLine($"The average attendance in day {dailyInput} is: {average:0.##}");
		}

		// 3: Temperatures
		// Populate a list of doubles to represent daily temperatures over two weeks
		// Calculate and output the min, max and average temperatures over the time period
		// Fine to use any of the methods available on the list
		// Sort the list in ascending order and output it
		public static void Temperatures()
		{
			List<double> temperatures = [ 22.4, 19.3, 28.4, 23.4, 19.6, 27.5, 20.0, 17.4, 23.8, 29.56, 25.7, 23.9, 26.7, 30.1 ];
			Console.WriteLine($"The minimum temperature is {temperatures.Min()}");
			Console.WriteLine($"The maximum temperature is {temperatures.Max()}");
			Console.WriteLine($"The maximum temperature is {temperatures.Max()}");
			Console.WriteLine($"The average is {temperatures.Average():0.##}");
			temperatures.Sort(); // Sorts the temperatures
			Console.WriteLine("The sorted temperatures are: " + string.Join(",", temperatures));
		}

		// 4: Employees
		// Populate a list of employee data for at least five employees with a firstname, surname and date of birth.
		// Use a tuple to do this.
		// Below is an example of using a tuple to represent an item in a shopping basket
		//List<(string item, int number)> shoppingList =
		//	[
		//		("BakedBeans", 2),
		//		("Apples", 6)
		//	];
		// Output the names of the oldest and youngest employees 
		// Output out how many students were born after 1990
		// Create a new list of strings with the full names of all the employees and output this
		// You may find the functions OrderBy, Count and Select which you can call on a list are helpful
		public static void Employees()
		{
			List<(string firstName, string surname, DateTime dateOfBirth)> employees = 
			[
				("Bob", "Dylan", new DateTime(1945, 10, 12)),
				("Jane", "Smith", new DateTime(2001, 11, 2)),
				("Tina", "Brown", new DateTime(1995, 04, 19)),
				("William", "Green", new DateTime(1982, 02, 23)),
				("Jenny", "Costa", new DateTime(1975, 07, 21)),
			];
			var sortedEmployees = employees.OrderBy(x => x.dateOfBirth).ToList();
			var youngest = sortedEmployees[sortedEmployees.Count - 1];
			Console.WriteLine($"The youngest employee is {youngest.firstName} {youngest.surname} who was born on {youngest.dateOfBirth:dd/MM/yyyy}");
			var oldest = sortedEmployees[0];
			Console.WriteLine($"The oldest employee is {oldest.firstName} {oldest.surname} who was born on {oldest.dateOfBirth:dd/MM/yyyy}");
			int bornAfter1990 = employees.Count(x => x.dateOfBirth.Year > 1990);
			Console.WriteLine($"{bornAfter1990} employees were born after 1990");
			List<string> fullNames = employees.Select(x => $"{x.firstName} {x.surname}").ToList();
			Console.WriteLine("Employee names are: " + string.Join(", ", fullNames));
		}

		// 5: Noughts And Crosses (Extension)
		// Write a game of noughts and crosses.
		// Players should be able to choose their move
		// It should print the state of the board after each player has chosen a move
		// The game will end when either there are no available spaces left on the board or one of the players has won.
		// Break into suitable subprograms preferring functions where appropriate




	}
}
