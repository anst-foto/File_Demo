var text = File.ReadAllText("example_1.txt");
Console.WriteLine(text);

File.WriteAllText("example_1.dat", text);