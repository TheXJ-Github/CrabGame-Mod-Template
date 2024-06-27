This Repo will help you create your first Crab Game Mod!

# Instructions
Before anything else, you'll need BepInEx 6.0 for IL2CPP, as Crab Game is an IL2CPP game meaning it's obfuscated and its more annoying to mod

Download BepInEx 6.0 Preview [here](https://github.com/BepInEx/BepInEx/releases/v6.0.0-pre.1)

Once downloaded, extract it and put BepInEx, Mono, doorstop.ini and winhttp.dll int Crab Game's root folder. To do this, open Steam, locate Crab Game in your Library, right click then click Manage, then click Browse local Files.
<p align="center"><img src="Images/screenshot1.png">
<img src="Images/screenshot2.png"></p>

Now, run Crab Game then close it. If you go back to the root folder and into the Bepinex folder, you should see a folder called 'Unhollowed' which means it decompiled the game!
<p align="center"><img src="Images/screenshot3.png"></p>

After this point, you need Visual Studio, and you'll need to create a new **Class Library (.NET Framework)**
<p align="center"><img src="Images/screenshot4.png"></p>

Set the .NET Framework to anywhere up to 4.8, but 4.7.1 works best
<p align="center"><img src="Images/screenshot5.png"></p>
