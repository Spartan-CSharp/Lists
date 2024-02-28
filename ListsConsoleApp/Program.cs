List<string> classRoster = new List<string>();
bool done = false;

do
{
	Console.Write("Enter student name: ");
	string? studentName = Console.ReadLine();

	if ( !string.IsNullOrEmpty(studentName) )
	{
		classRoster.Add(studentName);

	}

	Console.Write("Any more students (yes/no): ");
	string? moreStudents = Console.ReadLine();

	if ( moreStudents?.ToLower() == "no" )
	{
		done = true;
	}
} while ( !done );

Console.WriteLine($"There are {classRoster.Count} students in the class.");
