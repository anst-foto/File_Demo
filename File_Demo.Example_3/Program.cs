using System.Text;

using (var file = new FileStream(
           path: "example_3.txt",
           mode: FileMode.Open,
           access: FileAccess.Read))
{
    /*using (var textFile = new StreamReader(file))
    {
        var text = textFile.ReadToEnd();
        Console.WriteLine(text);
    }*/
    
    var buffer = new byte[file.Length];
    file.Read(buffer, 0, buffer.Length);
    var text = Encoding.UTF8.GetString(buffer);
    text = text.Replace("\uFEFF", "");
    Console.WriteLine(text);
}

using (var file = new FileStream(
           path: "example_3.dat",
           mode: FileMode.Append,
           access: FileAccess.Write))
{
    /*using (var textFile = new StreamWriter(file))
    {
        textFile.WriteLine("Hello");
    }*/
    
    var buffer = Encoding.Default.GetBytes("Привет");
    file.Write(buffer, 0, buffer.Length);
}