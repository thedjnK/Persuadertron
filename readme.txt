Persuadertron mod for Satellite Reign.

Idea is to recreate the syndicate wars persuadertron for capturing civilians, police, agents, etc.

Doesn't work as advertised, this is just something I'm working on to learn C#. Compiles/loads fine.
Select agents and approach civilians, press F11 to 'capture' civilians (they will be knocked to the ground).
Press F9 to get captured civilans to move towards the selected player.

Chances are it will mess up if a captured civilian despawns as there's no callback to remove the ID from the array.


How to Build:

You will need MonoDevelop (or Visual Studio) & Unity 5.0+ installed to compile this mod.

Open the solution file "Pause.sln" in MonoDevelop
Make sure the Solution pane is showing. (View -> Pads -> Solution)

Expand the "Pause" solution and "Pause" project in the "Solution" pane.

Right click "References" -> "Edit References"

Click ".Net Assembly" tab

Click "Browse" and add references to the following assemblies.

[SR install folder]\SatelliteReignWindows_Data\Managed\UnityEngine.dll
[SR install folder]\SatelliteReignWindows_Data\Managed\Assembly-CSharp.dll
[SR install folder]\SatelliteReignWindows_Data\Managed\Assembly-CSharp-firstpass.dll
Click "OK"

Select menu "Build" -> "Rebuild All". 
Depending on selected configuration, "Pause.dll" will be written out to either 

[ProjectRoot]Pause\bin\Debug\Pause.dll or 
[ProjectRoot]Pause\bin\Release\Pause.dll 

Copy Pause.dll to 
[SR install folder]\Mods

Start Satellite Reign and follow the above instructions.