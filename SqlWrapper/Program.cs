var content = await GetContentFromInputFile();

if (string.IsNullOrEmpty(content))
{
    Console.WriteLine("File's content is null or empty");
}



Console.WriteLine("Enter any key to exit.");
Console.ReadKey();

async Task<string> GetContentFromInputFile()
{
    Console.Write("Enter input file path: ");
    var path = Console.ReadLine();

    if (File.Exists(path))
    {
        return await File.ReadAllTextAsync(path);
    }
    else
    {
        Console.WriteLine("File not found.");
        return String.Empty;
    }
}