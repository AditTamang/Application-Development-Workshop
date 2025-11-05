// Birthdate
DateTime birthDate = new DateTime(2004, 11, 21); // <-- change to your birthday

// Current date and time
DateTime currentDate = DateTime.Now;

// Calculate age using TimeSpan
TimeSpan ageSpan = currentDate - birthDate;
double ageInYears = ageSpan.Days / 365.25; // approximate years

// Print results
Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
Console.WriteLine("Your Age (Years): " + (int)ageInYears);

// Add 10 days to your birthdate
DateTime newDate = birthDate.AddDays(10);
Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
