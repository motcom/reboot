using System.Diagnostics;

class Program
{
    static void Main()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "shutdown";  
        startInfo.Arguments = "-r -t 0";  
        startInfo.RedirectStandardOutput = false; 
        startInfo.UseShellExecute = false; 
        startInfo.CreateNoWindow = true; 

        Process? process = Process.Start(startInfo);
        if ( process is not null ) {
           process.Start();
        }
    }
}
