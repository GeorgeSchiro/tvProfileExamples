using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e04_Key_Value_Pairs_To_Command_Line_String
    {
        static void Main(string[] args)
        {
            tvProfile   loProfile = new tvProfile();
                        loProfile.Add("-String1", "This is string 1.");
                        loProfile.Add("-Int1", 123);
                        loProfile.Add("-Switch1", true);
                        loProfile.Add("-String2", "This is string 2.");
                        loProfile.Add("-Date1", "6/19/2021 8:08:30 AM");

            Console.WriteLine(@"
Example: e04_Key_Value_Pairs_To_Command_Line_String

This example demonstrates how to format a collection of key/value pairs
as a command-line string:

    The tvProfile object (""loProfile"") loads each key/value pair, 
    one at a time, like this:

        tvProfile   loProfile = new tvProfile();
                    loProfile.Add(""-String1"", ""This is string 1."");
                    loProfile.Add(""-Int1"", 123);
                    loProfile.Add(""-Switch1"", true);
                    loProfile.Add(""-String2"", ""This is string 2."");
                    loProfile.Add(""-Date1"", ""6/19/2021 8:08:30 AM"");

This is how you display the resulting command-line string:

        Console.WriteLine(loProfile.sCommandLine());
"
                    );
            Console.WriteLine(loProfile.sCommandLine());
            Console.WriteLine("");
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
This is how you display the resulting command-line
string in ""block"" format (ie. stacked):

        Console.WriteLine(loProfile.sCommandBlock());
"
                    );
            Console.WriteLine(loProfile.sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
