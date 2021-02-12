# WYZtoSDCCobj Converter Tool
    
```
Author:       mvac7 (aka aorante)
Architecture: Microsoft .Net framework 4.0
License:      GNU GPL v2  
```

## Sorry! This text is pending correction of the English translation

                                                               

---
## About WYZtoSDCCobj

This is a tool to convert export .MUS files from WYZ Tracker to SDCC Assembler files (.s)  
for use with [WYZ Player MSX SDCC Library](https://github.com/mvac7/SDCC_WYZplayer)

In the first version it only allows exporting the code file (.s), 
but the objective is that it can directly compile the Object file (.rel)  
necessary to include it in the projects where it is needed.

MSX PSG proPLAYER V 0.3 by WYZ/Iggy Rock 09.03.2016 [(WYZ Player)](https://sites.google.com/site/wyzplayer/home)

This tool is part of the [MSX fR3eL Project](https://github.com/mvac7/SDCC_MSX_fR3eL).

Enjoy it!




---
## License

Copyright (C) 2021 mvac7

This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.
If not, see <http://www.gnu.org/licenses/>.

 

---
## Requirements:

* Windows OS with .net framework v4.0
* Display with minimum resolution: XVGA (1024x768)



---
## Acknowledgements:

I want to give a special thanks to all those who freely share their knowledge with the MSX developer community.

* Iggy Rock/WYZ [(WEB)](https://sites.google.com/site/wyzplayer/home)
* Augusto Ruiz [(gitHub Tracker Project)](https://github.com/AugustoRuiz/WYZTracker)
* Avelino Herrera > [(WEB)](http://msx.atlantes.org/index_es.html)
* Nerlaska > [(Blog)](http://albertodehoyonebot.blogspot.com.es)
* Marq/Lieves!Tuore > [(WEB)](http://www.kameli.net/marq/) [(Lieves!Tuore)](http://www.kameli.net/lt/)
* Fubukimaru [(gitHub)](https://github.com/Fubukimaru) > [(Blog)](http://www.gamerachan.org/fubu/)
* Andrear > [(Blog)](http://andrear.altervista.org/home/msxsoftware.php)
* Ramones > [(Articles published in MSXBlog)](https://www.msxblog.es/tutoriales-de-programacion-en-ensamblador-ramones/) - [(MSXbanzai)](http://msxbanzai.tni.nl/dev/faq.html)
* Sapphire/Z80ST > [(WEB)](http://z80st.auic.es/)
* Fernando García > [(youtube tutorials)](https://www.youtube.com/user/bitvision)
* Eric Boez > [(gitHub)](https://github.com/ericb59)
* MSX Assembly Page > [(WEB)](http://map.grauw.nl/resources/msxbios.php)
* Portar MSX Tech Doc > [(WEB)](http://nocash.emubase.de/portar.htm)
* MSX Resource Center > [(WEB)](http://www.msx.org/)
* Karoshi MSX Community (RIP 2007-2020)?
* BlueMSX emulator >> [(WEB)](http://www.bluemsx.com/)
* OpenMSX emulator >> [(WEB)](http://openmsx.sourceforge.net/)
* Meisei emulator >> ?
 
 
## How to use

Once we have a song made with WYZ Tracker (.wyz), we must export it to the .mus format designed to import them into assembler projects.

The exported data consists of two files:
- **.mus.asm** Includes data for Instruments, Effects and the note table.
- **.mus** It is a binary with the sequence data of a song.

WYZ Player is designed to handle all the sound content of a video game. It allows you to play several songs and launch sound effects while it is playing.

For it to work properly we have to make the songs using the same set of instruments and effects.

You can also perform songs with different Instrument Sets, but when changing songs you will have to reset the player (WYZ_Init), pointing to the data of each song. 
The WYZplayer library for SDCC is not designed for this way of working but you can adapt it by just changing the name of the indexes (instruments, effects and note table) of each song.

WYZtoSDCCobj Converter Tool generates a C object file with the instrument set and one or more songs.

To do this, you will first have to load the file with the instrument data (.mus.asm), by pressing the "Add" button on the first line.

The second step you will have to add the data of all the songs (.mus) that you want to include, for this you have a list type field, where you can add or delete songs.

To finish you will have to save the result that is shown in the window, in SDCC assembler format, by pressing the "Save WYZ.s" button.

To compile this source and obtain the Object file (.rel), you must open the command line and execute the following:

```
sdasz80 -o filename.s
```
