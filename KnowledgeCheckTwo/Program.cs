// See https://aka.ms/new-console-template for more information

using KnowledgeCheckTwo;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Child>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var Child = new Child();

    Console.WriteLine("Enter the The Media Type: ");
    Child.mediaType = Console.ReadLine();

    Console.WriteLine("Enter The Artist's Name: ");
    Child.artistName = Console.ReadLine();

    Console.WriteLine("Enter the Song Title");
    Child.songTitle = Console.ReadLine();

    recordList.Add(Child);
}

Console.WriteLine("List of Record Details: ");
foreach(var Child in recordList)
{
    Console.WriteLine($"Media Type: {Child.mediaType}, Artist's Name: {Child.artistName}, Song Title: {Child.songTitle}");
}

// Print out the list of records using Console.WriteLine()

