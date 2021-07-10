using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e08_Get_Nth_Key_Or_Value_From_Profile
    {
        static void Main(string[] args)
        {
            tvProfile loProfile = new tvProfile(@"
    -String1=""This is string 1.""
    -Int1=123
    -Switch1=False
    -String2=""This is string 2.""
    -Date1=""6/26/2021 3:12:41 PM""
"
                    );

            Console.WriteLine(@"
Example: e08_Get_Nth_Key_Or_Value_From_Profile

This example demonstrates how to get the nth key or nth value from
a profile:

    The tvProfile object (""loProfile"") loads a command-line string.
    The resulting key/value pairs are laid down in a definite order.

This shows what the command-line string looks like (stacked):

        Console.WriteLine(loProfile.sCommandBlock());
"
                    );
            Console.WriteLine(loProfile.sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's how to get the 4th key from the profile:

        loProfile.sKey(3);

This displays it:

        Console.WriteLine(loProfile.sKey(3));
"
                    );
            Console.WriteLine(loProfile.sKey(3));
            Console.WriteLine();

            Console.WriteLine(@"
Here's how to get the 4th value from the profile:

        loProfile[3];

This displays it:

        Console.WriteLine(loProfile[3]);
"
                    );
            Console.WriteLine(loProfile[3]);
            Console.WriteLine();
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
