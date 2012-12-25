MatrixSkripter
==============

Key features:
Import bitmaps with up to 16 colors, match these colors to the existing 4 colors, manipulate the bitmap and show this bitmap on the matrix
Use all possible colors, from 0 to 9, for each pixel is one digit, the color information is stored in strings for faster communication
Use any text as bitmap with any font with any attribute for the matrix
Use for text in any language char instead of only Ascii 0-128 chars
Use all possible functions of the Lonewolf ht1632c library, http://code.google.com/p/ht1632c/
Test all data before you save it to the script. You can let run the script in background over USB or better Ethernet, but it consummates a lot of CPU Power.
Script your matrix functions and paste an Arduino sketch into the Arduino IDE
Faster bitmap drawing, because first the whole matrix will be plotted and then Send matrix will be sent. Also only the visible pixel will be plotted.

What is needed?
An Arduino board with serial communication, best over USB, I didn't get the Mega 2560 board to run
A Sure Electronics 32x16 bicolor LED matrix with Holtek ht1632c chip
An Ethernet shield could be also used for faster testing
The SD card could be used for storing commands, to run the matrix remotely but without bitmap scrolling

Why such a mess?
Because the Arduino has no bitmap handling, no color matching, not so easy possibilities to change the code and limited data storage. That you have to upload the code, if you want to test your content e.g. where to put the bitmap, is also annoying and takes a lot of time.
Because the PC can't directly address a LED matrix and can't run remotely on a simply 9V battery.
Therefore you get a tool which use all the bitmap possibilities of a PC, script handling with no limits except the Arduino data storage limit, almost live testing (bitmap scrolling is lame over USB) and all 4 colors at the same time.
Getting started
Start the Matrix Skripter and the Arduino IDE, connect your Arduino over USB.
Change the settings according to your board, especially the number of X-matrix.
Then for testing select at the menu "Copy Serial Test File to Clipboard" and copy the test file into the Arduino IDE and upload it.
If you uploaded the test file, select your COM port at " Select the Test Matrix Communication method". The board is now connected with Matrix Skripter, you can test now all functions.

How to use Matrix Skripter
The programme looks quite overload but you don't need to know all functions before you use it.
All similar buttons/options have the same color and the same position on the different tabs:
Beige – Saving of a text file, those are tab separated and only for the Matrix Skripter useful
Green – Import either a text file or bitmap for the Matrix Skripter also the font select is green 
Red – Test functions or script with the Arduino board connected
Yellow – Add data to the Matrix Script
Blue – Co-ordinates and delay of a function
White – Select the behaviour of the function
Grey – Manipulate the Matrix Script

General options
Each function has a color field and the option "Send Frame", the later could be used either to plot each Line/Text, show the content on the matrix after it was plotted in background or put the content only in the memory and the next function will send the content to the matrix.
At the white field, you can decided if you want only to show Bitmap/Text or scroll it, you can also choose the scrolling direction (LEFT | UP and RIGHT | DOWN are different options) and if you want to scroll blinking (this function is taken from Lonewolf, shame on me).
For "Input Bitmap" and "Text as Bitmap" there are also rotation and flip, so you don't need to manipulate the bitmap before import.
Bitmaps and Import Bitmaps
Bitmaps are similar to PGM, http://en.wikipedia.org/wiki/Portable_graymap#PGM_example, they are for each pixel one color. 
For the matrix you need bitmaps with maximum 16 colors, the best bitmaps are converted SVG files or converted vector graphic. Convert them to GIF and reduce the colors if possible to 4 or 5 colors.
The bitmap will be shown flipped and rotated below "Bitmap rotation", this is correct for the matrix.
There are 10 possible colors (BLACK, GREEN, RED, ORANGE and additional RANDOMCOLOR, RANDOMCOLUMNCOLOR, RANDOMLINECOLOR, RANDOMREDGREENMULTICOLOR, MULTICOLOR, RANDOMREDORANGEMULTICOLOR). The option "Common Random Columns/Lines" at the settings will be used for RANDOMCOLUMNCOLOR and RANDOMLINECOLOR if you set this option to 1 the bitmap would be too colorfull with 3 it looks better.
All bitmaps are normally set to "Transparent" i.e. black will not plotted except if you want to scroll the bitmap. Therefore you can draw different bitmaps at the same time to the matrix without destroying with the black pixels, they will be overlaid.
If you imported a bitmap, the label of each used color has the color of this color. You can now select the color for each color. If you don't select a color, this color will be BLACK. After you selected all necessary colors you can test the bitmap or add to script.

Use Text as Bitmap
For Text as Bitmap only two colors will be stored, 0 for background and 1 for the foreground but you can use all colors for background and foreground. 
With "Select Font" you can select any installed font with any size and attribute, only the number of colors are restricted.
You can test your text or add it to the script.

Draw
Here you will find all functions of Lonewolf's drawing library.

Normal Text
I use only the font FONT_5x7W because with the Arduino Duemilanove I have restricted memory
These functions are the same as putchar and scrolltext, the Show is a function where putchar writes a string without scrolling.
Special Clear/Fill Effects
These functions work with testing but if you upload it and you start a scrolling function afterward, the whole effects will be not visible. It is only a proof of concept

Add Clear Matrix/Send Frame/Delay to the Script
If you want to clear the matrix, show the content on the matrix or add a delay.

Matrix Script
Now the most important thing, it is a datagridview, similar to a spread sheet. 
You can change the rows but for bitmap and text bitmap you can't change the bitmap data, you have to load them again.
Types of the Matrix Script
Bitmap, for scrolling a large X or Y for direction could be added or removed
TextBitmap, for scrolling a large X or Y for direction could be added or removed. You can change the colors at Front Color and Background color
Text, for show a large X or Y for direction is necessary, for scrolling stands TextScroll and large X or Y for direction
Delay, Delay in Milliseconds
Clear, clear the matrix
All other functions are the same as written before

Test the Matrix Script
Runs all content of the matrix script with a background worker. Scrolling is really slow. 
You have to push to "Stop the Script Loop" to stop the matrix loop.

Copy to SD card and run remotely
This is another failed proof of concept. The aim was that the Arduino board will be installed remotely without a computer, only with an Ethernet shield and a SD card to receive data over LAN.
First the Ethernet and SD card could not be used at the same time and second SD card could only handle one file at the same time instead of wished 2 files (one file for the commands, the second file for bitmap data).
For text and drawing functions of Lonewolf's library it could be used but for bitmap scrolling it would take up to 5 minutes to write, the scrolling would not be faster than over USB and if you contact over USB, all data will be lost.

Save Script as Text file
Save your data as often you want if you "Open Text Script File", the file content will be appended to the datagridview.

Copy Script as Arduino File to Clipboard
If you still have Arduino IDE open but the COM port at Settings closed, you can upload the file to your Arduino. Now you will see how fast the Arduino is.

