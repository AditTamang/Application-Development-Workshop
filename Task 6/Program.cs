// List of favorite fruits
List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

// Add a new fruit
fruits.Add("Orange");

// Remove a fruit
fruits.Remove("Banana");

// Print all fruits
Console.WriteLine("Fruits in the list:");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Dictionary of fruit IDs
Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Banana" },
    { 3, "Mango" }
};

// Add a new entry
fruitDict.Add(4, "Orange");

// Print all dictionary entries
Console.WriteLine("\nFruit Dictionary:");
foreach (var item in fruitDict)
{
    Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
}
