using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e07_Get_More_From_Common_Key_Strings
    {
        static void Main(string[] args)
        {
            tvProfile loProfile = new tvProfile(@"
    -String1=""This is string 1.""
    -Int1=123
    -Switch1=False
    -FileAuthor1=Filename1.txt
    -FileAuthor2=Filename2.txt
    -FileAuthor3=Filename3.txt
    -String2=""This is string 2.""
    -Date1=""6/26/2021 3:12:41 PM""
"
                    );

            Console.WriteLine(@"
Example: e07_Get_More_From_Common_Key_Strings

This example demonstrates how to get a collection of key/value pairs
using a single key wildcard (note: more information is embedded in each key):

    The tvProfile object (""loProfile"") loads a command-line string
    that contains multiple keys, several of which have the same pattern.

This shows what the command-line string looks like (stacked):

        Console.WriteLine(loProfile.sCommandBlock());
"
                    );
            Console.WriteLine(loProfile.sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's how to get a subset (also a profile) of the original profile,
using just the '-File*' key pattern:

        loProfile.oOneKeyProfile(""-File*"");

This displays it:

        Console.WriteLine(loProfile.oOneKeyProfile(""-File*"").sCommandBlock());
"
                    );
            Console.WriteLine(loProfile.oOneKeyProfile("-File*").sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's how to get a subset (also a profile) of the original profile,
using just the '-File*' key pattern while also removing the common substring
from each key:

        loProfile.oOneKeyProfile(""-File*"", true);

This displays it:

        Console.WriteLine(loProfile.oOneKeyProfile(""-File*"", true).sCommandB...
"
                    );
            Console.WriteLine(loProfile.oOneKeyProfile("-File*", true).sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
