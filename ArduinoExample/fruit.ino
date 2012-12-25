#include <ht1632c.h>
ht1632c dotmatrix = ht1632c(&PORTD,7,6,5,3,GEOM_32x16,1);
#define Number_of_X_Displays 1
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


char cherrystring_0[] PROGMEM = "00001110000000000";
char cherrystring_1[] PROGMEM = "00011110000000000";
char cherrystring_2[] PROGMEM = "00113110000000000";
char cherrystring_3[] PROGMEM = "01131100000200000";
char cherrystring_4[] PROGMEM = "01131100002022200";
char cherrystring_5[] PROGMEM = "01311100020222220";
char cherrystring_6[] PROGMEM = "01311100022222220";
char cherrystring_7[] PROGMEM = "01111000022222220";
char cherrystring_8[] PROGMEM = "01113333322222220";
char cherrystring_9[] PROGMEM = "01113333322222220";
char cherrystring_10[] PROGMEM = "01130000002222220";
char cherrystring_11[] PROGMEM = "00300000002222200";
char cherrystring_12[] PROGMEM = "03330000020222220";
char cherrystring_13[] PROGMEM = "30003300020222220";
char cherrystring_14[] PROGMEM = "00000033322222220";
char cherrystring_15[] PROGMEM = "00000000002222220";
char cherrystring_16[] PROGMEM = "00000000002222200";
char cherrystring_17[] PROGMEM = "00000000002222000";

char apricotstring_0[] PROGMEM = "00000033333300000";
char apricotstring_1[] PROGMEM = "00000333333333000";
char apricotstring_2[] PROGMEM = "00003333222233300";
char apricotstring_3[] PROGMEM = "00003332222223330";
char apricotstring_4[] PROGMEM = "00003322222222330";
char apricotstring_5[] PROGMEM = "03003322333322330";
char apricotstring_6[] PROGMEM = "00333333333333330";
char apricotstring_7[] PROGMEM = "01113333333333330";
char apricotstring_8[] PROGMEM = "11113333333333330";
char apricotstring_9[] PROGMEM = "11113333333333300";
char apricotstring_10[] PROGMEM = "11003333333333000";
char apricotstring_11[] PROGMEM = "00000333333330000";

char strawberrystring_0[] PROGMEM = "00000020000000000";
char strawberrystring_1[] PROGMEM = "00002222220000000";
char strawberrystring_2[] PROGMEM = "00002323222000000";
char strawberrystring_3[] PROGMEM = "00222222232220000";
char strawberrystring_4[] PROGMEM = "01223232222222000";
char strawberrystring_5[] PROGMEM = "00122222322322200";
char strawberrystring_6[] PROGMEM = "11123222222222220";
char strawberrystring_7[] PROGMEM = "01222232223232220";
char strawberrystring_8[] PROGMEM = "10223222322222200";
char strawberrystring_9[] PROGMEM = "00222322222220000";
char strawberrystring_10[] PROGMEM = "00022222200000000";

char tomatoestring_0[] PROGMEM = "00022222222200000";
char tomatoestring_1[] PROGMEM = "00202222222222000";
char tomatoestring_2[] PROGMEM = "02022222222222000";
char tomatoestring_3[] PROGMEM = "22022222222222200";
char tomatoestring_4[] PROGMEM = "22022222222222200";
char tomatoestring_5[] PROGMEM = "22222222222222220";
char tomatoestring_6[] PROGMEM = "22122222222222220";
char tomatoestring_7[] PROGMEM = "21110000022222220";
char tomatoestring_8[] PROGMEM = "21110000022222220";
char tomatoestring_9[] PROGMEM = "22122222222222220";
char tomatoestring_10[] PROGMEM = "22110000002222220";
char tomatoestring_11[] PROGMEM = "22122000002222200";
char tomatoestring_12[] PROGMEM = "21222222222222200";
char tomatoestring_13[] PROGMEM = "02222222222222000";
char tomatoestring_14[] PROGMEM = "02222222222220000";
char tomatoestring_15[] PROGMEM = "00222222222200000";
char tomatoestring_16[] PROGMEM = "00000222200000000";

