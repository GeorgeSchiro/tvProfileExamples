using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e06_Get_Many_Values_From_A_Single_Key
    {
        static void Main(string[] args)
        {
            tvProfile loProfile = new tvProfile(@"
    -String1=""This is string 1.""
    -Int1=123
    -Switch1=False
    -File=Filename1.txt
    -File=Filename2.txt
    -File=Filename3.txt
    -String2=""This is string 2.""
    -Date1=""6/26/2021 3:12:41 PM""
"
                    );

            Console.WriteLine(@"
Example: e06_Get_Many_Values_From_A_Single_Key

This example demonstrates how to get a collection of key/value pairs
using a single key:

    The tvProfile object (""loProfile"") loads a command-line string
    that contains multiple keys, several of which have the same name.

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
using just the '-File' key:

        loProfile.oOneKeyProfile(""-File"");

This displays it:

        Console.WriteLine(loProfile.oOneKeyProfile(""-File"").sCommandBlock());
"
                    );
            Console.WriteLine(loProfile.oOneKeyProfile("-File").sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
