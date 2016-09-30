using System.IO;

static void Main(string[] args)
{
    var reader = new StreamReader(File.OpenRead(@Ctest.csv));
    Liststring listA = new Liststring();
    Liststring listB = new Liststring();
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(';');

        listA.Add(values[0]);
        listB.Add(values[1]);
    }
}