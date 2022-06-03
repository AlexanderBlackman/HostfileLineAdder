//Goal: To append lines to Hostfile in order to better facilitate its use as a porn/distraction blocker.
//Needs admin privileges to work. 
string hostFileLocation = Environment.SystemDirectory + @"\drivers\etc\hosts";

try
{
    using (StreamWriter sw = new StreamWriter(hostFileLocation, true))
    {
        while (true)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What domain do you want to block? (exit to close)");
            Console.ResetColor();

            string selectedDomain = Console.ReadLine();
            if (selectedDomain.ToLower() == "exit")
                break;
            sw.WriteLine($"0.0.0.0    {selectedDomain}");
        }

    }
}
catch (UnauthorizedAccessException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nSorry, you need admin privs to modify the host file");
    Console.ResetColor();
}


