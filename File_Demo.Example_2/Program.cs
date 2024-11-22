using (var file = new StreamReader("example_2.txt"))
{
    var text = file.ReadToEnd();
    Console.WriteLine(text);
}

/*using (var reader = new StringReader("example_2.txt"))
{
    do
    {
        var line = reader.ReadLine();
        if (line == null) break;
        Console.WriteLine(line);
    } while (true);
}*/

using (var file = new StreamWriter("example_2.dat", append: true))
{
    file.WriteLine("Hello");
}
