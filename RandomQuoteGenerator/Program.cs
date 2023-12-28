using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;

class Rqg
{
    static Random rand = new Random();
    static int randNumber; //determines which quote and author will show

    //List of quotes.
    //Add your quotes here.
    //Format: "\"<quote here>\" \n\n   - <author here>"
    static string[] quote =
    {
        "\"Out of the mountain of despair, a stone of hope.\" \n\n   - Martin Luther King Jr.",
        "\"When you have a dream, you've got to grab it and never let go.\" \n\n   - Carol Burnett",
        "\"Nothing is impossible. The word itself says 'I'm Possible!'.\" \n\n   - Audrey Hepburn",
        "\"There is nothing impossible to they who will try.\" \n\n   - Alexander the Great",
        "\"Show me a person who has never made a mistake and I'll show you someone who has never achieved much.\" \n\n   - Joan Collins",
        "\"All our dreams can come true, if we have the courage to pursue them.\" \n\n   - Walt Disney",
        "\"A man is a success if he gets up in the morning and gets to bed at night, and in between does what he wants to do.\" \n\n   - Bob Dylan",
        "\"The best way out is always through.\" \n\n   - Robert Frost",
        "\"The greater the obstacle, the more glory in overcoming it.\" \n\n   - Molière",
        "\"Failure is success in progress.\" \n\n   - Albert Einstein",
        "\"Without continual growth and progress, such words as improvement, achievement and success have no meaning.\" \n\n   - Benjamin Franklin",
        "\"Great things are not done by impulse, but by a series of small things brought together.\" \n\n   - Vincent Van Gogh",
        "\"Opportunity is missed by most people because it is dressed in overalls and looks like work.\" \n\n   - Thomas Jefferson",
        "\"A great leader's courage to fulfill his vision comes from passion, not position.\" \n\n   - John C. Maxwell"
    };


    public static void _quote()
    {

        string[] shuffledQuotes = quote.OrderBy(n => Guid.NewGuid()).ToArray();

        randNumber = rand.Next(0, quote.Length);

        string margin = "".PadLeft(3);
        string selectedQuote = shuffledQuotes[randNumber];

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

