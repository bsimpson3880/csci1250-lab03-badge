/*
* Name: Bryce Simpson
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/



Console.Write("What is your name?");
string fullName = Console.ReadLine();
fullName = fullName.Trim();
fullName = fullName.ToUpper();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string username = firstName.Substring(0, 1) + lastName;
string lowerUsername = username.ToLower();
string firstInitials = firstName.Substring(0, 1);
string lastInitials = lastName.Substring(0, 1);
int lastNameLength = lastName.Length;
Console.WriteLine($"Name on badge: {firstName} {lastName}");
Console.WriteLine($"Username: {lowerUsername}");
Console.WriteLine($"Initials: {firstInitials}.{lastInitials}.");
Console.WriteLine($"Letters in last name: {lastNameLength}");

Random rng = new Random();
int studentID = rng .Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker Number: {lockerNumber}");

Console.Write("What is the dorm's x coordinate?");
double dormX = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the dorm's y coordinate?");
double dormY = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the classroom's x coordinate?");
double classX = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the classroom's y coordinate?");
double classY = Convert.ToDouble(Console.ReadLine());

Console.Write("What is your walking speed in feet per second?");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));

System.Console.WriteLine($"Distance: {distance:F1} feet");
int totalSeconds =(int)Math.Round((distance / walkingSpeed));
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

System.Console.WriteLine($"Estimated walking time: {minutes} minutes and {seconds} seconds");

// the badge


double iD = studentID % 9;

Console.WriteLine("FULL RECEIPT");
Console.WriteLine("Full Name: " + fullName);
Console.WriteLine($"Name on badge: {firstName} {lastName}");
Console.WriteLine($"Username: {lowerUsername}");
Console.WriteLine($"Initials: {firstInitials}.{lastInitials}.");
Console.WriteLine($"Letters in last name: {lastNameLength}");
Console.WriteLine("");
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker Number: {lockerNumber}");
Console.WriteLine("");
Console.WriteLine("Dorm x: " + dormX);
Console.WriteLine("Dorm y: " + dormY);
Console.WriteLine("Classroom x: " + classX);
Console.WriteLine("Classroom y: " + classY);
Console.WriteLine($"Walking speed: {walkingSpeed} feet per second");
Console.WriteLine("");
Console.WriteLine($"Distance: {distance:F1} feet");
Console.WriteLine($"Estimated walking time: {minutes} minutes and {seconds} seconds");
Console.WriteLine("");
Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
System.Console.WriteLine("NAME".PadRight(10) + fullName);
System.Console.WriteLine("USERNAME".PadRight(10) + lowerUsername);
System.Console.WriteLine("ID".PadRight(10) + studentID + "-" + iD);
System.Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
System.Console.WriteLine($"WALK".PadRight(10) + $"{minutes} min"  + $"{seconds} sec" );
Console.WriteLine("==================================");
