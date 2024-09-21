# CSharpArrayAndListExercises

Please complete the questions below

1: Student Options</br>
Create an array of five strings to contain a student's option choices</br>
Using a for loop take user input to populate each of the choices</br>
Then output them to the console</br>

2: Weekly Attendence</br>
Create a two dimensional array to represent student attendance data for a school of 980 pupils</br>
The data is as follows</br>
Week 1: 968, 890, 960, 950, 901</br>
Week 2: 977, 923, 923, 950, 900</br>
Week 3: 970, 956, 976, 960, 897</br>
Week 4: 912, 942, 959, 970, 888</br>
Note that to initialise a two dimensional array curly brackets are required as illustrated below</br>
```csharp
int[,] numbers = { { 4, 5 }, { 9, 3 }, { 6, 2 }, { 8, 13 } };
```
Make the following options available to the user</br>
1: Find the attendance for a particular week and day</br> 
2: Find the average attendance for a particular week</br>
3: Find the average attendance for a particular day</br>
Please break this task down into sub programs</br>
You will need a procedure for the main task and one for each menu option</br>
No need to worry about validating the user input unless you wish to</br>
		
3: Temperatures</br>
Populate a list of doubles to represent daily temperatures over two weeks</br>
Calculate and output the min, max and average temperatures over the time period</br>
Sort the list in ascending order and output it</br>
You may find the functions Max, Min, Average and Sort which you can call on a list are helpful</br>

4: Employees</br>
Populate a list of employee data for at least five employees with a firstname, surname and date of birth.</br>
Use a tuple to do this.</br>
Below is an example of using a tuple to represent an item in a shopping basket</br>
```csharp
List<(string item, int number)> shoppingList =
			[
				("BakedBeans", 2),
				("Apples", 6)
			];
```
Output the names of the oldest and youngest employees</br> 
Output out how many students were born after 1990</br>
Create a new list of strings with the full names of all the employees and output this</br>
You may find the functions OrderBy, Count and Select which you can call on a list are helpful</br>

5: Noughts And Crosses (Extension)</br>
Write a game of noughts and crosses.</br>
Players should be able to choose their move</br>
It should print the state of the board after each player has chosen a move</br>
The game will end when either there are no available spaces left on the board or one of the players has won.</br>
Break into suitable subprograms preferring functions where appropriate</br>
