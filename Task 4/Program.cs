// Create an array of 5 favorite numbers
int[] favNumbers = { 10, 3, 25, 7, 18 };

// Sort the array in ascending order
Array.Sort(favNumbers);

// Reverse the sorted array (now in descending order)
Array.Reverse(favNumbers);

// Print each element using a for loop
Console.WriteLine("Array elements after sorting and reversing:");
for (int i = 0; i < favNumbers.Length; i++)
{
    Console.WriteLine(favNumbers[i]);
}

// Find the index of a specific number
int searchNumber = 7;
int index = Array.IndexOf(favNumbers, searchNumber);

// Print result
Console.WriteLine();
Console.WriteLine($"The number {searchNumber} is at index: {index}");
