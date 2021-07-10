using System;
using tvToolbox;

namespace tvProfileExamples
{
    class e01_Auto_Populate_and_Load_App_Properties
    {
        static void Main(string[] args)
        {
            if ( 0 == System.IO.Directory.GetFiles(".", "*.txt").GetLength(0) )
            {
                Console.WriteLine(@"
Example: e01_Auto_Populate_and_Load_App_Properties

  (First, notice the folder containing these examples includes EXE files only.
   During the initial run, there are no TXT files. They are created as you go.)
"
                        );
                Console.WriteLine("Take a look now, then press any key ...");
                Console.ReadKey();
            }


            //tvProfile   loProfile = new tvProfile(args);
            //            if ( loProfile.bExit ) return;

            tvProfile   loProfile = new tvProfile(args, tvProfileDefaultFileActions.AutoLoadSaveDefaultFile, tvProfileFileCreateActions.NoPromptCreateFile);
            string      lsString1 = loProfile.sValue("-String1", "This is string 1.");
            int         liInt1    = loProfile.iValue("-Int1", 123);

            if ( loProfile.bValue("-Switch1", false) )
            {
                // Do something here if -Switch1 is true. It's false by default.
                // Alternatively, this would make it true by default:
                //
                // if ( loProfile.bValue("-Switch1", true) )
            }

            Console.Clear();
            Console.WriteLine(@"
Example: e01_Auto_Populate_and_Load_App_Properties

This example demonstrates the most basic features of the tvProfile class:

    It loads a default profile file (named by default and filled with default
    properties). If the profile file doesn't exist, it is created in the same
    folder as the running EXE (same EXE filename with '.txt' appended).

    Notice this in the example code:

        tvProfile   loProfile = new tvProfile(args, tvProfileDefaultFileActio...

    Using this simpler syntax instead (commented out in the code):

        tvProfile   loProfile = new tvProfile(args);
                    if ( loProfile.bExit ) return;

    you will be prompted to copy the EXE to a new folder on the desktop to
    continue running the EXE from there. A new profile will be there as well.
    If the default profile already exists in the folder with the running EXE,
    there will be no prompt and the profile file will be loaded automatically.
"
                    );
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(String.Format(@"
Here are the values currently in the profile:

    -String1=""{0}""
       -Int1={1}
    -Switch1={2}
    -String2=""{3}""
      -Date1=""{4}""

Now edit the profile file (dismiss this screen first since you usually can't
edit a profile file while its EXE is still running). Then run this example
again. You will see how new values in the profile file override the default
values found in the code.
"
                    , lsString1, liInt1, loProfile.bValue("-Switch1", false)
                    , loProfile.sValue("-String2", "This is string 2.")
                    , loProfile.dtValue("-Date1", DateTime.Now)
                    ));
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
