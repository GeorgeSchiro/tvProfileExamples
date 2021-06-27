using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e05_Parse_Many_Nested_Profiles
    {
        static void Main(string[] args)
        {
            tvProfile loProfile = new tvProfile(@"
    -String1=""This is string 1.""
    -Int1=123
    -Switch1=False
    -ChildProfile=[
        -Double1=123.456
        -GrandChildProfile=[
            -SomeNewKey=""Grandchild string.""
            -GreatGrandChildProfile=[

                -NewSwitch
                -String2=""This is string 2 (in great grand child).""
                -Date1=""1/1/2001""

            -GreatGrandChildProfile=]
        -GrandChildProfile=]
    -ChildProfile=]
    -String2=""This is string 2.""
    -Date1=""6/26/2021 3:12:41 PM""
"
                    );

            Console.WriteLine(@"
Example: e05_Parse_Many_Nested_Profiles

This example demonstrates how to parse a collection of nested profiles:

    The tvProfile object (""loProfile"") loads a command-line
    string that contains multiple nested profiles.

Here's how to display the entire command-line string (stacked):

        Console.WriteLine(loProfile.sCommandBlock());
"
                    );
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(loProfile.sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's -ChildProfile:
"
                    );
            Console.WriteLine(loProfile.oProfile("-ChildProfile").sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's -GrandChildProfile:
"
                    );
            Console.WriteLine(loProfile.oProfile("-ChildProfile").oProfile("-GrandChildProfile").sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"
Here's -GreatGrandChildProfile:
"
                    );
            Console.WriteLine(loProfile.oProfile("-ChildProfile").oProfile("-GrandChildProfile").oProfile("-GreatGrandChildProfile").sCommandBlock());
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
