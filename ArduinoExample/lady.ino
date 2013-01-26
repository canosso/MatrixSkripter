#include <ht1632c.h>
ht1632c dotmatrix = ht1632c(&PORTD,7,6,5,3,GEOM_32x16,2);
#define Number_of_X_Displays 2
#define Number_of_Y_Displays 1
#define X_MAX (32*Number_of_X_Displays-1)
#define Y_MAX (16*Number_of_Y_Displays-1)
#define Transparent 1
#define RANDOMCOLUMNCOLOR 5
#define RANDOMLINECOLOR 6
#define RANDOMREDGREENMULTICOLOR 7
#define RANDOMREDORANGEMULTICOLOR 9
int commonlines=3;
int sx,sx2;
int sy,sy2;
int scolor,sbackcolor;
int columnColor = 0, randomcolor=0;
char myString[]="", colorString[128];

/*
*ht1632_putbitmap4color
* Draws a bitmap with all 4 colors (or 3 if you don't count black)
* The pixels are saved as numerical digit in a PROGMEM string, for each column one with a PGM_P stringtable
* Only visible pixels will be plotted
* ht1632_putbitmap4color( x location, y location, PGM_P * bitmapname, bitmap width, bitmap height,
* sendmatrix (0=draw each column, 1= draw the matrix after last column, 2= don't draw now),
* transparentblack (0= plot black, 1= Transparent, no black will be plotted),  bitmapmode (0= plot normal, 1= all colors will be black plotted),
* textbitmap (0= normal bitmap, 1= textbitmap), if selected the colors black (=backcolor) and green (=frontcolor) could be replaced),
* frontcolor (one of the 10 colors), backcolor (one of the 10 colors))
*/
void ht1632_putbitmap4color(int x, int y, PGM_P * stringtablename, int columncountbitmap, int rowcountbitmap, int sendmatrix, int transparentblack, int bitmapmode, int textbitmap, int frontcolor, int backcolor)
{
	unsigned short startcolumm, endcolumn,startrow, endrow;
	if (x>=0){
		startcolumm=0;
	}
	else{
		startcolumm=-x;
	}
	if ((-x+X_MAX+2)>=columncountbitmap){
		endcolumn=columncountbitmap;
	}
	else{
		endcolumn=-x+X_MAX+1;
	}
	if (y>=0){
		startrow=0;
	}
	else{
		startrow=-y;
	}
	if ((-y+Y_MAX+2)>=rowcountbitmap){
		endrow=rowcountbitmap;
	}
	else{
		endrow=-y+Y_MAX+1;
	}
	sx=x+startcolumm;
	randomcolor=random(3)+1;
	for (unsigned short i = startcolumm; i < endcolumn; i++)
	{
		if (i % commonlines ==0) {
			columnColor=random(3)+1;
		}
		strcpy_P(colorString, (PGM_P)pgm_read_word(&(stringtablename[i])));
		for(int tmp=startrow; tmp<=endrow; tmp++)
		{
			scolor=  char(colorString[tmp])-48;
			if (textbitmap==1 && scolor==1) {
				scolor=frontcolor;
			}
			if (textbitmap==1 && scolor==0) {
				scolor=backcolor;
			}
			sy2=y+tmp;
			if (scolor==4) {
				scolor=randomcolor;
			}
			else if (scolor==5) {
				scolor=columnColor;
			}
			else if (scolor==6) {
				scolor=(sy2/commonlines) % commonlines+1;
			}
			else if (scolor==7) {
				scolor=random(2)+1;
			}
			else if (scolor==8) {
				scolor=random(3)+1;
			}
			else if (scolor==9) {
				scolor=random(2)+2;
			}
			if (transparentblack==1 && scolor==0) {
			}
			else{
				if (bitmapmode==1 && scolor!=0) {
					dotmatrix.plot( sx, sy2,0);
				}
				else {
					dotmatrix.plot( sx, sy2,scolor);
				}
			}
			if (sendmatrix==0)
			dotmatrix.sendframe();
		}
		sx=sx+ 1;
	}
	if (sendmatrix==1)
	dotmatrix.sendframe();
}

