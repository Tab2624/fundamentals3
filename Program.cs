// 1 Given a List of strings, iterate through the List and print out all the values
using System.Globalization;

static void PrintList(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine(name);
    }
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

// 2 Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int number in IntList)
    {
        sum += number;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

// 3 Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> IntList)
{
    int max = 0;
    foreach (int number in IntList)
    {
        if (number > max)
        {
            max = number;
        }
    }
    Console.WriteLine(max);
    return max;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);

// 4 Given a List of integers, return the List with all the values squared.
static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    foreach (int num in IntList)
    {
        Console.WriteLine(num);
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

// 5 Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    foreach (int num in IntArray)
    {
        Console.WriteLine(num);
    }
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

// 6 Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> hero in MyDictionary)
    {
        Console.WriteLine($"{hero.Key} - {hero.Value}");
    }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// 7 Given a search term, return true or false whether the given term is a key in a dictionary.
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    bool isMatch = false;
    foreach (KeyValuePair<string, string> hero in MyDictionary)
    {
        if (SearchTerm == hero.Key)
        {
            isMatch = true;
        }
    }
    return isMatch;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// 8 Given a List of names and a List of integers create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. 
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> newDict = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        newDict.Add(Names[i], Numbers[i]);
    }
    foreach (KeyValuePair<string, int> person in newDict)
    {
        Console.WriteLine($"{person.Key} - {person.Value}");
    }
    return newDict;
}
List<string> namesList = new List<string>();
namesList.Add("Tim");
namesList.Add("Bob");
namesList.Add("Kieth");
namesList.Add("Michael");
List<int> numList = new List<int>();
numList.Add(1);
numList.Add(2);
numList.Add(3);
numList.Add(4);
GenerateDictionary(namesList, numList);


// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here












