Overview
========


<b>tvProfileExamples</b> is a collection of simple C# code samples that 
illustrate the various uses of the tvProfile class.

The tvProfile class provides a simple yet flexible interface to a collection of 
persistent application level properties. The key feature of tvProfile is its 
seamless integration of file based properties with command-line arguments and 
switches.

This class is heavily used in every "GeorgeSchiro" project on GitHub. So those 
projects serve as real-life examples as well.

The tvProfile class is included within this solution of examples projects as a 
CS file as well as a DLL file (ie. "tvToolbox.Net.dll"). Only the CS file 
is actually referenced in these projects, but either can be used. The DLL is 
included here to allow support for non-C# applications (eg. VB).

Included also is "tvToolbox.Net.chm" with detailed documentation on the 
tvProfile class and all of its members.


Details
=======


Here is the list of example projects included:

- e01_Auto_Populate_and_Load_App_Properties
- e02_Command_Line_Overrides_App_Properties
- e03_Command_Line_String_To_Key_Value_Pairs
- e04_Key_Value_Pairs_To_Command_Line_String
- e05_Parse_Many_Nested_Profiles
- e06_Get_Many_Values_From_A_Single_Key


Requirements
============


- .Net Framework 3.5+
- Microsoft Visual Studio 2008+
