MatrixSkripter
==============
![ScreenShot](https://raw.github.com/canosso/MatrixSkripter/master/matrixskripter.png)

<h1>Key features:<o:p></o:p></h1>

<p>Import
bitmaps with up to 16 colors, match these colors to the existing 4 colors,
manipulate the bitmap and show this bitmap on the matrix<o:p></o:p></p>

<p>Use all
possible colors, from 0 to 9,
for each pixel is one digit, the color information is
stored in strings for faster communication<o:p></o:p></p>

<p>Use any
text as bitmap with any font with any attribute for the matrix<o:p></o:p></p>

<p>Use any language char for text instead of only Ascii 0-128 chars, http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters,  i.e. that all UTF-8 chars, http://en.wikipedia.org/wiki/UTF-8#Examples could be used
<o:p></o:p></p>

<p>Use all
possible functions of the Lonewolf ht1632c library, <a
href="http://code.google.com/p/ht1632c/"><span lang=EN-GB style='mso-ansi-language:
EN-GB'>http://code.google.com/p/ht1632c/</a><span lang=EN-GB
style='mso-ansi-language:EN-GB'><o:p></o:p></p>

<p>Test all
data before you save it to the script. You can let run the script in background
over USB or better Ethernet, but it consummates a lot of CPU Power.<o:p></o:p></p>

<p>Script your
matrix functions and paste an Arduino sketch into the Arduino IDE<o:p></o:p></p>

<p>Faster
bitmap drawing, because first the whole matrix will be plotted and then Send
matrix will be sent. Also only the visible pixel will be plotted.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>What is needed?<o:p></o:p></h1>

<p>An Arduino
board with serial communication, best over USB, I didn't get the Mega 2560
board to run<o:p></o:p></p>

<p>A Sure
Electronics 32x16 bicolor LED matrix with <span
class=SpellE>Holtek ht1632c chip<o:p></o:p></p>

<p>An Ethernet
shield could be also used for faster testing<o:p></o:p></p>

<p>The SD card
could be used for storing commands, to run the matrix remotely but without
bitmap scrolling<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Why such a mess?<o:p></o:p></h1>

<p><span lang=EN-GB style='mso-ansi-language:
EN-GB'>Because the Arduino has no bitmap handling, no color
matching, not so easy possibilities to change the code and limited data
storage. <span
class=GramE>That you have to upload the code, if you want to test your content
e.g. where to put the bitmap, is also annoying and takes a lot of time.<o:p></o:p></p>

<p><span lang=EN-GB style='mso-ansi-language:
EN-GB'>Because the PC can't directly address a LED matrix and can't run
remotely on a simply 9V battery.<span lang=EN-GB
style='mso-ansi-language:EN-GB'><o:p></o:p></p>

<p>Therefore
you get a tool which use all the bitmap possibilities of a PC, script handling
with no limits except the Arduino data storage limit, almost live testing
(bitmap scrolling is lame over USB) and all 4 colors
at the same time.<o:p></o:p></p>

<h1>Getting started<o:p></o:p></h1>

<p>Start the
Matrix Skripter and the Arduino IDE,
connect your Arduino over USB.<o:p></o:p></p>

<p>Change the
settings according to your board, especially the number of X-matrix.<o:p></o:p></p>

<p>Then for
testing select at the menu &quot;Copy Serial Test File to Clipboard&quot; and
copy the test file into the Arduino IDE and upload it.<o:p></o:p></p>

<p>If you
uploaded the test file, select your COM port at &quot; Select
the Test Matrix Communication method&quot;. The board is now connected with
Matrix Skripter<span
class=GramE>, you can test now all functions.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>How to use Matrix <span
class=SpellE>Skripter<o:p></o:p></h1>

<p>The
programme looks quite overload but you don't need to know all functions before
you use it.<o:p></o:p></p>

<p>All similar
buttons/options have the same color and the same
position on the different tabs:<o:p></o:p></p>

<p>Beige – Saving
of a text file, those are tab separated and only for the Matrix <span
class=SpellE>Skripter useful<o:p></o:p></p>

<p>Green –
Import either a text file or bitmap for the Matrix Skripter
also the font select is green <o:p></o:p></p>

<p>Red – Test
functions or script with the Arduino board connected<o:p></o:p></p>

<p>Yellow –
Add data to the Matrix Script<o:p></o:p></p>

<p>Blue –
Co-ordinates and delay of a function<o:p></o:p></p>

<p>White – Select
the behaviour of the function<o:p></o:p></p>

<p>Grey –
Manipulate the Matrix Script<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>General options<o:p></o:p></h1>

<p>Each
function has a color field and the option &quot;Send
Frame&quot;, the later could be used either to plot each Line/Text, show the
content on the matrix after it was plotted in background or put the content
only in the memory and the next function will send the content to the matrix.<o:p></o:p></p>

<p>At the
white field, you can decided if you want only to show Bitmap/Text or scroll it,
you can also choose the scrolling direction (LEFT | UP and RIGHT | DOWN are
different options) and if you want to scroll blinking (this function is taken
from Lonewolf, shame on me).<o:p></o:p></p>

<p>For
&quot;Input Bitmap&quot; and &quot;Text as Bitmap&quot; there are also rotation
and flip, so you don't need to manipulate the bitmap before import.<o:p></o:p></p>

<h1>Bitmaps and Import Bitmaps<o:p></o:p></h1>

<p>Bitmaps are
similar to PGM, <a
href="http://en.wikipedia.org/wiki/Portable_graymap#PGM_example"><span
lang=EN-GB style='mso-ansi-language:EN-GB'>http://en.wikipedia.org/wiki/Portable_graymap#PGM_example</a><span
class=GramE>,<span
lang=EN-GB style='mso-ansi-language:EN-GB'> they are for each pixel one <span
class=SpellE>color. <o:p></o:p></p>

<p>For the
matrix you need bitmaps with maximum 16 colors, the
best bitmaps are converted SVG files or converted vector graphic. Convert them
to GIF and reduce the colors if possible to 4 or 5 <span
class=SpellE>colors.<o:p></o:p></p>

<p>The bitmap
will be shown flipped and rotated below &quot;Bitmap rotation&quot;, this is
correct for the matrix.<o:p></o:p></p>

<p>There are
10 possible colors (BLACK, GREEN, RED, ORANGE and
additional RANDOMCOLOR, RANDOMCOLUMNCOLOR, RANDOMLINECOLOR, RANDOMREDGREENMULTICOLOR,
MULTICOLOR, RANDOMREDORANGEMULTICOLOR). The option &quot;Common Random
Columns/Lines&quot; at the settings will be used for RANDOMCOLUMNCOLOR and RANDOMLINECOLOR
if you set this option to 1 the bitmap would be too colorfull
with 3 it looks better.<o:p></o:p></p>

<p>All bitmaps
are normally set to &quot;Transparent&quot; i.e. black will not plotted except
if you want to scroll the bitmap. Therefore you can draw different bitmaps at
the same time to the matrix without destroying with the black pixels, they will
be overlaid.<o:p></o:p></p>

<p>If you
imported a bitmap, the label of each used color has
the color of this color.
You can now select the color for each <span
class=SpellE>color. If you don't select a color,
this color will be BLACK. After you selected all
necessary colors you can test the bitmap or add to
script.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Use Text as Bitmap<o:p></o:p></h1>

<p>For Text as
Bitmap only two colors will be stored, 0 for
background and 1 for the foreground but you can use all colors
for background and foreground. <o:p></o:p></p>

<p>With
&quot;Select Font&quot; you can select any installed font with any size and
attribute, only the number of colors
are restricted.<o:p></o:p></p>

<p>You can
test your text or add it to the script.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Draw<o:p></o:p></h1>

<p>Here you
will find all functions of Lonewolf's drawing
library.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Normal Text<o:p></o:p></h1>

<p>I use only
the font FONT_5x7W because with the Arduino Duemilanove
I have restricted memory<o:p></o:p></p>

<p>These
functions are the same as putchar and <span
class=SpellE>scrolltext, the Show is a function where <span
class=SpellE>putchar writes a string without scrolling.<o:p></o:p></p>

<h1>Special Clear/Fill Effects<o:p></o:p></h1>

<p>These
functions work with testing but if you upload it and you start a scrolling
function afterward, the whole effects will be not visible. It is only a proof
of concept<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Add Clear Matrix/Send
Frame/Delay to the Script<o:p></o:p></h1>

<p>If you want
to clear the matrix, show the content on the matrix or add a delay.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Matrix Script<o:p></o:p></h1>

<p>Now the
most important thing, it is a datagridview, similar
to a spread sheet. <o:p></o:p></p>

<p>You can
change the rows but for bitmap and text bitmap you can't change the bitmap
data, you have to load them again.<o:p></o:p></p>

<h1>Types of the Matrix Script<o:p></o:p></h1>

<p>Bitmap, for
scrolling a large X or Y for direction could be added or removed<o:p></o:p></p>

<p><span lang=EN-GB style='mso-ansi-language:
EN-GB'>TextBitmap,
for scrolling a large X or Y for direction could be added or removed. You can
change the colors at Front Color
and Background color<o:p></o:p></p>

<p>Text, for
show a large X or Y for direction is necessary, for scrolling stands <span
class=SpellE>TextScroll and large X or Y for direction<o:p></o:p></p>

<p>Delay,
Delay in Milliseconds<o:p></o:p></p>

<p>Clear,
clear the matrix<o:p></o:p></p>

<p>All other
functions are the same as written before<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Test the Matrix Script<o:p></o:p></h1>

<p><span lang=EN-GB style='mso-ansi-language:
EN-GB'>Runs all content of the matrix script with a background worker.<span
lang=EN-GB style='mso-ansi-language:EN-GB'> Scrolling is really slow. <o:p></o:p></p>

<p>You have to
push to &quot;Stop the Script Loop&quot; to stop the matrix loop.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Copy to SD card and run
remotely<o:p></o:p></h1>

<p>This is
another failed proof of concept. The aim was that the Arduino board will be
installed remotely without a computer, only with an Ethernet shield and a SD
card to receive data over LAN.<o:p></o:p></p>

<p>First the
Ethernet and SD card could not be used at the same time and second SD card
could only handle one file at the same time instead of wished 2 files (one file
for the commands, the second file for bitmap data).<o:p></o:p></p>

<p>For text
and drawing functions of Lonewolf's library it could
be used but for bitmap scrolling it would take up to 5 minutes to write, the
scrolling would not be faster than over USB and if you contact over USB, all
data will be lost.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Save Script as Text file<o:p></o:p></h1>

<p>Save your
data as often you want if you &quot;Open Text Script File&quot;, the file
content will be appended to the datagridview.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

<h1>Copy Script as Arduino
File to Clipboard<o:p></o:p></h1>

<p>If you still
have Arduino IDE open but the COM port at Settings closed, you can upload the
file to your Arduino. Now you will see how fast the Arduino is.<o:p></o:p></p>

<p><o:p>&nbsp;</o:p></p>

</div>
