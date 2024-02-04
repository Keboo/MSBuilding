using CoderStringConcat.Core;
using Microsoft.Build.Framework;

namespace CoderStringConcat.Build;

public class CscTask : Microsoft.Build.Utilities.Task
{
    [Required]
    public ITaskItem[] CoderFiles { get; set; } = null!;

    [Required]
    public string OutputFile { get; set; } = "";

    public override bool Execute()
    {
        IEnumerable<string> coders = CoderFiles.Select(coderFile => File.ReadAllText(coderFile.ItemSpec));
        FileInfo outputFile = new(OutputFile);
        Task.Run(async () => await Compiler.CompileAsync(coders, outputFile)).Wait();
        return true;
    }
}