/*
* scrollbitmapx4color()
* Scrolls a bitmap from left to right
* Original function by Bill Ho
* Direction and Blinking function by lonewolf
* scrollbitmap4xcolor (x location, stringtablename , bitmap width, bitmap height, delaytime in millisecondsdirection,  not or blinking,
* textbitmap (0= normal bitmap, 1= textbitmap), if selected the colors black (=backcolor) and green (=frontcolor) could be replaced).
*/
void scrollbitmapx4color(int y, PGM_P * stringtablename,int columncountbitmap, byte rowcountbitmap,int delaytime, int dir, int sblinking, int textbitmap, int frontcolor, int backcolor) {
	int  x, blinking=0;
	for ((dir) ? x = - (columncountbitmap+1) : x = X_MAX; (dir) ? x <= X_MAX : x > - (columncountbitmap+1); (dir) ? x++ : x--)
	{
		for (int i = 0; i < 1; i++) {
			if (textbitmap==1) {
				if (frontcolor==4){
					scolor=random(3)+1;
				}
				else {
					scolor=frontcolor;
				} 
				if ( backcolor==4) {
					sbackcolor=random(3)+1;
				}
				else {
					sbackcolor=backcolor;
				}
			}
			if (dir==0){
				dotmatrix.line(x + columncountbitmap,y,x + columncountbitmap,y+rowcountbitmap,BLACK);   
			}
			if (sblinking==16){
				blinking = ( (x & 2)) ? 1 : 0;   
			}
			ht1632_putbitmap4color(x + (columncountbitmap *i), y, stringtablename , columncountbitmap,rowcountbitmap, 1, 0, blinking, textbitmap, scolor, sbackcolor);
			if (dir==1){
				dotmatrix.line(x,y,x,y+rowcountbitmap,BLACK);   
			}
		}
		delay(delaytime);// reduce speed of scroll
	}
}
/*
* scrollbitmapy4color()
* Scrolls a bitmap from bottom to up
* Original function by Bill Ho
* Direction and Blinking function by lonewolf
* scrollbitmapy4color (y location, stringtablename , bitmap width, bitmap height, delaytime in milliseconds, direction,  not or blinking,
* textbitmap (0= normal bitmap, 1= textbitmap), if selected the colors black (=backcolor) and green (=frontcolor) could be replaced).
*/
void scrollbitmapy4color(int x,PGM_P * stringtablename,int columncountbitmap, byte rowcountbitmap, int delaytime, int dir, int sblinking, int textbitmap, int frontcolor, int backcolor) {
	int  y, blinking=0;
	for ((dir) ? y = - (rowcountbitmap+1) : y = Y_MAX; (dir) ? y <= Y_MAX : y > - (rowcountbitmap+1); (dir) ? y++ : y--)
	{
		for (int i = 0; i < 1; i++) {
			if (textbitmap==1) {
				if (frontcolor==4){
					scolor=random(3)+1;
				}
				else {
					scolor=frontcolor;
				} 
				if ( backcolor==4) {
					sbackcolor=random(3)+1;
				}
				else {
					sbackcolor=backcolor;
				}
			}
			if (dir==1){
				dotmatrix.line(x ,y-1,x + (columncountbitmap),y-1,BLACK); 
			}
			if (sblinking==16){
				blinking = ( (y & 2)) ? 1 : 0;   
			}
			ht1632_putbitmap4color(x + (columncountbitmap *i), y, stringtablename , columncountbitmap,rowcountbitmap, 1, 0, blinking, textbitmap, scolor, sbackcolor);
			if (dir==0){
				dotmatrix.line(x ,y+1,x + (columncountbitmap),y+1,BLACK);
			}
		}
		delay(delaytime);// reduce speed of scroll
	}
}

/*
* ht1632_writetext()
* Writes a string either horizontal or vertical 
* Original function by Bill Ho
* ht1632_writetext (x location, y location, string, sendmatrix (0=draw each column, 1= draw the matrix after last column, 2= don't draw now),
* delaytime in milliseconds, direction, frontcolor, backcolor).
*/
void ht1632_writetext(int x, int y,  char *text, int sendmatrix, int delaytime, int dir, int scolor, int sbackcolor)
{
	for(int tmp=0; tmp<strlen(text); tmp++)
	{
		if (dir==0) {
			sx2=x+tmp*6;
			sy2=y;
		}
		else if (dir==1) {
			sx2=x;
			sy2=y+tmp*8;
		}
		dotmatrix.putchar(sx2,sy2, text[tmp] , scolor, 0, sbackcolor);
		if (sendmatrix==0)
		dotmatrix.sendframe();
		delay(delaytime);
	}
	if (sendmatrix==1)
	dotmatrix.sendframe();
}
void ht1632_clearfillcolor(int matrixtype, int typeofsplit, int dir, int sendmatrix, int delaytime, int fillcolor)
{
	int tmpx,tmpy ;
	scolor=fillcolor;
	if (fillcolor==4) {
		scolor=random(3)+1;
	}
	if (typeofsplit==0)
	{
		for((dir) ? tmpx=0: (matrixtype) ?  tmpx=(X_MAX+1)/2:  tmpx =X_MAX ;  (dir) ?  (matrixtype) ?  tmpx<=(X_MAX+1)/2:tmpx<=X_MAX: tmpx >=0; (dir)  ? tmpx++:tmpx--)
		{
			for((dir) ? tmpy=0: tmpy = Y_MAX; (dir) ?  tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)
			{
				if (fillcolor==8) {
					scolor=random(3)+1;
				}
				dotmatrix.plot( tmpx, tmpy,scolor);
				if (matrixtype==1)
				{
					dotmatrix.plot(X_MAX-tmpx, tmpy,scolor);
				}
				if (sendmatrix==0)
				dotmatrix.sendframe();
				delay(delaytime);
			}
			if (sendmatrix==1)
			dotmatrix.sendframe();
		}
	}
	else if (typeofsplit==1)
	{
		for((dir) ? tmpy=0: (matrixtype) ? tmpy=(Y_MAX+1)/2: tmpy = Y_MAX; (dir) ?  (matrixtype) ? tmpy<=(Y_MAX+1)/2 : tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)
		{
			for((dir) ? tmpx=0: tmpx = X_MAX;  (dir) ?  tmpx<=X_MAX : tmpx >=0; (dir)  ? tmpx++:tmpx--)
			{
				if (fillcolor==8)
				scolor=random(3)+1;
				dotmatrix.plot( tmpx, tmpy,scolor);
				if (matrixtype==1)
				{
					dotmatrix.plot(tmpx, Y_MAX-tmpy,scolor);
				}
				if (sendmatrix==0)
				dotmatrix.sendframe();
				delay(delaytime);
			}
			if (sendmatrix==1)
			dotmatrix.sendframe();
		}
	}
}


