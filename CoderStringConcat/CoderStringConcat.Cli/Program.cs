using CoderStringConcat.Core;
using System.CommandLine;

RootCommand rootCommand = new();
rootCommand.Description = "Concatenate coders into a file";

Option<string[]> codersOption = new(["--coders", "-c"], "The coders to concatenate");
rootCommand.AddOption(codersOption);

Option<FileInfo> outputFileOption = new(["--output", "-o"], "The file to output to");
rootCommand.AddOption(outputFileOption);

rootCommand.SetHandler(Compiler.CompileAsync, codersOption, outputFileOption);

return await rootCommand.InvokeAsync(args);
