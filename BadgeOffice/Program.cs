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

Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
System.Console.WriteLine("NAME " + fullName.ToString().PadLeft(17));
System.Console.WriteLine("USERNAME" + lowerUsername.ToString().PadLeft(11));
double iD = studentID % 9;
System.Console.WriteLine("ID" + studentID.ToString().PadLeft(14) + "-" + iD.ToString());
System.Console.WriteLine("LOCKER" + lockerNumber.ToString().PadLeft(7));
System.Console.WriteLine($"WALK" + $"{minutes} min" .PadLeft(11) + $"{seconds} sec" .PadLeft(8));
Console.WriteLine("==================================");

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
System.Console.WriteLine("NAME " + fullName.ToString().PadLeft(17));
System.Console.WriteLine("USERNAME" + lowerUsername.ToString().PadLeft(11));
System.Console.WriteLine("ID" + studentID.ToString().PadLeft(14) + "-" + iD.ToString());
System.Console.WriteLine("LOCKER" + lockerNumber.ToString().PadLeft(7));
System.Console.WriteLine($"WALK" + $"{minutes} min" .PadLeft(11) + $"{seconds} sec" .PadLeft(8));
Console.WriteLine("==================================");
