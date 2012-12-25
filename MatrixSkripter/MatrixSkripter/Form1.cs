using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections;
using System.Reflection;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public ArrayList bitmapxarray = new ArrayList();
        public ArrayList bitmapyarray = new ArrayList();
        public ArrayList bitmapnamearray = new ArrayList();
        public ArrayList bitmapcolorarray = new ArrayList();
        public ArrayList bitmapusedcolorarray = new ArrayList();
        public ArrayList bitmapusedallcolorarray = new ArrayList();
        public ArrayList ScriptPoints = new ArrayList();
        string ShowType = "", BitName = "", TxData = "", TimDelay = "0", SFrame = "Send Frame after Bitmap/Text", SDirection = "LEFT | UP", XCoord = "0", YCoord = "0", BitWidth = "0", BitHeight = "0", BitData = "", BTransparency = "Transparent", PMode = "Normal", FColor = "BLACK", BColor = "BLACK", STextBehaviour = "Normal";
        int ShowTypeIndex = 0, BitNameIndex = 1, TxDataIndex = 2, TimDelayIndex = 3, SFrameIndex = 4, SDirectionIndex = 5, XCoordIndex = 6, YCoordIndex = 7, BitWidthIndex = 8, BitHeightIndex = 9, BitDataIndex = 10, BTransparencyIndex = 11, PModeIndex = 12, FColorIndex = 13, BColorIndex = 14, STextBehaviourIndex = 15;
        public int X_MAX = 31;
        public int Y_MAX = 15;
        public int currentRow = 0;
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TextBitmapFrontColor.SelectedIndex = 2;
            this.TextBitmapBackgroundColor.SelectedIndex = 0;
            this.TextFrontColor.SelectedIndex = 2;
            this.TextBackgroundColor.SelectedIndex = 0;
            this.DrawColor.SelectedIndex = 2;
            this.BitmapSendFrame.SelectedIndex = 1;
            this.TextBitmapSendFrame.SelectedIndex = 1;
            this.TextSendFrame.SelectedIndex = 1;
            this.DrawSendFrame.SelectedIndex = 1;
            this.ClearSpecialSendFrame.SelectedIndex = 1;
            this.BitmapScrollDirection.SelectedIndex = 0;
            this.TextBitmapScrollDirection.SelectedIndex = 0;
            this.TextScrollDirection.SelectedIndex = 0;
            this.ClearFillColor.SelectedIndex = 0;
        }
        private void SPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = SPorts.Text;
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.RtsEnable = true;
            serialPort1.DtrEnable = true;
            serialPort1.ReadTimeout = 2000;
            serialPort1.WriteTimeout = 1000;
            serialPort1.Open();
        }
        private void TestText_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (InputStringText.Text == "") return;
            try
            {
                int test = Convert.ToInt32(InputTextX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputTextX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputTextY.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputTextDelay.Text = "";
                return;
            }
            int textfrontcolor = 0;
            if (TextFrontColor.SelectedIndex == 0) { textfrontcolor = 0; }
            if (TextFrontColor.SelectedIndex == 1 || InputStringText.ForeColor == Color.Green) { textfrontcolor = 1; }
            if (TextFrontColor.SelectedIndex == 2 || InputStringText.ForeColor == Color.Red) { textfrontcolor = 2; }
            if (TextFrontColor.SelectedIndex == 3 || InputStringText.ForeColor == Color.Orange) { textfrontcolor = 3; }
            if (TextFrontColor.SelectedIndex == 4) { textfrontcolor = 4; }
            if (TextFrontColor.SelectedIndex == 5) { textfrontcolor = 8; }
            int textbackcolor = 0;
            if (TextBackgroundColor.SelectedIndex == 0) { textbackcolor = 0; }
            if (TextBackgroundColor.SelectedIndex == 1 || InputStringText.BackColor == Color.Green) { textbackcolor = 1; }
            if (TextBackgroundColor.SelectedIndex == 2 || InputStringText.BackColor == Color.Red) { textbackcolor = 2; }
            if (TextBackgroundColor.SelectedIndex == 3 || InputStringText.BackColor == Color.Orange) { textbackcolor = 3; }
            if (TextBackgroundColor.SelectedIndex == 4) { textbackcolor = 4; }
            if (TextBackgroundColor.SelectedIndex == 5) { textbackcolor = 5; }
            if (TextShow.Checked)
            {
                serialPort1.Write("tx,");
                serialPort1.Write(InputTextX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextY.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextDelay.Text);
                serialPort1.Write(",");
                if (TextSendFrame.SelectedIndex == 0)
                {
                    serialPort1.Write("0,");
                }
                else if (TextSendFrame.SelectedIndex == 1)
                {
                    serialPort1.Write("1,");
                }
                else if (TextSendFrame.SelectedIndex == 2)
                {
                    serialPort1.Write("2,");
                }
                serialPort1.Write(textfrontcolor.ToString());
                serialPort1.Write(",");
                serialPort1.Write(textbackcolor.ToString());
                serialPort1.Write(",0,");
                serialPort1.WriteLine(InputStringText.Text + "\n");
            }
            else if (TextShowY.Checked)
            {
                serialPort1.Write("ty,");
                serialPort1.Write(InputTextX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextY.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextDelay.Text);
                serialPort1.Write(",");
                if (TextSendFrame.SelectedIndex == 0)
                {
                    serialPort1.Write("0,");
                }
                else if (TextSendFrame.SelectedIndex == 1)
                {
                    serialPort1.Write("1,");
                }
                else if (TextSendFrame.SelectedIndex == 2)
                {
                    serialPort1.Write("2,");
                }
                serialPort1.Write(textfrontcolor.ToString());
                serialPort1.Write(",");
                serialPort1.Write(textbackcolor.ToString());
                serialPort1.Write(",0,");
                serialPort1.WriteLine(InputStringText.Text + "\n");
            }
            else if (TextScrollX.Checked)
            {
                serialPort1.Write("sx,");
                serialPort1.Write(InputTextX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextY.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextDelay.Text);
                serialPort1.Write(",1,");
                if (TextBehaviourBlink.Checked)
                { textfrontcolor = textfrontcolor + 16; }
                serialPort1.Write(textfrontcolor.ToString());
                if (TextScrollDirection.SelectedIndex == 0)
                {
                    serialPort1.Write(",0,");
                }
                else if (TextScrollDirection.SelectedIndex == 1)
                {
                    serialPort1.Write(",1,");
                }
                serialPort1.Write(textbackcolor.ToString());
                serialPort1.Write(",");
                serialPort1.WriteLine(InputStringText.Text + "\n");
                System.Threading.Thread.Sleep(InputStringText.Text.Length * 200);
            }
            else if (TextScrollY.Checked)
            {
                serialPort1.Write("sy,");
                serialPort1.Write(InputTextX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextY.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputTextDelay.Text);
                serialPort1.Write(",1,");
                if (TextBehaviourBlink.Checked)
                { textfrontcolor = textfrontcolor + 16; }
                serialPort1.Write(textfrontcolor.ToString());
                if (TextScrollDirection.SelectedIndex == 0)
                {
                    serialPort1.Write(",0,");
                }
                else if (TextScrollDirection.SelectedIndex == 1)
                {
                    serialPort1.Write(",1,");
                }
                serialPort1.Write(textbackcolor.ToString());
                serialPort1.Write(",");
                serialPort1.WriteLine(InputStringText.Text + "\n");
                System.Threading.Thread.Sleep(InputStringText.Text.Length * 200);
            }
        }
        private void SelectFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = InputStringTextBitmap.Font;
            fontDialog1.Color = InputStringTextBitmap.ForeColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                InputStringTextBitmap.Font = fontDialog1.Font;
                InputStringTextBitmap.ForeColor = fontDialog1.Color;
            }
        }
        private void TestTextBitmap_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (InputStringTextBitmap.Text == "") return;
            try
            {
                int test = Convert.ToInt32(InputTextBitmapX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputTextBitmapX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextBitmapY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputTextBitmapY.Text = "";
                return;
            }
            Bitmap flag = new Bitmap(1500, 50);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.SmoothingMode = SmoothingMode.None;
            // Set maximum layout size.
            SizeF layoutSize = new SizeF(1000.0F, 100.0F);
            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = flagGraphics.MeasureString(InputStringTextBitmap.Text, InputStringTextBitmap.Font, layoutSize);
            flagGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            flagGraphics.FillRectangle(new System.Drawing.SolidBrush(InputStringTextBitmap.BackColor), 0, 0, stringSize.Width, stringSize.Height);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            flagGraphics.DrawString(InputStringTextBitmap.Text, InputStringTextBitmap.Font, new System.Drawing.SolidBrush(InputStringTextBitmap.ForeColor), 0, 0, strFormat);
            pictureBox1.Image = flag;
            ArrayList fontallarray = new ArrayList();
            String colorstring = "";
            ArrayList ycolor = new ArrayList();
            ArrayList xcolor = new ArrayList();
            int firstxpixel = 0, firstypixel = 0, firstxcontrolpixel = 0, firstycontrolpixel = 0, lastxpixel = 0, lastypixel = 0, lastxcontrolpixel = 0, lastycontrolpixel = 0, actualxpixel = 0, actualypixel = 0;
            bool foundxpixel = false, foundypixel = false, foundlastxpixel = false, foundlastypixel = false;
            int widthtestpixel = 0, heighttestpixel = 0;
            while (foundypixel == false)
            {
                while (widthtestpixel < stringSize.Width && foundypixel == false)
                {
                    while (heighttestpixel < stringSize.Height && foundypixel == false)
                    {
                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundypixel == false)
                        {
                            firstxcontrolpixel = widthtestpixel;
                            firstypixel = heighttestpixel;
                            foundypixel = true;
                        }
                        heighttestpixel++;
                    }
                    widthtestpixel++;
                    heighttestpixel = 0;
                }
                widthtestpixel = 0;
            }
            widthtestpixel = 0;
            heighttestpixel = 0;
            while (foundxpixel == false)
            {
                while (heighttestpixel < stringSize.Height && foundxpixel == false)
                {
                    while (widthtestpixel < stringSize.Width && foundxpixel == false)
                    {
                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundxpixel == false)
                        {
                            firstxpixel = widthtestpixel;
                            firstycontrolpixel = heighttestpixel;
                            foundxpixel = true;
                        }
                        widthtestpixel++;
                    }
                    heighttestpixel++;
                    widthtestpixel = 0;
                }
                heighttestpixel = 0;
            }
            widthtestpixel = (int)stringSize.Width;
            heighttestpixel = (int)stringSize.Height;
            while (foundlastypixel == false)
            {
                while (widthtestpixel > 0 && foundlastypixel == false)
                {
                    while (heighttestpixel > 0 && foundlastypixel == false)
                    {
                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundlastypixel == false)
                        {
                            lastxcontrolpixel = widthtestpixel;
                            lastypixel = heighttestpixel;
                            foundlastypixel = true;
                        }
                        heighttestpixel--;
                    }
                    widthtestpixel--;
                    heighttestpixel = (int)stringSize.Height;
                }
                widthtestpixel = (int)stringSize.Width;
            }
            widthtestpixel = (int)stringSize.Width;
            heighttestpixel = (int)stringSize.Height;
            while (foundlastxpixel == false)
            {
                while (heighttestpixel > 0 && foundlastxpixel == false)
                {
                    while (widthtestpixel > 0 && foundlastxpixel == false)
                    {
                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundlastxpixel == false)
                        {
                            lastxpixel = widthtestpixel;
                            lastycontrolpixel = heighttestpixel;
                            foundlastxpixel = true;
                        }
                        widthtestpixel--;
                    }
                    heighttestpixel--;
                    widthtestpixel = (int)stringSize.Width;
                }
                heighttestpixel = (int)stringSize.Height;
            }
            if (firstxcontrolpixel != firstxpixel && firstycontrolpixel != firstypixel)
            {
                firstxpixel = firstxcontrolpixel;
                firstypixel = firstycontrolpixel;
            }
            if (lastxcontrolpixel != lastxpixel && lastycontrolpixel != lastypixel)
            {
                lastxpixel = lastxcontrolpixel;
                lastypixel = lastycontrolpixel;
            }
            lastxpixel = lastxpixel + firstxpixel;
            lastypixel = lastypixel + firstypixel;
            int textfrontcolor = 0;
            if (TextBitmapFrontColor.SelectedIndex == 0) { textfrontcolor = 0; }
            if (TextBitmapFrontColor.SelectedIndex == 1 || InputStringTextBitmap.ForeColor == Color.Green) { textfrontcolor = 1; }
            if (TextBitmapFrontColor.SelectedIndex == 2 || InputStringTextBitmap.ForeColor == Color.Red) { textfrontcolor = 2; }
            if (TextBitmapFrontColor.SelectedIndex == 3 || InputStringTextBitmap.ForeColor == Color.Orange) { textfrontcolor = 3; }
            if (TextBitmapFrontColor.SelectedIndex == 4) { textfrontcolor = 4; }
            if (TextBitmapFrontColor.SelectedIndex == 5) { textfrontcolor = 5; }
            if (TextBitmapFrontColor.SelectedIndex == 6) { textfrontcolor = 6; }
            if (TextBitmapFrontColor.SelectedIndex == 7) { textfrontcolor = 7; }
            if (TextBitmapFrontColor.SelectedIndex == 8) { textfrontcolor = 8; }
            if (TextBitmapFrontColor.SelectedIndex == 9) { textfrontcolor = 9; }
            int textbackcolor = 0;
            if (TextBitmapBackgroundColor.SelectedIndex == 0) { textbackcolor = 0; }
            if (TextBitmapBackgroundColor.SelectedIndex == 1 || InputStringTextBitmap.BackColor == Color.Green) { textbackcolor = 1; }
            if (TextBitmapBackgroundColor.SelectedIndex == 2 || InputStringTextBitmap.BackColor == Color.Red) { textbackcolor = 2; }
            if (TextBitmapBackgroundColor.SelectedIndex == 3 || InputStringTextBitmap.BackColor == Color.Orange) { textbackcolor = 3; }
            if (TextBitmapBackgroundColor.SelectedIndex == 4) { textbackcolor = 4; }
            if (TextBitmapBackgroundColor.SelectedIndex == 5) { textbackcolor = 5; }
            if (TextBitmapBackgroundColor.SelectedIndex == 6) { textbackcolor = 6; }
            if (TextBitmapBackgroundColor.SelectedIndex == 7) { textbackcolor = 7; }
            if (TextBitmapBackgroundColor.SelectedIndex == 8) { textbackcolor = 8; }
            if (TextBitmapBackgroundColor.SelectedIndex == 9) { textbackcolor = 9; }
            Random rnd = new Random();
            if (textfrontcolor == 6 || textbackcolor == 6)
            {
                for (int ycounter = 0; ycounter <= lastypixel; ycounter++)
                {
                    ycolor.Add(rnd.Next(1, 4));
                }
            }
            for (int widthpixel = firstxpixel; widthpixel < lastxpixel; widthpixel++)
            {
                for (int heightpixel = firstypixel; heightpixel < lastypixel; heightpixel++)
                {
                    if (flag.GetPixel(widthpixel, heightpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()))
                    {
                        actualxpixel = widthpixel - firstxpixel;
                        actualypixel = heightpixel - firstypixel;
                        if (textfrontcolor == 6)
                        {

                            colorstring = colorstring + ycolor[heightpixel].ToString();
                        }
                        else
                        {

                            colorstring = colorstring + textfrontcolor.ToString();
                        }
                    }
                    else
                    {
                        actualxpixel = widthpixel - firstxpixel;
                        actualypixel = heightpixel - firstypixel;
                        if (textbackcolor == 6)
                        {
                            colorstring = colorstring + ycolor[heightpixel].ToString();

                        }
                        else
                        {
                            colorstring = colorstring + textbackcolor.ToString();

                        }
                    }
                }
                fontallarray.Add(colorstring);

                colorstring = "";
            }
            int startcolumn = 0, endcolumn = X_MAX;
            int randomcolor = rnd.Next(1, 4);
            if (TextBitmapShow.Checked)
            {
                if ((Convert.ToInt16(InputTextBitmapX.Text) + X_MAX + 1) >= fontallarray.Count)
                {
                    endcolumn = fontallarray.Count;
                }
                else
                {
                    endcolumn = -Convert.ToInt16(InputTextBitmapX.Text) + X_MAX + 1;
                }
                for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                {
                    int actualx = countarraylist + Convert.ToInt16(InputTextBitmapX.Text);
                    int actualy = Convert.ToInt16(InputTextBitmapY.Text);
                    serialPort1.Write("dr,");
                    serialPort1.Write(actualx.ToString());
                    serialPort1.Write(",");
                    serialPort1.Write(actualy.ToString() + ",");
                    serialPort1.Write(InputTextBitmapDelay.Text + ",");
                    if ((countarraylist == endcolumn - 1 && TextBitmapSendFrame.SelectedIndex != 2) || TextBitmapSendFrame.SelectedIndex == 0)
                    {
                        serialPort1.Write("1,");
                    }
                    else
                    {
                        serialPort1.Write("0,");
                    }
                    if (TextBitmapTransparent.Checked)
                    {
                        serialPort1.Write("1,");
                    }
                    else
                    {
                        serialPort1.Write("0,");
                    }
                    if (TextBitmapPictureErase.Checked)
                    {
                        serialPort1.Write("1,");
                    }
                    else
                    {
                        serialPort1.Write("0,");
                    }
                    serialPort1.Write("0,");
                    if (textfrontcolor == 4 || textbackcolor == 4) { serialPort1.Write(fontallarray[countarraylist].ToString().Replace("4", randomcolor.ToString()) + "\n"); }
                    else
                    { serialPort1.Write(fontallarray[countarraylist].ToString() + "\n"); }

                    serialPort1.ReadChar();
                }

            }
            else if (TextBitmapScrollX.Checked)
            {
                if (TextBitmapScrollDirection.SelectedIndex == 0)
                {
                    for (int xmove = X_MAX; xmove >= -lastxpixel; xmove--)
                    {
                        if (xmove >= 0)
                        {
                            startcolumn = 0;
                        }
                        else
                        {
                            startcolumn = -xmove;
                        }
                        if ((-xmove + X_MAX + 1) >= fontallarray.Count)
                        {
                            endcolumn = fontallarray.Count;
                        }
                        else
                        {
                            endcolumn = -xmove + X_MAX + 1;
                        }
                        randomcolor = rnd.Next(1, 4);
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + xmove;
                            int actualy = Convert.ToInt16(InputTextBitmapY.Text);
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputTextBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            if (textfrontcolor == 4 || textbackcolor == 4) { serialPort1.Write(fontallarray[countarraylist].ToString().Replace("4", randomcolor.ToString()) + "\n"); }
                            else
                            { serialPort1.Write(fontallarray[countarraylist].ToString() + "\n"); }

                            serialPort1.ReadChar();

                        }

                    }
                }
                else if (TextBitmapScrollDirection.SelectedIndex == 1)
                {
                    for (int xmove = -lastxpixel; xmove <= X_MAX; xmove++)
                    {
                        startcolumn = 0;
                        if ((X_MAX + 1 - fontallarray.Count) <= xmove)
                        {
                            endcolumn = X_MAX + 1 - xmove;
                        }
                        else
                        {
                            endcolumn = fontallarray.Count;
                        }
                        randomcolor = rnd.Next(1, 4);
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + xmove;
                            int actualy = Convert.ToInt16(InputTextBitmapY.Text);
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputTextBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            if (textfrontcolor == 4 || textbackcolor == 4) { serialPort1.Write(fontallarray[countarraylist].ToString().Replace("4", randomcolor.ToString()) + "\n"); }
                            else
                            { serialPort1.Write(fontallarray[countarraylist].ToString() + "\n"); }

                            serialPort1.ReadChar();

                        }

                    }
                }
            }
            else if (TextBitmapScrollY.Checked)
            {
                if (TextBitmapScrollDirection.SelectedIndex == 0)
                {
                    for (int ymove = Y_MAX; ymove >= -lastypixel; ymove--)
                    {
                        if (X_MAX >= fontallarray.Count)
                        {
                            endcolumn = fontallarray.Count;
                        }
                        else
                        {
                            endcolumn = X_MAX;
                        }
                        randomcolor = rnd.Next(1, 4);
                        for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + Convert.ToInt16(InputTextBitmapX.Text);
                            int actualy = ymove;
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputTextBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            if (textfrontcolor == 4 || textbackcolor == 4) { serialPort1.Write(fontallarray[countarraylist].ToString().Replace("4", randomcolor.ToString()) + "\n"); }
                            else
                            { serialPort1.Write(fontallarray[countarraylist].ToString() + "\n"); }

                            serialPort1.ReadChar();

                        }

                    }
                }
                else if (TextBitmapScrollDirection.SelectedIndex == 1)
                {
                    for (int ymove = -lastypixel; ymove <= Y_MAX; ymove++)
                    {
                        if (X_MAX >= fontallarray.Count)
                        {
                            endcolumn = fontallarray.Count;
                        }
                        else
                        {
                            endcolumn = X_MAX;
                        }
                        randomcolor = rnd.Next(1, 4);
                        for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + Convert.ToInt16(InputTextBitmapX.Text);
                            int actualy = ymove;
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputTextBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            if (textfrontcolor == 4 || textbackcolor == 4) { serialPort1.Write(fontallarray[countarraylist].ToString().Replace("4", randomcolor.ToString()) + "\n"); }
                            else
                            { serialPort1.Write(fontallarray[countarraylist].ToString() + "\n"); }

                            serialPort1.ReadChar();

                        }

                    }
                }
            }
        }
        private void TestBitmap_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (bitmapxarray.Count == 0) return;
            try
            {
                int test = Convert.ToInt32(InputBitmapX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputBitmapX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputBitmapY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputBitmapY.Text = "";
                return;
            }
            int startcolumn = 0, endcolumn = X_MAX, startline = 0, endline = Y_MAX;
            int randomcolor = rnd.Next(1, 4);
            if (BitmapColor0.SelectedIndex == -1 && BitmapColor1.SelectedIndex == -1 && BitmapColor2.SelectedIndex == -1 && BitmapColor3.SelectedIndex == -1 && BitmapColor4.SelectedIndex == -1 && BitmapColor5.SelectedIndex == -1 && BitmapColor6.SelectedIndex == -1 && BitmapColor7.SelectedIndex == -1 && BitmapColor8.SelectedIndex == -1 && BitmapColor9.SelectedIndex == -1 && BitmapColor10.SelectedIndex == -1 && BitmapColor11.SelectedIndex == -1 && BitmapColor12.SelectedIndex == -1 && BitmapColor13.SelectedIndex == -1 && BitmapColor14.SelectedIndex == -1 && BitmapColor15.SelectedIndex == -1)
            {
                MessageBox.Show("Please match the bitmap colors to the colors you want to display on the matrix");
                return;
            }
            if (BitmapShow.Checked)
            {
                if (Convert.ToInt16(InputBitmapX.Text) >= 0)
                {
                    startcolumn = 0;
                }
                else
                {
                    startcolumn = -Convert.ToInt16(InputBitmapX.Text);
                }
                if ((-Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1) >= bitmapcolorarray.Count)
                {
                    endcolumn = bitmapcolorarray.Count;
                }
                else
                {
                    endcolumn = -Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1;
                }
                if (Convert.ToInt16(InputBitmapY.Text) >= 0)
                {
                    startline = 0;
                }
                else
                {
                    startline = -Convert.ToInt16(InputBitmapY.Text);
                }
                if ((startline + Y_MAX + 1) >= Convert.ToInt16(bitmapyarray[0]))
                {
                    endline = Convert.ToInt16(bitmapyarray[0]) - startline;
                }
                else
                {
                    endline = Y_MAX + 1;
                }
                if (endcolumn > bitmapcolorarray.Count) { endcolumn = bitmapcolorarray.Count; }
                if (startline >= (Convert.ToInt16(bitmapyarray[0]) - 1)) { return; }
                for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                {
                    int actualx = countarraylist + Convert.ToInt16(InputBitmapX.Text);
                    int actualy = Convert.ToInt16(InputBitmapY.Text) + startline;
                    String colorstring = "";
                    String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                    String[] allcolorstring = wholecolorstring.ToString().Split(';');

                    foreach (string s in allcolorstring)
                    {

                        if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                        }
                        else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor15.SelectedIndex != -1)
                        {
                            colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                        }
                        else
                        {
                            colorstring = colorstring + "0";
                        }
                    }

                    serialPort1.Write("dr,");
                    serialPort1.Write(actualx.ToString());
                    serialPort1.Write(",");
                    serialPort1.Write(actualy.ToString() + ",");
                    serialPort1.Write(InputBitmapDelay.Text + ",");
                    if ((countarraylist == endcolumn - 1 && BitmapSendFrame.SelectedIndex != 2) || BitmapSendFrame.SelectedIndex == 0)
                    {
                        serialPort1.Write("1,");
                    }
                    else if (BitmapSendFrame.SelectedIndex == 0)
                    {
                        serialPort1.Write("0,");
                    }
                    else if (BitmapSendFrame.SelectedIndex == 2)
                    {
                        serialPort1.Write("2,");
                    }
                    if (BitmapTransparent.Checked)
                    {
                        serialPort1.Write("1,");
                    }
                    else
                    {
                        serialPort1.Write("0,");
                    }
                    if (BitmapPictureErase.Checked)
                    {
                        serialPort1.Write("1,");
                    }
                    else
                    {
                        serialPort1.Write("0,");
                    }
                    serialPort1.Write("0,");
                    serialPort1.Write(colorstring.Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                    serialPort1.ReadChar();
                    colorstring = "";

                }

            }
            else if (BitmapScrollX.Checked)
            {
                if (BitmapScrollDirection.SelectedIndex == 0)
                {
                    for (int xmove = X_MAX; xmove >= -Convert.ToInt16(bitmapxarray[0]); xmove--)
                    {
                        if (xmove >= 0)
                        {
                            startcolumn = 0;
                        }
                        else
                        {
                            startcolumn = -xmove;
                        }
                        if ((-xmove + X_MAX + 1) >= bitmapcolorarray.Count)
                        {
                            endcolumn = bitmapcolorarray.Count;
                        }
                        else
                        {
                            endcolumn = -xmove + X_MAX + 1;
                        }
                        if (Convert.ToInt16(InputBitmapY.Text) >= 0)
                        {
                            startline = 0;
                        }
                        else
                        {
                            startline = -Convert.ToInt16(InputBitmapY.Text);
                        }
                        if ((startline + Y_MAX) >= Convert.ToInt16(bitmapyarray[0]))
                        {
                            endline = Convert.ToInt16(bitmapyarray[0]) - startline;
                        }
                        else
                        {
                            endline = Y_MAX + 1;
                        }
                        if (endcolumn > bitmapcolorarray.Count) { endcolumn = bitmapcolorarray.Count; }
                        if (startline >= (Convert.ToInt16(bitmapyarray[0]))) { return; }
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + xmove;
                            int actualy = Convert.ToInt16(InputBitmapY.Text) + startline;
                            String colorstring = "";
                            String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(';');
                            foreach (string s in allcolorstring)
                            {

                                if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                                }
                                else
                                {
                                    colorstring = colorstring + "0";
                                }
                            }
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            serialPort1.Write(colorstring.Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                            serialPort1.ReadChar();
                            colorstring = "";

                        }

                    }
                }
                else if (BitmapScrollDirection.SelectedIndex == 1)
                {
                    for (int xmove = -Convert.ToInt16(bitmapxarray[0]); xmove <= X_MAX; xmove++)
                    {
                        startcolumn = 0;
                        if ((X_MAX - bitmapcolorarray.Count + 1) <= xmove)
                        {
                            endcolumn = X_MAX - xmove;
                        }
                        else
                        {
                            endcolumn = bitmapcolorarray.Count;
                        }
                        if (Convert.ToInt16(InputBitmapY.Text) >= 0)
                        {
                            startline = 0;
                        }
                        else
                        {
                            startline = -Convert.ToInt16(InputBitmapY.Text);
                        }
                        if ((startline + Y_MAX) >= Convert.ToInt16(bitmapyarray[0]))
                        {
                            endline = Convert.ToInt16(bitmapyarray[0]) - startline;
                        }
                        else
                        {
                            endline = Y_MAX + 1;
                        }

                        if (endcolumn > bitmapcolorarray.Count) { endcolumn = bitmapcolorarray.Count; }
                        if (startline >= (Convert.ToInt16(bitmapyarray[0]))) { return; }
                        if (endline > Convert.ToInt16(bitmapyarray[0])) { endline = Convert.ToInt16(bitmapyarray[0]); }
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {

                            int actualx = countarraylist + xmove;
                            int actualy = Convert.ToInt16(InputBitmapY.Text) + startline;
                            String colorstring = "";
                            String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(';');

                            foreach (string s in allcolorstring)
                            {

                                if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                                }
                                else
                                {
                                    colorstring = colorstring + "0";
                                }
                            }
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            serialPort1.Write(colorstring.Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                            serialPort1.ReadChar();
                            colorstring = "";
                        }
                    }
                }
            }
            else if (BitmapScrollY.Checked)
            {
                if (BitmapScrollDirection.SelectedIndex == 0)
                {
                    for (int ymove = Y_MAX; ymove >= -Convert.ToInt16(bitmapyarray[0]); ymove--)
                    {
                        if (Convert.ToInt16(InputBitmapX.Text) >= 0)
                        {
                            startcolumn = 0;
                        }
                        else
                        {
                            startcolumn = -Convert.ToInt16(InputBitmapX.Text);
                        }
                        if ((-Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1) >= bitmapcolorarray.Count)
                        {
                            endcolumn = bitmapcolorarray.Count;
                        }
                        else
                        {
                            endcolumn = -Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1;
                        }
                        if (ymove >= 0)
                        {
                            startline = 0;
                        }
                        else
                        {
                            startline = -ymove;
                        }
                        if ((-ymove + Y_MAX + 1) >= Convert.ToInt16(bitmapyarray[0]))
                        {
                            endline = Convert.ToInt16(bitmapyarray[0]) - startline;
                        }
                        else
                        {
                            endline = Y_MAX + 1;
                        }
                        if (endcolumn > bitmapcolorarray.Count) { endcolumn = bitmapcolorarray.Count; }
                        if (endline > Convert.ToInt16(bitmapyarray[0])) { endline = Convert.ToInt16(bitmapyarray[0]); }
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {

                            int actualx = countarraylist + Convert.ToInt16(InputBitmapX.Text);
                            int actualy = ymove + startline;
                            String colorstring = "";
                            String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(';');

                            foreach (string s in allcolorstring)
                            {
                                //richTextBox1.AppendText(s + ";\n");
                                if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor15.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                                }
                                else
                                {
                                    colorstring = colorstring + "0";
                                }
                            }
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            serialPort1.Write(colorstring.Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                            serialPort1.ReadChar();
                            colorstring = "";

                        }

                    }
                }
                if (BitmapScrollDirection.SelectedIndex == 1)
                {
                    for (int ymove = -Convert.ToInt16(bitmapyarray[0]); ymove <= Y_MAX; ymove++)
                    {
                        if (Convert.ToInt16(InputBitmapX.Text) >= 0)
                        {
                            startcolumn = 0;
                        }
                        else
                        {
                            startcolumn = -Convert.ToInt16(InputBitmapX.Text);
                        }
                        if ((-Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1) >= bitmapcolorarray.Count)
                        {
                            endcolumn = bitmapcolorarray.Count;
                        }
                        else
                        {
                            endcolumn = -Convert.ToInt16(InputBitmapX.Text) + X_MAX + 1;
                        }
                        if (ymove <= 0)
                        {
                            startline = -ymove;
                        }
                        else
                        {
                            startline = 0;
                        }
                        if ((-ymove + Y_MAX + 1) >= Convert.ToInt16(bitmapyarray[0]))
                        {
                            endline = Convert.ToInt16(bitmapyarray[0]) - startline;
                        }
                        else
                        {
                            endline = Y_MAX + 1;
                        }
                        if (endcolumn > bitmapcolorarray.Count) { endcolumn = bitmapcolorarray.Count; }
                        if (endline > Convert.ToInt16(bitmapyarray[0])) { endline = Convert.ToInt16(bitmapyarray[0]); }
                        for (int countarraylist = startcolumn; countarraylist < endcolumn; countarraylist++)
                        {
                            int actualx = countarraylist + Convert.ToInt16(InputBitmapX.Text);
                            int actualy = ymove + startline;
                            String colorstring = "";
                            String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(';');
                            foreach (string s in allcolorstring)
                            {

                                if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                                }
                                else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor15.SelectedIndex != -1)
                                {
                                    colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                                }
                                else
                                {
                                    colorstring = colorstring + "0";
                                }
                            }
                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString() + ",");
                            serialPort1.Write(InputBitmapDelay.Text + ",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write("0,0,0,");
                            serialPort1.Write(colorstring.Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                            serialPort1.ReadChar();
                            colorstring = "";
                        }

                    }
                }
            }
        }
        private void Bitmapopener2_Click(object sender, EventArgs e)
        {
            bitmapxarray.Clear();
            bitmapyarray.Clear();
            bitmapnamearray.Clear();
            bitmapcolorarray.Clear();
            bitmapusedcolorarray.Clear();
            bitmapusedallcolorarray.Clear();
            openFileDialog1.Filter = "JPG Image (*.jpg, *.jpeg, *.jpe, *.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|Bitmap Image|*.bmp|Gif Image (*.gif)|*.gif|PNG Files (*.png)|*.png|All Files|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cl0label.BackColor = System.Drawing.SystemColors.Control;
                cl1label.BackColor = System.Drawing.SystemColors.Control;
                cl2label.BackColor = System.Drawing.SystemColors.Control;
                cl3label.BackColor = System.Drawing.SystemColors.Control;
                cl4label.BackColor = System.Drawing.SystemColors.Control;
                cl5label.BackColor = System.Drawing.SystemColors.Control;
                cl6label.BackColor = System.Drawing.SystemColors.Control;
                cl7label.BackColor = System.Drawing.SystemColors.Control;
                cl8label.BackColor = System.Drawing.SystemColors.Control;
                cl9label.BackColor = System.Drawing.SystemColors.Control;
                cl10label.BackColor = System.Drawing.SystemColors.Control;
                cl11label.BackColor = System.Drawing.SystemColors.Control;
                cl12label.BackColor = System.Drawing.SystemColors.Control;
                cl13label.BackColor = System.Drawing.SystemColors.Control;
                cl14label.BackColor = System.Drawing.SystemColors.Control;
                cl15label.BackColor = System.Drawing.SystemColors.Control;

                Bitmap image1 = new Bitmap(openFileDialog1.FileName, true);
                image1.RotateFlip(RotateFlipType.Rotate90FlipX);
                pictureBox1.Image = image1;
                bitmapxarray.Add(image1.Height);
                bitmapyarray.Add(image1.Width);
                bitmapnamearray.Add(System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
                String colorstring = "";
                //for (int scrollxpixel = 0; scrollxpixel < 31; scrollxpixel++)                
                for (int heightpixel = 0; heightpixel < image1.Height; heightpixel++)
                {
                    for (int widthpixel = 0; widthpixel < image1.Width; widthpixel++)
                    {
                        Color pixelColor = image1.GetPixel(widthpixel, heightpixel);
                        String PixelwertAllText = pixelColor.ToString();
                        colorstring = colorstring + PixelwertAllText + ";";
                        bitmapusedcolorarray.Add(PixelwertAllText);
                    }
                    bitmapcolorarray.Add(colorstring);
                    colorstring = "";
                }
                bitmapusedcolorarray.Sort();
                String oldcolortext = "", actualcolortext = "";
                int usedcolors = 0;
                for (int countarraylist = 0; countarraylist < bitmapusedcolorarray.Count; countarraylist++)
                {
                    actualcolortext = bitmapusedcolorarray[countarraylist].ToString();
                    if (oldcolortext != actualcolortext)
                    {

                        string[] oldcolortextdifferent = actualcolortext.Split(',');
                        switch (usedcolors)
                        {
                            case 0:
                                cl0label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 1:
                                cl1label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 2:
                                cl2label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 3:
                                cl3label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 4:
                                cl4label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 5:
                                cl5label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 6:
                                cl6label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 7:
                                cl7label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 8:
                                cl8label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 9:
                                cl9label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 10:
                                cl10label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 11:
                                cl11label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 12:
                                cl12label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 13:
                                cl13label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 14:
                                cl14label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                            case 15:
                                cl15label.BackColor = Color.FromArgb(Convert.ToInt16(oldcolortextdifferent[1].Replace(" R=", "")), Convert.ToInt16(oldcolortextdifferent[2].Replace(" G=", "")), Convert.ToInt16(oldcolortextdifferent[3].Replace(" B=", "").Replace("]", "")));
                                break;
                        }
                        oldcolortext = bitmapusedcolorarray[countarraylist].ToString();
                        usedcolors = usedcolors + 1;
                        bitmapusedallcolorarray.Add(bitmapusedcolorarray[countarraylist]);

                    }
                }
                if (bitmapusedallcolorarray.Count < 16)
                {
                    for (int countarraylist = bitmapusedallcolorarray.Count; countarraylist < 16; countarraylist++)
                    {
                        bitmapusedallcolorarray.Add("Color [A=255, R=255, G=255, B=255]");
                    }
                }
            }
        }
        private void TextBitmapFrontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBitmapFrontColor.SelectedIndex == 1)
            {
                InputStringTextBitmap.ForeColor = Color.Green;
            }
            else if (TextBitmapFrontColor.SelectedIndex == 2)
            {
                InputStringTextBitmap.ForeColor = Color.Red;
            }
            else if (TextBitmapFrontColor.SelectedIndex == 3)
            {
                InputStringTextBitmap.ForeColor = Color.Orange;
            }
            else if (TextBitmapFrontColor.SelectedIndex == 0)
            {
                InputStringTextBitmap.ForeColor = Color.Black;
            }
        }
        private void TextFrontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextFrontColor.SelectedIndex == 1)
            {
                InputStringText.ForeColor = Color.Green;
            }
            else if (TextFrontColor.SelectedIndex == 2)
            {
                InputStringText.ForeColor = Color.Red;
            }
            else if (TextFrontColor.SelectedIndex == 3)
            {
                InputStringText.ForeColor = Color.Orange;
            }
            else if (TextFrontColor.SelectedIndex == 0)
            {
                InputStringText.ForeColor = Color.Black;
            }
        }
        private void TextBitmapBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBitmapBackgroundColor.SelectedIndex == 1)
            {
                InputStringTextBitmap.BackColor = Color.Green;
            }
            else if (TextBitmapBackgroundColor.SelectedIndex == 2)
            {
                InputStringTextBitmap.BackColor = Color.Red;
            }
            else if (TextBitmapBackgroundColor.SelectedIndex == 3)
            {
                InputStringTextBitmap.BackColor = Color.Orange;
            }
            else if (TextBitmapBackgroundColor.SelectedIndex == 0)
            {
                InputStringTextBitmap.BackColor = Color.White;
            }
        }
        private void TextBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBackgroundColor.SelectedIndex == 1)
            {
                InputStringText.BackColor = Color.Green;
            }
            else if (TextBackgroundColor.SelectedIndex == 2)
            {
                InputStringText.BackColor = Color.Red;
            }
            else if (TextBackgroundColor.SelectedIndex == 3)
            {
                InputStringText.BackColor = Color.Orange;
            }
            else if (TextBackgroundColor.SelectedIndex == 0)
            {
                InputStringText.BackColor = Color.White;
            }
        }
        private void TestSpecialClearEffects_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            try
            {
                int test = Convert.ToInt32(InputClearSpecialDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputClearSpecialDelay.Text = "";
                return;
            }
            int clearfillcolor = 0;
            if (ClearFillColor.SelectedIndex == 0) { clearfillcolor = 0; }
            if (ClearFillColor.SelectedIndex == 1) { clearfillcolor = 1; }
            if (ClearFillColor.SelectedIndex == 2) { clearfillcolor = 2; }
            if (ClearFillColor.SelectedIndex == 3) { clearfillcolor = 3; }
            if (ClearFillColor.SelectedIndex == 4) { clearfillcolor = 4; }
            if (ClearFillColor.SelectedIndex == 5) { clearfillcolor = 8; }
            serialPort1.Write("cs,");
            serialPort1.Write("0,0,");
            serialPort1.Write(InputClearSpecialDelay.Text);
            serialPort1.Write(",");
            if (ClearSpecialSendFrame.SelectedIndex == 0)
            {
                serialPort1.Write("0,");
            }
            else if (ClearSpecialSendFrame.SelectedIndex == 1)
            {
                serialPort1.Write("1,");
            }
            else if (ClearSpecialSendFrame.SelectedIndex == 2)
            {
                serialPort1.Write("2,");
            }
            if (ClearFullMatrix.Checked)
            {
                serialPort1.Write("0,");
                if (FullMatrixLeft.Checked)
                {
                    serialPort1.Write("0,0,");
                }
                else if (FullMatrixRight.Checked)
                {
                    serialPort1.Write("0,1,");
                }
                else if (FullMatrixUp.Checked)
                {
                    serialPort1.Write("1,0,");
                }
                else if (FullMatrixTop.Checked)
                {
                    serialPort1.Write("1,1,");
                }
            }
            else if (ClearHalfMatrix.Checked)
            {
                if (HalfVertical.Checked)
                {
                    serialPort1.Write("1,0,");
                }
                else if (HalfHorizontal.Checked)
                {
                    serialPort1.Write("1,1,");
                }
                if (HalfMatrixCenter.Checked)
                {
                    serialPort1.Write("0,");
                }
                else if (HalfMatrixOutside.Checked)
                {
                    serialPort1.Write("1,");
                }
            }

            serialPort1.WriteLine(clearfillcolor.ToString() + "\n");
        }
        private void TestDrawings_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            try
            {
                int test = Convert.ToInt32(InputDrawX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputDrawX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputDrawY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputDrawY.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputDrawDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputDrawDelay.Text = "";
                return;
            }
            if (DrawLine.Checked || DrawRectangle.Checked || DrawEllipse.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawSecondX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawSecondX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawSecondY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawSecondY.Text = "";
                    return;
                }
            }
            if (DrawCircle.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawCircleRadius.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawCircleRadius.Text = "";
                    return;
                }
            }
            if (DrawBezier.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierSecondX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawBezierSecondX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierSecondY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawBezierSecondY.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierThirdX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawBezierThirdX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierThirdY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawBezierThirdY.Text = "";
                    return;
                }
            }
            int drawingcolor = 0;
            if (DrawColor.SelectedIndex == 0) { drawingcolor = 0; }
            if (DrawColor.SelectedIndex == 1) { drawingcolor = 1; }
            if (DrawColor.SelectedIndex == 2) { drawingcolor = 2; }
            if (DrawColor.SelectedIndex == 3) { drawingcolor = 3; }
            if (DrawColor.SelectedIndex == 4) { drawingcolor = 4; }
            if (DrawColor.SelectedIndex == 5) { drawingcolor = 8; }
            if (DrawPlot.Checked)
            {
                serialPort1.Write("pl,");
            }
            else if (DrawLine.Checked)
            {
                serialPort1.Write("li,");
            }
            else if (DrawRectangle.Checked)
            {
                serialPort1.Write("re,");
            }
            else if (DrawEllipse.Checked)
            {
                serialPort1.Write("el,");
            }
            else if (DrawCircle.Checked)
            {
                serialPort1.Write("ci,");
            }
            else if (DrawBezier.Checked)
            {
                serialPort1.Write("be,");
            }
            else if (DrawFill.Checked)
            {
                serialPort1.Write("fi,");
            }
            serialPort1.Write(InputDrawX.Text);
            serialPort1.Write(",");
            serialPort1.Write(InputDrawY.Text);
            serialPort1.Write(",");
            serialPort1.Write(InputDrawDelay.Text);
            serialPort1.Write(",");
            if (DrawSendFrame.SelectedIndex == 1 || DrawSendFrame.SelectedIndex == 0)
            {
                serialPort1.Write("1,");
            }
            else if (DrawSendFrame.SelectedIndex == 2)
            {
                serialPort1.Write("2,");
            }
            if (DrawLine.Checked || DrawRectangle.Checked || DrawEllipse.Checked)
            {
                serialPort1.Write(InputDrawSecondX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputDrawSecondY.Text);
                serialPort1.Write(",");
                serialPort1.Write(drawingcolor.ToString());
                serialPort1.WriteLine(",0\n");
            }
            else if (DrawCircle.Checked)
            {
                serialPort1.Write(InputDrawCircleRadius.Text);
                serialPort1.Write(",");
                serialPort1.Write(drawingcolor.ToString());
                serialPort1.Write(",0");
                serialPort1.WriteLine(",0\n");
            }
            else if (DrawBezier.Checked)
            {
                serialPort1.Write(InputDrawBezierSecondX.Text);
                serialPort1.Write(",");
                serialPort1.Write(InputDrawBezierSecondY.Text);
                serialPort1.Write(",");
                serialPort1.Write(drawingcolor.ToString());
                serialPort1.WriteLine("," + InputDrawBezierThirdX.Text + "-" + InputDrawBezierThirdY.Text + "\n");
            }
            else if (DrawFill.Checked || DrawPlot.Checked)
            {
                serialPort1.Write(drawingcolor.ToString());
                serialPort1.Write(",");
                serialPort1.Write("0,0");
                serialPort1.WriteLine(",0\n");
            }
        }
        private void TestClearMatrix_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            serialPort1.WriteLine("cl,0,0,0,0,0,0,0\n");
        }
        private void TestMatrixScript_Click(object sender, EventArgs e)
        {

            int startcolumn = 0, endcolumn = X_MAX, startline = 0, endline = Y_MAX;
            if (TestSerialPort.Checked)
            {
                if (!serialPort1.IsOpen) return;
            }

            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                int randomcolor = rnd.Next(1, 4);
                int rowfrontcolor = 0;
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "BLACK") { rowfrontcolor = 0; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "GREEN") { rowfrontcolor = 1; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RED") { rowfrontcolor = 2; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "ORANGE") { rowfrontcolor = 3; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RANDOMCOLOR") { rowfrontcolor = 4; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RANDOMCOLUMNCOLOR") { rowfrontcolor = 5; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RANDOMLINECOLOR") { rowfrontcolor = 6; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RANDOMREDGREENMULTICOLOR") { rowfrontcolor = 7; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "MULTICOLOR") { rowfrontcolor = 8; }
                if (dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() == "RANDOMREDORANGEMULTICOLOR") { rowfrontcolor = 9; }
                int rowbackcolor = 0;
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "BLACK") { rowbackcolor = 0; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "GREEN") { rowbackcolor = 1; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RED") { rowbackcolor = 2; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "ORANGE") { rowbackcolor = 3; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RANDOMCOLOR") { rowbackcolor = 4; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RANDOMCOLUMNCOLOR") { rowbackcolor = 5; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RANDOMLINECOLOR") { rowbackcolor = 6; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RANDOMREDGREENMULTICOLOR") { rowbackcolor = 7; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "MULTICOLOR") { rowbackcolor = 8; }
                if (dataGridView1.Rows[x].Cells[BColorIndex].Value.ToString() == "RANDOMREDORANGEMULTICOLOR") { rowbackcolor = 9; }
                if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Draw Each Column/Char")
                {
                    SFrame = "0";
                }
                else if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Send Frame after Bitmap/Text")
                {
                    SFrame = "1";
                }
                else if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Don't Send Frame")
                {
                    SFrame = "2";
                }
                if ((string)dataGridView1.Rows[x].Cells[PModeIndex].Value == "Picture Erase")
                {
                    PMode = "1";
                }
                else
                {
                    PMode = "0";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bitmap" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                {
                    if (Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) >= 0)
                    {
                        startcolumn = 0;
                    }
                    else
                    {
                        startcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                    }
                    if ((-Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value))
                    {
                        endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value);
                    }
                    else
                    {
                        endcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1;
                    }
                    if (Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) >= 0)
                    {
                        startline = 0;
                    }
                    else
                    {
                        startline = -Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value);
                    }
                    if ((startline + Y_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value))
                    {
                        endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - startline;
                    }
                    else
                    {
                        endline = Y_MAX + 1;
                    }
                    if (endcolumn > Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value)) { endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); }
                    if (startline >= (Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - 1)) { return; }
                    String wholecolorstring = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString();
                    String[] allcolorstring = wholecolorstring.ToString().Split(':');
                    for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                    {
                        int actualx = countarraylist + Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                        int actualy = Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) + startline;
                        if (TestSerialPort.Checked)
                        {

                            serialPort1.Write("dr,");
                            serialPort1.Write(actualx.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(actualy.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                            serialPort1.Write(",");
                            if (countarraylist == endcolumn - 1)
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            if (dataGridView1.Rows[x].Cells[BTransparencyIndex].Value.ToString() == "Transparent")
                            {
                                serialPort1.Write("1,");
                            }
                            else
                            {
                                serialPort1.Write("0,");
                            }
                            serialPort1.Write(PMode + ",");
                            serialPort1.Write("0,");
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                            {
                                serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n");
                            }
                            else
                            {
                                serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                            }
                            serialPort1.ReadChar();
                        }
                        else if (TestUDP.Checked)
                        {

                            UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                            try
                            {
                                udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                                // Sends a message to the host to which you have connected.
                                string FunctionString = ""; Byte[] sendBytes;
                                FunctionString += "dr,";
                                FunctionString += actualx.ToString();
                                FunctionString += ",";
                                FunctionString += actualy.ToString();
                                FunctionString += ",";
                                FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                                FunctionString += ",";
                                if (countarraylist == endcolumn - 1)
                                {
                                    FunctionString += "1,";
                                }
                                else
                                {
                                    FunctionString += "0,";
                                }
                                if (dataGridView1.Rows[x].Cells[BTransparencyIndex].Value.ToString() == "Transparent")
                                {
                                    FunctionString += "1,";
                                }
                                else
                                {
                                    FunctionString += "0,";
                                }
                                FunctionString += PMode + ",";
                                FunctionString += "0,";
                                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                                {
                                    FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n";
                                }
                                else
                                {
                                    FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n";
                                }

                                sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                                udpClient.Send(sendBytes, sendBytes.Length);
                                //IPEndPoint object will allow us to read datagrams sent from any source.
                                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                                // Blocks until a message returns on this socket from a remote host.
                                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                                string returnData = Encoding.ASCII.GetString(receiveBytes);

                                udpClient.Close();

                            }
                            catch (Exception)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "BitmapX" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapX")
                {
                    int scrolldirection = Convert.ToInt16(dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "0").Replace("RIGHT | ", "1").Replace("UP", "0").Replace("DOWN", "1"));
                    if (scrolldirection == 0)
                    {
                        for (int xmove = X_MAX; xmove >= -Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); xmove--)
                        {
                            if (xmove >= 0)
                            {
                                startcolumn = 0;
                            }
                            else
                            {
                                startcolumn = -xmove;
                            }
                            if ((-xmove + X_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value))
                            {
                                endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value);
                            }
                            else
                            {
                                endcolumn = -xmove + X_MAX + 1;
                            }
                            if (Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) >= 0)
                            {
                                startline = 0;
                            }
                            else
                            {
                                startline = -Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value);
                            }
                            if ((startline + Y_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value))
                            {
                                endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - startline;
                            }
                            else
                            {
                                endline = Y_MAX + 1;
                            }
                            if (endcolumn > Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value)) { endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); }
                            if (startline >= (Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - 1)) { return; }
                            String wholecolorstring = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(':');
                            for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                            {
                                int actualx = countarraylist + xmove;
                                int actualy = Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) + startline;
                                if (TestSerialPort.Checked)
                                {
                                    serialPort1.Write("dr,");
                                    serialPort1.Write(actualx.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(actualy.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                                    serialPort1.Write(",");
                                    if (countarraylist == endcolumn - 1)
                                    {
                                        serialPort1.Write("1,");
                                    }
                                    else
                                    {
                                        serialPort1.Write("0,");
                                    }
                                    serialPort1.Write("0,");
                                    serialPort1.Write(PMode + ",");
                                    serialPort1.Write("0,");
                                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapX")
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n");
                                    }
                                    else
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                                    }
                                    serialPort1.ReadChar();
                                }
                                else if (TestUDP.Checked)
                                {
                                    UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                                    try
                                    {
                                        udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                                        // Sends a message to the host to which you have connected.
                                        string FunctionString = ""; Byte[] sendBytes;
                                        FunctionString += "dr,";
                                        FunctionString += actualx.ToString();
                                        FunctionString += ",";
                                        FunctionString += actualy.ToString();
                                        FunctionString += ",";
                                        FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                                        FunctionString += ",";
                                        if (countarraylist == endcolumn - 1)
                                        {
                                            FunctionString += "1,";
                                        }
                                        else
                                        {
                                            FunctionString += "0,";
                                        }
                                        FunctionString += "0,";
                                        FunctionString += PMode + ",";
                                        FunctionString += "0,";
                                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n";
                                        }
                                        else
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n";
                                        }

                                        sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                                        udpClient.Send(sendBytes, sendBytes.Length);

                                        //IPEndPoint object will allow us to read datagrams sent from any source.
                                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                                        // Blocks until a message returns on this socket from a remote host.
                                        Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                                        string returnData = Encoding.ASCII.GetString(receiveBytes);

                                        udpClient.Close();

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        for (int xmove = -Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); xmove <= X_MAX; xmove++)
                        {
                            startcolumn = 0;
                            if ((X_MAX - Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value) + 1) <= xmove)
                            {
                                endcolumn = X_MAX - xmove;
                            }
                            else
                            {
                                endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value);
                            }
                            if (Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) >= 0)
                            {
                                startline = 0;
                            }
                            else
                            {
                                startline = -Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value);
                            }
                            if ((startline + Y_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value))
                            {
                                endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - startline;
                            }
                            else
                            {
                                endline = Y_MAX + 1;
                            }
                            if (endcolumn > Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value)) { endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); }
                            if (startline >= (Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - 1)) { return; }
                            String wholecolorstring = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(':');
                            for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                            {
                                int actualx = countarraylist + xmove;
                                int actualy = Convert.ToInt16(dataGridView1.Rows[x].Cells[YCoordIndex].Value) + startline;
                                if (TestSerialPort.Checked)
                                {
                                    serialPort1.Write("dr,");
                                    serialPort1.Write(actualx.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(actualy.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                                    serialPort1.Write(",");
                                    if (countarraylist == endcolumn - 1)
                                    {
                                        serialPort1.Write("1,");
                                    }
                                    else
                                    {
                                        serialPort1.Write("0,");
                                    }
                                    serialPort1.Write("0,");
                                    serialPort1.Write(PMode + ",");
                                    serialPort1.Write("0,");
                                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapX")
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n");
                                    }
                                    else
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                                    }
                                    serialPort1.ReadChar();
                                }
                                else if (TestUDP.Checked)
                                {
                                    UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                                    try
                                    {
                                        udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                                        // Sends a message to the host to which you have connected.
                                        string FunctionString = ""; Byte[] sendBytes;
                                        FunctionString += "dr,";
                                        FunctionString += actualx.ToString();
                                        FunctionString += ",";
                                        FunctionString += actualy.ToString();
                                        FunctionString += ",";
                                        FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                                        FunctionString += ",";
                                        if (countarraylist == endcolumn - 1)
                                        {
                                            FunctionString += "1,";
                                        }
                                        else
                                        {
                                            FunctionString += "0,";
                                        }
                                       FunctionString += "0,";
                                        FunctionString += PMode + ",";
                                        FunctionString += "0,";
                                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n";
                                        }
                                        else
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n";
                                        }

                                        sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                                        udpClient.Send(sendBytes, sendBytes.Length);

                                        //IPEndPoint object will allow us to read datagrams sent from any source.
                                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                                        // Blocks until a message returns on this socket from a remote host.
                                        Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                                        string returnData = Encoding.ASCII.GetString(receiveBytes);

                                        udpClient.Close();

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }

                                }
                            }
                        }
                    }
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "BitmapY" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapY")
                {
                    int scrolldirection = Convert.ToInt16(dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "0").Replace("RIGHT | ", "1").Replace("UP", "0").Replace("DOWN", "1"));
                    if (scrolldirection == 0)
                    {                      
                        for (int ymove = Y_MAX; ymove >= -Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value); ymove--)
                        {
                            if (Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) >= 0)
                            {
                                startcolumn = 0;
                            }
                            else
                            {
                                startcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                            }
                            if ((-Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value))
                            {
                                endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value);
                            }
                            else
                            {
                                endcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1;
                            }
                            if (ymove >= 0)
                            {
                                startline = 0;
                            }
                            else
                            {
                                startline = -ymove;
                            }
                            if ((-ymove + Y_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value))
                            {
                                endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - startline;
                            }
                            else
                            {
                                endline = Y_MAX + 1;
                            }
                            if (endcolumn > Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value)) { endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); }
                            if (endline >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value)) { endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value); }
                            String wholecolorstring = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(':');
                           
                            for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                            {
                                int actualx = countarraylist + Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                                int actualy = ymove + startline;
                                if (TestSerialPort.Checked)
                                {
                                    serialPort1.Write("dr,");
                                    serialPort1.Write(actualx.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(actualy.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                                    serialPort1.Write(",");
                                    if (countarraylist == endcolumn - 1)
                                    {
                                        serialPort1.Write("1,");
                                    }
                                    else
                                    {
                                        serialPort1.Write("0,");
                                    }
                                    serialPort1.Write("0,");
                                    serialPort1.Write(PMode + ",");
                                    serialPort1.Write("0,");
                                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapY")
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n");
                                    }
                                    else
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                                    }
                                    serialPort1.ReadChar();
                                }
                                else if (TestUDP.Checked)
                                {
                                    UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                                    try
                                    {
                                        udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                                        // Sends a message to the host to which you have connected.
                                        string FunctionString = ""; Byte[] sendBytes;
                                        FunctionString += "dr,";
                                        FunctionString += actualx.ToString();
                                        FunctionString += ",";
                                        FunctionString += actualy.ToString();
                                        FunctionString += ",";
                                        FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                                        FunctionString += ",";
                                        if (countarraylist == endcolumn - 1)
                                        {
                                            FunctionString += "1,";
                                        }
                                        else
                                        {
                                            FunctionString += "0,";
                                        }
                                        FunctionString += "0,";

                                        FunctionString += PMode + ",";
                                        FunctionString += "0,";
                                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n";
                                        }
                                        else
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n";
                                        }

                                        sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                                        udpClient.Send(sendBytes, sendBytes.Length);

                                        //IPEndPoint object will allow us to read datagrams sent from any source.
                                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                                        // Blocks until a message returns on this socket from a remote host.
                                        Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                                        string returnData = Encoding.ASCII.GetString(receiveBytes);

                                        udpClient.Close();

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                            
                        }
                       
                        
                    }
                    else
                    {
                        for (int ymove = -Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value); ymove <= Y_MAX; ymove++)
                        {
                            if (Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) >= 0)
                            {
                                startcolumn = 0;
                            }
                            else
                            {
                                startcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                            }
                            if ((-Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value))
                            {
                                endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value);
                            }
                            else
                            {
                                endcolumn = -Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value) + X_MAX + 1;
                            }
                            if (ymove >= 0)
                            {
                                startline = 0;
                            }
                            else
                            {
                                startline = -ymove;
                            }
                            if ((-ymove + Y_MAX + 1) >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value))
                            {
                                endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value) - startline;
                            }
                            else
                            {
                                endline = Y_MAX + 1;
                            }
                            if (endcolumn > Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value)) { endcolumn = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitWidthIndex].Value); }
                            if (endline >= Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value)) { endline = Convert.ToInt16(dataGridView1.Rows[x].Cells[BitHeightIndex].Value); }
                            String wholecolorstring = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString();
                            String[] allcolorstring = wholecolorstring.ToString().Split(':');
                            for (int countarraylist = 0; countarraylist < endcolumn; countarraylist++)
                            {
                                int actualx = countarraylist + Convert.ToInt16(dataGridView1.Rows[x].Cells[XCoordIndex].Value);
                                int actualy = ymove + startline;
                                if (TestSerialPort.Checked)
                                {
                                    serialPort1.Write("dr,");
                                    serialPort1.Write(actualx.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(actualy.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                                    serialPort1.Write(",");
                                    serialPort1.Write(SFrame + ",");
                                    serialPort1.Write("0,");
                                    serialPort1.Write(PMode + ",");
                                    serialPort1.Write("0,");
                                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapY")
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n");
                                    }
                                    else
                                    {
                                        serialPort1.Write(allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n");
                                    }
                                    serialPort1.ReadChar();
                                }
                                else if (TestUDP.Checked)
                                {
                                    UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                                    try
                                    {
                                        udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                                        // Sends a message to the host to which you have connected.
                                        string FunctionString = ""; Byte[] sendBytes;
                                        FunctionString += "dr,";
                                        FunctionString += actualx.ToString();
                                        FunctionString += ",";
                                        FunctionString += actualy.ToString();
                                        FunctionString += ",";
                                        FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                                        FunctionString += ",";
                                        if (countarraylist == endcolumn - 1)
                                        {
                                            FunctionString += "1,";
                                        }
                                        else
                                        {
                                            FunctionString += "0,";
                                        }
                                        FunctionString += "0,";

                                        FunctionString += PMode + ",";
                                        FunctionString += "0,";
                                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("0", rowbackcolor.ToString().Replace("4", randomcolor.ToString())).Replace("1", rowfrontcolor.ToString().Replace("4", randomcolor.ToString())) + "\n";
                                        }
                                        else
                                        {
                                            FunctionString += allcolorstring[countarraylist].Substring(startline, endline).Replace("4", randomcolor.ToString()) + "\n";
                                        }

                                        sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                                        udpClient.Send(sendBytes, sendBytes.Length);

                                        //IPEndPoint object will allow us to read datagrams sent from any source.
                                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                                        // Blocks until a message returns on this socket from a remote host.
                                        Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                                        string returnData = Encoding.ASCII.GetString(receiveBytes);

                                        udpClient.Close();

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }


                            }
                        }
                    }
                }



                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Clear")
                {
                    if (TestSerialPort.Checked)
                    {
                        serialPort1.WriteLine("cl,0,0,0,0,0,0,0\n");
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = "cl,0,0,0,0,0,0,0\n"; Byte[] sendBytes;
                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    System.Threading.Thread.Sleep(100);
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Delay")
                {
                    System.Threading.Thread.Sleep(Convert.ToInt16(dataGridView1.Rows[x].Cells[TimDelayIndex].Value));
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "SendFrame")
                {
                    if (TestSerialPort.Checked)
                    {
                        serialPort1.WriteLine("sf,0,0,0,0,0,0,0\n");
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = "sf,0,0,0,0,0,0,0\n"; Byte[] sendBytes;
                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    System.Threading.Thread.Sleep(100);
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Fill")
                {
                    if (TestSerialPort.Checked)
                    {
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot")
                        {
                            serialPort1.Write("pl,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line")
                        {
                            serialPort1.Write("li,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle")
                        {
                            serialPort1.Write("re,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse")
                        {
                            serialPort1.Write("el,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle")
                        {
                            serialPort1.Write("ci,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier")
                        {
                            serialPort1.Write("be,");
                        }
                        serialPort1.Write(dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(SFrame + ",");
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse")
                        {
                            serialPort1.Write(dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(dataGridView1.Rows[x].Cells[BitHeightIndex].Value.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(rowfrontcolor.ToString());
                            serialPort1.WriteLine(",0\n");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle")
                        {
                            serialPort1.Write(dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(rowfrontcolor.ToString());
                            serialPort1.Write(",0");
                            serialPort1.WriteLine(",0\n");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier")
                        {
                            serialPort1.Write(dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(dataGridView1.Rows[x].Cells[BitHeightIndex].Value.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write(rowfrontcolor.ToString());
                            serialPort1.WriteLine("," + dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString() + "\n");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Fill" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot")
                        {
                            serialPort1.Write(rowfrontcolor.ToString());
                            serialPort1.Write(",");
                            serialPort1.Write("0,0");
                            serialPort1.WriteLine(",0\n");
                        }
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = ""; Byte[] sendBytes;
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot")
                            {
                                FunctionString += "pl,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line")
                            {
                                FunctionString += "li,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle")
                            {
                                FunctionString += "re,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse")
                            {
                                FunctionString += "el,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle")
                            {
                                FunctionString += "ci,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier")
                            {
                                FunctionString += "be,";
                            }
                            FunctionString += dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += SFrame + ",";
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse")
                            {
                                FunctionString += dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString();
                                FunctionString += ",";
                                FunctionString += dataGridView1.Rows[x].Cells[BitHeightIndex].Value.ToString();
                                FunctionString += ",";
                                FunctionString += rowfrontcolor.ToString();
                                FunctionString += ",0;";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle")
                            {
                                FunctionString += dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString();
                                FunctionString += ",";
                                FunctionString += rowfrontcolor.ToString();
                                FunctionString += ",0";
                                FunctionString += ",0;";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier")
                            {
                                FunctionString += dataGridView1.Rows[x].Cells[BitWidthIndex].Value.ToString();
                                FunctionString += ",";
                                FunctionString += dataGridView1.Rows[x].Cells[BitHeightIndex].Value.ToString();
                                FunctionString += ",";
                                FunctionString += rowfrontcolor.ToString();
                                FunctionString += "," + dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString() + "\n";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Fill" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot")
                            {
                                FunctionString += rowfrontcolor.ToString();
                                FunctionString += ",";
                                FunctionString += "0,0";
                                FunctionString += ",0;";
                            }

                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    System.Threading.Thread.Sleep(100);

                }

                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextX" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextY")
                {
                    if (TestSerialPort.Checked)
                    {
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextX")
                        {
                            serialPort1.Write("tx,");
                        }
                        else { serialPort1.Write("ty,"); }
                        serialPort1.Write(dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(SFrame + ",");                        
                        serialPort1.Write(rowfrontcolor.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(rowbackcolor.ToString());
                        serialPort1.Write(",0,");
                        serialPort1.WriteLine(dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\n");
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = ""; Byte[] sendBytes;
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextX")
                            {
                                FunctionString += "tx,";
                            }
                            else { FunctionString += "ty,"; }
                            FunctionString += dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += SFrame + ",";
                            FunctionString += rowfrontcolor.ToString();
                            FunctionString += ",";
                            FunctionString += rowbackcolor.ToString();
                            FunctionString += ",0,";
                            FunctionString += dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\n";
                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    System.Threading.Thread.Sleep(100);
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollX" || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollY")
                {
                    if (TestSerialPort.Checked)
                    {
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollX")
                        { serialPort1.Write("sx,"); }
                        else { serialPort1.Write("sy,"); }
                        serialPort1.Write(dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(SFrame + ",");
                        /*if (TextBehaviourBlink.Checked)
                        { rowfrontcolor = rowfrontcolor + 16; }*/
                        serialPort1.Write(rowfrontcolor.ToString());
                        serialPort1.Write("," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "0").Replace("RIGHT | ", "1").Replace("UP", "0").Replace("DOWN", "1") + ",");                        
                        serialPort1.Write(rowbackcolor.ToString());
                        serialPort1.Write(",");
                        serialPort1.WriteLine(dataGridView1.Rows[x].Cells[TxDataIndex].Value.ToString() + "\n");
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = ""; Byte[] sendBytes;
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollX")
                            { FunctionString += "sx,"; }
                            else { FunctionString += "sy,"; }
                            FunctionString += dataGridView1.Rows[x].Cells[XCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[YCoordIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += SFrame + ",";
                            FunctionString += rowfrontcolor.ToString();
                            FunctionString += "," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "0").Replace("RIGHT | ", "1").Replace("UP", "0").Replace("DOWN", "1") + ",";                           
                            FunctionString += rowbackcolor.ToString();
                            FunctionString += ",";
                            FunctionString += dataGridView1.Rows[x].Cells[TxDataIndex].Value.ToString() + "\n";
                            MessageBox.Show(FunctionString);
                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                    System.Threading.Thread.Sleep(dataGridView1.Rows[x].Cells[TxDataIndex].Value.ToString().Length * 500);
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("ClearFull") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("ClearHalf"))
                {
                    if (TestSerialPort.Checked)
                    {

                        serialPort1.Write("cs,");
                        serialPort1.Write("0,0,");
                        serialPort1.Write(dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString());
                        serialPort1.Write(",");
                        serialPort1.Write(SFrame + ",");
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Full"))
                        {
                            serialPort1.Write("0,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Half"))
                        {
                            serialPort1.Write("1,");
                        }
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Vertical") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Left") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Right"))
                        {
                            serialPort1.Write("0,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Horizontal") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Up") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Down"))
                        {
                            serialPort1.Write("1,");
                        }
                        if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Left") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Up") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Outwards"))
                        {
                            serialPort1.Write("0,");
                        }
                        else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Right") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Down") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Inside"))
                        {
                            serialPort1.Write("1,");
                        }
                        serialPort1.WriteLine(rowfrontcolor.ToString() + "\n");
                    }
                    else if (TestUDP.Checked)
                    {
                        UdpClient udpClient = new UdpClient(Convert.ToInt16(TestUDPPort.Text));
                        try
                        {
                            udpClient.Connect(TestUDPIPAddress.Text, Convert.ToInt16(TestUDPPort.Text));
                            string FunctionString = ""; Byte[] sendBytes;
                            FunctionString += "cs,";
                            FunctionString += "0,0,";
                            FunctionString += dataGridView1.Rows[x].Cells[TimDelayIndex].Value.ToString();
                            FunctionString += ",";
                            FunctionString += SFrame + ",";
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Full"))
                            {
                                FunctionString += "0,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Half"))
                            {
                                FunctionString += "1,";
                            }
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Vertical") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Left") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Right"))
                            {
                                FunctionString += "0,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().Contains("Horizontal") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Up") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Down"))
                            {
                                FunctionString += "1,";
                            }
                            if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Left") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Up") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Outwards"))
                            {
                                FunctionString += "0,";
                            }
                            else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Right") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Down") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Inside"))
                            {
                                FunctionString += "1,";
                            }
                            FunctionString += rowfrontcolor.ToString() + "\n";



                            sendBytes = Encoding.ASCII.GetBytes(FunctionString);
                            udpClient.Send(sendBytes, sendBytes.Length);
                            udpClient.Close();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        private void AddBitmapToScript_Click(object sender, EventArgs e)
        {
            string Lastbitmapname = "";
            if (BitmapColor0.SelectedIndex == -1 && BitmapColor1.SelectedIndex == -1 && BitmapColor2.SelectedIndex == -1 && BitmapColor3.SelectedIndex == -1 && BitmapColor4.SelectedIndex == -1 && BitmapColor5.SelectedIndex == -1 && BitmapColor6.SelectedIndex == -1 && BitmapColor7.SelectedIndex == -1 && BitmapColor8.SelectedIndex == -1 && BitmapColor9.SelectedIndex == -1 && BitmapColor10.SelectedIndex == -1 && BitmapColor11.SelectedIndex == -1 && BitmapColor12.SelectedIndex == -1 && BitmapColor13.SelectedIndex == -1 && BitmapColor14.SelectedIndex == -1 && BitmapColor15.SelectedIndex == -1)
            {
                MessageBox.Show("Please match the bitmap colors to the colors you want to display on the matrix");
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputBitmapX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputBitmapX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputBitmapY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputBitmapY.Text = "";
                return;
            }
            BitData = "";
            if (BitmapShow.Checked)
            {
                ShowType = "Bitmap";
            }
            else if (BitmapScrollX.Checked)
            {
                ShowType = "BitmapX";
            }
            else if (BitmapScrollY.Checked)
            {
                ShowType = "BitmapY";
            }
            TxData = "";
            TimDelay = InputBitmapDelay.Text;
            if (BitmapSendFrame.SelectedIndex == 0)
            {
                SFrame = "Draw Each Column/Char";
            }
            else if (BitmapSendFrame.SelectedIndex == 1)
            {
                SFrame = "Send Frame after Bitmap/Text";
            }
            else if (BitmapSendFrame.SelectedIndex == 2)
            {
                SFrame = "Don't Send Frame";
            }
            SDirection = (string)this.BitmapScrollDirection.SelectedItem;
            XCoord = InputBitmapX.Text;
            YCoord = InputBitmapY.Text;
            BitWidth = bitmapxarray[0].ToString();
            BitHeight = bitmapyarray[0].ToString();
            if (BitmapTransparent.Checked)
            {
                BTransparency = "Transparent";
            }
            else
            {
                BTransparency = "BLACK";
            }
            if (BitmapPictureErase.Checked)
            {
                PMode = "Picture Erase";
            }
            else
            {
                PMode = "Normal";
            }
            FColor = "BLACK";
            BColor = "BLACK";
            for (int countarraylist = 0; countarraylist < bitmapcolorarray.Count; countarraylist++)
            {

                int actualx = countarraylist + Convert.ToInt16(InputBitmapX.Text);
                int actualy = Convert.ToInt16(InputBitmapY.Text);
                String colorstring = "";
                String wholecolorstring = bitmapcolorarray[countarraylist].ToString();
                String[] allcolorstring = wholecolorstring.ToString().Split(';');

                foreach (string s in allcolorstring)
                {

                    if (s == bitmapusedallcolorarray[0].ToString() && BitmapColor0.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor0.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[1].ToString() && BitmapColor1.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor1.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[2].ToString() && BitmapColor2.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor2.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[3].ToString() && BitmapColor3.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor3.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[4].ToString() && BitmapColor4.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor4.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[5].ToString() && BitmapColor5.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor5.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[6].ToString() && BitmapColor6.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor6.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[7].ToString() && BitmapColor7.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor7.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[8].ToString() && BitmapColor8.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor8.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[9].ToString() && BitmapColor9.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor9.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[10].ToString() && BitmapColor10.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor10.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[11].ToString() && BitmapColor11.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor11.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[12].ToString() && BitmapColor12.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor12.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[13].ToString() && BitmapColor13.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor13.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[14].ToString() && BitmapColor14.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor14.SelectedIndex.ToString();
                    }
                    else if (s == bitmapusedallcolorarray[15].ToString() && BitmapColor15.SelectedIndex != -1)
                    {
                        colorstring = colorstring + BitmapColor15.SelectedIndex.ToString();
                    }
                    else
                    {
                        colorstring = colorstring + "0";
                    }
                }
                BitData = BitData + colorstring + ":";
            }
            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("Bitmap") && dataGridView1.Rows[x].Cells[BitNameIndex].Value.ToString().StartsWith(bitmapnamearray[0].ToString().Replace(" ", "")) && dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString() != BitData)
                {
                    Lastbitmapname = dataGridView1.Rows[x].Cells[BitNameIndex].Value.ToString();
                }
            }
            if (Lastbitmapname != "")
            {
                BitName = Lastbitmapname + "1";
            }
            else
            {
                BitName = bitmapnamearray[0].ToString().Replace(" ", "");
            }
            STextBehaviour = "Normal";
            string[] row0 = { ShowType, BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddTextBitmapToScript_Click(object sender, EventArgs e)
        {
            try
            {
                int test = Convert.ToInt32(InputTextBitmapX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputTextBitmapX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextBitmapY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputTextBitmapY.Text = "";
                return;
            }
            Bitmap flag = new Bitmap(1500, 50);
            string Lastbitmapname = "";
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.SmoothingMode = SmoothingMode.None;
            // Set maximum layout size.
            SizeF layoutSize = new SizeF(200.0F, 50.0F);
            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = flagGraphics.MeasureString(InputStringTextBitmap.Text, InputStringTextBitmap.Font, layoutSize);
            flagGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            flagGraphics.FillRectangle(new System.Drawing.SolidBrush(InputStringTextBitmap.BackColor), 0, 0, stringSize.Width, stringSize.Height);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;

            flagGraphics.DrawString(InputStringTextBitmap.Text, InputStringTextBitmap.Font, new System.Drawing.SolidBrush(InputStringTextBitmap.ForeColor), 0, 0, strFormat);

            ArrayList fontallarray = new ArrayList();
            String colorstring = "";
            ArrayList ycolor = new ArrayList();
            ArrayList xcolor = new ArrayList();
            int firstxpixel = 0, firstypixel = 0, firstxcontrolpixel = 0, firstycontrolpixel = 0, lastxpixel = 0, lastypixel = 0, lastxcontrolpixel = 0, lastycontrolpixel = 0, actualxpixel = 0, actualypixel = 0;
            bool foundxpixel = false, foundypixel = false, foundlastxpixel = false, foundlastypixel = false;

            int widthtestpixel = 0, heighttestpixel = 0;
            while (foundypixel == false)
            {
                while (widthtestpixel < stringSize.Width && foundypixel == false)
                {
                    while (heighttestpixel < stringSize.Height && foundypixel == false)
                    {

                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundypixel == false)
                        {
                            firstxcontrolpixel = widthtestpixel;
                            firstypixel = heighttestpixel;
                            foundypixel = true;

                        }
                        heighttestpixel++;
                    }
                    widthtestpixel++;
                    heighttestpixel = 0;
                }
                widthtestpixel = 0;
            }
            widthtestpixel = 0;
            heighttestpixel = 0;
            while (foundxpixel == false)
            {
                while (heighttestpixel < stringSize.Height && foundxpixel == false)
                {
                    while (widthtestpixel < stringSize.Width && foundxpixel == false)
                    {

                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundxpixel == false)
                        {
                            firstxpixel = widthtestpixel;
                            firstycontrolpixel = heighttestpixel;
                            foundxpixel = true;

                        }
                        widthtestpixel++;
                    }
                    heighttestpixel++;
                    widthtestpixel = 0;
                }
                heighttestpixel = 0;
            }
            widthtestpixel = (int)stringSize.Width;
            heighttestpixel = (int)stringSize.Height;
            while (foundlastypixel == false)
            {
                while (widthtestpixel > 0 && foundlastypixel == false)
                {
                    while (heighttestpixel > 0 && foundlastypixel == false)
                    {

                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundlastypixel == false)
                        {
                            lastxcontrolpixel = widthtestpixel;
                            lastypixel = heighttestpixel;
                            foundlastypixel = true;

                        }
                        heighttestpixel--;
                    }
                    widthtestpixel--;
                    heighttestpixel = (int)stringSize.Height;
                }
                widthtestpixel = (int)stringSize.Width;
            }
            widthtestpixel = (int)stringSize.Width;
            heighttestpixel = (int)stringSize.Height;
            while (foundlastxpixel == false)
            {
                while (heighttestpixel > 0 && foundlastxpixel == false)
                {
                    while (widthtestpixel > 0 && foundlastxpixel == false)
                    {

                        if (flag.GetPixel(widthtestpixel, heighttestpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()) && foundlastxpixel == false)
                        {
                            lastxpixel = widthtestpixel;
                            lastycontrolpixel = heighttestpixel;
                            foundlastxpixel = true;

                        }
                        widthtestpixel--;
                    }
                    heighttestpixel--;
                    widthtestpixel = (int)stringSize.Width;
                }
                heighttestpixel = (int)stringSize.Height;
            }
            if (firstxcontrolpixel != firstxpixel && firstycontrolpixel != firstypixel)
            {
                firstxpixel = firstxcontrolpixel;
                firstypixel = firstycontrolpixel;
            }
            if (lastxcontrolpixel != lastxpixel && lastycontrolpixel != lastypixel)
            {
                lastxpixel = lastxcontrolpixel;
                lastypixel = lastycontrolpixel;
            }
            lastxpixel = lastxpixel + firstxpixel;
            lastypixel = lastypixel + firstypixel;
            Random rnd = new Random();

            for (int widthpixel = firstxpixel; widthpixel < lastxpixel; widthpixel++)
            {
                for (int heightpixel = firstypixel; heightpixel < lastypixel; heightpixel++)
                {
                    if (flag.GetPixel(widthpixel, heightpixel) == Color.FromArgb(InputStringTextBitmap.ForeColor.ToArgb()))
                    {
                        actualxpixel = widthpixel - firstxpixel;
                        actualypixel = heightpixel - firstypixel;
                        colorstring = colorstring + "1";
                    }
                    else
                    {
                        actualxpixel = widthpixel - firstxpixel;
                        actualypixel = heightpixel - firstypixel;
                        colorstring = colorstring + "0";
                    }
                }

                colorstring = colorstring + ":";
            }
            BitData = "";
            if (TextBitmapShow.Checked)
            {
                ShowType = "TextBitmap";
            }
            else if (TextBitmapScrollX.Checked)
            {
                ShowType = "TextBitmapX";
            }
            else if (TextBitmapScrollY.Checked)
            {
                ShowType = "TextBitmapY";
            }
            TxData = InputStringTextBitmap.Text;
            TimDelay = InputTextBitmapDelay.Text;
            if (TextBitmapSendFrame.SelectedIndex == 0)
            {
                SFrame = "Draw Each Column/Char";
            }
            else if (TextBitmapSendFrame.SelectedIndex == 1)
            {
                SFrame = "Send Frame after Bitmap/Text";
            }
            else if (TextBitmapSendFrame.SelectedIndex == 2)
            {
                SFrame = "Don't Send Frame";
            }
            SDirection = (string)this.TextBitmapScrollDirection.SelectedItem;
            XCoord = InputTextBitmapX.Text;
            YCoord = InputTextBitmapY.Text;
            int textWidth = (lastxpixel - firstxpixel);
            BitWidth = textWidth.ToString();
            int textheight = (lastypixel - firstypixel);
            BitHeight = textheight.ToString();
            string fsize = InputStringTextBitmap.Font.SizeInPoints.ToString();
            string[] erg = fsize.Split(',');
            string ActualBitName = InputStringTextBitmap.Font.Name.Replace(" ", "") + erg[0];
            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("TextBitmap") && dataGridView1.Rows[x].Cells[BitNameIndex].Value.ToString().StartsWith(ActualBitName) && dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString() != colorstring)
                {
                    Lastbitmapname = dataGridView1.Rows[x].Cells[BitNameIndex].Value.ToString();
                }
            }
            if (Lastbitmapname != "")
            {
                BitName = Lastbitmapname + "1";
            }
            else
            {
                BitName = ActualBitName;
            }
            BitData = colorstring;
            if (TextBitmapTransparent.Checked)
            {
                BTransparency = "Transparent";
            }
            else
            {
                BTransparency = "BLACK";
            }
            if (TextBitmapPictureErase.Checked)
            {
                PMode = "Picture Erase";
            }
            else
            {
                PMode = "Normal";
            }
            FColor = (string)this.TextBitmapFrontColor.SelectedItem;
            BColor = (string)this.TextBitmapBackgroundColor.SelectedItem;
            STextBehaviour = "Normal";
            string[] row0 = { ShowType, BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddTextToScript_Click(object sender, EventArgs e)
        {
            try
            {
                int test = Convert.ToInt32(InputTextX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputTextX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputTextY.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputTextDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputTextDelay.Text = "";
                return;
            }
            BitData = "";
            if (TextShow.Checked)
            {
                ShowType = "TextX";
            }
            else if (TextShowY.Checked)
            {
                ShowType = "TextY";
            }
            else if (TextScrollX.Checked)
            {
                ShowType = "TextScrollX";
            }
            else if (TextScrollY.Checked)
            {
                ShowType = "TextScrollY";
            }
            TxData = InputStringText.Text;
            TimDelay = InputTextDelay.Text;
            if (TextSendFrame.SelectedIndex == 0)
            {
                SFrame = "Draw Each Column/Char";
            }
            else if (TextSendFrame.SelectedIndex == 1)
            {
                SFrame = "Send Frame after Bitmap/Text";
            }
            else if (TextSendFrame.SelectedIndex == 2)
            {
                SFrame = "Don't Send Frame";
            }
            SDirection = (string)this.TextScrollDirection.SelectedItem;
            XCoord = InputTextX.Text;
            YCoord = InputTextY.Text;
            BitName = ""; BitWidth = "0"; BitHeight = "0"; BitData = ""; BTransparency = "BLACK"; PMode = "Normal";
            FColor = (string)this.TextFrontColor.SelectedItem;
            BColor = (string)this.TextBackgroundColor.SelectedItem;
            if (TextBehaviourBlink.Checked)
            {
                STextBehaviour = "BLINK";
            }
            else
            {
                STextBehaviour = "Normal";
            }
            string[] row0 = { ShowType, BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddSendFrameToScript_Click(object sender, EventArgs e)
        {
            BitName = ""; TxData = ""; TimDelay = "0"; SFrame = "Send Frame after Bitmap/Text"; SDirection = "LEFT | UP"; XCoord = "0"; YCoord = "0"; BitWidth = "0"; BitHeight = "0"; BitData = ""; BTransparency = "Transparent"; PMode = "Normal"; FColor = "BLACK"; BColor = "BLACK"; STextBehaviour = "Normal";
            string[] row0 = { "SendFrame", BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddSpecialClearEffectsToScript_Click(object sender, EventArgs e)
        {
            try
            {
                int test = Convert.ToInt32(InputClearSpecialDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputClearSpecialDelay.Text = "";
                return;
            }
            if (ClearFullMatrix.Checked)
            {
                if (FullMatrixLeft.Checked)
                {
                    ShowType = "ClearFullLeft";
                }
                else if (FullMatrixTop.Checked)
                {
                    ShowType = "ClearFullDown";
                }
                else if (FullMatrixUp.Checked)
                {
                    ShowType = "ClearFullUp";
                }
                else if (FullMatrixRight.Checked)
                {
                    ShowType = "ClearFullRight";
                }
            }
            else if (ClearHalfMatrix.Checked)
            {
                if (HalfVertical.Checked)
                {
                    ShowType = "ClearHalfVertical";
                }
                else if (HalfHorizontal.Checked)
                {
                    ShowType = "ClearHalfHorizontal";
                }
                if (HalfMatrixCenter.Checked)
                {
                    ShowType = ShowType + "Outwards";
                }
                else if (HalfMatrixOutside.Checked)
                {
                    ShowType = ShowType + "Inside";
                }
            }
            if (ClearSpecialSendFrame.SelectedIndex == 0)
            {
                SFrame = "Draw Each Column/Char";
            }
            else if (ClearSpecialSendFrame.SelectedIndex == 1)
            {
                SFrame = "Send Frame after Bitmap/Text";
            }
            else if (ClearSpecialSendFrame.SelectedIndex == 2)
            {
                SFrame = "Don't Send Frame";
            }
            TimDelay = InputClearSpecialDelay.Text;
            FColor = (string)this.ClearFillColor.SelectedItem;
            BitName = ""; TxData = ""; SDirection = "LEFT | UP"; XCoord = "0"; YCoord = "0"; BitWidth = "0"; BitHeight = "0"; BitData = ""; BTransparency = "Transparent"; PMode = "Normal"; BColor = "BLACK"; STextBehaviour = "Normal";
            string[] row0 = { ShowType, BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddDrawingsToScript_Click(object sender, EventArgs e)
        {
            try
            {
                int test = Convert.ToInt32(InputDrawX.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input X");
                InputDrawX.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputDrawY.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Input Y");
                InputDrawY.Text = "";
                return;
            }
            try
            {
                int test = Convert.ToInt32(InputDrawDelay.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers at Delay");
                InputDrawDelay.Text = "";
                return;
            }
            if (DrawLine.Checked || DrawRectangle.Checked || DrawEllipse.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawSecondX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawSecondX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawSecondY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawSecondY.Text = "";
                    return;
                }
            }
            if (DrawCircle.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawCircleRadius.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawCircleRadius.Text = "";
                    return;
                }
            }
            if (DrawBezier.Checked)
            {
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierSecondX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawBezierSecondX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierSecondY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawBezierSecondY.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierThirdX.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second X");
                    InputDrawBezierThirdX.Text = "";
                    return;
                }
                try
                {
                    int test = Convert.ToInt32(InputDrawBezierThirdY.Text);
                }
                catch
                {
                    MessageBox.Show("Please insert only numbers at Input Second Y");
                    InputDrawBezierThirdY.Text = "";
                    return;
                }
            }
            if (DrawPlot.Checked)
            {
                ShowType = "Plot";
            }
            else if (DrawLine.Checked)
            {
                ShowType = "Line";
            }
            else if (DrawRectangle.Checked)
            {
                ShowType = "Rectangle";
            }
            else if (DrawEllipse.Checked)
            {
                ShowType = "Ellipse";
            }
            else if (DrawCircle.Checked)
            {
                ShowType = "Circle";
            }
            else if (DrawBezier.Checked)
            {
                ShowType = "Bezier";
            }
            else if (DrawFill.Checked)
            {
                ShowType = "Fill";
            }
            XCoord = InputDrawX.Text;
            YCoord = InputDrawY.Text;
            TimDelay = InputDrawDelay.Text;
            if (DrawSendFrame.SelectedIndex == 1 || DrawSendFrame.SelectedIndex == 0)
            {
                SFrame = "Send Frame after Bitmap/Text";
            }
            else if (DrawSendFrame.SelectedIndex == 2)
            {
                SFrame = "Don't Send Frame";
            }
            if (DrawLine.Checked || DrawRectangle.Checked || DrawEllipse.Checked)
            {
                BitWidth = InputDrawSecondX.Text; BitHeight = InputDrawSecondY.Text; BitData = "";
            }
            else if (DrawCircle.Checked)
            {
                BitWidth = InputDrawCircleRadius.Text; BitHeight = ""; BitData = "";
            }
            else if (DrawBezier.Checked)
            {
                BitWidth = InputDrawBezierSecondX.Text; BitHeight = InputDrawBezierSecondY.Text; BitData = InputDrawBezierThirdX.Text + "-" + InputDrawBezierThirdY.Text;
            }
            else if (DrawFill.Checked || DrawPlot.Checked)
            {
                BitWidth = "0"; BitHeight = "0"; BitData = "";
            }
            FColor = (string)this.DrawColor.SelectedItem;
            BitName = ""; SDirection = "LEFT | UP"; TxData = ""; BTransparency = "Transparent"; PMode = "Normal"; BColor = "BLACK"; STextBehaviour = "Normal";
            string[] row0 = { ShowType, BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }

        private void AddClearToScript_Click(object sender, EventArgs e)
        {
            BitName = ""; TxData = ""; TimDelay = "0"; SFrame = "Send Frame after Bitmap/Text"; SDirection = "LEFT | UP"; XCoord = "0"; YCoord = "0"; BitWidth = "0"; BitHeight = "0"; BitData = ""; BTransparency = "BLACK"; PMode = "Normal"; FColor = "BLACK"; BColor = "BLACK"; STextBehaviour = "Normal";
            string[] row0 = { "Clear", BitName, TxData, TimDelay, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void AddDelayToScript_Click(object sender, EventArgs e)
        {
            BitName = ""; TxData = ""; SFrame = "Send Frame after Bitmap/Text"; SDirection = "LEFT | UP"; XCoord = "0"; YCoord = "0"; BitWidth = "0"; BitHeight = "0"; BitData = ""; BTransparency = "Transparent"; PMode = "Normal"; FColor = "BLACK"; BColor = "BLACK"; STextBehaviour = "Normal";
            string[] row0 = { "Delay", BitName, TxData, DelayScript.Text, SFrame, SDirection, XCoord, YCoord, BitWidth, BitHeight, BitData, BTransparency, PMode, FColor, BColor, STextBehaviour };
            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
            }
        }
        private void CopySerialArduinoTestFileToClipboard_Click(object sender, EventArgs e)
        {
            int numberdisplays = 1;
            if ((int)NumberOfYMatrix.Value > 1)
            {
                numberdisplays = (int)NumberOfXMatrix.Value + (int)NumberOfYMatrix.Value;
            }
            else
            {
                numberdisplays = (int)NumberOfXMatrix.Value;
            }
            string ArduinoTestFileText = "";
            ArduinoTestFileText += "#include <ht1632c.h>\n";
            ArduinoTestFileText += "ht1632c dotmatrix = ht1632c(&PORTD," + DataText.Text + "," + WR.Text + "," + CLK.Text + "," + CS.Text + ",GEOM_32x16," + numberdisplays.ToString() + ");\n";
            ArduinoTestFileText += "#define Number_of_X_Displays " + NumberOfXMatrix.Value.ToString() + "\n";
            ArduinoTestFileText += "#define Number_of_Y_Displays " + NumberOfYMatrix.Value.ToString() + "\n";
            ArduinoTestFileText += "#define X_MAX (32*Number_of_X_Displays-1)" + "\n";
            ArduinoTestFileText += "#define Y_MAX (16*Number_of_Y_Displays-1)" + "\n";
            ArduinoTestFileText += "int commonlines=" + CommonColumsLines.Text + ";" + "\n";
            ArduinoTestFileText += "int sx,sx2;" + "\n";
            ArduinoTestFileText += "int sy,sy2;" + "\n";
            ArduinoTestFileText += "int scolor,sdelay, ssendmatrix, soption1, soption2, soption3, soption4, soption5;" + "\n";
            ArduinoTestFileText += "String readString, functionString=\"\";" + "\n";
            ArduinoTestFileText += "int columnColor = 0;" + "\n";
            ArduinoTestFileText += "char myString[]=\"\", colorString[128], workitString[3]=\"\";\n\n\n\n";
            ArduinoTestFileText += "void ht1632_writetext(int x, int y,  char *text, int sendmatrix, int delaytime, int dir, int scolor, int sbackcolor)\n";
            ArduinoTestFileText += "{\n";
            ArduinoTestFileText += "  for(int tmp=0; tmp<strlen(text); tmp++)\n";
            ArduinoTestFileText += "  { \n";
            ArduinoTestFileText += "    if (dir==0) {            \n";
            ArduinoTestFileText += "      sx2=x+tmp*6;\n";
            ArduinoTestFileText += "      sy2=y;\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "    else if (dir==1) {            \n";
            ArduinoTestFileText += "      sx2=x;\n";
            ArduinoTestFileText += "      sy2=y+tmp*8;\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "    dotmatrix.putchar(sx2,sy2, text[tmp] , scolor, 0, sbackcolor);\n";
            ArduinoTestFileText += "    if (sendmatrix==0)\n";
            ArduinoTestFileText += "      dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    delay(delaytime); \n";
            ArduinoTestFileText += "  } \n";
            ArduinoTestFileText += "  if (sendmatrix==1)\n";
            ArduinoTestFileText += "    dotmatrix.sendframe();\n";
            ArduinoTestFileText += "}\n\n\n\n";
            ArduinoTestFileText += "void  ht1632_clearfillcolor(int matrixtype, int typeofsplit, int dir, int sendmatrix, int delaytime, int fillcolor)\n";
            ArduinoTestFileText += "{\n";
            ArduinoTestFileText += "  int tmpx,tmpy ;  \n";
            ArduinoTestFileText += "  scolor=fillcolor;\n";
            ArduinoTestFileText += "  if (fillcolor==4) {\n";
            ArduinoTestFileText += "    scolor=random(3)+1;\n";
            ArduinoTestFileText += "  }                 \n";
            ArduinoTestFileText += "  if (typeofsplit==0)\n";
            ArduinoTestFileText += "  {              \n";
            ArduinoTestFileText += "    for((dir) ? tmpx=0: (matrixtype) ?  tmpx=(X_MAX+1)/2:  tmpx =X_MAX ;  (dir) ?  (matrixtype) ?  tmpx<=(X_MAX+1)/2:tmpx<=X_MAX: tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoTestFileText += "    {\n";
            ArduinoTestFileText += "      for((dir) ? tmpy=0: tmpy = Y_MAX; (dir) ?  tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoTestFileText += "      {                 \n";
            ArduinoTestFileText += "        if (fillcolor==8) { \n";
            ArduinoTestFileText += "          scolor=random(3)+1; \n";
            ArduinoTestFileText += "        }               \n";
            ArduinoTestFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        if (matrixtype==1)\n";
            ArduinoTestFileText += "        {\n";
            ArduinoTestFileText += "          dotmatrix.plot(X_MAX-tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        }\n";
            ArduinoTestFileText += "        if (sendmatrix==0)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();  \n";
            ArduinoTestFileText += "        delay(delaytime);          \n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      if (sendmatrix==1)\n";
            ArduinoTestFileText += "        dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "  }\n";
            ArduinoTestFileText += "  else if (typeofsplit==1)\n";
            ArduinoTestFileText += "  {               \n";
            ArduinoTestFileText += "    for((dir) ? tmpy=0: (matrixtype) ? tmpy=(Y_MAX+1)/2: tmpy = Y_MAX; (dir) ?  (matrixtype) ? tmpy<=(Y_MAX+1)/2 : tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoTestFileText += "    {\n";
            ArduinoTestFileText += "      for((dir) ? tmpx=0: tmpx = X_MAX;  (dir) ?  tmpx<=X_MAX : tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoTestFileText += "      {\n";
            ArduinoTestFileText += "        if (fillcolor==8) \n";
            ArduinoTestFileText += "          scolor=random(3)+1;\n";
            ArduinoTestFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        if (matrixtype==1)\n";
            ArduinoTestFileText += "        {\n";
            ArduinoTestFileText += "          dotmatrix.plot(tmpx, Y_MAX-tmpy,scolor);\n";
            ArduinoTestFileText += "        }\n";
            ArduinoTestFileText += "        if (sendmatrix==0)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();  \n";
            ArduinoTestFileText += "        delay(delaytime);          \n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      if (sendmatrix==1)\n";
            ArduinoTestFileText += "        dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "  }\n";
            ArduinoTestFileText += "}\n\n\n\n";
            ArduinoTestFileText += "void setup() {" + "\n";
            ArduinoTestFileText += "  Serial.begin(115200);" + "\n";
            ArduinoTestFileText += "  dotmatrix.clear();" + "\n";
            ArduinoTestFileText += "}" + "\n";
            ArduinoTestFileText += "void loop() {" + "\n";
            ArduinoTestFileText += "  dotmatrix.setfont(FONT_5x7W);" + "\n";
            ArduinoTestFileText += "  while (Serial.available()) {" + "\n";
            ArduinoTestFileText += "    char c = Serial.read();  //gets one byte from serial buffer" + "\n";
            ArduinoTestFileText += "    if (c == '\\n') {" + "\n";
            ArduinoTestFileText += "      if (readString.length() >0) {" + "\n";
            ArduinoTestFileText += "        char myString[readString.length()+1]; //determine size of the array" + "\n";
            ArduinoTestFileText += "        readString.toCharArray(myString, sizeof(myString)); //put readStringinto an array*/" + "\n";
            ArduinoTestFileText += "        /*  List of all functions and the used options" + "\n";
            ArduinoTestFileText += "         The options are not for all function the same, because not all functions use all " + "\n";
            ArduinoTestFileText += "         options and to minimize the string send from the computer to Arduino board." + "\n";
            ArduinoTestFileText += "         function      functionstring  soption1          soption2          soption3" + "\n";
            ArduinoTestFileText += "         draw          dr              transparentblack  pictureerase        /" + "\n";
            ArduinoTestFileText += "         Text          tx/ty           color             backgroundcolor     /   " + "\n";
            ArduinoTestFileText += "         ScrollText    sx/sy           color             direction         backgroundcolor " + "\n";
            ArduinoTestFileText += "         ClearSpecial  cs              partofmatrix      split             direction " + "\n";
            ArduinoTestFileText += "         Plot          pl              color              /                  /" + "\n";
            ArduinoTestFileText += "         Line          li              secondx           secondy           color" + "\n";
            ArduinoTestFileText += "         Rectangle     re              secondx           secondy           color" + "\n";
            ArduinoTestFileText += "         Circle        ci              radius            color              /" + "\n";
            ArduinoTestFileText += "         Ellipse       el              secondx           secondy           color" + "\n";
            ArduinoTestFileText += "         Bezier        be              secondx           secondy           color (thirdx and thirdy are a string with a hyphen between) " + "\n";
            ArduinoTestFileText += "         Fill          fi              color              /                  /" + "\n";
            ArduinoTestFileText += "         */" + "\n";
            ArduinoTestFileText += "        sscanf(myString,\"%2s,%d,%d,%d,%d,%d,%d,%d,%[^\\t\\n]\", &workitString, &sx, &sy,  &sdelay,  &ssendmatrix, &soption1, &soption2, &soption3, &colorString);" + "\n";
            ArduinoTestFileText += "        functionString=workitString;" + "\n";
            ArduinoTestFileText += "        if (functionString==\"dr\") {          " + "\n";
            ArduinoTestFileText += "          columnColor=random(3)+1;          " + "\n";
            ArduinoTestFileText += "          for(int tmp=0; tmp<=strlen(colorString); tmp++)" + "\n";
            ArduinoTestFileText += "          {" + "\n";
            ArduinoTestFileText += "            scolor=  colorString[tmp]-48;" + "\n";
            ArduinoTestFileText += "            sy2=sy+tmp;" + "\n";
            ArduinoTestFileText += "            if (scolor==5) {" + "\n";
            ArduinoTestFileText += "              scolor=columnColor;" + "\n";
            ArduinoTestFileText += "            }" + "\n";
            ArduinoTestFileText += "            else if (scolor==7) {" + "\n";
            ArduinoTestFileText += "              scolor=random(2)+1;" + "\n";
            ArduinoTestFileText += "            } " + "\n";
            ArduinoTestFileText += "            else if (scolor==8) {" + "\n";
            ArduinoTestFileText += "              scolor=random(3)+1;" + "\n";
            ArduinoTestFileText += "            }" + "\n";
            ArduinoTestFileText += "            else if (scolor==9) {" + "\n";
            ArduinoTestFileText += "              scolor=random(2)+2;" + "\n";
            ArduinoTestFileText += "            }" + "\n";
            ArduinoTestFileText += "            if (soption1==1 && scolor==0) {             				" + "\n";
            ArduinoTestFileText += "            } " + "\n";
            ArduinoTestFileText += "            else{" + "\n";
            ArduinoTestFileText += "              if (soption2==1 && scolor!=0) {" + "\n";
            ArduinoTestFileText += "                dotmatrix.plot( sx, sy2,0);						" + "\n";
            ArduinoTestFileText += "              } " + "\n";
            ArduinoTestFileText += "              else {			" + "\n";
            ArduinoTestFileText += "                dotmatrix.plot( sx, sy2,scolor);" + "\n";
            ArduinoTestFileText += "              }" + "\n";
            ArduinoTestFileText += "            }           " + "\n";
            ArduinoTestFileText += "          }" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          Serial.print(\"O\");" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        } " + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"tx\") {" + "\n";
            ArduinoTestFileText += "          ht1632_writetext(sx, sy, colorString, ssendmatrix,sdelay, 0, soption1, soption2);" + "\n";
            ArduinoTestFileText += "          Serial.flush();           " + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"ty\") {" + "\n";
            ArduinoTestFileText += "          ht1632_writetext(sx, sy, colorString, ssendmatrix, sdelay, 1, soption1, soption2);" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"sx\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.hscrolltext(sy, colorString , soption1, sdelay,  1, soption2, 0, soption3);" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        } " + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"sy\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.vscrolltext(sx,colorString , soption1, sdelay, 1, soption2, 0, soption3);" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"cl\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.clear();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"pl\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.plot( sx, sy,soption1);          " + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"li\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.line(sx, sy, soption1, soption2, soption3);" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"re\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.rect(sx, sy, soption1, soption2, soption3);" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"ci\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.circle(sx, sy, soption1, soption2);" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"el\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.ellipse(sx, sy, soption1, soption2, soption3);" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"fi\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.fill(sx, sy, soption1);" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else     if (functionString==\"be\") {" + "\n";
            ArduinoTestFileText += "          sscanf(colorString,\"%d-%d\", &soption4, &soption5);" + "\n";
            ArduinoTestFileText += "          dotmatrix.bezier(sx, sy, soption1, soption2, soption4,soption5, soption3 );" + "\n";
            ArduinoTestFileText += "          if (ssendmatrix==1)" + "\n";
            ArduinoTestFileText += "            dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }        " + "\n";
            ArduinoTestFileText += "        else  if (functionString==\"cs\") {" + "\n";
            ArduinoTestFileText += "          ht1632_clearfillcolor(soption1, soption2, soption3, ssendmatrix, sdelay,int(colorString[0])-48);" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "        else  if (functionString==\"sf\") {" + "\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();" + "\n";
            ArduinoTestFileText += "          Serial.flush();" + "\n";
            ArduinoTestFileText += "          readString=\"\"; //clears variable for new input" + "\n";
            ArduinoTestFileText += "          functionString=\"\";" + "\n";
            ArduinoTestFileText += "          break;" + "\n";
            ArduinoTestFileText += "        }" + "\n";
            ArduinoTestFileText += "      }" + "\n";
            ArduinoTestFileText += "    } " + "\n";
            ArduinoTestFileText += "    else      " + "\n";
            ArduinoTestFileText += "      readString += c; 	" + "\n";
            ArduinoTestFileText += "  }" + "\n";
            ArduinoTestFileText += "}" + "\n";
            Clipboard.SetText(ArduinoTestFileText, TextDataFormat.Text);
        }
        private void CopyUDPArduinoTestFileToClipboard_Click(object sender, EventArgs e)
        {
            int numberdisplays = 1;
            if ((int)NumberOfYMatrix.Value > 1)
            {
                numberdisplays = (int)NumberOfXMatrix.Value + (int)NumberOfYMatrix.Value;
            }
            else
            {
                numberdisplays = (int)NumberOfXMatrix.Value;
            }
            string ArduinoTestFileText = "";
            ArduinoTestFileText += "/*\n";
            ArduinoTestFileText += "  UDPSendReceive.pde:\n";
            ArduinoTestFileText += " This sketch receives UDP message strings, prints them to the serial port\n";
            ArduinoTestFileText += " and sends an \"acknowledge\" string back to the sender\n";
            ArduinoTestFileText += " \n";
            ArduinoTestFileText += " A Processing sketch is included at the end of file that can be used to send \n";
            ArduinoTestFileText += " and received messages for testing with a computer.\n";
            ArduinoTestFileText += " \n";
            ArduinoTestFileText += " created 21 Aug 2010\n";
            ArduinoTestFileText += " by Michael Margolis\n";
            ArduinoTestFileText += " \n";
            ArduinoTestFileText += " This code is in the public domain.\n";
            ArduinoTestFileText += " */\n";
            ArduinoTestFileText += "#include <SPI.h>         // needed for Arduino versions later than 0018\n";
            ArduinoTestFileText += "#include <Ethernet.h>\n";
            ArduinoTestFileText += "#include <EthernetUdp.h>         // UDP library from: bjoern@cs.stanford.edu 12/30/2008\n";
            ArduinoTestFileText += "#include <ht1632c.h>\n";
            ArduinoTestFileText += "#include <ht1632c.h>\n";
            ArduinoTestFileText += "ht1632c dotmatrix = ht1632c(&PORTD," + DataText.Text + "," + WR.Text + "," + CLK.Text + "," + CS.Text + ",GEOM_32x16," + numberdisplays.ToString() + ");\n";
            ArduinoTestFileText += "#define Number_of_X_Displays " + NumberOfXMatrix.Value.ToString() + "\n";
            ArduinoTestFileText += "#define Number_of_Y_Displays " + NumberOfYMatrix.Value.ToString() + "\n";
            ArduinoTestFileText += "#define X_MAX (32*Number_of_X_Displays-1)" + "\n";
            ArduinoTestFileText += "#define Y_MAX (16*Number_of_Y_Displays-1)" + "\n";
            ArduinoTestFileText += "int commonlines=" + CommonColumsLines.Text + ";" + "\n";
            ArduinoTestFileText += "int sx,sx2;\n";
            ArduinoTestFileText += "int sy,sy2;\n";
            ArduinoTestFileText += "int scolor,sdelay, ssendmatrix, soption1, soption2, soption3, soption4, soption5;\n";
            ArduinoTestFileText += "String readString, functionString=\"\";\n";
            ArduinoTestFileText += "int columnColor = 0;\n";
            ArduinoTestFileText += "char myString[]=\"\", colorString[128], workitString[3]=\"\";\n\n\n";
            ArduinoTestFileText += "// Enter a MAC address and IP address for your controller below.\n";
            ArduinoTestFileText += "// The IP address will be dependent on your local network:\n";
            ArduinoTestFileText += "byte mac[] = {  \n";
            ArduinoTestFileText += "  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };\n";
            ArduinoTestFileText += "IPAddress ip(192,168,178,20);\n";
            ArduinoTestFileText += "unsigned int localPort = 8888;      // local port to listen on\n";
            ArduinoTestFileText += "// buffers for receiving and sending data\n";
            ArduinoTestFileText += "char packetBuffer[128]; //buffer to hold incoming packet,\n";
            ArduinoTestFileText += "char  ReplyBuffer[] = \"0\";       // a string to send back\n";
            ArduinoTestFileText += "// An EthernetUDP instance to let us send and receive packets over UDP\n";
            ArduinoTestFileText += "EthernetUDP Udp;\n\n\n";
            ArduinoTestFileText += "void ht1632_writetext(int x, int y,  char *text, int sendmatrix, int delaytime, int dir, int scolor, int sbackcolor)\n";
            ArduinoTestFileText += "{\n";
            ArduinoTestFileText += "  for(int tmp=0; tmp<strlen(text); tmp++)\n";
            ArduinoTestFileText += "  { \n";
            ArduinoTestFileText += "    if (dir==0) {            \n";
            ArduinoTestFileText += "      sx2=x+tmp*6;\n";
            ArduinoTestFileText += "      sy2=y;\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "    else if (dir==1) {            \n";
            ArduinoTestFileText += "      sx2=x;\n";
            ArduinoTestFileText += "      sy2=y+tmp*8;\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "    dotmatrix.putchar(sx2,sy2, text[tmp] , scolor, 0, sbackcolor);\n";
            ArduinoTestFileText += "    if (sendmatrix==0)\n";
            ArduinoTestFileText += "      dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    delay(delaytime); \n";
            ArduinoTestFileText += "  } \n";
            ArduinoTestFileText += "  if (sendmatrix==1)\n";
            ArduinoTestFileText += "    dotmatrix.sendframe();\n";
            ArduinoTestFileText += "}\n\n\n";
            ArduinoTestFileText += "void  ht1632_clearfillcolor(int matrixtype, int typeofsplit, int dir, int sendmatrix, int delaytime, int fillcolor)\n";
            ArduinoTestFileText += "{\n";
            ArduinoTestFileText += "  int tmpx,tmpy ;  \n";
            ArduinoTestFileText += "  scolor=fillcolor;\n";
            ArduinoTestFileText += "  if (fillcolor==4) {\n";
            ArduinoTestFileText += "    scolor=random(3)+1;\n";
            ArduinoTestFileText += "  }                 \n";
            ArduinoTestFileText += "  if (typeofsplit==0)\n";
            ArduinoTestFileText += "  {              \n";
            ArduinoTestFileText += "    for((dir) ? tmpx=0: (matrixtype) ?  tmpx=(X_MAX+1)/2:  tmpx =X_MAX ;  (dir) ?  (matrixtype) ?  tmpx<=(X_MAX+1)/2:tmpx<=X_MAX: tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoTestFileText += "    {\n";
            ArduinoTestFileText += "      for((dir) ? tmpy=0: tmpy = Y_MAX; (dir) ?  tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoTestFileText += "      {                 \n";
            ArduinoTestFileText += "        if (fillcolor==8) { \n";
            ArduinoTestFileText += "          scolor=random(3)+1; \n";
            ArduinoTestFileText += "        }               \n";
            ArduinoTestFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        if (matrixtype==1)\n";
            ArduinoTestFileText += "        {\n";
            ArduinoTestFileText += "          dotmatrix.plot(X_MAX-tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        }\n";
            ArduinoTestFileText += "        if (sendmatrix==0)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();  \n";
            ArduinoTestFileText += "        delay(delaytime);          \n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      if (sendmatrix==1)\n";
            ArduinoTestFileText += "        dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "  }\n";
            ArduinoTestFileText += "  else if (typeofsplit==1)\n";
            ArduinoTestFileText += "  {               \n";
            ArduinoTestFileText += "    for((dir) ? tmpy=0: (matrixtype) ? tmpy=(Y_MAX+1)/2: tmpy = Y_MAX; (dir) ?  (matrixtype) ? tmpy<=(Y_MAX+1)/2 : tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoTestFileText += "    {\n";
            ArduinoTestFileText += "      for((dir) ? tmpx=0: tmpx = X_MAX;  (dir) ?  tmpx<=X_MAX : tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoTestFileText += "      {\n";
            ArduinoTestFileText += "        if (fillcolor==8) \n";
            ArduinoTestFileText += "          scolor=random(3)+1;\n";
            ArduinoTestFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoTestFileText += "        if (matrixtype==1)\n";
            ArduinoTestFileText += "        {\n";
            ArduinoTestFileText += "          dotmatrix.plot(tmpx, Y_MAX-tmpy,scolor);\n";
            ArduinoTestFileText += "        }\n";
            ArduinoTestFileText += "        if (sendmatrix==0)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();  \n";
            ArduinoTestFileText += "        delay(delaytime);          \n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      if (sendmatrix==1)\n";
            ArduinoTestFileText += "        dotmatrix.sendframe();\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "  }\n";
            ArduinoTestFileText += "}\n\n\n";
            ArduinoTestFileText += "void setup() {\n";
            ArduinoTestFileText += "  // start the Ethernet and UDP:\n";
            ArduinoTestFileText += "  Ethernet.begin(mac,ip);\n";
            ArduinoTestFileText += "  Udp.begin(localPort);\n";
            ArduinoTestFileText += "  //Serial.begin(9600);\n";
            ArduinoTestFileText += "}\n";
            ArduinoTestFileText += "void loop() {\n";
            ArduinoTestFileText += "  dotmatrix.setfont(FONT_5x7W);\n";
            ArduinoTestFileText += "  // if there's data available, read a packet\n";
            ArduinoTestFileText += "  int packetSize = Udp.parsePacket();\n\n";
            ArduinoTestFileText += "  if(packetSize)\n";
            ArduinoTestFileText += "  {\n";
            ArduinoTestFileText += "    /*Serial.print(\"Received packet of size \");\n";
            ArduinoTestFileText += "     Serial.println(packetSize);\n";
            ArduinoTestFileText += "     Serial.print(\"From \");*/\n";
            ArduinoTestFileText += "    IPAddress remote = Udp.remoteIP();\n";
            ArduinoTestFileText += "    /*for (int i =0; i < 4; i++)\n";
            ArduinoTestFileText += "     {\n";
            ArduinoTestFileText += "     Serial.print(remote[i], DEC);\n";
            ArduinoTestFileText += "     if (i < 3)\n";
            ArduinoTestFileText += "     {\n";
            ArduinoTestFileText += "     Serial.print(\".\");\n";
            ArduinoTestFileText += "     }\n";
            ArduinoTestFileText += "     }\n";
            ArduinoTestFileText += "     Serial.print(\", port \");\n";
            ArduinoTestFileText += "     Serial.println(Udp.remotePort());*/\n";
            ArduinoTestFileText += "    // read the packet into packetBufffer\n\n";
            ArduinoTestFileText += "    Udp.read(packetBuffer,128);    \n";
            ArduinoTestFileText += "    //Serial.println(\"Contents:\");\n";
            ArduinoTestFileText += "    //Serial.println(packetBuffer);\n\n";
            ArduinoTestFileText += "    readString += readString+packetBuffer;\n";
            ArduinoTestFileText += "    if (readString.endsWith(\"\\n\")) {\n";
            ArduinoTestFileText += "      char myString[readString.length()+1]; //determine size of the array\n";
            ArduinoTestFileText += "      readString.toCharArray(myString, sizeof(myString)); //put readStringinto an array*/\n";
            ArduinoTestFileText += "      /*  List of all functions and the used options\n";
            ArduinoTestFileText += "       The options are not for all function the same, because not all functions use all \n";
            ArduinoTestFileText += "       options and to minimize the string send from the computer to Arduino board.\n";
            ArduinoTestFileText += "       function      functionstring  soption1          soption2          soption3\n";
            ArduinoTestFileText += "       draw          dr              transparentblack  pictureerase        /\n";
            ArduinoTestFileText += "       Text          tx/ty           color             backgroundcolor     /   \n";
            ArduinoTestFileText += "       ScrollText    sx/sy           color             direction         backgroundcolor \n";
            ArduinoTestFileText += "       ClearSpecial  cs              partofmatrix      split             direction          \n";
            ArduinoTestFileText += "       Plot          pl              color              /                  /\n";
            ArduinoTestFileText += "       Line          li              secondx           secondy           color\n";
            ArduinoTestFileText += "       Rectangle     re              secondx           secondy           color\n";
            ArduinoTestFileText += "       Circle        ci              radius            color              /\n";
            ArduinoTestFileText += "       Ellipse       el              secondx           secondy           color\n";
            ArduinoTestFileText += "       Bezier        be              secondx           secondy           color (thirdx and thirdy are a string with a hyphen between) \n";
            ArduinoTestFileText += "       Fill          fi              color              /                  /\n";
            ArduinoTestFileText += "       */\n";
            ArduinoTestFileText += "      sscanf(myString,\"%2s,%d,%d,%d,%d,%d,%d,%d,%[^\\t\\n]\", &workitString, &sx, &sy,  &sdelay,  &ssendmatrix, &soption1, &soption2, &soption3, &colorString);\n";
            ArduinoTestFileText += "      functionString=workitString;\n";
            ArduinoTestFileText += "      if (functionString==\"dr\") {          \n";
            ArduinoTestFileText += "        columnColor=random(3)+1;          \n";
            ArduinoTestFileText += "        for(int tmp=0; tmp<=strlen(colorString); tmp++)\n";
            ArduinoTestFileText += "        {\n";
            ArduinoTestFileText += "          scolor=  colorString[tmp]-48;\n";
            ArduinoTestFileText += "          sy2=sy+tmp;\n";
            ArduinoTestFileText += "          if (scolor==5) {\n";
            ArduinoTestFileText += "            scolor=columnColor;\n";
            ArduinoTestFileText += "          }\n";
            ArduinoTestFileText += "          else if (scolor==7) {\n";
            ArduinoTestFileText += "            scolor=random(2)+1;\n";
            ArduinoTestFileText += "          } \n";
            ArduinoTestFileText += "          else if (scolor==8) {\n";
            ArduinoTestFileText += "            scolor=random(3)+1;\n";
            ArduinoTestFileText += "          }\n";
            ArduinoTestFileText += "          else if (scolor==9) {\n";
            ArduinoTestFileText += "            scolor=random(2)+2;\n";
            ArduinoTestFileText += "          }\n";
            ArduinoTestFileText += "          if (soption1==1 && scolor==0) {             				\n";
            ArduinoTestFileText += "          } \n";
            ArduinoTestFileText += "          else{\n";
            ArduinoTestFileText += "            if (soption2==1 && scolor!=0) {\n";
            ArduinoTestFileText += "              dotmatrix.plot( sx, sy2,0);						\n";
            ArduinoTestFileText += "            } \n";
            ArduinoTestFileText += "            else {			\n";
            ArduinoTestFileText += "              dotmatrix.plot( sx, sy2,scolor);\n";
            ArduinoTestFileText += "            }\n";
            ArduinoTestFileText += "          }           \n";
            ArduinoTestFileText += "        }\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());\n";
            ArduinoTestFileText += "        Udp.write(ReplyBuffer);\n";
            ArduinoTestFileText += "        Udp.endPacket();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      else     if (functionString==\"tx\") {\n";
            ArduinoTestFileText += "        ht1632_writetext(sx, sy, colorString, ssendmatrix,sdelay, 0, soption1, soption2);\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"ty\") {\n";
            ArduinoTestFileText += "        ht1632_writetext(sx, sy, colorString, ssendmatrix, sdelay, 1, soption1, soption2);\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"sx\") {\n";
            ArduinoTestFileText += "        dotmatrix.hscrolltext(sy, colorString , soption1, sdelay,  1, soption2, 0, soption3);\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      } \n";
            ArduinoTestFileText += "      else     if (functionString==\"sy\") {\n";
            ArduinoTestFileText += "        dotmatrix.vscrolltext(sx,colorString , soption1, sdelay, 1, soption2, 0, soption3);\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"cl\") {\n";
            ArduinoTestFileText += "        dotmatrix.clear();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"pl\") {\n";
            ArduinoTestFileText += "        dotmatrix.plot( sx, sy,soption1);          \n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"li\") {\n";
            ArduinoTestFileText += "        dotmatrix.line(sx, sy, soption1, soption2, soption3);\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"re\") {\n";
            ArduinoTestFileText += "        dotmatrix.rect(sx, sy, soption1, soption2, soption3);\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"ci\") {\n";
            ArduinoTestFileText += "        dotmatrix.circle(sx, sy, soption1, soption2);\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"el\") {\n";
            ArduinoTestFileText += "        dotmatrix.ellipse(sx, sy, soption1, soption2, soption3);\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"fi\") {\n";
            ArduinoTestFileText += "        dotmatrix.fill(sx, sy, soption1);\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else     if (functionString==\"be\") {\n";
            ArduinoTestFileText += "        sscanf(colorString,\"%d-%d\", &soption4, &soption5);\n";
            ArduinoTestFileText += "        dotmatrix.bezier(sx, sy, soption1, soption2, soption4,soption5, soption3 );\n";
            ArduinoTestFileText += "        if (ssendmatrix==1)\n";
            ArduinoTestFileText += "          dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }        \n";
            ArduinoTestFileText += "      else  if (functionString==\"cs\") {\n";
            ArduinoTestFileText += "        ht1632_clearfillcolor(soption1, soption2, soption3, ssendmatrix, sdelay,int(colorString[0])-48);\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "      else  if (functionString==\"sf\") {\n";
            ArduinoTestFileText += "        dotmatrix.sendframe();\n";
            ArduinoTestFileText += "        readString=\"\"; //clears variable for new input\n";
            ArduinoTestFileText += "        functionString=\"\";\n";
            ArduinoTestFileText += "      }\n";
            ArduinoTestFileText += "    }\n";
            ArduinoTestFileText += "  }\n";
            ArduinoTestFileText += "}\n";
            ArduinoTestFileText += "\n";

            Clipboard.SetText(ArduinoTestFileText, TextDataFormat.Text);
        }
        private void CopyArduinoScriptToClipboard_Click(object sender, EventArgs e)
        {
            string[] BmdRow, BmdRowData;
            int numberdisplays = 1;
            string ArduinoFileText = "";
            ArduinoFileText += "#include <ht1632c.h>\n";
            if ((int)NumberOfYMatrix.Value > 1)
            {
                numberdisplays = (int)NumberOfXMatrix.Value + (int)NumberOfYMatrix.Value;
            }
            else
            {
                numberdisplays = (int)NumberOfXMatrix.Value;
            }
            ArduinoFileText += "ht1632c dotmatrix = ht1632c(&PORTD," + DataText.Text + "," + WR.Text + "," + CLK.Text + "," + CS.Text + ",GEOM_32x16," + numberdisplays.ToString() + ");\n";
            ArduinoFileText += "#define Number_of_X_Displays " + NumberOfXMatrix.Value.ToString() + "\n";
            ArduinoFileText += "#define Number_of_Y_Displays " + NumberOfYMatrix.Value.ToString() + "\n";
            ArduinoFileText += "#define X_MAX (32*Number_of_X_Displays-1)\n";
            ArduinoFileText += "#define Y_MAX (16*Number_of_Y_Displays-1)\n";
            ArduinoFileText += "#define Transparent 1\n";
            ArduinoFileText += "#define RANDOMCOLUMNCOLOR 5\n";
            ArduinoFileText += "#define RANDOMLINECOLOR 6\n";
            ArduinoFileText += "#define RANDOMREDGREENMULTICOLOR 7\n";
            ArduinoFileText += "#define RANDOMREDORANGEMULTICOLOR 9\n";
            ArduinoFileText += "int commonlines=" + CommonColumsLines.Text + ";\n";
            ArduinoFileText += "int sx,sx2;\n";
            ArduinoFileText += "int sy,sy2;\n";
            ArduinoFileText += "int scolor,sbackcolor;\n";
            ArduinoFileText += "int columnColor = 0, randomcolor=0;\n";
            ArduinoFileText += "char myString[]=\"\", colorString[128];\n\n\n\n\n";
            ArduinoFileText += "void ht1632_putbitmap4color(int x, int y, PGM_P * stringtablename, int columncountbitmap, int rowcountbitmap, int sendmatrix, int transparentblack, int picturemode, int textbitmap, int frontcolor, int backcolor)\n";
            ArduinoFileText += "{\n";
            ArduinoFileText += "  unsigned short startcolumm, endcolumn,startrow, endrow;\n";
            ArduinoFileText += "  if (x>=0){\n";
            ArduinoFileText += "    startcolumm=0;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  else{\n";
            ArduinoFileText += "    startcolumm=-x;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  if ((-x+X_MAX+2)>=columncountbitmap){\n";
            ArduinoFileText += "    endcolumn=columncountbitmap;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  else{\n";
            ArduinoFileText += "    endcolumn=-x+X_MAX+1;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  if (y>=0){\n";
            ArduinoFileText += "    startrow=0;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  else{\n";
            ArduinoFileText += "    startrow=-y;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  if ((-y+Y_MAX+2)>=rowcountbitmap){\n";
            ArduinoFileText += "    endrow=rowcountbitmap;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  else{\n";
            ArduinoFileText += "    endrow=-y+Y_MAX+1;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  sx=x;\n";
            ArduinoFileText += "  randomcolor=random(3)+1;\n";
            ArduinoFileText += "  for (unsigned char i = startcolumm; i < endcolumn; i++)\n";
            ArduinoFileText += "  {\n";
            ArduinoFileText += "    if (i % commonlines ==0) {\n";
            ArduinoFileText += "      columnColor=random(3)+1; \n";
            ArduinoFileText += "    }            \n";
            ArduinoFileText += "    strcpy_P(colorString, (PGM_P)pgm_read_word(&(stringtablename[i])));\n";
            ArduinoFileText += "    for(int tmp=startrow; tmp<=endrow; tmp++)\n";
            ArduinoFileText += "    {\n";
            ArduinoFileText += "      scolor=  char(colorString[tmp])-48;\n";
            ArduinoFileText += "if (textbitmap==1 && scolor==1) {\n";
            ArduinoFileText += "        scolor=frontcolor;\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      if (textbitmap==1 && scolor==0) {\n";
            ArduinoFileText += "        scolor=backcolor;\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      sy2=y+tmp;\n";
            ArduinoFileText += "      if (scolor==4) {\n";
            ArduinoFileText += "        scolor=randomcolor;\n";
            ArduinoFileText += "      } \n";
            ArduinoFileText += "      else if (scolor==5) {\n";
            ArduinoFileText += "        scolor=columnColor;\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      else if (scolor==6) {\n";
            ArduinoFileText += "          scolor=(sy2/commonlines) % commonlines+1;;\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      else if (scolor==7) {\n";
            ArduinoFileText += "        scolor=random(2)+1;\n";
            ArduinoFileText += "      } \n";
            ArduinoFileText += "      else if (scolor==8) {\n";
            ArduinoFileText += "        scolor=random(3)+1;\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      else if (scolor==9) {\n";
            ArduinoFileText += "        scolor=random(2)+2;\n";
            ArduinoFileText += "      }      \n";
            ArduinoFileText += "      if (transparentblack==1 && scolor==0) {\n";
            ArduinoFileText += "     }\n";
            ArduinoFileText += "     else{\n";
            ArduinoFileText += "         if (picturemode==1 && scolor!=0) {\n";
            ArduinoFileText += "             dotmatrix.plot( sx, sy2,0); \n";
            ArduinoFileText += "         } \n";
            ArduinoFileText += "         else { \n";
            ArduinoFileText += "              dotmatrix.plot( sx, sy2,scolor); \n";
            ArduinoFileText += "             }  \n";
            ArduinoFileText += "     }  \n";
            ArduinoFileText += "     if (sendmatrix==0)\n";
            ArduinoFileText += "      dotmatrix.sendframe();\n";
            ArduinoFileText += "    }    \n";
            ArduinoFileText += "    sx=sx+ 1;\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  if (sendmatrix==1)\n";
            ArduinoFileText += "      dotmatrix.sendframe();\n";
            ArduinoFileText += "}\n\n\n";
            ArduinoFileText += "/*\n";
            ArduinoFileText += " * scrollbitmapx4color()\n";
            ArduinoFileText += " * Scrolls a bitmap from left to right\n";
            ArduinoFileText += " * Original function by Bill Ho\n";
            ArduinoFileText += " * Direction function by lonewolf \n";
            ArduinoFileText += " * scrollbitmap4xcolor (x location, stringtablename , number of columns, number of rows, delaytime in milliseconds).\n";
            ArduinoFileText += " */\n";
            ArduinoFileText += "void scrollbitmapx4color(int y, PGM_P * stringtablename,int columncountbitmap, byte rowcountbitmap,int delaytime, int dir, int textbitmap, int frontcolor, int backcolor) {\n";
            ArduinoFileText += "  int  x;\n";
            ArduinoFileText += "  for ((dir) ? x = - (columncountbitmap) : x = X_MAX; (dir) ? x <= X_MAX : x > - (columncountbitmap); (dir) ? x++ : x--)\n";
            ArduinoFileText += "  {   \n";
            ArduinoFileText += "    if (textbitmap==1 && frontcolor==4) {\n";
            ArduinoFileText += "      frontcolor=random(3)+1;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    if (textbitmap==1 && backcolor==4) {\n";
            ArduinoFileText += "      backcolor=random(3)+1;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    for (int i = 0; i < 1; i++) {\n";
            ArduinoFileText += "    ht1632_putbitmap4color(x + (columncountbitmap *i), y, stringtablename , columncountbitmap,rowcountbitmap, 1, 0, 0, textbitmap, frontcolor, backcolor);\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    delay(delaytime);// reduce speed of scroll\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "}\n\n\n\n";
            ArduinoFileText += "/*\n";
            ArduinoFileText += " * scrollbitmapy4color()\n";
            ArduinoFileText += " * Scrolls a bitmap from bottom to up\n";
            ArduinoFileText += " * Original function by Bill Ho\n";
            ArduinoFileText += " * scrollbitmapy4color (y location, stringtablename , number of columns, number of rows, delaytime in milliseconds).\n";
            ArduinoFileText += " */\n";
            ArduinoFileText += "void scrollbitmapy4color(int x,PGM_P * stringtablename,int columncountbitmap, byte rowcountbitmap, int delaytime, int dir, int textbitmap, int frontcolor, int backcolor) {\n";
            ArduinoFileText += "   int  y;\n";
            ArduinoFileText += "  for ((dir) ? y = - (rowcountbitmap) : y = Y_MAX; (dir) ? y <= Y_MAX : y > - (rowcountbitmap); (dir) ? y++ : y--)\n";
            ArduinoFileText += "  {   \n";
            ArduinoFileText += "    if (textbitmap==1 && frontcolor==4) {\n";
            ArduinoFileText += "      frontcolor=random(3)+1;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    if (textbitmap==1 && backcolor==4) {\n";
            ArduinoFileText += "      backcolor=random(3)+1;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "      for (int i = 0; i < 1; i++) {\n";
            ArduinoFileText += "        ht1632_putbitmap4color(x,  y + ( rowcountbitmap *i), stringtablename , columncountbitmap,rowcountbitmap, 1, 0, 0, textbitmap, frontcolor, backcolor);\n";
            ArduinoFileText += "      }\n";
            ArduinoFileText += "      delay(delaytime);// reduce speed of scroll\n";
            ArduinoFileText += "     \n";
            ArduinoFileText += "   \n";
            ArduinoFileText += "   \n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "}\n\n\n";
            ArduinoFileText += "void ht1632_writetext(int x, int y,  char *text, int sendmatrix, int delaytime, int dir, int scolor, int sbackcolor)\n";
            ArduinoFileText += "{\n";
            ArduinoFileText += "  for(int tmp=0; tmp<strlen(text); tmp++)\n";
            ArduinoFileText += "  { \n";
            ArduinoFileText += "    if (dir==0) {            \n";
            ArduinoFileText += "      sx2=x+tmp*6;\n";
            ArduinoFileText += "      sy2=y;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    else if (dir==1) {            \n";
            ArduinoFileText += "      sx2=x;\n";
            ArduinoFileText += "      sy2=y+tmp*8;\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "    dotmatrix.putchar(sx2,sy2, text[tmp] , scolor, 0, sbackcolor);\n";
            ArduinoFileText += "    if (sendmatrix==0)\n";
            ArduinoFileText += "      dotmatrix.sendframe();\n";
            ArduinoFileText += "    delay(delaytime); \n";
            ArduinoFileText += "  } \n";
            ArduinoFileText += "  if (sendmatrix==1)\n";
            ArduinoFileText += "    dotmatrix.sendframe();\n";
            ArduinoFileText += "}\n\n\n";
            ArduinoFileText += "void ht1632_clearfillcolor(int matrixtype, int typeofsplit, int dir, int sendmatrix, int delaytime, int fillcolor)\n";
            ArduinoFileText += "{\n";
            ArduinoFileText += "  int tmpx,tmpy ;  \n";
            ArduinoFileText += "  scolor=fillcolor;\n";
            ArduinoFileText += "  if (fillcolor==4) {\n";
            ArduinoFileText += "    scolor=random(3)+1;\n";
            ArduinoFileText += "  }                 \n";
            ArduinoFileText += "  if (typeofsplit==0)\n";
            ArduinoFileText += "  {              \n";
            ArduinoFileText += "    for((dir) ? tmpx=0: (matrixtype) ?  tmpx=(X_MAX+1)/2:  tmpx =X_MAX ;  (dir) ?  (matrixtype) ?  tmpx<=(X_MAX+1)/2:tmpx<=X_MAX: tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoFileText += "    {\n";
            ArduinoFileText += "      for((dir) ? tmpy=0: tmpy = Y_MAX; (dir) ?  tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoFileText += "      {                 \n";
            ArduinoFileText += "        if (fillcolor==8) { \n";
            ArduinoFileText += "          scolor=random(3)+1; \n";
            ArduinoFileText += "        }               \n";
            ArduinoFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoFileText += "        if (matrixtype==1)\n";
            ArduinoFileText += "        {\n";
            ArduinoFileText += "          dotmatrix.plot(X_MAX-tmpx, tmpy,scolor);\n";
            ArduinoFileText += "        }\n";
            ArduinoFileText += "        if (sendmatrix==0)\n";
            ArduinoFileText += "          dotmatrix.sendframe();  \n";
            ArduinoFileText += "        delay(delaytime);          \n";
            ArduinoFileText += "      } \n";
            ArduinoFileText += "      if (sendmatrix==1)\n";
            ArduinoFileText += "        dotmatrix.sendframe();\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "  else if (typeofsplit==1)\n";
            ArduinoFileText += "  {               \n";
            ArduinoFileText += "    for((dir) ? tmpy=0: (matrixtype) ? tmpy=(Y_MAX+1)/2: tmpy = Y_MAX; (dir) ?  (matrixtype) ? tmpy<=(Y_MAX+1)/2 : tmpy<=Y_MAX : tmpy >=0; (dir)  ? tmpy++:tmpy--)\n";
            ArduinoFileText += "    {\n";
            ArduinoFileText += "      for((dir) ? tmpx=0: tmpx = X_MAX;  (dir) ?  tmpx<=X_MAX : tmpx >=0; (dir)  ? tmpx++:tmpx--)\n";
            ArduinoFileText += "      {\n";
            ArduinoFileText += "        if (fillcolor==8) \n";
            ArduinoFileText += "          scolor=random(3)+1;\n";
            ArduinoFileText += "        dotmatrix.plot( tmpx, tmpy,scolor);\n";
            ArduinoFileText += "        if (matrixtype==1)\n";
            ArduinoFileText += "        {\n";
            ArduinoFileText += "          dotmatrix.plot(tmpx, Y_MAX-tmpy,scolor);\n";
            ArduinoFileText += "        }\n";
            ArduinoFileText += "        if (sendmatrix==0)\n";
            ArduinoFileText += "          dotmatrix.sendframe();  \n";
            ArduinoFileText += "        delay(delaytime);          \n";
            ArduinoFileText += "      } \n";
            ArduinoFileText += "      if (sendmatrix==1)\n";
            ArduinoFileText += "        dotmatrix.sendframe();\n";
            ArduinoFileText += "    }\n";
            ArduinoFileText += "  }\n";
            ArduinoFileText += "}\n\n\n";
            ArrayList BMData = new ArrayList();
            ArrayList BMSingleData = new ArrayList();
            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("Bitmap") || dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("TextBitmap"))
                {
                    BMData.Add(dataGridView1.Rows[x].Cells[BitNameIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[BitDataIndex].Value);
                }
            }
            foreach (string ts in BMData)
            {
                if (!BMSingleData.Contains(ts))
                {
                    BMSingleData.Add(ts);
                }
            }
            foreach (string bmda in BMSingleData)
            {
                BmdRow = bmda.Split(',');
                BmdRowData = BmdRow[3].Split(':');
                for (int x = 0; x < Convert.ToInt16(BmdRow[1]); x++)
                {
                    ArduinoFileText += "char " + BmdRow[0].ToString() + "string_" + x + "[] PROGMEM = \"" + BmdRowData[x] + "\";\n";
                }
                ArduinoFileText += "\n\n";
            }
            foreach (string bmda in BMSingleData)
            {
                BmdRow = bmda.Split(',');
                ArduinoFileText += "PGM_P " + BmdRow[0].ToString() + "string_table[] PROGMEM = \n{\n";
                for (int x = 0; x < Convert.ToInt16(BmdRow[1]); x++)
                {
                    ArduinoFileText += "\t" + BmdRow[0].ToString() + "string_" + x + ",\n";
                }
                ArduinoFileText += "};\n\n";
            }
            ArduinoFileText += "void setup() {\n";
            ArduinoFileText += "  Serial.begin(115200);\n";
            ArduinoFileText += "  dotmatrix.clear();\n";
            ArduinoFileText += "}\n\n\n";
            ArduinoFileText += "void loop() {\n";
            ArduinoFileText += " dotmatrix.setfont(FONT_5x7W);\n";
            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Draw Each Column/Char")
                {
                    SFrame = "0";
                }
                else if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Send Frame after Bitmap/Text")
                {
                    SFrame = "1";
                }
                else if ((string)dataGridView1.Rows[x].Cells[SFrameIndex].Value == "Don't Send Frame")
                {
                    SFrame = "2";
                }
                if ((string)dataGridView1.Rows[x].Cells[PModeIndex].Value == "Picture Erase")
                {
                    PMode = "1";
                }
                else
                {
                    PMode = "0";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bitmap")
                {
                    string actualrow =
                        "ht1632_putbitmap4color(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + SFrame + "," + dataGridView1.Rows[x].Cells[BTransparencyIndex].Value + "," + PMode + ",0,0,0);";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "BitmapX")
                {
                    string actualrow =
                        "scrollbitmapx4color(" + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace(" | UP", "").Replace(" | DOWN", "") + ",0,0,0);";

                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "BitmapY")
                {
                    string actualrow =
                        "scrollbitmapy4color(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "").Replace("RIGHT | ", "") + ",0,0,0);";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmap")
                {
                    string actualrow =
                                "ht1632_putbitmap4color(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + SFrame + "," + dataGridView1.Rows[x].Cells[BTransparencyIndex].Value + "," + PMode + ",1," + dataGridView1.Rows[x].Cells[FColorIndex].Value + "," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapX")
                {
                    string actualrow =
                        "scrollbitmapx4color(" + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace(" | UP", "").Replace(" | DOWN", "") + ",1," + dataGridView1.Rows[x].Cells[FColorIndex].Value + "," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextBitmapY")
                {
                    string actualrow =
                        "scrollbitmapy4color(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitNameIndex].Value + "string_table," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "").Replace("RIGHT | ", "") + ",1," + dataGridView1.Rows[x].Cells[FColorIndex].Value + "," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Clear")
                {
                    string actualrow =
                        "dotmatrix.clear();";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Delay")
                {
                    string actualrow =
                        " delay(" + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "SendFrame")
                {
                    string actualrow =
                        "dotmatrix.sendframe();";
                    ArduinoFileText += actualrow + "\n";
                }
                if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Plot")
                {
                    string actualrow =
                       " dotmatrix.plot(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Line")
                {
                    string actualrow =
                        " dotmatrix.line(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Rectangle")
                {
                    string actualrow =
                         " dotmatrix.rect(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Ellipse")
                {
                    string actualrow =
                          " dotmatrix.ellipse(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Circle")
                {
                    string actualrow =
                           " dotmatrix.circle(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Bezier")
                {
                    string[] words = dataGridView1.Rows[x].Cells[BitDataIndex].Value.ToString().Split('-');
                    string actualrow =
                           " dotmatrix.bezier(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[BitWidthIndex].Value + "," + dataGridView1.Rows[x].Cells[BitHeightIndex].Value + "," + words[0] + "," + words[1] + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "Fill")
                {
                    string actualrow =
                          " dotmatrix.fill(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                    if (SFrame == "1")
                    {
                        ArduinoFileText += "dotmatrix.sendframe();" + "\n";
                    }
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextX")
                {
                    string actualrow =
                          " ht1632_writetext(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + ",\"" + dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\"," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + ",0," + dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() + "," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextY")
                {
                    string actualrow =
                          " ht1632_writetext(" + dataGridView1.Rows[x].Cells[XCoordIndex].Value + "," + dataGridView1.Rows[x].Cells[YCoordIndex].Value + ",\"" + dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\"," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + ",1," + dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString() + "," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollX")
                {
                    FColor = dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString();
                    if (dataGridView1.Rows[x].Cells[STextBehaviourIndex].Value.ToString() == "BLINK")
                    {
                        FColor = FColor + " | BLINK";
                    }
                    string actualrow =
                          " dotmatrix.hscrolltext(" + dataGridView1.Rows[x].Cells[YCoordIndex].Value + ",\"" + dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\"," + FColor + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + ",1," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace(" | UP", "").Replace(" | DOWN", "") + ",0," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "TextScrollY")
                {
                    FColor = dataGridView1.Rows[x].Cells[FColorIndex].Value.ToString();
                    if (dataGridView1.Rows[x].Cells[STextBehaviourIndex].Value.ToString() == "BLINK")
                    {
                        FColor = FColor + " | BLINK";
                    }
                    string actualrow =
                          " dotmatrix.vscrolltext(" + dataGridView1.Rows[x].Cells[YCoordIndex].Value + ",\"" + dataGridView1.Rows[x].Cells[TxDataIndex].Value + "\"," + FColor + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + ",1," + dataGridView1.Rows[x].Cells[SDirectionIndex].Value.ToString().Replace("LEFT | ", "").Replace("RIGHT | ", "") + ",0," + dataGridView1.Rows[x].Cells[BColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "ClearFullLeft")
                {
                    string actualrow =
                          " ht1632_clearfillcolor(" + "0,0,0," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "ClearFullRight")
                {
                    string actualrow =
                          " ht1632_clearfillcolor(" + "0,0,1," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "ClearFullUp")
                {
                    string actualrow =
                          " ht1632_clearfillcolor(" + "0,1,0," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString() == "ClearFullDown")
                {
                    string actualrow =
                          " ht1632_clearfillcolor(" + "0,1,1," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("ClearHalfVertical"))
                {
                    string ClearingDirection = "0";
                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Inside")) { ClearingDirection = "1"; }
                    string actualrow =
                          " ht1632_clearfillcolor(" + "1,0," + ClearingDirection + "," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
                else if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().StartsWith("ClearHalfHorizontal"))
                {
                    string ClearingDirection = "0";
                    if (dataGridView1.Rows[x].Cells[ShowTypeIndex].Value.ToString().EndsWith("Inside")) { ClearingDirection = "1"; }
                    string actualrow =
                          " ht1632_clearfillcolor(" + "1,1," + ClearingDirection + "," + SFrame + "," + dataGridView1.Rows[x].Cells[TimDelayIndex].Value + "," + dataGridView1.Rows[x].Cells[FColorIndex].Value + ");";
                    ArduinoFileText += actualrow + "\n";
                }
            }
            ArduinoFileText += "}\n\n\n";
            Clipboard.SetText(ArduinoFileText, TextDataFormat.Text);

        }
        private void SaveScriptText_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine("ShwType\tRowIdentifier\tText\tDelay\tSendFrame\tScrollDirection\tXCoordinate\tYCoordinate\tBitmapHeight\tBitmapWidth\tBitmapData\tTransparency\tPictureMode\tFrontTextColor\tBackTextColor\tScrollTextBehaviour");
            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                string actualrow =
                dataGridView1.Rows[x].Cells[0].Value + "\t" +
                dataGridView1.Rows[x].Cells[1].Value + "\t" +
                dataGridView1.Rows[x].Cells[2].Value + "\t" +
                dataGridView1.Rows[x].Cells[3].Value + "\t" +
                dataGridView1.Rows[x].Cells[4].Value + "\t" +
                dataGridView1.Rows[x].Cells[5].Value + "\t" +
                dataGridView1.Rows[x].Cells[6].Value + "\t" +
                dataGridView1.Rows[x].Cells[7].Value + "\t" +
                dataGridView1.Rows[x].Cells[8].Value + "\t" +
                dataGridView1.Rows[x].Cells[9].Value + "\t" +
                dataGridView1.Rows[x].Cells[10].Value + "\t" +
                dataGridView1.Rows[x].Cells[11].Value + "\t" +
                dataGridView1.Rows[x].Cells[12].Value + "\t" +
                dataGridView1.Rows[x].Cells[13].Value + "\t" +
                dataGridView1.Rows[x].Cells[14].Value + "\t" +
                dataGridView1.Rows[x].Cells[15].Value + "\t"
                ;
                sw.WriteLine(actualrow);
            }
            sw.Close();
        }
        private void OpenScript_Click(object sender, EventArgs e)
        {
            string strLine = "";
            string[] CSVRow, CSVRowMember;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.Title = "Select a Text File";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog2.FileName, System.Text.Encoding.UTF8);
                strLine = sr.ReadToEnd();
                sr.Close();
            }
            CSVRow = strLine.Split('\n');
            if (!CSVRow[0].StartsWith("ShwType"))
            {
                System.Windows.Forms.MessageBox.Show("Sorry, this is not a Script File for the Matrix");
            }
            else
            {
                for (int x = 1; x < CSVRow.Length; x++)
                {
                    CSVRowMember = CSVRow[x].Split('\t');
                    if (CSVRowMember.Length > 1)
                    {
                        string[] row0 = { CSVRowMember[0], CSVRowMember[1], CSVRowMember[2], CSVRowMember[3], CSVRowMember[4], CSVRowMember[5], CSVRowMember[6], CSVRowMember[7], CSVRowMember[8], CSVRowMember[9], CSVRowMember[10], CSVRowMember[11], CSVRowMember[12], CSVRowMember[13], CSVRowMember[14], CSVRowMember[15] };
                        {
                            DataGridViewRowCollection rows = this.dataGridView1.Rows;
                            rows.Add(row0);
                        }
                    }
                }
            }
        }
        private void RemoveRow_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
            this.dataGridView1.SelectedRows[0].Index !=
            this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }
        private void RemoveAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void RowUp_Click(object sender, System.EventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Index;
            if (currentRow > 0)
            {
                DataGridViewRow myRow = dataGridView1.CurrentRow;
                dataGridView1.Rows.RemoveAt(currentRow);
                dataGridView1.Rows.Insert(currentRow - 1, myRow);
                dataGridView1.CurrentCell = dataGridView1.Rows[currentRow - 1].Cells[0];
                dataGridView1.BeginEdit(true);
            }
        }
        private void RowDown_Click(object sender, EventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Index;
            if (currentRow < (dataGridView1.Rows.Count - 2))
            {
                DataGridViewRow myRow = dataGridView1.CurrentRow;
                dataGridView1.Rows.RemoveAt(currentRow);
                dataGridView1.Rows.Insert(currentRow + 1, myRow);
                dataGridView1.CurrentCell = dataGridView1.Rows[currentRow + 1].Cells[0];
                dataGridView1.BeginEdit(true);
            }
        }
        private void CopyRow_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Insert(currentRow + 1, CloneWithValues(dataGridView1.CurrentRow));
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow + 1].Cells[0];
            dataGridView1.BeginEdit(true);
        }
        public DataGridViewRow CloneWithValues(DataGridViewRow row)
        {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
            for (Int32 index = 0; index < row.Cells.Count; index++)
            {
                clonedRow.Cells[index].Value = row.Cells[index].Value;
            }
            return clonedRow;
        }
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine("ComPort\tXMatrix\tYMatrix\tData\tWR\tCLK\tCS\tCommon");
            if (SPorts.SelectedIndex == -1)
            {
                sw.WriteLine(" \t" + NumberOfXMatrix.Value.ToString() + "\t" + NumberOfYMatrix.Value.ToString() + "\t" + DataText.Text + "\t" + WR.Text + "\t" + CLK.Text + "\t" + CS.Text + "\t" + CommonColumsLines.Text);
            }
            else
            {
                sw.WriteLine(SPorts.Text + "\t" + NumberOfXMatrix.Value.ToString() + "\t" + NumberOfYMatrix.Value.ToString() + "\t" + DataText.Text + "\t" + WR.Text + "\t" + CLK.Text + "\t" + CS.Text + "\t" + CommonColumsLines.Text);
            }
            sw.Close();
        }
        private void OpenSettings_Click(object sender, EventArgs e)
        {
            string strLine = "";
            string[] CSVRow, CSVRowMember;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.Title = "Select a Text File";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog2.FileName, System.Text.Encoding.UTF8);
                strLine = sr.ReadToEnd();
                sr.Close();
            }
            CSVRow = strLine.Split('\n');
            if (!CSVRow[0].StartsWith("ComPort"))
            {
                System.Windows.Forms.MessageBox.Show("Sorry, this is not a Settings File for Matrix Skripter");
            }
            else
            {
                CSVRowMember = CSVRow[1].Split('\t');
                SPorts.Text = CSVRowMember[0];
                NumberOfXMatrix.Value = Convert.ToInt16(CSVRowMember[1]);
                NumberOfYMatrix.Value = Convert.ToInt16(CSVRowMember[2]);
                DataText.Text = CSVRowMember[3];
                WR.Text = CSVRowMember[4];
                CLK.Text = CSVRowMember[5];
                CS.Text = CSVRowMember[6];
                CommonColumsLines.Text = CSVRowMember[7];
            }
        }
        private void NumberOfXMatrix_ValueChanged(object sender, EventArgs e)
        {
            X_MAX = 32 * (int)NumberOfXMatrix.Value - 1;
        }
        private void NumberOfYMatrix_ValueChanged(object sender, EventArgs e)
        {
            Y_MAX = 16 * (int)NumberOfXMatrix.Value - 1;
        }

       

        
    }
}