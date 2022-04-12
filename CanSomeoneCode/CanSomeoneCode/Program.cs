using System.CommandLine;

Option<string> coderOption = new("--coder", "The name of the coder");
coderOption.IsRequired = true;

RootCommand root = new()
{
    coderOption
};
root.SetHandler((string coder, IConsole console) =>
{
    if (string.Equals(coder, "kevin", StringComparison.InvariantCultureIgnoreCase))
    {
        console.WriteLine($"{coder} only thinks he can code");
    }
    else
    {
        console.WriteLine($"{coder} can code");
    }
}, coderOption);

await root.InvokeAsync(args);