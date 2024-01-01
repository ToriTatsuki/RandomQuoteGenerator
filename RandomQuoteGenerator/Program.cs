using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;

class Rqg
{
    static Random rand = new Random();
    static int randNumber; //determines which quote and author will show

    public static void _quote()
    {
        try
        {
            string[] fileQuotes = File.ReadLines(System.Environment.CurrentDirectory + "\\Quotes\\quotes.txt").ToArray();

            string[] shuffledQuotes = fileQuotes.OrderBy(n => Guid.NewGuid()).ToArray();

            randNumber = rand.Next(0, fileQuotes.Length);

            string margin = "".PadLeft(3);
            string selectedQuote = shuffledQuotes[randNumber].Replace("<Author>", "\n\n    ");


            Console.Write(margin + selectedQuote[0]);

            char[] myChar = { selectedQuote[0] };
            string newQuote = selectedQuote.TrimStart(myChar);

            foreach (char _selectedQuote in newQuote)
            {
                Thread.Sleep(10);
                Console.Write($"{_selectedQuote}");
            }

            Console.WriteLine("\n");
        }
        catch (Exception ex) {
            Console.WriteLine("Error Occured: " + ex.Message);

            Thread.Sleep(1500);
            Environment.Exit(0);
        }
    }

    public static void endText()
    {
        Console.WriteLine(@"   _____ ______ ______  __     ______  _    _   _   _ ________   _________   _______ _____ __  __ ______ _ ");
        Console.WriteLine(@"  / ____|  ____|  ____| \ \   / / __ \| |  | | | \ | |  ____\ \ / /__   __| |__   __|_   _|  \/  |  ____| |");
        Console.WriteLine(@" | (___ | |__  | |__     \ \_/ / |  | | |  | | |  \| | |__   \ V /   | |       | |    | | | \  / | |__  | |");
        Console.WriteLine(@"  \___ \|  __| |  __|     \   /| |  | | |  | | | . ` |  __|   > <    | |       | |    | | | |\/| |  __| | |");
        Console.WriteLine(@"  ____) | |____| |____     | | | |__| | |__| | | |\  | |____ / . \   | |       | |   _| |_| |  | | |____|_|");
        Console.WriteLine(@" |_____/|______|______|    |_|  \____/ \____/  |_| \_|______/_/ \_\  |_|       |_|  |_____|_|  |_|______(_)" + "\n");

        Console.WriteLine("                               [Console Application: Random Quote Generator]\n");
        Console.WriteLine("                                       Created by Group 8 BSIT 1-C\n");

        Thread.Sleep(300);
        string[] members =
        {
            "Lorico, Jean Edrich",
            "Gruezo, Cathyhannel Gloma",
            "Esita, Jhustin Rodriguez",
            "Limuaco, Mc Lawrence Isleta"
        };

        for (int i = 0; i < members.Length; i++)
        {
            Console.WriteLine($"                                        {members[i]}");
            Thread.Sleep(300);
        }
    }

    static void Main()
    {


        for (int i = 0; i <= 100; i++)
        {
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                                                   ");
            Console.WriteLine($"                         Loading Quote: {i}%                       ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝\n");


            Thread.Sleep(10);
        }

        Thread.Sleep(400);

        Console.Clear();

        string[] _title =
        {
            @"  ____              _          _____                           _             ",
            @" / __ \            | |        / ____|                         | |            ",
            @"| |  | |_   _  ___ | |_ ___  | |  __  ___ _ __   ___ _ __ __ _| |_ ___  _ __ ",
            @"| |  | | | | |/ _ \| __/ _ \ | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|",
            @"| |__| | |_| | (_) | ||  __/ | |__| |  __/ | | |  __/ | | (_| | || (_) | |   ",
            @" \___\_\\__,_|\___/ \__\___|  \_____|\___|_| |_|\___|_|  \__,_|\__\___/|_|   "

        };

        for (int i = 0; i < _title.Length; i++)
        {
            Console.WriteLine(_title[i]);
            Thread.Sleep(50);

        }

        Console.WriteLine("                         Written by Group 8 BSIT 1-C");
        Console.WriteLine("\n╠════════════════════════════════════════════════════════════════════════════╣\n\n");
        Thread.Sleep(700);

        _quote();


        Thread.Sleep(1000);

        Console.WriteLine("\n╔═════════════════════════╗");
        Console.WriteLine("  ►Press any key to exit◄");
        Console.WriteLine("╚═════════════════════════╝");

        Console.ReadKey();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearConsoleLine();

        Thread.Sleep(10);
        Console.Clear();
        endText();
        Console.WriteLine("\n");

        string endLoad = "...";
        foreach (char _endLoad in endLoad)
        {
            Console.Write($"{_endLoad}");
            Thread.Sleep(500);
        }

        Thread.Sleep(1000);
        Environment.Exit(0);

    }

    //clears previous line
    public static void ClearConsoleLine()
    {
        int currentCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentCursor);
    }
}

