using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e02_Command_Line_Overrides_App_Properties
    {
        static void Main(string[] args)
        {
            // The following  sample profile file is needed only for this example.
            // See the "e01_Auto_Populate_and_Load_App_Properties" example for how
            // a similar default profile file is created for the EXE automatically.
            System.IO.File.WriteAllText("e02_Command_Line_Overrides_App_Properties.exe.txt", 
@"e02_Command_Line_Overrides_App_Properties.exe

-XML_Profile=False
-SaveProfile=True
-ShowProfile=False
-String1=""This is string 1.""
-Int1=123
-Switch1=False
-Date1=""6/19/2021 8:08:30 AM""
"
                    );

            tvProfile   loProfile = new tvProfile(args);
                        if ( loProfile.bExit ) return;

            // Disabling the profile file lock allows you to open the profile file while the app is
            // still running. This way you can compare what's in the profile to what's on the screen.
            // This will also permit you to run multiple instances of the app at the same time.
            loProfile.bEnableFileLock = false;

            Console.WriteLine(String.Format(@"
Example: e02_Command_Line_Overrides_App_Properties

This example demonstrates the most important feature of the tvProfile class:

    It loads the default profile file for the running EXE. It then merges
    any given command-line switches and parameters with corresponding items
    found in the profile file (command-line arguments take precedence).

Here are the values currently in the profile:

    -String1=""{0}""
       -Int1={1}
    -Switch1={2}
      -Date1=""{3}""
"
                    , loProfile.sValue("-String1", "This is string 1.")
                    , loProfile.iValue("-Int1", 123)
                    , loProfile.bValue("-Switch1", false)
                    , loProfile.dtValue("-Date1", DateTime.Now)
                    ));

            if ( 0 == args.Length )
            {
                Console.WriteLine(@"
Now create a shortcut to ""e02_Command_Line_Overrides_App_Properties.exe""
with the following command-line arguments appended (you can copy from here):

  -Int1=456 -Switch1 -String1=""This replaces string 1.""

Then run the shortcut to see the profile change in memory (but not on disk).
"
                        );
            }
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
