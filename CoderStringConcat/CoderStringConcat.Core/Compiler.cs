namespace CoderStringConcat.Core;

public static class Compiler
{
    public static async Task CompileAsync(IEnumerable<string> coders, FileInfo outputFile)
    {
        using StreamWriter writer = new(outputFile.FullName, append: false);
        foreach (string coder in coders)
        {
            await writer.WriteLineAsync(coder);
        }
    }
}
