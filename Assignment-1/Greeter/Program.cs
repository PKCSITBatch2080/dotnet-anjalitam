using System;
// to print the full name to console
 //Console.WriteLine("Enter your Full Name");
 //string fullName ="Anjali Tamang ";
 //Console.WriteLine(fullName);

// to define another variable FullName and initilize it with fullName in uppercase letters
//string fullName="Anjali Tamang";
//string cFullName= fullName.ToUpper();
//Console.WriteLine($"Hello, {cFullName} Ji!");

//to get fullName from user instead of initializing it 
//Console.WriteLine("Enter your full name:");
//string fullName = Console.ReadLine();
//Console.WriteLine($"Hello, {fullName} Ji!");

//to enter user's DOB
//Console.WriteLine("Enter your full name:");
//string fullName = Console.ReadLine();
//string cFullName = fullName.ToUpper();
//Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
//DateTime DOB = DateTime.Parse(Console.ReadLine()); 
//DateTime today = DateTime.Today;
//Console.WriteLine($"Hello, {cFullName} Ji!");
//Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");

//to calculate user's age as accurate as possible and dispaly it to console
Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
DateTime DOB = DateTime.Parse(Console.ReadLine()); // Parse user input into DateTime
DateTime today = DateTime.Today;

TimeSpan age = today - DOB; // Calculate age based on the difference between today and DOB

int years = (int)(age.TotalDays / 365.25);  // Adjusting for leap years
int months = (int)((age.TotalDays % 365.25) / 30.44);  // Approximate average number of days in a month
int weeks = (int)(age.TotalDays / 7);
int days = (int)(age.TotalDays);

 //Print the greeting, DOB, and age information to the console
Console.WriteLine($"Hello, ANJALI TAMANG Ji!");
Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");
Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");