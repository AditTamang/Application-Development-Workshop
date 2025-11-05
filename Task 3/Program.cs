// Variable declarations
byte myByte = 255;
short myShort = 94;
int myInt = 42;
long myLong = 15;
float myFloat = 3.12f;
double myDouble = 3.14159343;
decimal myDecimal = 3.1415926535897932384626433832m;
char myChar = 'M';
bool isGarib = true;

// Conversions
int number = 42;
string numberAsString = number.ToString();   // int → string

string strValue = "3.14";
double strToDouble = Convert.ToDouble(strValue); // string → double

// Print results
Console.WriteLine("byte: " + myByte);
Console.WriteLine("short: " + myShort);
Console.WriteLine("int: " + myInt);
Console.WriteLine("long: " + myLong);
Console.WriteLine("float: " + myFloat);
Console.WriteLine("double: " + myDouble);
Console.WriteLine("decimal: " + myDecimal);
Console.WriteLine("char: " + myChar);
Console.WriteLine("bool: " + isGarib);
Console.WriteLine("int to string: " + numberAsString);
Console.WriteLine("string to double: " + strToDouble);
