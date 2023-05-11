
// single quote identifies a char
// double quotes identifies a string

string data = "Tim,Sue,Bob,Jane,Frank";

string[] firstNames = data.Split(',');

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 2, 3, 4 };