/*
* Bitmap Data
* Writes a PROGMEM string for each column, each pixel is a numeric digit
* All strings/columns are saved in a PGM_P string table
* The bitmap will be called with the bitmap name
*/


char Webdings52string_0[] PROGMEM = "000000000000000001111111111111111100000000000001000000000000000000000000";
char Webdings52string_1[] PROGMEM = "000000000000000111111111111111111110000000001111000000000000000000000000";
char Webdings52string_2[] PROGMEM = "000000000000001111111111111111111110000000111111000000000000000000000000";
char Webdings52string_3[] PROGMEM = "000000000000011111111111111111111110000111111111000000000000000000000000";
char Webdings52string_4[] PROGMEM = "000000000000011111111111111111111000011111111111000000000000000000000000";
char Webdings52string_5[] PROGMEM = "000000000000011111100000000000000011111111111111000000000000000000000000";
char Webdings52string_6[] PROGMEM = "000000000000011111111111111111111111111111111111111111111111111111111110";
char Webdings52string_7[] PROGMEM = "000011110000011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_8[] PROGMEM = "001111111100011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_9[] PROGMEM = "011111111110011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_10[] PROGMEM = "111111111111011111111111111111111111111111111111111111111111111111111110";
char Webdings52string_11[] PROGMEM = "111111111111011111111111111111111111111111111111000000000000000000000000";
char Webdings52string_12[] PROGMEM = "111111111111011111111111111111111111111111111111000000000000000000000000";
char Webdings52string_13[] PROGMEM = "111111111111011111111111111111111111111111111111111111111111111111111110";
char Webdings52string_14[] PROGMEM = "011111111110011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_15[] PROGMEM = "001111111100011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_16[] PROGMEM = "000011110000011111111111111111111111111111111111111111111111111111111111";
char Webdings52string_17[] PROGMEM = "000000000000011111111111111111111111111111111111111111111111111111111110";
char Webdings52string_18[] PROGMEM = "000000000000011111100000000000000011111111111111000000000000000000000000";
char Webdings52string_19[] PROGMEM = "000000000000011111100000000000000000111111111111000000000000000000000000";
char Webdings52string_20[] PROGMEM = "000000000000011111111111111111111110000111111111000000000000000000000000";
char Webdings52string_21[] PROGMEM = "000000000000001111111111111111111110000001111111000000000000000000000000";
char Webdings52string_22[] PROGMEM = "000000000000000111111111111111111110000000001111000000000000000000000000";
char Webdings52string_23[] PROGMEM = "000000000000000011111111111111111100000000000001000000000000000000000000";

PGM_P Webdings52[] PROGMEM = 
{
	Webdings52string_0,
	Webdings52string_1,
	Webdings52string_2,
	Webdings52string_3,
	Webdings52string_4,
	Webdings52string_5,
	Webdings52string_6,
	Webdings52string_7,
	Webdings52string_8,
	Webdings52string_9,
	Webdings52string_10,
	Webdings52string_11,
	Webdings52string_12,
	Webdings52string_13,
	Webdings52string_14,
	Webdings52string_15,
	Webdings52string_16,
	Webdings52string_17,
	Webdings52string_18,
	Webdings52string_19,
	Webdings52string_20,
	Webdings52string_21,
	Webdings52string_22,
	Webdings52string_23,
};
void setup() {
  Serial.begin(115200);
  dotmatrix.clear();
}
void loop() {
 dotmatrix.setfont(FONT_5x7W);

 /* scrollbitmap x/y 4color (x / y location, stringtablename , bitmap width, bitmap height, delaytime in milliseconds, direction,  not or blinking,
  * textbitmap (0= normal bitmap, 1= textbitmap), if selected the colors black (=backcolor) and green (=frontcolor) could be replaced).
  */

 scrollbitmapx4color(0,Webdings52,24,72,30,LEFT,0,1,RANDOMCOLOR,ORANGE);
 scrollbitmapy4color(0,Webdings52,24,72,30,UP,0,1,MULTICOLOR,BLACK);
}
