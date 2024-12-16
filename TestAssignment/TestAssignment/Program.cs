using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] Chanell = { "BE", "FE", "QA", "Urgent" };

        Console.Write("Enter the notification title: ");
        string notification = Console.ReadLine();

        List<string> result = new List<string>();

        foreach (string channel in Chanell)
        {
            int index = notification.IndexOf($"[{channel}]");
            if (index != -1)
            {
                result.Add(channel); 
            }
        }
        Console.WriteLine("Receive channels: " + string.Join(", ", result));
    }
}
