MatrixSkripter
==============

![ScreenShot](https://raw.github.com/canosso/MatrixSkripter/master/matrixskripter.png)

<h1>Key features:</h1>

* <p>Import
bitmaps with up to 16 colors, match these colors to the existing **4 colors,**
manipulate the bitmap and show this bitmap on the matrix

* <p>Use all
possible colors, from 0 to 9,
for each pixel is one digit, the color information is
stored in strings for faster communication

* <p>Use any
text as bitmap with any font with any attribute for the matrix

* <p>Use any language char for text instead of only <a
href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">Ascii 0-128 chars,</a> i.e. that all  <a
href="http://en.wikipedia.org/wiki/UTF-8#Examples">UTF-8 chars</a> could be used

* <p>Use all
possible functions of the Lonewolf ht1632c library, <a
href="http://code.google.com/p/ht1632c/">http://code.google.com/p/ht1632c/</a>

* <p>Test all
data before you save it to the script. You can let run the script in background
over USB or better Ethernet, but it consummates a lot of CPU Power.

* <p>Script your
matrix functions and paste an Arduino sketch into the Arduino IDE

* <p>Faster
bitmap drawing, because first the whole matrix will be plotted and then Send
matrix will be sent. Also only the visible pixel will be plotted.

<p>&nbsp;</p>

<h1>What is needed?</h1>

<p>An Arduino
board with serial communication, best over USB, I didn't get the Mega 2560
board to run</p>

<p>A Sure
Electronics 32x16 bicolor LED matrix with Holtek ht1632c chip</p>

<p>An Ethernet
shield could be also used for faster testing</p>

<p>The SD card
could be used for storing commands, to run the matrix remotely but without
bitmap scrolling</p>

<p>&nbsp;</p>

<h1>Why such a mess?</h1>

<p>Because the Arduino has no bitmap handling, no color
matching, not so easy possibilities to change the code and limited data
storage. That you have to upload the code, if you want to test your content
e.g. where to put the bitmap, is also annoying and takes a lot of time.</p>

<p>Because the PC can't directly address a LED matrix and can't run
remotely on a simply 9V battery

<p>Therefore
you get a tool which use all the bitmap possibilities of a PC, script handling
with no limits except the Arduino data storage limit, almost live testing
(bitmap scrolling is lame over USB) and all 4 colors
at the same time.</p>

<h1>Getting started</h1>

<p>Start the
Matrix Skripter and the Arduino IDE,
connect your Arduino over USB.</p>

<p>Change the
settings according to your board, especially the number of X-matrix.</p>

<p>Then for
testing select at the menu &quot;Copy Serial Test File to Clipboard&quot; and
copy the test file into the Arduino IDE and upload it.</p>

<p>If you
uploaded the test file, <b>select your COM port at &quot; Select
the Test Matrix Communication method&quot;.</b> The board is now connected with
Matrix Skripter, you can test now all functions.</p>

<p>&nbsp;</p>

<h1>How to use Matrix Skripter</h1>

<p>The
programme looks quite overload but you don't need to know all functions before
you use it.</p>

<p>All similar
buttons/options have the same color and the same
position on the different tabs:</p>

<p>Beige – Saving
of a text file, those are tab separated and only for the Matrix Skripter useful</p>

<p>Green–
Import either a text file or bitmap for the Matrix Skripter
also the font select is green </p>

<p>Red – Test
functions or script with the Arduino board connected</p>

<p>Yellow –
Add data to the Matrix Script</p>

<p>Blue –
Co-ordinates and delay of a function</p>

<p>White – Select
the behaviour of the function</p>

<p>Grey –
Manipulate the Matrix Script</p>

<p>&nbsp;</p>

<h1>General options</h1>

<p>Each
function has a <b>color field</b> and the option <b>&quot;Send
Frame&quot;,</b> the later could be used either to plot each Line/Text, show the
content on the matrix after it was plotted in background or put the content
only in the memory and the next function will send the content to the matrix.</p>

<p>At the
white field, you can decided if you want only to show Bitmap/Text or scroll it,
you can also choose the scrolling direction (LEFT | UP and RIGHT | DOWN are
different options) and if you want to scroll blinking (this function is taken
from Lonewolf, shame on me).</p>

<p>For
&quot;Input Bitmap&quot; and &quot;Text as Bitmap&quot; there are also rotation
and flip, so you don't need to manipulate the bitmap before import.</p>

<h1>Bitmaps and Import Bitmaps</h1>

![Bitmap Example](https://raw.github.com/canosso/MatrixSkripter/master/4colors.jpg)<br>
_Left a bitmap composition with 4 colors and transparent, right only 2 colors and plotting black pixels_ 

<p>Bitmaps are
similar to PGM, <a
href="http://en.wikipedia.org/wiki/Portable_graymap#PGM_example">http://en.wikipedia.org/wiki/Portable_graymap#PGM_example</a>, they are for each pixel one color. </p>

<p>For the
matrix you need bitmaps with maximum 16 colors, the
best bitmaps are converted SVG files or converted vector graphic. Convert them
to GIF and reduce the colors if possible to 4 or 5 colors.</p>

<p>The bitmap
will be shown flipped and rotated below &quot;Bitmap rotation&quot;, this is
correct for the matrix.</p>

<p>There are
<b>10 possible colors</b> (BLACK, GREEN, RED, ORANGE and
additional RANDOMCOLOR, RANDOMCOLUMNCOLOR, RANDOMLINECOLOR, RANDOMREDGREENMULTICOLOR,
MULTICOLOR, RANDOMREDORANGEMULTICOLOR). The option <b>&quot;Common Random
Columns/Lines&quot;</b> at the settings will be used for RANDOMCOLUMNCOLOR and RANDOMLINECOLOR
if you set this option to 1 the bitmap would be too colorfull
with 3 it looks better.</p>

<p>All bitmaps
are normally set to <b>&quot;Transparent&quot;</b> i.e. black will not plotted except
if you want to scroll the bitmap. Therefore you can draw different bitmaps at
the same time to the matrix without destroying with the black pixels, they will
be overlaid.</p>

<p>If you
imported a bitmap, the label of each used color has
the color of this color.
You can now select the color for each color. If you don't select a color,
this color will be BLACK. After you selected all
necessary colors you can test the bitmap or add to
script.</p>

<p>&nbsp;</p>

<h1>Use Text as Bitmap</h1>

<p>For Text as
Bitmap only two colors will be stored, 0 for
background and 1 for the foreground but you can use all colors
for background and foreground. </p>

<p>With
&quot;Select Font&quot; you can select any installed font with any size and
attribute, only the number of colors
are restricted.</p>

<p>You can
test your text or add it to the script.</p>

<p>&nbsp;</p>

<h1>Draw</h1>

<p>Here you
will find all functions of Lonewolf's drawing
library.</p>

<p>&nbsp;</p>

<h1>Normal Text</h1>

<p>I use only
the font FONT_5x7W because with the Arduino Duemilanove
I have restricted memory</p>

<p>These
functions are the same as putchar and scrolltext, the Show is a function where putchar writes a string without scrolling.</p>

<h1>Special Clear/Fill Effects</h1>

<p>These
functions work with testing but if you upload it and you start a scrolling
function afterward, the whole effects will be not visible. It is only a proof
of concept</p>

<p>&nbsp;</p>

<h1>Add Clear Matrix/Send
Frame/Delay to the Script</h1>

<p>If you want
to clear the matrix, show the content on the matrix or add a delay.</p>

<p>&nbsp;</p>

<h1>Matrix Script</h1>

<p>Now the
most important thing, it is a datagridview, similar
to a spread sheet. </p>

<p>You can
change the rows but for bitmap and text bitmap you can't change the bitmap
data, you have to load them again.</p>

<h1>Types of the Matrix Script</h1>

<p>Bitmap, for
scrolling a large X or Y for direction could be added or removed</p>

<p>TextBitmap,
for scrolling a large X or Y for direction could be added or removed. You can
change the colors at Front Color
and Background color</p>

<p>Text, for
show a large X or Y for direction is necessary, for scrolling stands TextScroll and large X or Y for direction</p>

<p>Delay,
Delay in Milliseconds</p>

<p>Clear,
clear the matrix</p>

<p>All other
functions are the same as written before</p>

<p>&nbsp;</p>

<h1>Test the Matrix Script</h1>

<p>Runs all content of the matrix script with a background worker. Scrolling is really slow. </p>

<p>You have to
push to <b>&quot;Stop the Script Loop&quot;</b> to stop the matrix loop.</p>

<p>&nbsp;</p>

<h1>Copy to SD card and run
remotely</h1>

<p>This is
another failed proof of concept. The aim was that the Arduino board will be
installed remotely without a computer, only with an Ethernet shield and a SD
card to receive data over LAN.</p>

<p>First the
Ethernet and SD card could not be used at the same time and second SD card
could only handle one file at the same time instead of wished 2 files (one file
for the commands, the second file for bitmap data).</p>

<p>For text
and drawing functions of Lonewolf's library it could
be used but for bitmap scrolling it would take up to 5 minutes to write, the
scrolling would not be faster than over USB and if you contact over USB, all
data will be lost.</p>

<p>&nbsp;</p>

<h1>Save Script as Text file</h1>

<p>Save your
data as often you want if you &quot;Open Text Script File&quot;, the file
content will be appended to the datagridview.</p>

<p>&nbsp;</p>

<h1>Copy Script as Arduino
File to Clipboard</h1>

If you still
have <b>Arduino IDE</b> open but the <b>COM port at Settings closed,</b> you can upload the
file to your Arduino. Now you will see how fast the Arduino is.

<p>&nbsp;</p>

</div>
