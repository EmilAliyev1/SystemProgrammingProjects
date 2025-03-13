using System.Diagnostics;

#region Task 1

Console.WriteLine($"Process with id: {Process.GetCurrentProcess().Id} started");

string childApp = "C:\\Users\\Aliev_uj65\\RiderProjects\\SystemProgrammingProjects\\ChildProcess\\bin\\Debug\\net8.0\\ChildProcess.exe";

ProcessStartInfo psi = new ProcessStartInfo
{
    FileName = childApp,
    Arguments = "arg1 arg2 arg3",
    RedirectStandardOutput = true
};

using Process process = new Process { StartInfo = psi };

process.EnableRaisingEvents = true;
process.Exited += (sender, e) => Console.WriteLine($"Child process with id: {process.Id} finished");
process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);

process.Start();

Console.WriteLine($"Child process with id: {process.Id} started");

process.BeginOutputReadLine();

process.WaitForExit();


Console.WriteLine($"Process with id: {Process.GetCurrentProcess().Id} finished");

#endregion

#region Task 2



#endregion