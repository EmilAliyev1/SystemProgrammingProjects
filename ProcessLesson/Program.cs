using System.Diagnostics;

#region Task 1

// Console.WriteLine($"Process with id: {Process.GetCurrentProcess().Id} started");

// string childApp = "/home/emiloff/Documents/C#Projects/ChildProcess/bin/Debug/net8.0/ChildProcess";

// ProcessStartInfo psi = new ProcessStartInfo
// {
//     FileName = childApp,
//     Arguments = "arg1 arg2 arg3",
//     RedirectStandardOutput = true
// };

// using Process process = new Process { StartInfo = psi };

// process.EnableRaisingEvents = true;
// process.Exited += (sender, e) => Console.WriteLine($"Child process with id: {process.Id} finished");
// process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);

// process.Start();

// Console.WriteLine($"Child process with id: {process.Id} started");

// process.BeginOutputReadLine();

// process.WaitForExit();


// Console.WriteLine($"Process with id: {Process.GetCurrentProcess().Id} finished");

#endregion

#region Task 2

// Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} started");

// string childApp = "/home/emiloff/Documents/C#Projects/ChildProcess/bin/Debug/net8.0/ChildProcess";

// ProcessStartInfo psi = new ProcessStartInfo
// {
//     FileName = childApp,
//     Arguments = "arg1 arg2 arg3",
//     RedirectStandardOutput = true,
//     UseShellExecute = false
// };

// using Process process = new Process { StartInfo = psi };

// process.EnableRaisingEvents = true;
// process.Exited += (sender, e) => Console.WriteLine($"Child process with id: {process.Id} finished");
// process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);

// process.Start();

// Console.WriteLine($"Child process with id: {process.Id} started");

// process.BeginOutputReadLine();

// Console.WriteLine("Choose an option:");
// Console.WriteLine("1. Wait for child process to exit");
// Console.WriteLine("2. Terminate child process manually");
// Console.Write("Enter your choice: ");

// string choice = Console.ReadLine();

// if (choice == "1")
// {
//     process.WaitForExit();
//     Console.WriteLine($"Child process exited with code {process.ExitCode}");
// }
// else if (choice == "2")
// {
//     Console.WriteLine("Terminating child process...");
//     process.Kill();
//     Console.WriteLine("Child process terminated");
// }
// else
// {
//     Console.WriteLine("Invalid option. Exiting...");
// }

// Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} finished");

#endregion

#region Task 3

// Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} started");

// string childApp = "/home/emiloff/Documents/C#Projects/ChildProcess/bin/Debug/net8.0/ChildProcess";

// Console.Write("Enter first number: ");
// string num1 = Console.ReadLine();

// Console.Write("Enter second number: ");
// string num2 = Console.ReadLine();

// Console.Write("Enter operation (+, -, *, /): ");
// string operation = Console.ReadLine();

// ProcessStartInfo psi = new ProcessStartInfo
// {
//     FileName = childApp,
//     Arguments = $"{num1} {num2} {operation}",
//     RedirectStandardOutput = true,
//     UseShellExecute = false
// };

// using Process process = new Process { StartInfo = psi };

// process.EnableRaisingEvents = true;
// process.Exited += (sender, e) => Console.WriteLine($"Child process with id: {process.Id} finished");
// process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);

// process.Start();

// Console.WriteLine($"Child process with id: {process.Id} started");

// process.BeginOutputReadLine();

// process.WaitForExit();

// Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} finished");

#endregion

#region Task 4

Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} started");

string childApp = "/home/emiloff/Documents/C#Projects/ChildProcess/bin/Debug/net8.0/ChildProcess";

Console.Write("Enter file path: ");
string filePath = Console.ReadLine();

Console.Write("Enter word to search: ");
string searchWord = Console.ReadLine();

ProcessStartInfo psi = new ProcessStartInfo
{
    FileName = childApp,
    Arguments = $"\"{filePath}\" {searchWord}",
    RedirectStandardOutput = true,
    UseShellExecute = false
};

using Process process = new Process { StartInfo = psi };

process.EnableRaisingEvents = true;
process.Exited += (sender, e) => Console.WriteLine($"Child process with id: {process.Id} finished");
process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);

process.Start();

Console.WriteLine($"Child process with id: {process.Id} started");

process.BeginOutputReadLine();

process.WaitForExit();

Console.WriteLine($"Parent process with id: {Process.GetCurrentProcess().Id} finished");

#endregion