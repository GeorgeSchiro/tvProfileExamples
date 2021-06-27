using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e03_Command_Line_String_To_Key_Value_Pairs
    {
        static void Main(string[] args)
        {
            tvProfile loProfile = new tvProfile("  -String1='This is string 1.' -Int1=123 -Switch1 -String2='This is string 2.' -Date1='6/19/2021 8:08:30 AM'  ");

            Console.WriteLine(@"
Example: e03_Command_Line_String_To_Key_Value_Pairs

This example demonstrates how to parse a command-line string and access its
resulting key/value pairs discretely, one-by-one, using known keys:

    The tvProfile object (""loProfile"") loads an embedded profile string
    (alternatively, get it from a text file, a database or anywhere else).

    Here's what the command-line looks like in the code:

""  -String1='This is string 1.' -Int1=123 -Switch1 -String2='This is string 2.' -Date1='6/19/2021 8:08:30 AM'  ""

    Notice the use of single-quotes around string value parameters while
    double-quotes contain the entire command-line string as a whole. The
    use of single-quotes makes it easy to delimit parameter strings in code.
    If the command-line string comes from elsewhere (eg. a config file or a
    database) then it might look like this instead:

  -String1=""This is string 1."" -Int1=123 -Switch1 -String2=""This is string 2."" -Date1=""6/19/2021 8:08:30 AM""
"
                    );
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(String.Format(@"
These are the values currently in the profile (populated from a command-line
string and referenced individually using known key strings):

    -String1=""{0}""
       -Int1={1}
    -Switch1={2}
    -String2=""{3}""
      -Date1=""{4}""
"
                    , loProfile.sValue("-String1", null)
                    , loProfile.iValue("-Int1", 0)
                    , loProfile.bValue("-Switch1", false)
                    , loProfile.sValue("-String2", null)
                    , loProfile.dtValue("-Date1", DateTime.MinValue)
                    ));
            Console.WriteLine(@"
These are the values from the same profile but referenced without using keys
at all. Instead we use a 'DictionaryEntry' collection and a 'foreach' loop:
"
                    );

            foreach(System.Collections.DictionaryEntry loEntry in loProfile)
            {
                Console.WriteLine(String.Format("    {0}='{1}'", loEntry.Key, loEntry.Value));
            }

            Console.WriteLine(@"
Notice every value looks like a string this time. Using discrete references
instead lets you easily convert the string values to their proper data types.
"
                    );
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
