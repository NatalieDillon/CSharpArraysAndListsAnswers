namespace CSharpArraysAndLists.Classes
{
	public class Exercises
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
		// Sort the list in ascending order and output it
		private static void Temperatures()
		{

		}

		// 4: Students
		// Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
		// Output the names of the oldest and youngest students
		// Output out how many students were born after 2010
		// Create a new list of strings with the full names of all the students and output this

		// 5: Noughts And Crosses (Extension)
		// Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
		// Print the names of the oldest and youngest students
		// Print out how many students were born after 2010
		// Create a new list of strings with the full names of all the students and print this out  

		// 6: TV Remote (Extension)
		// Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
		// Print the names of the oldest and youngest students
		// Print out how many students were born after 2010
		// Create a new list of strings with the full names of all the students and print this out  

	}
}