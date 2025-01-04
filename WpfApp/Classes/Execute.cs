using System.Diagnostics;

namespace WpfApp.Classes;

public class Execute
{
    public async Task ExecuteCommand(string command) {
        await Task.Run(() => {
            try {
                var startInfo = new System.Diagnostics.ProcessStartInfo {
                    FileName = "cmd.exe",          Arguments = $"/c {command}",
                    RedirectStandardOutput = true, RedirectStandardError = true,
                    UseShellExecute = false,       CreateNoWindow = true
                };

                using (var process = System.Diagnostics.Process.Start(startInfo)) {
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(errors)) {
                        Console.WriteLine("Error: " + errors);
                    }

                    Console.WriteLine(output);
                }
            } catch (Exception ex) {
                Console.WriteLine("Command execution failed: " + ex.Message);
            }
        });
    }
    
    public async Task ExecuteCommand(string commandPath, string arguments)
    {
        try
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = commandPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(processStartInfo))
            {
                if (process != null)
                {
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();

                    Console.WriteLine($"Output: {output}");
                    Console.WriteLine($"Error: {error}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Command execution failed: " + ex.Message);    
        }
    }
}