PGM_P cherrystring_table[] PROGMEM = 
{
	cherrystring_0,
	cherrystring_1,
	cherrystring_2,
	cherrystring_3,
	cherrystring_4,
	cherrystring_5,
	cherrystring_6,
	cherrystring_7,
	cherrystring_8,
	cherrystring_9,
	cherrystring_10,
	cherrystring_11,
	cherrystring_12,
	cherrystring_13,
	cherrystring_14,
	cherrystring_15,
	cherrystring_16,
	cherrystring_17,
};
PGM_P apricotstring_table[] PROGMEM = 
{
	apricotstring_0,
	apricotstring_1,
	apricotstring_2,
	apricotstring_3,
	apricotstring_4,
	apricotstring_5,
	apricotstring_6,
	apricotstring_7,
	apricotstring_8,
	apricotstring_9,
	apricotstring_10,
	apricotstring_11,
};
PGM_P strawberrystring_table[] PROGMEM = 
{
	strawberrystring_0,
	strawberrystring_1,
	strawberrystring_2,
	strawberrystring_3,
	strawberrystring_4,
	strawberrystring_5,
	strawberrystring_6,
	strawberrystring_7,
	strawberrystring_8,
	strawberrystring_9,
	strawberrystring_10,
};
PGM_P tomatoestring_table[] PROGMEM = 
{
	tomatoestring_0,
	tomatoestring_1,
	tomatoestring_2,
	tomatoestring_3,
	tomatoestring_4,
	tomatoestring_5,
	tomatoestring_6,
	tomatoestring_7,
	tomatoestring_8,
	tomatoestring_9,
	tomatoestring_10,
	tomatoestring_11,
	tomatoestring_12,
	tomatoestring_13,
	tomatoestring_14,
	tomatoestring_15,
	tomatoestring_16,
};
void setup() {
  Serial.begin(115200);
  dotmatrix.clear();
}
void loop() {
 dotmatrix.setfont(FONT_5x7W);

 /* ht1632_writetext (x location, y location, string, sendmatrix (0=draw each column, 1= draw the matrix after last column, 2= don't draw now), 
  * delaytime in milliseconds, direction, frontcolor, backcolor).
  */

 ht1632_writetext(0,0,"What",1,0,0,RED,BLACK);
 ht1632_writetext(0,9,"kind",1,0,0,ORANGE,BLACK);
 delay(1000);
 dotmatrix.clear();
 ht1632_writetext(0,0,"of ",1,0,0,GREEN,BLACK);
 ht1632_writetext(0,9,"fruit",1,0,0,MULTICOLOR,BLACK);
 delay(1000);
 dotmatrix.clear();
 ht1632_writetext(0,0,"do you",1,0,0,RED,BLACK);
 ht1632_writetext(0,9,"like?",1,0,0,GREEN,BLACK);
 delay(1000);
 dotmatrix.clear();

 /* ht1632_putbitmap4color( x location, y location, PGM_P * bitmapname, bitmap width, bitmap height,
  * sendmatrix (0=draw each column, 1= draw the matrix after last column, 2= don't draw now),
  * transparentblack (0= plot black, 1= Transparent, no black will be plotted),  bitmapmode (0= plot normal, 1= all colors will be black plotted),
  * textbitmap (0= normal bitmap, 1= textbitmap), if selected the colors black (=backcolor) and green (=frontcolor) could be replaced),
  * frontcolor (one of the 10 colors), backcolor (one of the 10 colors))
  */
 ht1632_putbitmap4color(0,0,cherrystring_table,18,16,1,Transparent,0,0,0,0);
 ht1632_writetext(16,0,"che",1,0,0,RED,BLACK);
 ht1632_writetext(16,9,"rry",1,0,0,RED,BLACK);
 delay(1000);
 dotmatrix.clear();
 ht1632_putbitmap4color(0,0,apricotstring_table,12,16,1,Transparent,0,0,0,0);
 ht1632_writetext(12,0,"apri",1,0,0,ORANGE,BLACK);
 ht1632_writetext(12,9,"cot",1,0,0,ORANGE,BLACK);
 delay(1000);
 dotmatrix.clear();
 ht1632_putbitmap4color(0,0,strawberrystring_table,11,16,1,Transparent,0,0,0,0);
 ht1632_writetext(11,0,"straw",1,0,0,RED,BLACK);
 ht1632_writetext(11,9,"berry",1,0,0,RED,BLACK);
 delay(1000);
 dotmatrix.clear();
 ht1632_putbitmap4color(0,0,tomatoestring_table,17,16,1,Transparent,0,0,0,0);
 ht1632_writetext(15,0,"tom",1,0,0,RED,BLACK);
 ht1632_writetext(15,9,"atoe",1,0,0,RED,BLACK);
 delay(1000);
 dotmatrix.clear();
 dotmatrix.hscrolltext(4,"You decide!",RANDOMCOLOR | BLINK,10,1,LEFT,0,BLACK);
}
