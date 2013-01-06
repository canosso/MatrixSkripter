namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TestText = new System.Windows.Forms.Button();
            this.TestClearMatrix = new System.Windows.Forms.Button();
            this.SPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.NumberOfXMatrix = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberOfYMatrix = new System.Windows.Forms.NumericUpDown();
            this.AddBitmapToScript = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TestTextBitmap = new System.Windows.Forms.Button();
            this.BitmapOpener = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShwType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowIdentifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendFrame = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScrollDirection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.XCoordinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YCoordinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitmapWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitmapHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitmapData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transparency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BitmapMode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FrontTextColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BackTextColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScrollBlinking = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BitmapFlipMode = new System.Windows.Forms.ComboBox();
            this.BitmapRotate = new System.Windows.Forms.ComboBox();
            this.BitmapSendFrame = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.BitmapErase = new System.Windows.Forms.RadioButton();
            this.BitmapNormal = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.BitmapTransparent = new System.Windows.Forms.RadioButton();
            this.BitmapBlack = new System.Windows.Forms.RadioButton();
            this.TestBitmap = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InputBitmapDelay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.InputBitmapY = new System.Windows.Forms.TextBox();
            this.InputBitmapX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BitmapScrollBlinking = new System.Windows.Forms.ComboBox();
            this.BitmapScrollDirection = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.BitmapScrollY = new System.Windows.Forms.RadioButton();
            this.BitmapScrollX = new System.Windows.Forms.RadioButton();
            this.BitmapShow = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BitmapColor15 = new System.Windows.Forms.ComboBox();
            this.cl15label = new System.Windows.Forms.Label();
            this.BitmapColor14 = new System.Windows.Forms.ComboBox();
            this.cl14label = new System.Windows.Forms.Label();
            this.BitmapColor11 = new System.Windows.Forms.ComboBox();
            this.cl11label = new System.Windows.Forms.Label();
            this.BitmapColor10 = new System.Windows.Forms.ComboBox();
            this.cl10label = new System.Windows.Forms.Label();
            this.BitmapColor12 = new System.Windows.Forms.ComboBox();
            this.cl12label = new System.Windows.Forms.Label();
            this.BitmapColor13 = new System.Windows.Forms.ComboBox();
            this.cl13label = new System.Windows.Forms.Label();
            this.BitmapColor8 = new System.Windows.Forms.ComboBox();
            this.cl8label = new System.Windows.Forms.Label();
            this.BitmapColor7 = new System.Windows.Forms.ComboBox();
            this.cl7label = new System.Windows.Forms.Label();
            this.BitmapColor9 = new System.Windows.Forms.ComboBox();
            this.cl9label = new System.Windows.Forms.Label();
            this.BitmapColor6 = new System.Windows.Forms.ComboBox();
            this.cl6label = new System.Windows.Forms.Label();
            this.BitmapColor5 = new System.Windows.Forms.ComboBox();
            this.cl5label = new System.Windows.Forms.Label();
            this.BitmapColor3 = new System.Windows.Forms.ComboBox();
            this.cl3label = new System.Windows.Forms.Label();
            this.BitmapColor2 = new System.Windows.Forms.ComboBox();
            this.cl2label = new System.Windows.Forms.Label();
            this.BitmapColor4 = new System.Windows.Forms.ComboBox();
            this.cl4label = new System.Windows.Forms.Label();
            this.BitmapColor1 = new System.Windows.Forms.ComboBox();
            this.cl1label = new System.Windows.Forms.Label();
            this.BitmapColor0 = new System.Windows.Forms.ComboBox();
            this.cl0label = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddTextBitmapToScript = new System.Windows.Forms.Button();
            this.InputStringTextBitmapControl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBitmapFlipMode = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.TextBitmapRotate = new System.Windows.Forms.ComboBox();
            this.TextBitmapSendFrame = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.TextBitmapPictureErase = new System.Windows.Forms.RadioButton();
            this.TextBitmapNormal = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TextBitmapTransparent = new System.Windows.Forms.RadioButton();
            this.TextBitmapBlack = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TextBitmapScrollBlinking = new System.Windows.Forms.ComboBox();
            this.TextBitmapScrollDirection = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.TextBitmapShow = new System.Windows.Forms.RadioButton();
            this.TextBitmapScrollY = new System.Windows.Forms.RadioButton();
            this.TextBitmapScrollX = new System.Windows.Forms.RadioButton();
            this.TextBitmapBackColorLabel = new System.Windows.Forms.Label();
            this.TextBitmapBackgroundColor = new System.Windows.Forms.ComboBox();
            this.TextBitmapFontColorLabel = new System.Windows.Forms.Label();
            this.TextBitmapFrontColor = new System.Windows.Forms.ComboBox();
            this.SelectFont = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.InputTextBitmapDelay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.InputTextBitmapY = new System.Windows.Forms.TextBox();
            this.InputTextBitmapX = new System.Windows.Forms.TextBox();
            this.InputStringTextBitmap = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DrawSendFrame = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.AddDrawingsToScript = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.TestDrawings = new System.Windows.Forms.Button();
            this.DrawColor = new System.Windows.Forms.ComboBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.DrawPlot = new System.Windows.Forms.RadioButton();
            this.DrawFill = new System.Windows.Forms.RadioButton();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.InputDrawBezierThirdY = new System.Windows.Forms.TextBox();
            this.InputDrawBezierThirdX = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.InputDrawBezierSecondY = new System.Windows.Forms.TextBox();
            this.InputDrawBezierSecondX = new System.Windows.Forms.TextBox();
            this.DrawBezier = new System.Windows.Forms.RadioButton();
            this.label39 = new System.Windows.Forms.Label();
            this.InputDrawCircleRadius = new System.Windows.Forms.TextBox();
            this.DrawCircle = new System.Windows.Forms.RadioButton();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.InputDrawSecondY = new System.Windows.Forms.TextBox();
            this.InputDrawSecondX = new System.Windows.Forms.TextBox();
            this.DrawEllipse = new System.Windows.Forms.RadioButton();
            this.DrawRectangle = new System.Windows.Forms.RadioButton();
            this.DrawLine = new System.Windows.Forms.RadioButton();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InputDrawDelay = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.InputDrawY = new System.Windows.Forms.TextBox();
            this.InputDrawX = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.InputStringText = new System.Windows.Forms.MaskedTextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.TextBackgroundColor = new System.Windows.Forms.ComboBox();
            this.TextSendFrame = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.AddTextToScript = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TextFrontColor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextDelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputTextY = new System.Windows.Forms.TextBox();
            this.InputTextX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextScrollBlinking = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextScrollDirection = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.TextShowY = new System.Windows.Forms.RadioButton();
            this.TextShow = new System.Windows.Forms.RadioButton();
            this.TextScrollY = new System.Windows.Forms.RadioButton();
            this.TextScrollX = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.ClearFillColor = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.HalfMatrixOutside = new System.Windows.Forms.RadioButton();
            this.HalfMatrixCenter = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.FullMatrixUp = new System.Windows.Forms.RadioButton();
            this.FullMatrixTop = new System.Windows.Forms.RadioButton();
            this.FullMatrixRight = new System.Windows.Forms.RadioButton();
            this.FullMatrixLeft = new System.Windows.Forms.RadioButton();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.HalfHorizontal = new System.Windows.Forms.RadioButton();
            this.HalfVertical = new System.Windows.Forms.RadioButton();
            this.ClearHalfMatrix = new System.Windows.Forms.RadioButton();
            this.ClearFullMatrix = new System.Windows.Forms.RadioButton();
            this.ClearSpecialSendFrame = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.InputClearSpecialDelay = new System.Windows.Forms.TextBox();
            this.AddSpecialClearEffectsToScript = new System.Windows.Forms.Button();
            this.TestSpecialClearEffects = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.OpenScript = new System.Windows.Forms.Button();
            this.SaveScriptText = new System.Windows.Forms.Button();
            this.CopyArduinoScriptToClipboard = new System.Windows.Forms.Button();
            this.RemoveRow = new System.Windows.Forms.Button();
            this.RemoveAll = new System.Windows.Forms.Button();
            this.RowUp = new System.Windows.Forms.Button();
            this.RowDown = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.DelayScript = new System.Windows.Forms.TextBox();
            this.AddDelayToScript = new System.Windows.Forms.Button();
            this.AddClearToScript = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.CommonColumsLines = new System.Windows.Forms.TextBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.OpenSettings = new System.Windows.Forms.Button();
            this.CLK = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.CS = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.DataText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.WR = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.SPortsClose = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.TestUDPPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestUDPIPAddress = new System.Windows.Forms.TextBox();
            this.TestUDP = new System.Windows.Forms.RadioButton();
            this.TestSerialPort = new System.Windows.Forms.RadioButton();
            this.AddSendFrameToScript = new System.Windows.Forms.Button();
            this.CopyRow = new System.Windows.Forms.Button();
            this.TestMatrixScript = new System.Windows.Forms.Button();
            this.StopTheScriptLoop = new System.Windows.Forms.Button();
            this.CopyToSDCardRunRemotely = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testMatrixFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopySerialTestFileToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyUDPTestFileToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopySerialToSDCardFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfXMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfYMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestText
            // 
            this.TestText.BackColor = System.Drawing.Color.Red;
            this.TestText.ForeColor = System.Drawing.Color.White;
            this.TestText.Location = new System.Drawing.Point(629, 6);
            this.TestText.Margin = new System.Windows.Forms.Padding(4);
            this.TestText.Name = "TestText";
            this.TestText.Size = new System.Drawing.Size(113, 65);
            this.TestText.TabIndex = 0;
            this.TestText.Text = "Test Normal Text";
            this.TestText.UseVisualStyleBackColor = false;
            this.TestText.Click += new System.EventHandler(this.TestText_Click);
            // 
            // TestClearMatrix
            // 
            this.TestClearMatrix.BackColor = System.Drawing.Color.Red;
            this.TestClearMatrix.ForeColor = System.Drawing.Color.White;
            this.TestClearMatrix.Location = new System.Drawing.Point(24, 758);
            this.TestClearMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.TestClearMatrix.Name = "TestClearMatrix";
            this.TestClearMatrix.Size = new System.Drawing.Size(85, 65);
            this.TestClearMatrix.TabIndex = 1;
            this.TestClearMatrix.Text = "Test Clear the Matrix";
            this.TestClearMatrix.UseVisualStyleBackColor = false;
            this.TestClearMatrix.Click += new System.EventHandler(this.TestClearMatrix_Click);
            // 
            // SPorts
            // 
            this.SPorts.BackColor = System.Drawing.Color.White;
            this.SPorts.DropDownWidth = 120;
            this.SPorts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SPorts.FormattingEnabled = true;
            this.SPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.SPorts.Location = new System.Drawing.Point(341, 28);
            this.SPorts.Margin = new System.Windows.Forms.Padding(4);
            this.SPorts.Name = "SPorts";
            this.SPorts.Size = new System.Drawing.Size(61, 24);
            this.SPorts.Sorted = true;
            this.SPorts.TabIndex = 3;
            this.SPorts.SelectedIndexChanged += new System.EventHandler(this.SPorts_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(630, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 55);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // NumberOfXMatrix
            // 
            this.NumberOfXMatrix.Location = new System.Drawing.Point(563, 59);
            this.NumberOfXMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfXMatrix.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfXMatrix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfXMatrix.Name = "NumberOfXMatrix";
            this.NumberOfXMatrix.Size = new System.Drawing.Size(33, 22);
            this.NumberOfXMatrix.TabIndex = 19;
            this.NumberOfXMatrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfXMatrix.ValueChanged += new System.EventHandler(this.NumberOfXMatrix_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Number of X-Matrix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Number of Y-Matrix";
            // 
            // NumberOfYMatrix
            // 
            this.NumberOfYMatrix.Location = new System.Drawing.Point(691, 59);
            this.NumberOfYMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfYMatrix.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfYMatrix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfYMatrix.Name = "NumberOfYMatrix";
            this.NumberOfYMatrix.Size = new System.Drawing.Size(33, 22);
            this.NumberOfYMatrix.TabIndex = 21;
            this.NumberOfYMatrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfYMatrix.ValueChanged += new System.EventHandler(this.NumberOfYMatrix_ValueChanged);
            // 
            // AddBitmapToScript
            // 
            this.AddBitmapToScript.BackColor = System.Drawing.Color.Orange;
            this.AddBitmapToScript.Location = new System.Drawing.Point(749, 6);
            this.AddBitmapToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddBitmapToScript.Name = "AddBitmapToScript";
            this.AddBitmapToScript.Size = new System.Drawing.Size(113, 133);
            this.AddBitmapToScript.TabIndex = 24;
            this.AddBitmapToScript.Text = "Add Bitmap to the Script";
            this.AddBitmapToScript.UseVisualStyleBackColor = false;
            this.AddBitmapToScript.Click += new System.EventHandler(this.AddBitmapToScript_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestTextBitmap
            // 
            this.TestTextBitmap.BackColor = System.Drawing.Color.Red;
            this.TestTextBitmap.ForeColor = System.Drawing.Color.White;
            this.TestTextBitmap.Location = new System.Drawing.Point(629, 6);
            this.TestTextBitmap.Margin = new System.Windows.Forms.Padding(4);
            this.TestTextBitmap.Name = "TestTextBitmap";
            this.TestTextBitmap.Size = new System.Drawing.Size(113, 65);
            this.TestTextBitmap.TabIndex = 28;
            this.TestTextBitmap.Text = "Test Text as Bitmap";
            this.TestTextBitmap.UseVisualStyleBackColor = false;
            this.TestTextBitmap.Click += new System.EventHandler(this.TestTextBitmap_Click);
            // 
            // BitmapOpener
            // 
            this.BitmapOpener.BackColor = System.Drawing.Color.Green;
            this.BitmapOpener.ForeColor = System.Drawing.Color.White;
            this.BitmapOpener.Location = new System.Drawing.Point(629, 6);
            this.BitmapOpener.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapOpener.Name = "BitmapOpener";
            this.BitmapOpener.Size = new System.Drawing.Size(113, 65);
            this.BitmapOpener.TabIndex = 32;
            this.BitmapOpener.Text = "Open Bitmap";
            this.BitmapOpener.UseVisualStyleBackColor = false;
            this.BitmapOpener.Click += new System.EventHandler(this.BitmapOpener_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShwType,
            this.RowIdentifier,
            this.TextData,
            this.TimeDelay,
            this.SendFrame,
            this.ScrollDirection,
            this.XCoordinate,
            this.YCoordinate,
            this.BitmapWidth,
            this.BitmapHeight,
            this.BitmapData,
            this.Transparency,
            this.BitmapMode,
            this.FrontTextColor,
            this.BackTextColor,
            this.ScrollBlinking});
            this.dataGridView1.Location = new System.Drawing.Point(24, 454);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 262);
            this.dataGridView1.TabIndex = 35;
            // 
            // ShwType
            // 
            this.ShwType.HeaderText = "Type";
            this.ShwType.Name = "ShwType";
            // 
            // RowIdentifier
            // 
            this.RowIdentifier.HeaderText = "Name of Bitmap or Font";
            this.RowIdentifier.Name = "RowIdentifier";
            this.RowIdentifier.ReadOnly = true;
            // 
            // TextData
            // 
            this.TextData.HeaderText = "Text";
            this.TextData.Name = "TextData";
            // 
            // TimeDelay
            // 
            this.TimeDelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TimeDelay.HeaderText = "Delay";
            this.TimeDelay.Name = "TimeDelay";
            this.TimeDelay.ToolTipText = "Delay in Milliseconds";
            this.TimeDelay.Width = 69;
            // 
            // SendFrame
            // 
            this.SendFrame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SendFrame.DropDownWidth = 220;
            this.SendFrame.HeaderText = "Send Frame";
            this.SendFrame.Items.AddRange(new object[] {
            "Draw Each Column/Char",
            "Send Frame after Bitmap/Text",
            "Don\'t Send Frame"});
            this.SendFrame.Name = "SendFrame";
            this.SendFrame.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SendFrame.ToolTipText = "0 for each Column/Char, 1 for Draw the whole Bitmap/Text, 2 for not sending a Fra" +
                "me";
            this.SendFrame.Width = 82;
            // 
            // ScrollDirection
            // 
            this.ScrollDirection.DropDownWidth = 150;
            this.ScrollDirection.HeaderText = "Scroll Direction";
            this.ScrollDirection.Items.AddRange(new object[] {
            "LEFT | UP",
            "RIGHT | DOWN"});
            this.ScrollDirection.Name = "ScrollDirection";
            this.ScrollDirection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScrollDirection.ToolTipText = "0 for Right | Bottom, 1 for Left | Top";
            this.ScrollDirection.Width = 79;
            // 
            // XCoordinate
            // 
            this.XCoordinate.HeaderText = "X-Coordinate";
            this.XCoordinate.Name = "XCoordinate";
            this.XCoordinate.Width = 70;
            // 
            // YCoordinate
            // 
            this.YCoordinate.HeaderText = "Y-Coordinate";
            this.YCoordinate.Name = "YCoordinate";
            this.YCoordinate.Width = 70;
            // 
            // BitmapWidth
            // 
            this.BitmapWidth.HeaderText = "Bitmap Width";
            this.BitmapWidth.Name = "BitmapWidth";
            this.BitmapWidth.ReadOnly = true;
            this.BitmapWidth.Width = 70;
            // 
            // BitmapHeight
            // 
            this.BitmapHeight.HeaderText = "Bitmap Height";
            this.BitmapHeight.Name = "BitmapHeight";
            this.BitmapHeight.ReadOnly = true;
            this.BitmapHeight.Width = 70;
            // 
            // BitmapData
            // 
            this.BitmapData.HeaderText = "Data of Bitmap";
            this.BitmapData.Name = "BitmapData";
            this.BitmapData.ReadOnly = true;
            // 
            // Transparency
            // 
            this.Transparency.DropDownWidth = 100;
            this.Transparency.HeaderText = "Transparency";
            this.Transparency.Items.AddRange(new object[] {
            "BLACK",
            "Transparent"});
            this.Transparency.Name = "Transparency";
            this.Transparency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Transparency.ToolTipText = "BLACK for normal Black, Transparent for not plotting Black";
            this.Transparency.Width = 70;
            // 
            // BitmapMode
            // 
            this.BitmapMode.DropDownWidth = 100;
            this.BitmapMode.HeaderText = "BitmapMode";
            this.BitmapMode.Items.AddRange(new object[] {
            "Normal",
            "Bitmap Erase"});
            this.BitmapMode.Name = "BitmapMode";
            this.BitmapMode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BitmapMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BitmapMode.ToolTipText = "Normal for normal drawing of the Bitmap, Bitmap Erase for erase all colors except" +
                " black";
            this.BitmapMode.Width = 70;
            // 
            // FrontTextColor
            // 
            this.FrontTextColor.DropDownWidth = 250;
            this.FrontTextColor.HeaderText = "Front Color";
            this.FrontTextColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.FrontTextColor.Name = "FrontTextColor";
            this.FrontTextColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FrontTextColor.ToolTipText = "Front Color for Text as Bitmap and all other functions who use a color";
            this.FrontTextColor.Width = 70;
            // 
            // BackTextColor
            // 
            this.BackTextColor.DropDownWidth = 250;
            this.BackTextColor.HeaderText = "Background Color";
            this.BackTextColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BackTextColor.Name = "BackTextColor";
            this.BackTextColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BackTextColor.ToolTipText = "Background Color for Text as Bitmap and all other functions who use a color";
            this.BackTextColor.Width = 50;
            // 
            // ScrollBlinking
            // 
            this.ScrollBlinking.HeaderText = "Scroll Blinking";
            this.ScrollBlinking.Items.AddRange(new object[] {
            "Blink OFF",
            "BLINK"});
            this.ScrollBlinking.Name = "ScrollBlinking";
            this.ScrollBlinking.ToolTipText = "Blink OFF for not blinking, BLINK for blinking";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 312);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BitmapFlipMode);
            this.tabPage1.Controls.Add(this.BitmapRotate);
            this.tabPage1.Controls.Add(this.BitmapSendFrame);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.TestBitmap);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.BitmapOpener);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.AddBitmapToScript);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.label57);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(869, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import Bitmap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BitmapFlipMode
            // 
            this.BitmapFlipMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapFlipMode.FormattingEnabled = true;
            this.BitmapFlipMode.Items.AddRange(new object[] {
            "No Flip",
            "Flip X",
            "Flip Y",
            "Flip XY"});
            this.BitmapFlipMode.Location = new System.Drawing.Point(749, 157);
            this.BitmapFlipMode.Name = "BitmapFlipMode";
            this.BitmapFlipMode.Size = new System.Drawing.Size(113, 24);
            this.BitmapFlipMode.TabIndex = 49;
            this.BitmapFlipMode.SelectionChangeCommitted += new System.EventHandler(this.BitmapFlipMode_SelectionChangeCommitted);
            // 
            // BitmapRotate
            // 
            this.BitmapRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapRotate.FormattingEnabled = true;
            this.BitmapRotate.Items.AddRange(new object[] {
            "No Rotation",
            "Rotate 90°",
            "Rotate 180°",
            "Rotate 270°"});
            this.BitmapRotate.Location = new System.Drawing.Point(629, 157);
            this.BitmapRotate.Name = "BitmapRotate";
            this.BitmapRotate.Size = new System.Drawing.Size(113, 24);
            this.BitmapRotate.TabIndex = 48;
            this.BitmapRotate.SelectionChangeCommitted += new System.EventHandler(this.BitmapRotate_SelectionChangeCommitted);
            // 
            // BitmapSendFrame
            // 
            this.BitmapSendFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapSendFrame.DropDownWidth = 250;
            this.BitmapSendFrame.FormattingEnabled = true;
            this.BitmapSendFrame.Items.AddRange(new object[] {
            "Draw Each Column",
            "Send Frame after Drawing the Bitmap",
            "Don\'t Send Frame"});
            this.BitmapSendFrame.Location = new System.Drawing.Point(677, 247);
            this.BitmapSendFrame.Name = "BitmapSendFrame";
            this.BitmapSendFrame.Size = new System.Drawing.Size(172, 24);
            this.BitmapSendFrame.TabIndex = 47;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(590, 250);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 17);
            this.label45.TabIndex = 46;
            this.label45.Text = "Send Frame";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.BitmapErase);
            this.groupBox11.Controls.Add(this.BitmapNormal);
            this.groupBox11.Location = new System.Drawing.Point(301, 233);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(275, 46);
            this.groupBox11.TabIndex = 45;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Bitmap Mode";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.ForestGreen;
            this.label27.Font = new System.Drawing.Font("Wingdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label27.ForeColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(237, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 15);
            this.label27.TabIndex = 3;
            this.label27.Text = "(";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.ForestGreen;
            this.label28.Font = new System.Drawing.Font("Wingdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(90, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(22, 15);
            this.label28.TabIndex = 2;
            this.label28.Text = "(";
            // 
            // BitmapErase
            // 
            this.BitmapErase.AutoSize = true;
            this.BitmapErase.Location = new System.Drawing.Point(121, 15);
            this.BitmapErase.Name = "BitmapErase";
            this.BitmapErase.Size = new System.Drawing.Size(113, 21);
            this.BitmapErase.TabIndex = 1;
            this.BitmapErase.Text = "Bitmap Erase";
            this.BitmapErase.UseVisualStyleBackColor = true;
            // 
            // BitmapNormal
            // 
            this.BitmapNormal.AutoSize = true;
            this.BitmapNormal.Checked = true;
            this.BitmapNormal.Location = new System.Drawing.Point(10, 15);
            this.BitmapNormal.Name = "BitmapNormal";
            this.BitmapNormal.Size = new System.Drawing.Size(74, 21);
            this.BitmapNormal.TabIndex = 0;
            this.BitmapNormal.TabStop = true;
            this.BitmapNormal.Text = "Normal";
            this.BitmapNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.BitmapTransparent);
            this.groupBox10.Controls.Add(this.BitmapBlack);
            this.groupBox10.Location = new System.Drawing.Point(12, 233);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(275, 46);
            this.groupBox10.TabIndex = 44;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Transparency";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Webdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(238, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 20);
            this.label26.TabIndex = 3;
            this.label26.Text = "Y";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Black;
            this.label25.Font = new System.Drawing.Font("Webdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(74, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "Y";
            // 
            // BitmapTransparent
            // 
            this.BitmapTransparent.AutoSize = true;
            this.BitmapTransparent.Checked = true;
            this.BitmapTransparent.Location = new System.Drawing.Point(130, 15);
            this.BitmapTransparent.Name = "BitmapTransparent";
            this.BitmapTransparent.Size = new System.Drawing.Size(111, 21);
            this.BitmapTransparent.TabIndex = 1;
            this.BitmapTransparent.TabStop = true;
            this.BitmapTransparent.Text = "Transparent ";
            this.BitmapTransparent.UseVisualStyleBackColor = true;
            // 
            // BitmapBlack
            // 
            this.BitmapBlack.AutoSize = true;
            this.BitmapBlack.Location = new System.Drawing.Point(10, 15);
            this.BitmapBlack.Name = "BitmapBlack";
            this.BitmapBlack.Size = new System.Drawing.Size(63, 21);
            this.BitmapBlack.TabIndex = 0;
            this.BitmapBlack.Text = "Black";
            this.BitmapBlack.UseVisualStyleBackColor = true;
            // 
            // TestBitmap
            // 
            this.TestBitmap.BackColor = System.Drawing.Color.Red;
            this.TestBitmap.ForeColor = System.Drawing.Color.White;
            this.TestBitmap.Location = new System.Drawing.Point(629, 75);
            this.TestBitmap.Margin = new System.Windows.Forms.Padding(4);
            this.TestBitmap.Name = "TestBitmap";
            this.TestBitmap.Size = new System.Drawing.Size(113, 65);
            this.TestBitmap.TabIndex = 43;
            this.TestBitmap.Text = "Test Bitmap";
            this.TestBitmap.UseVisualStyleBackColor = false;
            this.TestBitmap.Click += new System.EventHandler(this.TestBitmap_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Blue;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.InputBitmapDelay);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.InputBitmapY);
            this.groupBox4.Controls.Add(this.InputBitmapX);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(333, 62);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Co-ordinates of the Bitmap";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Delay";
            // 
            // InputBitmapDelay
            // 
            this.InputBitmapDelay.Location = new System.Drawing.Point(283, 23);
            this.InputBitmapDelay.Margin = new System.Windows.Forms.Padding(4);
            this.InputBitmapDelay.Name = "InputBitmapDelay";
            this.InputBitmapDelay.Size = new System.Drawing.Size(43, 22);
            this.InputBitmapDelay.TabIndex = 45;
            this.InputBitmapDelay.Text = "0";
            this.InputBitmapDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Input Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Input X";
            // 
            // InputBitmapY
            // 
            this.InputBitmapY.Location = new System.Drawing.Point(179, 23);
            this.InputBitmapY.Margin = new System.Windows.Forms.Padding(4);
            this.InputBitmapY.Name = "InputBitmapY";
            this.InputBitmapY.Size = new System.Drawing.Size(43, 22);
            this.InputBitmapY.TabIndex = 42;
            this.InputBitmapY.Text = "0";
            this.InputBitmapY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputBitmapX
            // 
            this.InputBitmapX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InputBitmapX.Location = new System.Drawing.Point(64, 23);
            this.InputBitmapX.Margin = new System.Windows.Forms.Padding(4);
            this.InputBitmapX.Name = "InputBitmapX";
            this.InputBitmapX.Size = new System.Drawing.Size(43, 22);
            this.InputBitmapX.TabIndex = 41;
            this.InputBitmapX.Text = "0";
            this.InputBitmapX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BitmapScrollBlinking);
            this.groupBox2.Controls.Add(this.BitmapScrollDirection);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.BitmapScrollY);
            this.groupBox2.Controls.Add(this.BitmapScrollX);
            this.groupBox2.Controls.Add(this.BitmapShow);
            this.groupBox2.Location = new System.Drawing.Point(356, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 62);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kind of placing the bitmap";
            // 
            // BitmapScrollBlinking
            // 
            this.BitmapScrollBlinking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapScrollBlinking.DropDownWidth = 100;
            this.BitmapScrollBlinking.FormattingEnabled = true;
            this.BitmapScrollBlinking.Items.AddRange(new object[] {
            "Blink OFF",
            "BLINK"});
            this.BitmapScrollBlinking.Location = new System.Drawing.Point(183, 35);
            this.BitmapScrollBlinking.Name = "BitmapScrollBlinking";
            this.BitmapScrollBlinking.Size = new System.Drawing.Size(79, 24);
            this.BitmapScrollBlinking.TabIndex = 5;
            // 
            // BitmapScrollDirection
            // 
            this.BitmapScrollDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapScrollDirection.DropDownWidth = 100;
            this.BitmapScrollDirection.FormattingEnabled = true;
            this.BitmapScrollDirection.Items.AddRange(new object[] {
            "LEFT | UP",
            "RIGHT | DOWN"});
            this.BitmapScrollDirection.Location = new System.Drawing.Point(103, 35);
            this.BitmapScrollDirection.Name = "BitmapScrollDirection";
            this.BitmapScrollDirection.Size = new System.Drawing.Size(79, 24);
            this.BitmapScrollDirection.TabIndex = 4;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 40);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(103, 17);
            this.label50.TabIndex = 3;
            this.label50.Text = "Scroll Direction";
            // 
            // BitmapScrollY
            // 
            this.BitmapScrollY.AutoSize = true;
            this.BitmapScrollY.Location = new System.Drawing.Point(183, 18);
            this.BitmapScrollY.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapScrollY.Name = "BitmapScrollY";
            this.BitmapScrollY.Size = new System.Drawing.Size(77, 21);
            this.BitmapScrollY.TabIndex = 2;
            this.BitmapScrollY.Text = "Scroll Y";
            this.BitmapScrollY.UseVisualStyleBackColor = true;
            // 
            // BitmapScrollX
            // 
            this.BitmapScrollX.AutoSize = true;
            this.BitmapScrollX.Location = new System.Drawing.Point(91, 18);
            this.BitmapScrollX.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapScrollX.Name = "BitmapScrollX";
            this.BitmapScrollX.Size = new System.Drawing.Size(77, 21);
            this.BitmapScrollX.TabIndex = 1;
            this.BitmapScrollX.Text = "Scroll X";
            this.BitmapScrollX.UseVisualStyleBackColor = true;
            // 
            // BitmapShow
            // 
            this.BitmapShow.AutoSize = true;
            this.BitmapShow.Checked = true;
            this.BitmapShow.Location = new System.Drawing.Point(13, 18);
            this.BitmapShow.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapShow.Name = "BitmapShow";
            this.BitmapShow.Size = new System.Drawing.Size(63, 21);
            this.BitmapShow.TabIndex = 0;
            this.BitmapShow.TabStop = true;
            this.BitmapShow.Text = "Show";
            this.BitmapShow.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BitmapColor15);
            this.groupBox3.Controls.Add(this.cl15label);
            this.groupBox3.Controls.Add(this.BitmapColor14);
            this.groupBox3.Controls.Add(this.cl14label);
            this.groupBox3.Controls.Add(this.BitmapColor11);
            this.groupBox3.Controls.Add(this.cl11label);
            this.groupBox3.Controls.Add(this.BitmapColor10);
            this.groupBox3.Controls.Add(this.cl10label);
            this.groupBox3.Controls.Add(this.BitmapColor12);
            this.groupBox3.Controls.Add(this.cl12label);
            this.groupBox3.Controls.Add(this.BitmapColor13);
            this.groupBox3.Controls.Add(this.cl13label);
            this.groupBox3.Controls.Add(this.BitmapColor8);
            this.groupBox3.Controls.Add(this.cl8label);
            this.groupBox3.Controls.Add(this.BitmapColor7);
            this.groupBox3.Controls.Add(this.cl7label);
            this.groupBox3.Controls.Add(this.BitmapColor9);
            this.groupBox3.Controls.Add(this.cl9label);
            this.groupBox3.Controls.Add(this.BitmapColor6);
            this.groupBox3.Controls.Add(this.cl6label);
            this.groupBox3.Controls.Add(this.BitmapColor5);
            this.groupBox3.Controls.Add(this.cl5label);
            this.groupBox3.Controls.Add(this.BitmapColor3);
            this.groupBox3.Controls.Add(this.cl3label);
            this.groupBox3.Controls.Add(this.BitmapColor2);
            this.groupBox3.Controls.Add(this.cl2label);
            this.groupBox3.Controls.Add(this.BitmapColor4);
            this.groupBox3.Controls.Add(this.cl4label);
            this.groupBox3.Controls.Add(this.BitmapColor1);
            this.groupBox3.Controls.Add(this.cl1label);
            this.groupBox3.Controls.Add(this.BitmapColor0);
            this.groupBox3.Controls.Add(this.cl0label);
            this.groupBox3.Location = new System.Drawing.Point(11, 75);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(613, 151);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose the colors of the bitmap";
            // 
            // BitmapColor15
            // 
            this.BitmapColor15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor15.DropDownWidth = 250;
            this.BitmapColor15.FormattingEnabled = true;
            this.BitmapColor15.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor15.Location = new System.Drawing.Point(505, 121);
            this.BitmapColor15.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor15.Name = "BitmapColor15";
            this.BitmapColor15.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor15.TabIndex = 39;
            // 
            // cl15label
            // 
            this.cl15label.AutoSize = true;
            this.cl15label.BackColor = System.Drawing.SystemColors.Control;
            this.cl15label.ForeColor = System.Drawing.Color.White;
            this.cl15label.Location = new System.Drawing.Point(447, 126);
            this.cl15label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl15label.Name = "cl15label";
            this.cl15label.Size = new System.Drawing.Size(61, 17);
            this.cl15label.TabIndex = 38;
            this.cl15label.Text = "Color 15";
            // 
            // BitmapColor14
            // 
            this.BitmapColor14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor14.DropDownWidth = 250;
            this.BitmapColor14.FormattingEnabled = true;
            this.BitmapColor14.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor14.Location = new System.Drawing.Point(361, 121);
            this.BitmapColor14.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor14.Name = "BitmapColor14";
            this.BitmapColor14.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor14.TabIndex = 37;
            // 
            // cl14label
            // 
            this.cl14label.AutoSize = true;
            this.cl14label.BackColor = System.Drawing.SystemColors.Control;
            this.cl14label.ForeColor = System.Drawing.Color.White;
            this.cl14label.Location = new System.Drawing.Point(299, 126);
            this.cl14label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl14label.Name = "cl14label";
            this.cl14label.Size = new System.Drawing.Size(61, 17);
            this.cl14label.TabIndex = 36;
            this.cl14label.Text = "Color 14";
            // 
            // BitmapColor11
            // 
            this.BitmapColor11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor11.DropDownWidth = 250;
            this.BitmapColor11.FormattingEnabled = true;
            this.BitmapColor11.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor11.Location = new System.Drawing.Point(505, 89);
            this.BitmapColor11.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor11.Name = "BitmapColor11";
            this.BitmapColor11.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor11.TabIndex = 35;
            // 
            // cl11label
            // 
            this.cl11label.AutoSize = true;
            this.cl11label.BackColor = System.Drawing.SystemColors.Control;
            this.cl11label.ForeColor = System.Drawing.Color.White;
            this.cl11label.Location = new System.Drawing.Point(447, 94);
            this.cl11label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl11label.MaximumSize = new System.Drawing.Size(93, 0);
            this.cl11label.Name = "cl11label";
            this.cl11label.Size = new System.Drawing.Size(61, 17);
            this.cl11label.TabIndex = 34;
            this.cl11label.Text = "Color 11";
            this.cl11label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BitmapColor10
            // 
            this.BitmapColor10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor10.DropDownWidth = 250;
            this.BitmapColor10.FormattingEnabled = true;
            this.BitmapColor10.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor10.Location = new System.Drawing.Point(361, 89);
            this.BitmapColor10.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor10.Name = "BitmapColor10";
            this.BitmapColor10.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor10.TabIndex = 33;
            // 
            // cl10label
            // 
            this.cl10label.AutoSize = true;
            this.cl10label.BackColor = System.Drawing.SystemColors.Control;
            this.cl10label.ForeColor = System.Drawing.Color.White;
            this.cl10label.Location = new System.Drawing.Point(299, 94);
            this.cl10label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl10label.Name = "cl10label";
            this.cl10label.Size = new System.Drawing.Size(61, 17);
            this.cl10label.TabIndex = 32;
            this.cl10label.Text = "Color 10";
            // 
            // BitmapColor12
            // 
            this.BitmapColor12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor12.DropDownWidth = 250;
            this.BitmapColor12.FormattingEnabled = true;
            this.BitmapColor12.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor12.Location = new System.Drawing.Point(69, 122);
            this.BitmapColor12.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor12.Name = "BitmapColor12";
            this.BitmapColor12.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor12.TabIndex = 31;
            // 
            // cl12label
            // 
            this.cl12label.AutoSize = true;
            this.cl12label.BackColor = System.Drawing.SystemColors.Control;
            this.cl12label.ForeColor = System.Drawing.Color.White;
            this.cl12label.Location = new System.Drawing.Point(13, 127);
            this.cl12label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl12label.MaximumSize = new System.Drawing.Size(93, 0);
            this.cl12label.Name = "cl12label";
            this.cl12label.Size = new System.Drawing.Size(61, 17);
            this.cl12label.TabIndex = 30;
            this.cl12label.Text = "Color 12";
            this.cl12label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BitmapColor13
            // 
            this.BitmapColor13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor13.DropDownWidth = 250;
            this.BitmapColor13.FormattingEnabled = true;
            this.BitmapColor13.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor13.Location = new System.Drawing.Point(213, 122);
            this.BitmapColor13.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor13.Name = "BitmapColor13";
            this.BitmapColor13.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor13.TabIndex = 29;
            // 
            // cl13label
            // 
            this.cl13label.AutoSize = true;
            this.cl13label.BackColor = System.Drawing.SystemColors.Control;
            this.cl13label.ForeColor = System.Drawing.Color.White;
            this.cl13label.Location = new System.Drawing.Point(155, 127);
            this.cl13label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl13label.Name = "cl13label";
            this.cl13label.Size = new System.Drawing.Size(61, 17);
            this.cl13label.TabIndex = 28;
            this.cl13label.Text = "Color 13";
            // 
            // BitmapColor8
            // 
            this.BitmapColor8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor8.DropDownWidth = 250;
            this.BitmapColor8.FormattingEnabled = true;
            this.BitmapColor8.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor8.Location = new System.Drawing.Point(69, 87);
            this.BitmapColor8.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor8.Name = "BitmapColor8";
            this.BitmapColor8.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor8.TabIndex = 27;
            // 
            // cl8label
            // 
            this.cl8label.AutoSize = true;
            this.cl8label.BackColor = System.Drawing.SystemColors.Control;
            this.cl8label.ForeColor = System.Drawing.Color.White;
            this.cl8label.Location = new System.Drawing.Point(13, 92);
            this.cl8label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl8label.MaximumSize = new System.Drawing.Size(93, 0);
            this.cl8label.Name = "cl8label";
            this.cl8label.Size = new System.Drawing.Size(53, 17);
            this.cl8label.TabIndex = 26;
            this.cl8label.Text = "Color 8";
            this.cl8label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BitmapColor7
            // 
            this.BitmapColor7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor7.DropDownWidth = 250;
            this.BitmapColor7.FormattingEnabled = true;
            this.BitmapColor7.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor7.Location = new System.Drawing.Point(505, 54);
            this.BitmapColor7.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor7.Name = "BitmapColor7";
            this.BitmapColor7.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor7.TabIndex = 25;
            // 
            // cl7label
            // 
            this.cl7label.AutoSize = true;
            this.cl7label.BackColor = System.Drawing.SystemColors.Control;
            this.cl7label.ForeColor = System.Drawing.Color.White;
            this.cl7label.Location = new System.Drawing.Point(447, 59);
            this.cl7label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl7label.Name = "cl7label";
            this.cl7label.Size = new System.Drawing.Size(53, 17);
            this.cl7label.TabIndex = 24;
            this.cl7label.Text = "Color 7";
            // 
            // BitmapColor9
            // 
            this.BitmapColor9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor9.DropDownWidth = 250;
            this.BitmapColor9.FormattingEnabled = true;
            this.BitmapColor9.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor9.Location = new System.Drawing.Point(213, 87);
            this.BitmapColor9.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor9.Name = "BitmapColor9";
            this.BitmapColor9.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor9.TabIndex = 23;
            // 
            // cl9label
            // 
            this.cl9label.AutoSize = true;
            this.cl9label.BackColor = System.Drawing.SystemColors.Control;
            this.cl9label.ForeColor = System.Drawing.Color.White;
            this.cl9label.Location = new System.Drawing.Point(155, 92);
            this.cl9label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl9label.Name = "cl9label";
            this.cl9label.Size = new System.Drawing.Size(53, 17);
            this.cl9label.TabIndex = 22;
            this.cl9label.Text = "Color 9";
            // 
            // BitmapColor6
            // 
            this.BitmapColor6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor6.DropDownWidth = 250;
            this.BitmapColor6.FormattingEnabled = true;
            this.BitmapColor6.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor6.Location = new System.Drawing.Point(361, 54);
            this.BitmapColor6.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor6.Name = "BitmapColor6";
            this.BitmapColor6.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor6.TabIndex = 21;
            // 
            // cl6label
            // 
            this.cl6label.AutoSize = true;
            this.cl6label.BackColor = System.Drawing.SystemColors.Control;
            this.cl6label.ForeColor = System.Drawing.Color.White;
            this.cl6label.Location = new System.Drawing.Point(299, 59);
            this.cl6label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl6label.Name = "cl6label";
            this.cl6label.Size = new System.Drawing.Size(53, 17);
            this.cl6label.TabIndex = 20;
            this.cl6label.Text = "Color 6";
            // 
            // BitmapColor5
            // 
            this.BitmapColor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor5.DropDownWidth = 250;
            this.BitmapColor5.FormattingEnabled = true;
            this.BitmapColor5.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor5.Location = new System.Drawing.Point(213, 54);
            this.BitmapColor5.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor5.Name = "BitmapColor5";
            this.BitmapColor5.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor5.TabIndex = 19;
            // 
            // cl5label
            // 
            this.cl5label.AutoSize = true;
            this.cl5label.BackColor = System.Drawing.SystemColors.Control;
            this.cl5label.ForeColor = System.Drawing.Color.White;
            this.cl5label.Location = new System.Drawing.Point(155, 59);
            this.cl5label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl5label.Name = "cl5label";
            this.cl5label.Size = new System.Drawing.Size(53, 17);
            this.cl5label.TabIndex = 18;
            this.cl5label.Text = "Color 5";
            // 
            // BitmapColor3
            // 
            this.BitmapColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor3.DropDownWidth = 250;
            this.BitmapColor3.FormattingEnabled = true;
            this.BitmapColor3.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor3.Location = new System.Drawing.Point(505, 22);
            this.BitmapColor3.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor3.Name = "BitmapColor3";
            this.BitmapColor3.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor3.TabIndex = 17;
            // 
            // cl3label
            // 
            this.cl3label.AutoSize = true;
            this.cl3label.BackColor = System.Drawing.SystemColors.Control;
            this.cl3label.ForeColor = System.Drawing.Color.White;
            this.cl3label.Location = new System.Drawing.Point(447, 27);
            this.cl3label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl3label.MaximumSize = new System.Drawing.Size(93, 0);
            this.cl3label.Name = "cl3label";
            this.cl3label.Size = new System.Drawing.Size(53, 17);
            this.cl3label.TabIndex = 16;
            this.cl3label.Text = "Color 3";
            this.cl3label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BitmapColor2
            // 
            this.BitmapColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor2.DropDownWidth = 250;
            this.BitmapColor2.FormattingEnabled = true;
            this.BitmapColor2.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor2.Location = new System.Drawing.Point(361, 22);
            this.BitmapColor2.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor2.Name = "BitmapColor2";
            this.BitmapColor2.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor2.TabIndex = 9;
            // 
            // cl2label
            // 
            this.cl2label.AutoSize = true;
            this.cl2label.BackColor = System.Drawing.SystemColors.Control;
            this.cl2label.ForeColor = System.Drawing.Color.White;
            this.cl2label.Location = new System.Drawing.Point(299, 27);
            this.cl2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl2label.Name = "cl2label";
            this.cl2label.Size = new System.Drawing.Size(57, 17);
            this.cl2label.TabIndex = 8;
            this.cl2label.Text = "Color  2";
            // 
            // BitmapColor4
            // 
            this.BitmapColor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor4.DropDownWidth = 250;
            this.BitmapColor4.FormattingEnabled = true;
            this.BitmapColor4.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor4.Location = new System.Drawing.Point(69, 53);
            this.BitmapColor4.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor4.Name = "BitmapColor4";
            this.BitmapColor4.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor4.TabIndex = 5;
            // 
            // cl4label
            // 
            this.cl4label.AutoSize = true;
            this.cl4label.BackColor = System.Drawing.SystemColors.Control;
            this.cl4label.ForeColor = System.Drawing.Color.White;
            this.cl4label.Location = new System.Drawing.Point(13, 58);
            this.cl4label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl4label.Name = "cl4label";
            this.cl4label.Size = new System.Drawing.Size(53, 17);
            this.cl4label.TabIndex = 4;
            this.cl4label.Text = "Color 4";
            // 
            // BitmapColor1
            // 
            this.BitmapColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor1.DropDownWidth = 250;
            this.BitmapColor1.FormattingEnabled = true;
            this.BitmapColor1.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor1.Location = new System.Drawing.Point(213, 22);
            this.BitmapColor1.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor1.Name = "BitmapColor1";
            this.BitmapColor1.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor1.TabIndex = 3;
            // 
            // cl1label
            // 
            this.cl1label.AutoSize = true;
            this.cl1label.BackColor = System.Drawing.SystemColors.Control;
            this.cl1label.ForeColor = System.Drawing.Color.White;
            this.cl1label.Location = new System.Drawing.Point(155, 27);
            this.cl1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl1label.Name = "cl1label";
            this.cl1label.Size = new System.Drawing.Size(53, 17);
            this.cl1label.TabIndex = 2;
            this.cl1label.Text = "Color 1";
            // 
            // BitmapColor0
            // 
            this.BitmapColor0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitmapColor0.DropDownWidth = 250;
            this.BitmapColor0.FormattingEnabled = true;
            this.BitmapColor0.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.BitmapColor0.Location = new System.Drawing.Point(69, 22);
            this.BitmapColor0.Margin = new System.Windows.Forms.Padding(4);
            this.BitmapColor0.Name = "BitmapColor0";
            this.BitmapColor0.Size = new System.Drawing.Size(79, 24);
            this.BitmapColor0.TabIndex = 1;
            // 
            // cl0label
            // 
            this.cl0label.AutoSize = true;
            this.cl0label.BackColor = System.Drawing.SystemColors.Control;
            this.cl0label.ForeColor = System.Drawing.Color.White;
            this.cl0label.Location = new System.Drawing.Point(13, 27);
            this.cl0label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cl0label.Name = "cl0label";
            this.cl0label.Size = new System.Drawing.Size(53, 17);
            this.cl0label.TabIndex = 0;
            this.cl0label.Text = "Color 0";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(630, 139);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(108, 17);
            this.label58.TabIndex = 69;
            this.label58.Text = "Bitmap Rotation";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(750, 139);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(116, 17);
            this.label57.TabIndex = 70;
            this.label57.Text = "Bitmap Flip Mode";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TestTextBitmap);
            this.tabPage2.Controls.Add(this.AddTextBitmapToScript);
            this.tabPage2.Controls.Add(this.InputStringTextBitmapControl);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TextBitmapFlipMode);
            this.tabPage2.Controls.Add(this.label56);
            this.tabPage2.Controls.Add(this.TextBitmapRotate);
            this.tabPage2.Controls.Add(this.TextBitmapSendFrame);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.TextBitmapBackColorLabel);
            this.tabPage2.Controls.Add(this.TextBitmapBackgroundColor);
            this.tabPage2.Controls.Add(this.TextBitmapFontColorLabel);
            this.tabPage2.Controls.Add(this.TextBitmapFrontColor);
            this.tabPage2.Controls.Add(this.SelectFont);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.InputStringTextBitmap);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(869, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Use Text as Bitmap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddTextBitmapToScript
            // 
            this.AddTextBitmapToScript.BackColor = System.Drawing.Color.Orange;
            this.AddTextBitmapToScript.Location = new System.Drawing.Point(749, 6);
            this.AddTextBitmapToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddTextBitmapToScript.Name = "AddTextBitmapToScript";
            this.AddTextBitmapToScript.Size = new System.Drawing.Size(113, 133);
            this.AddTextBitmapToScript.TabIndex = 59;
            this.AddTextBitmapToScript.Text = "Add Text as Bitmap to the Script";
            this.AddTextBitmapToScript.UseVisualStyleBackColor = false;
            this.AddTextBitmapToScript.Click += new System.EventHandler(this.AddTextBitmapToScript_Click);
            // 
            // InputStringTextBitmapControl
            // 
            this.InputStringTextBitmapControl.AutoSize = true;
            this.InputStringTextBitmapControl.ForeColor = System.Drawing.Color.Black;
            this.InputStringTextBitmapControl.Location = new System.Drawing.Point(11, 59);
            this.InputStringTextBitmapControl.Name = "InputStringTextBitmapControl";
            this.InputStringTextBitmapControl.Size = new System.Drawing.Size(0, 17);
            this.InputStringTextBitmapControl.TabIndex = 69;
            this.InputStringTextBitmapControl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Text Flip Mode";
            // 
            // TextBitmapFlipMode
            // 
            this.TextBitmapFlipMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapFlipMode.FormattingEnabled = true;
            this.TextBitmapFlipMode.Items.AddRange(new object[] {
            "No Flip",
            "Flip X",
            "Flip Y",
            "Flip XY"});
            this.TextBitmapFlipMode.Location = new System.Drawing.Point(748, 157);
            this.TextBitmapFlipMode.Name = "TextBitmapFlipMode";
            this.TextBitmapFlipMode.Size = new System.Drawing.Size(113, 24);
            this.TextBitmapFlipMode.TabIndex = 67;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(630, 139);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(92, 17);
            this.label56.TabIndex = 65;
            this.label56.Text = "Text Rotation";
            // 
            // TextBitmapRotate
            // 
            this.TextBitmapRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapRotate.FormattingEnabled = true;
            this.TextBitmapRotate.Items.AddRange(new object[] {
            "No Rotation",
            "Rotate 90°",
            "Rotate 180°",
            "Rotate 270°"});
            this.TextBitmapRotate.Location = new System.Drawing.Point(629, 157);
            this.TextBitmapRotate.Name = "TextBitmapRotate";
            this.TextBitmapRotate.Size = new System.Drawing.Size(113, 24);
            this.TextBitmapRotate.TabIndex = 64;
            // 
            // TextBitmapSendFrame
            // 
            this.TextBitmapSendFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapSendFrame.DropDownWidth = 250;
            this.TextBitmapSendFrame.FormattingEnabled = true;
            this.TextBitmapSendFrame.Items.AddRange(new object[] {
            "Draw Each Column",
            "Send Frame after Drawing the Bitmap",
            "Don\'t Send Frame"});
            this.TextBitmapSendFrame.Location = new System.Drawing.Point(672, 196);
            this.TextBitmapSendFrame.Name = "TextBitmapSendFrame";
            this.TextBitmapSendFrame.Size = new System.Drawing.Size(172, 24);
            this.TextBitmapSendFrame.TabIndex = 63;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(585, 199);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 17);
            this.label46.TabIndex = 62;
            this.label46.Text = "Send Frame";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.label30);
            this.groupBox12.Controls.Add(this.TextBitmapPictureErase);
            this.groupBox12.Controls.Add(this.TextBitmapNormal);
            this.groupBox12.Location = new System.Drawing.Point(303, 187);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(275, 36);
            this.groupBox12.TabIndex = 61;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Bitmap Mode";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.ForestGreen;
            this.label29.Font = new System.Drawing.Font("Wingdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label29.ForeColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(237, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 15);
            this.label29.TabIndex = 3;
            this.label29.Text = "(";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.ForestGreen;
            this.label30.Font = new System.Drawing.Font("Wingdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(90, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(22, 15);
            this.label30.TabIndex = 2;
            this.label30.Text = "(";
            // 
            // TextBitmapPictureErase
            // 
            this.TextBitmapPictureErase.AutoSize = true;
            this.TextBitmapPictureErase.Location = new System.Drawing.Point(121, 15);
            this.TextBitmapPictureErase.Name = "TextBitmapPictureErase";
            this.TextBitmapPictureErase.Size = new System.Drawing.Size(113, 21);
            this.TextBitmapPictureErase.TabIndex = 1;
            this.TextBitmapPictureErase.Text = "Bitmap Erase";
            this.TextBitmapPictureErase.UseVisualStyleBackColor = true;
            // 
            // TextBitmapNormal
            // 
            this.TextBitmapNormal.AutoSize = true;
            this.TextBitmapNormal.Checked = true;
            this.TextBitmapNormal.Location = new System.Drawing.Point(10, 15);
            this.TextBitmapNormal.Name = "TextBitmapNormal";
            this.TextBitmapNormal.Size = new System.Drawing.Size(74, 21);
            this.TextBitmapNormal.TabIndex = 0;
            this.TextBitmapNormal.TabStop = true;
            this.TextBitmapNormal.Text = "Normal";
            this.TextBitmapNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label31);
            this.groupBox13.Controls.Add(this.label32);
            this.groupBox13.Controls.Add(this.TextBitmapTransparent);
            this.groupBox13.Controls.Add(this.TextBitmapBlack);
            this.groupBox13.Location = new System.Drawing.Point(14, 187);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(275, 36);
            this.groupBox13.TabIndex = 60;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Transparency";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Webdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(241, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 20);
            this.label31.TabIndex = 3;
            this.label31.Text = "Y";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Font = new System.Drawing.Font("Webdings", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(74, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "Y";
            // 
            // TextBitmapTransparent
            // 
            this.TextBitmapTransparent.AutoSize = true;
            this.TextBitmapTransparent.Checked = true;
            this.TextBitmapTransparent.Location = new System.Drawing.Point(133, 15);
            this.TextBitmapTransparent.Name = "TextBitmapTransparent";
            this.TextBitmapTransparent.Size = new System.Drawing.Size(111, 21);
            this.TextBitmapTransparent.TabIndex = 1;
            this.TextBitmapTransparent.TabStop = true;
            this.TextBitmapTransparent.Text = "Transparent ";
            this.TextBitmapTransparent.UseVisualStyleBackColor = true;
            // 
            // TextBitmapBlack
            // 
            this.TextBitmapBlack.AutoSize = true;
            this.TextBitmapBlack.Location = new System.Drawing.Point(10, 15);
            this.TextBitmapBlack.Name = "TextBitmapBlack";
            this.TextBitmapBlack.Size = new System.Drawing.Size(63, 21);
            this.TextBitmapBlack.TabIndex = 0;
            this.TextBitmapBlack.Text = "Black";
            this.TextBitmapBlack.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.TextBitmapScrollBlinking);
            this.groupBox6.Controls.Add(this.TextBitmapScrollDirection);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.TextBitmapShow);
            this.groupBox6.Controls.Add(this.TextBitmapScrollY);
            this.groupBox6.Controls.Add(this.TextBitmapScrollX);
            this.groupBox6.Location = new System.Drawing.Point(351, 121);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(267, 62);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kind of placing the text";
            // 
            // TextBitmapScrollBlinking
            // 
            this.TextBitmapScrollBlinking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapScrollBlinking.DropDownWidth = 100;
            this.TextBitmapScrollBlinking.FormattingEnabled = true;
            this.TextBitmapScrollBlinking.Items.AddRange(new object[] {
            "Blink OFF",
            "BLINK"});
            this.TextBitmapScrollBlinking.Location = new System.Drawing.Point(183, 35);
            this.TextBitmapScrollBlinking.Name = "TextBitmapScrollBlinking";
            this.TextBitmapScrollBlinking.Size = new System.Drawing.Size(79, 24);
            this.TextBitmapScrollBlinking.TabIndex = 7;
            // 
            // TextBitmapScrollDirection
            // 
            this.TextBitmapScrollDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapScrollDirection.FormattingEnabled = true;
            this.TextBitmapScrollDirection.Items.AddRange(new object[] {
            "LEFT | UP",
            "RIGHT | DOWN"});
            this.TextBitmapScrollDirection.Location = new System.Drawing.Point(103, 35);
            this.TextBitmapScrollDirection.Name = "TextBitmapScrollDirection";
            this.TextBitmapScrollDirection.Size = new System.Drawing.Size(79, 24);
            this.TextBitmapScrollDirection.TabIndex = 6;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(3, 40);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(103, 17);
            this.label53.TabIndex = 5;
            this.label53.Text = "Scroll Direction";
            // 
            // TextBitmapShow
            // 
            this.TextBitmapShow.AutoSize = true;
            this.TextBitmapShow.Checked = true;
            this.TextBitmapShow.Location = new System.Drawing.Point(13, 17);
            this.TextBitmapShow.Margin = new System.Windows.Forms.Padding(4);
            this.TextBitmapShow.Name = "TextBitmapShow";
            this.TextBitmapShow.Size = new System.Drawing.Size(63, 21);
            this.TextBitmapShow.TabIndex = 3;
            this.TextBitmapShow.TabStop = true;
            this.TextBitmapShow.Text = "Show";
            this.TextBitmapShow.UseVisualStyleBackColor = true;
            // 
            // TextBitmapScrollY
            // 
            this.TextBitmapScrollY.AutoSize = true;
            this.TextBitmapScrollY.Location = new System.Drawing.Point(183, 18);
            this.TextBitmapScrollY.Margin = new System.Windows.Forms.Padding(4);
            this.TextBitmapScrollY.Name = "TextBitmapScrollY";
            this.TextBitmapScrollY.Size = new System.Drawing.Size(77, 21);
            this.TextBitmapScrollY.TabIndex = 2;
            this.TextBitmapScrollY.Text = "Scroll Y";
            this.TextBitmapScrollY.UseVisualStyleBackColor = true;
            // 
            // TextBitmapScrollX
            // 
            this.TextBitmapScrollX.AutoSize = true;
            this.TextBitmapScrollX.Location = new System.Drawing.Point(91, 18);
            this.TextBitmapScrollX.Margin = new System.Windows.Forms.Padding(4);
            this.TextBitmapScrollX.Name = "TextBitmapScrollX";
            this.TextBitmapScrollX.Size = new System.Drawing.Size(77, 21);
            this.TextBitmapScrollX.TabIndex = 1;
            this.TextBitmapScrollX.Text = "Scroll X";
            this.TextBitmapScrollX.UseVisualStyleBackColor = true;
            // 
            // TextBitmapBackColorLabel
            // 
            this.TextBitmapBackColorLabel.AutoSize = true;
            this.TextBitmapBackColorLabel.Location = new System.Drawing.Point(395, 68);
            this.TextBitmapBackColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBitmapBackColorLabel.Name = "TextBitmapBackColorLabel";
            this.TextBitmapBackColorLabel.Size = new System.Drawing.Size(186, 17);
            this.TextBitmapBackColorLabel.TabIndex = 57;
            this.TextBitmapBackColorLabel.Text = "Select the Background color";
            // 
            // TextBitmapBackgroundColor
            // 
            this.TextBitmapBackgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapBackgroundColor.DropDownWidth = 250;
            this.TextBitmapBackgroundColor.FormattingEnabled = true;
            this.TextBitmapBackgroundColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.TextBitmapBackgroundColor.Location = new System.Drawing.Point(395, 86);
            this.TextBitmapBackgroundColor.Margin = new System.Windows.Forms.Padding(4);
            this.TextBitmapBackgroundColor.Name = "TextBitmapBackgroundColor";
            this.TextBitmapBackgroundColor.Size = new System.Drawing.Size(199, 24);
            this.TextBitmapBackgroundColor.TabIndex = 56;
            this.TextBitmapBackgroundColor.SelectedIndexChanged += new System.EventHandler(this.TextBitmapBackgroundColor_SelectedIndexChanged);
            // 
            // TextBitmapFontColorLabel
            // 
            this.TextBitmapFontColorLabel.AutoSize = true;
            this.TextBitmapFontColorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBitmapFontColorLabel.Location = new System.Drawing.Point(176, 68);
            this.TextBitmapFontColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBitmapFontColorLabel.Name = "TextBitmapFontColorLabel";
            this.TextBitmapFontColorLabel.Size = new System.Drawing.Size(138, 17);
            this.TextBitmapFontColorLabel.TabIndex = 55;
            this.TextBitmapFontColorLabel.Text = "Select the Font color";
            // 
            // TextBitmapFrontColor
            // 
            this.TextBitmapFrontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBitmapFrontColor.DropDownWidth = 250;
            this.TextBitmapFrontColor.FormattingEnabled = true;
            this.TextBitmapFrontColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "RANDOMCOLUMNCOLOR",
            "RANDOMLINECOLOR",
            "RANDOMREDGREENMULTICOLOR",
            "MULTICOLOR",
            "RANDOMREDORANGEMULTICOLOR"});
            this.TextBitmapFrontColor.Location = new System.Drawing.Point(176, 86);
            this.TextBitmapFrontColor.Margin = new System.Windows.Forms.Padding(4);
            this.TextBitmapFrontColor.Name = "TextBitmapFrontColor";
            this.TextBitmapFrontColor.Size = new System.Drawing.Size(199, 24);
            this.TextBitmapFrontColor.TabIndex = 54;
            this.TextBitmapFrontColor.SelectedIndexChanged += new System.EventHandler(this.TextBitmapFrontColor_SelectedIndexChanged);
            // 
            // SelectFont
            // 
            this.SelectFont.BackColor = System.Drawing.Color.Green;
            this.SelectFont.ForeColor = System.Drawing.Color.White;
            this.SelectFont.Location = new System.Drawing.Point(12, 82);
            this.SelectFont.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFont.Name = "SelectFont";
            this.SelectFont.Size = new System.Drawing.Size(136, 32);
            this.SelectFont.TabIndex = 53;
            this.SelectFont.Text = "Select Font";
            this.SelectFont.UseVisualStyleBackColor = false;
            this.SelectFont.Click += new System.EventHandler(this.SelectFont_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 6);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "Input Text";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Blue;
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.InputTextBitmapDelay);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.InputTextBitmapY);
            this.groupBox5.Controls.Add(this.InputTextBitmapX);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 121);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(333, 62);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Co-ordinates of the Text as Bitmap";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Delay";
            // 
            // InputTextBitmapDelay
            // 
            this.InputTextBitmapDelay.Location = new System.Drawing.Point(276, 18);
            this.InputTextBitmapDelay.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBitmapDelay.Name = "InputTextBitmapDelay";
            this.InputTextBitmapDelay.Size = new System.Drawing.Size(43, 22);
            this.InputTextBitmapDelay.TabIndex = 45;
            this.InputTextBitmapDelay.Text = "0";
            this.InputTextBitmapDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Input Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Input X";
            // 
            // InputTextBitmapY
            // 
            this.InputTextBitmapY.Location = new System.Drawing.Point(180, 18);
            this.InputTextBitmapY.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBitmapY.Name = "InputTextBitmapY";
            this.InputTextBitmapY.Size = new System.Drawing.Size(43, 22);
            this.InputTextBitmapY.TabIndex = 42;
            this.InputTextBitmapY.Text = "0";
            this.InputTextBitmapY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputTextBitmapX
            // 
            this.InputTextBitmapX.Location = new System.Drawing.Point(65, 18);
            this.InputTextBitmapX.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBitmapX.Name = "InputTextBitmapX";
            this.InputTextBitmapX.Size = new System.Drawing.Size(43, 22);
            this.InputTextBitmapX.TabIndex = 41;
            this.InputTextBitmapX.Text = "0";
            this.InputTextBitmapX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputStringTextBitmap
            // 
            this.InputStringTextBitmap.AllowDrop = true;
            this.InputStringTextBitmap.Font = new System.Drawing.Font("Arial", 8F);
            this.InputStringTextBitmap.ForeColor = System.Drawing.Color.Black;
            this.InputStringTextBitmap.Location = new System.Drawing.Point(12, 26);
            this.InputStringTextBitmap.Margin = new System.Windows.Forms.Padding(4);
            this.InputStringTextBitmap.MaximumSize = new System.Drawing.Size(447, 30);
            this.InputStringTextBitmap.Name = "InputStringTextBitmap";
            this.InputStringTextBitmap.Size = new System.Drawing.Size(447, 23);
            this.InputStringTextBitmap.TabIndex = 52;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DrawSendFrame);
            this.tabPage5.Controls.Add(this.label49);
            this.tabPage5.Controls.Add(this.AddDrawingsToScript);
            this.tabPage5.Controls.Add(this.label36);
            this.tabPage5.Controls.Add(this.TestDrawings);
            this.tabPage5.Controls.Add(this.DrawColor);
            this.tabPage5.Controls.Add(this.groupBox20);
            this.tabPage5.Controls.Add(this.groupBox19);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(869, 283);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Draw";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DrawSendFrame
            // 
            this.DrawSendFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawSendFrame.DropDownWidth = 250;
            this.DrawSendFrame.FormattingEnabled = true;
            this.DrawSendFrame.Items.AddRange(new object[] {
            "Not Applicable",
            "Send Frame after Drawing",
            "Don\'t Send Frame"});
            this.DrawSendFrame.Location = new System.Drawing.Point(691, 237);
            this.DrawSendFrame.Name = "DrawSendFrame";
            this.DrawSendFrame.Size = new System.Drawing.Size(172, 24);
            this.DrawSendFrame.TabIndex = 73;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(604, 240);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(85, 17);
            this.label49.TabIndex = 72;
            this.label49.Text = "Send Frame";
            // 
            // AddDrawingsToScript
            // 
            this.AddDrawingsToScript.BackColor = System.Drawing.Color.Orange;
            this.AddDrawingsToScript.Location = new System.Drawing.Point(749, 6);
            this.AddDrawingsToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddDrawingsToScript.Name = "AddDrawingsToScript";
            this.AddDrawingsToScript.Size = new System.Drawing.Size(113, 133);
            this.AddDrawingsToScript.TabIndex = 68;
            this.AddDrawingsToScript.Text = "Add Drawings to the Script";
            this.AddDrawingsToScript.UseVisualStyleBackColor = false;
            this.AddDrawingsToScript.Click += new System.EventHandler(this.AddDrawingsToScript_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(394, 215);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(142, 17);
            this.label36.TabIndex = 63;
            this.label36.Text = "Select the Draw color";
            // 
            // TestDrawings
            // 
            this.TestDrawings.BackColor = System.Drawing.Color.Red;
            this.TestDrawings.ForeColor = System.Drawing.Color.White;
            this.TestDrawings.Location = new System.Drawing.Point(629, 6);
            this.TestDrawings.Margin = new System.Windows.Forms.Padding(4);
            this.TestDrawings.Name = "TestDrawings";
            this.TestDrawings.Size = new System.Drawing.Size(113, 65);
            this.TestDrawings.TabIndex = 67;
            this.TestDrawings.Text = "Test Drawings";
            this.TestDrawings.UseVisualStyleBackColor = false;
            this.TestDrawings.Click += new System.EventHandler(this.TestDrawings_Click);
            // 
            // DrawColor
            // 
            this.DrawColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawColor.DropDownWidth = 250;
            this.DrawColor.FormattingEnabled = true;
            this.DrawColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "MULTICOLOR"});
            this.DrawColor.Location = new System.Drawing.Point(394, 237);
            this.DrawColor.Margin = new System.Windows.Forms.Padding(4);
            this.DrawColor.Name = "DrawColor";
            this.DrawColor.Size = new System.Drawing.Size(199, 24);
            this.DrawColor.TabIndex = 62;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.DrawPlot);
            this.groupBox20.Controls.Add(this.DrawFill);
            this.groupBox20.Controls.Add(this.label42);
            this.groupBox20.Controls.Add(this.label43);
            this.groupBox20.Controls.Add(this.InputDrawBezierThirdY);
            this.groupBox20.Controls.Add(this.InputDrawBezierThirdX);
            this.groupBox20.Controls.Add(this.label40);
            this.groupBox20.Controls.Add(this.label41);
            this.groupBox20.Controls.Add(this.InputDrawBezierSecondY);
            this.groupBox20.Controls.Add(this.InputDrawBezierSecondX);
            this.groupBox20.Controls.Add(this.DrawBezier);
            this.groupBox20.Controls.Add(this.label39);
            this.groupBox20.Controls.Add(this.InputDrawCircleRadius);
            this.groupBox20.Controls.Add(this.DrawCircle);
            this.groupBox20.Controls.Add(this.groupBox21);
            this.groupBox20.Controls.Add(this.DrawEllipse);
            this.groupBox20.Controls.Add(this.DrawRectangle);
            this.groupBox20.Controls.Add(this.DrawLine);
            this.groupBox20.Location = new System.Drawing.Point(12, 3);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(717, 201);
            this.groupBox20.TabIndex = 45;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Type of Drawing";
            // 
            // DrawPlot
            // 
            this.DrawPlot.AutoSize = true;
            this.DrawPlot.Location = new System.Drawing.Point(14, 20);
            this.DrawPlot.Name = "DrawPlot";
            this.DrawPlot.Size = new System.Drawing.Size(61, 21);
            this.DrawPlot.TabIndex = 60;
            this.DrawPlot.Text = "Plot .";
            this.DrawPlot.UseVisualStyleBackColor = true;
            // 
            // DrawFill
            // 
            this.DrawFill.AutoSize = true;
            this.DrawFill.Location = new System.Drawing.Point(14, 176);
            this.DrawFill.Name = "DrawFill";
            this.DrawFill.Size = new System.Drawing.Size(59, 21);
            this.DrawFill.TabIndex = 59;
            this.DrawFill.Text = "Fill █";
            this.DrawFill.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(570, 149);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 17);
            this.label42.TabIndex = 58;
            this.label42.Text = "Input Third Y";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(429, 149);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 17);
            this.label43.TabIndex = 57;
            this.label43.Text = "Input Third X";
            // 
            // InputDrawBezierThirdY
            // 
            this.InputDrawBezierThirdY.Location = new System.Drawing.Point(660, 146);
            this.InputDrawBezierThirdY.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawBezierThirdY.Name = "InputDrawBezierThirdY";
            this.InputDrawBezierThirdY.Size = new System.Drawing.Size(43, 22);
            this.InputDrawBezierThirdY.TabIndex = 56;
            this.InputDrawBezierThirdY.Text = "0";
            this.InputDrawBezierThirdY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputDrawBezierThirdX
            // 
            this.InputDrawBezierThirdX.Location = new System.Drawing.Point(514, 146);
            this.InputDrawBezierThirdX.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawBezierThirdX.Name = "InputDrawBezierThirdX";
            this.InputDrawBezierThirdX.Size = new System.Drawing.Size(43, 22);
            this.InputDrawBezierThirdX.TabIndex = 55;
            this.InputDrawBezierThirdX.Text = "0";
            this.InputDrawBezierThirdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(279, 150);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(104, 17);
            this.label40.TabIndex = 54;
            this.label40.Text = "Input Second Y";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(134, 150);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(104, 17);
            this.label41.TabIndex = 53;
            this.label41.Text = "Input Second X";
            // 
            // InputDrawBezierSecondY
            // 
            this.InputDrawBezierSecondY.Location = new System.Drawing.Point(381, 147);
            this.InputDrawBezierSecondY.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawBezierSecondY.Name = "InputDrawBezierSecondY";
            this.InputDrawBezierSecondY.Size = new System.Drawing.Size(43, 22);
            this.InputDrawBezierSecondY.TabIndex = 52;
            this.InputDrawBezierSecondY.Text = "0";
            this.InputDrawBezierSecondY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputDrawBezierSecondX
            // 
            this.InputDrawBezierSecondX.Location = new System.Drawing.Point(232, 147);
            this.InputDrawBezierSecondX.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawBezierSecondX.Name = "InputDrawBezierSecondX";
            this.InputDrawBezierSecondX.Size = new System.Drawing.Size(43, 22);
            this.InputDrawBezierSecondX.TabIndex = 51;
            this.InputDrawBezierSecondX.Text = "0";
            this.InputDrawBezierSecondX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DrawBezier
            // 
            this.DrawBezier.AutoSize = true;
            this.DrawBezier.Location = new System.Drawing.Point(14, 150);
            this.DrawBezier.Name = "DrawBezier";
            this.DrawBezier.Size = new System.Drawing.Size(87, 21);
            this.DrawBezier.TabIndex = 50;
            this.DrawBezier.Text = "Bezier ⌘";
            this.DrawBezier.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(134, 122);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(142, 17);
            this.label39.TabIndex = 49;
            this.label39.Text = "Input Radius of Circle";
            // 
            // InputDrawCircleRadius
            // 
            this.InputDrawCircleRadius.Location = new System.Drawing.Point(275, 121);
            this.InputDrawCircleRadius.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawCircleRadius.Name = "InputDrawCircleRadius";
            this.InputDrawCircleRadius.Size = new System.Drawing.Size(43, 22);
            this.InputDrawCircleRadius.TabIndex = 48;
            this.InputDrawCircleRadius.Text = "0";
            this.InputDrawCircleRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DrawCircle
            // 
            this.DrawCircle.AutoSize = true;
            this.DrawCircle.Location = new System.Drawing.Point(14, 124);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(82, 21);
            this.DrawCircle.TabIndex = 4;
            this.DrawCircle.Text = "Circle ◯";
            this.DrawCircle.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.label38);
            this.groupBox21.Controls.Add(this.InputDrawSecondY);
            this.groupBox21.Controls.Add(this.InputDrawSecondX);
            this.groupBox21.Location = new System.Drawing.Point(124, 36);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(320, 77);
            this.groupBox21.TabIndex = 3;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Second Co-ordinates for Line, Rectangle and Ellipse";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(158, 40);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(104, 17);
            this.label37.TabIndex = 48;
            this.label37.Text = "Input Second Y";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 40);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(104, 17);
            this.label38.TabIndex = 47;
            this.label38.Text = "Input Second X";
            // 
            // InputDrawSecondY
            // 
            this.InputDrawSecondY.Location = new System.Drawing.Point(260, 37);
            this.InputDrawSecondY.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawSecondY.Name = "InputDrawSecondY";
            this.InputDrawSecondY.Size = new System.Drawing.Size(43, 22);
            this.InputDrawSecondY.TabIndex = 46;
            this.InputDrawSecondY.Text = "0";
            this.InputDrawSecondY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputDrawSecondX
            // 
            this.InputDrawSecondX.Location = new System.Drawing.Point(111, 37);
            this.InputDrawSecondX.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawSecondX.Name = "InputDrawSecondX";
            this.InputDrawSecondX.Size = new System.Drawing.Size(43, 22);
            this.InputDrawSecondX.TabIndex = 45;
            this.InputDrawSecondX.Text = "0";
            this.InputDrawSecondX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DrawEllipse
            // 
            this.DrawEllipse.AutoSize = true;
            this.DrawEllipse.Location = new System.Drawing.Point(14, 98);
            this.DrawEllipse.Name = "DrawEllipse";
            this.DrawEllipse.Size = new System.Drawing.Size(88, 21);
            this.DrawEllipse.TabIndex = 2;
            this.DrawEllipse.Text = "Ellipse ↂ";
            this.DrawEllipse.UseVisualStyleBackColor = true;
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.AutoSize = true;
            this.DrawRectangle.Location = new System.Drawing.Point(14, 72);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(105, 21);
            this.DrawRectangle.TabIndex = 1;
            this.DrawRectangle.Text = "Rectangle □";
            this.DrawRectangle.UseVisualStyleBackColor = true;
            // 
            // DrawLine
            // 
            this.DrawLine.AutoSize = true;
            this.DrawLine.Checked = true;
            this.DrawLine.Location = new System.Drawing.Point(14, 46);
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(66, 21);
            this.DrawLine.TabIndex = 0;
            this.DrawLine.TabStop = true;
            this.DrawLine.Text = "Line  ⁄";
            this.DrawLine.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.Blue;
            this.groupBox19.Controls.Add(this.label9);
            this.groupBox19.Controls.Add(this.InputDrawDelay);
            this.groupBox19.Controls.Add(this.label34);
            this.groupBox19.Controls.Add(this.InputDrawY);
            this.groupBox19.Controls.Add(this.InputDrawX);
            this.groupBox19.Controls.Add(this.label35);
            this.groupBox19.ForeColor = System.Drawing.Color.White;
            this.groupBox19.Location = new System.Drawing.Point(11, 211);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox19.Size = new System.Drawing.Size(371, 62);
            this.groupBox19.TabIndex = 44;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Co-ordinates of Drawing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Delay";
            // 
            // InputDrawDelay
            // 
            this.InputDrawDelay.Location = new System.Drawing.Point(315, 18);
            this.InputDrawDelay.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawDelay.Name = "InputDrawDelay";
            this.InputDrawDelay.Size = new System.Drawing.Size(43, 22);
            this.InputDrawDelay.TabIndex = 45;
            this.InputDrawDelay.Text = "0";
            this.InputDrawDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(138, 23);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 17);
            this.label34.TabIndex = 44;
            this.label34.Text = "Input First Y";
            // 
            // InputDrawY
            // 
            this.InputDrawY.Location = new System.Drawing.Point(220, 18);
            this.InputDrawY.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawY.Name = "InputDrawY";
            this.InputDrawY.Size = new System.Drawing.Size(43, 22);
            this.InputDrawY.TabIndex = 42;
            this.InputDrawY.Text = "0";
            this.InputDrawY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputDrawX
            // 
            this.InputDrawX.Location = new System.Drawing.Point(87, 18);
            this.InputDrawX.Margin = new System.Windows.Forms.Padding(4);
            this.InputDrawX.Name = "InputDrawX";
            this.InputDrawX.Size = new System.Drawing.Size(43, 22);
            this.InputDrawX.TabIndex = 41;
            this.InputDrawX.Text = "0";
            this.InputDrawX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 23);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 17);
            this.label35.TabIndex = 43;
            this.label35.Text = "Input First X";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.InputStringText);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.TextBackgroundColor);
            this.tabPage3.Controls.Add(this.TextSendFrame);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.AddTextToScript);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.TextFrontColor);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.TestText);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(869, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Normal Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // InputStringText
            // 
            this.InputStringText.AsciiOnly = true;
            this.InputStringText.Culture = new System.Globalization.CultureInfo("en-US");
            this.InputStringText.Location = new System.Drawing.Point(12, 26);
            this.InputStringText.Name = "InputStringText";
            this.InputStringText.Size = new System.Drawing.Size(447, 22);
            this.InputStringText.TabIndex = 69;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(235, 57);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(186, 17);
            this.label52.TabIndex = 68;
            this.label52.Text = "Select the Background color";
            // 
            // TextBackgroundColor
            // 
            this.TextBackgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBackgroundColor.DropDownWidth = 250;
            this.TextBackgroundColor.FormattingEnabled = true;
            this.TextBackgroundColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "MULTICOLOR"});
            this.TextBackgroundColor.Location = new System.Drawing.Point(235, 73);
            this.TextBackgroundColor.Margin = new System.Windows.Forms.Padding(4);
            this.TextBackgroundColor.Name = "TextBackgroundColor";
            this.TextBackgroundColor.Size = new System.Drawing.Size(199, 24);
            this.TextBackgroundColor.TabIndex = 67;
            this.TextBackgroundColor.SelectedIndexChanged += new System.EventHandler(this.TextBackgroundColor_SelectedIndexChanged);
            // 
            // TextSendFrame
            // 
            this.TextSendFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextSendFrame.DropDownWidth = 250;
            this.TextSendFrame.FormattingEnabled = true;
            this.TextSendFrame.Items.AddRange(new object[] {
            "Show Each Char",
            "Send Frame after Showing the Text",
            "Don\'t Send Frame"});
            this.TextSendFrame.Location = new System.Drawing.Point(677, 247);
            this.TextSendFrame.Name = "TextSendFrame";
            this.TextSendFrame.Size = new System.Drawing.Size(172, 24);
            this.TextSendFrame.TabIndex = 66;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(590, 250);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 17);
            this.label47.TabIndex = 65;
            this.label47.Text = "Send Frame";
            // 
            // AddTextToScript
            // 
            this.AddTextToScript.BackColor = System.Drawing.Color.Orange;
            this.AddTextToScript.Location = new System.Drawing.Point(749, 6);
            this.AddTextToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddTextToScript.Name = "AddTextToScript";
            this.AddTextToScript.Size = new System.Drawing.Size(113, 133);
            this.AddTextToScript.TabIndex = 64;
            this.AddTextToScript.Text = "Add Text  to the Script";
            this.AddTextToScript.UseVisualStyleBackColor = false;
            this.AddTextToScript.Click += new System.EventHandler(this.AddTextToScript_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 17);
            this.label16.TabIndex = 61;
            this.label16.Text = "Select the Font color";
            // 
            // TextFrontColor
            // 
            this.TextFrontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextFrontColor.DropDownWidth = 250;
            this.TextFrontColor.FormattingEnabled = true;
            this.TextFrontColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "MULTICOLOR"});
            this.TextFrontColor.Location = new System.Drawing.Point(12, 73);
            this.TextFrontColor.Margin = new System.Windows.Forms.Padding(4);
            this.TextFrontColor.Name = "TextFrontColor";
            this.TextFrontColor.Size = new System.Drawing.Size(199, 24);
            this.TextFrontColor.TabIndex = 60;
            this.TextFrontColor.SelectedIndexChanged += new System.EventHandler(this.TextFrontColor_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "Input Text";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Blue;
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.InputTextDelay);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.InputTextY);
            this.groupBox7.Controls.Add(this.InputTextX);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(12, 110);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(333, 62);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Co-ordinates of the Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Delay";
            // 
            // InputTextDelay
            // 
            this.InputTextDelay.Location = new System.Drawing.Point(279, 18);
            this.InputTextDelay.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextDelay.Name = "InputTextDelay";
            this.InputTextDelay.Size = new System.Drawing.Size(43, 22);
            this.InputTextDelay.TabIndex = 45;
            this.InputTextDelay.Text = "0";
            this.InputTextDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Input Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Input X";
            // 
            // InputTextY
            // 
            this.InputTextY.Location = new System.Drawing.Point(179, 18);
            this.InputTextY.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextY.Name = "InputTextY";
            this.InputTextY.Size = new System.Drawing.Size(43, 22);
            this.InputTextY.TabIndex = 42;
            this.InputTextY.Text = "0";
            this.InputTextY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputTextX
            // 
            this.InputTextX.Location = new System.Drawing.Point(68, 18);
            this.InputTextX.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextX.Name = "InputTextX";
            this.InputTextX.Size = new System.Drawing.Size(43, 22);
            this.InputTextX.TabIndex = 41;
            this.InputTextX.Text = "0";
            this.InputTextX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TextScrollBlinking);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextScrollDirection);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.TextShowY);
            this.groupBox1.Controls.Add(this.TextShow);
            this.groupBox1.Controls.Add(this.TextScrollY);
            this.groupBox1.Controls.Add(this.TextScrollX);
            this.groupBox1.Location = new System.Drawing.Point(351, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(391, 107);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kind of placing the text";
            // 
            // TextScrollBlinking
            // 
            this.TextScrollBlinking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextScrollBlinking.DropDownWidth = 120;
            this.TextScrollBlinking.FormattingEnabled = true;
            this.TextScrollBlinking.Items.AddRange(new object[] {
            "Blink OFF",
            "BLINK"});
            this.TextScrollBlinking.Location = new System.Drawing.Point(282, 65);
            this.TextScrollBlinking.Name = "TextScrollBlinking";
            this.TextScrollBlinking.Size = new System.Drawing.Size(95, 24);
            this.TextScrollBlinking.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scroll Blinking";
            // 
            // TextScrollDirection
            // 
            this.TextScrollDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextScrollDirection.DropDownWidth = 120;
            this.TextScrollDirection.FormattingEnabled = true;
            this.TextScrollDirection.Items.AddRange(new object[] {
            "LEFT | UP",
            "RIGHT | DOWN"});
            this.TextScrollDirection.Location = new System.Drawing.Point(181, 65);
            this.TextScrollDirection.Name = "TextScrollDirection";
            this.TextScrollDirection.Size = new System.Drawing.Size(95, 24);
            this.TextScrollDirection.TabIndex = 6;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(176, 47);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(103, 17);
            this.label51.TabIndex = 5;
            this.label51.Text = "Scroll Direction";
            // 
            // TextShowY
            // 
            this.TextShowY.AutoSize = true;
            this.TextShowY.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextShowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShowY.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextShowY.Location = new System.Drawing.Point(123, 25);
            this.TextShowY.MaximumSize = new System.Drawing.Size(71, 100);
            this.TextShowY.Name = "TextShowY";
            this.TextShowY.Size = new System.Drawing.Size(37, 94);
            this.TextShowY.TabIndex = 4;
            this.TextShowY.TabStop = true;
            this.TextShowY.Text = "S\nh\no\nw\n\nY";
            this.TextShowY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextShowY.UseVisualStyleBackColor = true;
            // 
            // TextShow
            // 
            this.TextShow.AutoSize = true;
            this.TextShow.Checked = true;
            this.TextShow.Location = new System.Drawing.Point(19, 25);
            this.TextShow.Margin = new System.Windows.Forms.Padding(4);
            this.TextShow.Name = "TextShow";
            this.TextShow.Size = new System.Drawing.Size(76, 21);
            this.TextShow.TabIndex = 3;
            this.TextShow.TabStop = true;
            this.TextShow.Text = "Show X";
            this.TextShow.UseVisualStyleBackColor = true;
            // 
            // TextScrollY
            // 
            this.TextScrollY.AutoSize = true;
            this.TextScrollY.Location = new System.Drawing.Point(297, 25);
            this.TextScrollY.Margin = new System.Windows.Forms.Padding(4);
            this.TextScrollY.Name = "TextScrollY";
            this.TextScrollY.Size = new System.Drawing.Size(77, 21);
            this.TextScrollY.TabIndex = 2;
            this.TextScrollY.Text = "Scroll Y";
            this.TextScrollY.UseVisualStyleBackColor = true;
            // 
            // TextScrollX
            // 
            this.TextScrollX.AutoSize = true;
            this.TextScrollX.Location = new System.Drawing.Point(192, 25);
            this.TextScrollX.Margin = new System.Windows.Forms.Padding(4);
            this.TextScrollX.Name = "TextScrollX";
            this.TextScrollX.Size = new System.Drawing.Size(77, 21);
            this.TextScrollX.TabIndex = 1;
            this.TextScrollX.Text = "Scroll X";
            this.TextScrollX.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.ClearFillColor);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.ClearSpecialSendFrame);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.InputClearSpecialDelay);
            this.tabPage4.Controls.Add(this.AddSpecialClearEffectsToScript);
            this.tabPage4.Controls.Add(this.TestSpecialClearEffects);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(869, 283);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Special Clear/Fill Effects";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(619, 184);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(164, 17);
            this.label54.TabIndex = 74;
            this.label54.Text = "Select the Clear/Fill color";
            // 
            // ClearFillColor
            // 
            this.ClearFillColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClearFillColor.DropDownWidth = 250;
            this.ClearFillColor.FormattingEnabled = true;
            this.ClearFillColor.Items.AddRange(new object[] {
            "BLACK",
            "GREEN",
            "RED",
            "ORANGE",
            "RANDOMCOLOR",
            "MULTICOLOR"});
            this.ClearFillColor.Location = new System.Drawing.Point(619, 200);
            this.ClearFillColor.Margin = new System.Windows.Forms.Padding(4);
            this.ClearFillColor.Name = "ClearFillColor";
            this.ClearFillColor.Size = new System.Drawing.Size(199, 24);
            this.ClearFillColor.TabIndex = 73;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox16);
            this.groupBox9.Controls.Add(this.groupBox15);
            this.groupBox9.Controls.Add(this.groupBox14);
            this.groupBox9.Controls.Add(this.ClearHalfMatrix);
            this.groupBox9.Controls.Add(this.ClearFullMatrix);
            this.groupBox9.Location = new System.Drawing.Point(15, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(594, 220);
            this.groupBox9.TabIndex = 72;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Choose Type of Matrix and Direction of Clearing";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.HalfMatrixOutside);
            this.groupBox16.Controls.Add(this.HalfMatrixCenter);
            this.groupBox16.Location = new System.Drawing.Point(369, 21);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(216, 49);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Direction of Clearing";
            // 
            // HalfMatrixOutside
            // 
            this.HalfMatrixOutside.AutoSize = true;
            this.HalfMatrixOutside.Location = new System.Drawing.Point(142, 23);
            this.HalfMatrixOutside.Name = "HalfMatrixOutside";
            this.HalfMatrixOutside.Size = new System.Drawing.Size(66, 21);
            this.HalfMatrixOutside.TabIndex = 1;
            this.HalfMatrixOutside.Text = "Inside";
            this.HalfMatrixOutside.UseVisualStyleBackColor = true;
            // 
            // HalfMatrixCenter
            // 
            this.HalfMatrixCenter.AutoSize = true;
            this.HalfMatrixCenter.Checked = true;
            this.HalfMatrixCenter.Location = new System.Drawing.Point(16, 23);
            this.HalfMatrixCenter.Name = "HalfMatrixCenter";
            this.HalfMatrixCenter.Size = new System.Drawing.Size(115, 21);
            this.HalfMatrixCenter.TabIndex = 0;
            this.HalfMatrixCenter.TabStop = true;
            this.HalfMatrixCenter.Text = "⇔⇕ Outwards";
            this.HalfMatrixCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.FullMatrixUp);
            this.groupBox15.Controls.Add(this.FullMatrixTop);
            this.groupBox15.Controls.Add(this.FullMatrixRight);
            this.groupBox15.Controls.Add(this.FullMatrixLeft);
            this.groupBox15.Location = new System.Drawing.Point(372, 117);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(216, 86);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Direction of Clearing";
            // 
            // FullMatrixUp
            // 
            this.FullMatrixUp.AutoSize = true;
            this.FullMatrixUp.Location = new System.Drawing.Point(80, 57);
            this.FullMatrixUp.Name = "FullMatrixUp";
            this.FullMatrixUp.Size = new System.Drawing.Size(59, 21);
            this.FullMatrixUp.TabIndex = 3;
            this.FullMatrixUp.Text = "⇑ Up";
            this.FullMatrixUp.UseVisualStyleBackColor = true;
            // 
            // FullMatrixTop
            // 
            this.FullMatrixTop.AutoSize = true;
            this.FullMatrixTop.Location = new System.Drawing.Point(80, 17);
            this.FullMatrixTop.Name = "FullMatrixTop";
            this.FullMatrixTop.Size = new System.Drawing.Size(76, 21);
            this.FullMatrixTop.TabIndex = 2;
            this.FullMatrixTop.Text = "⇓ Down";
            this.FullMatrixTop.UseVisualStyleBackColor = true;
            // 
            // FullMatrixRight
            // 
            this.FullMatrixRight.AutoSize = true;
            this.FullMatrixRight.Location = new System.Drawing.Point(139, 37);
            this.FullMatrixRight.Name = "FullMatrixRight";
            this.FullMatrixRight.Size = new System.Drawing.Size(80, 21);
            this.FullMatrixRight.TabIndex = 1;
            this.FullMatrixRight.Text = "⇒ Right";
            this.FullMatrixRight.UseVisualStyleBackColor = true;
            // 
            // FullMatrixLeft
            // 
            this.FullMatrixLeft.AutoSize = true;
            this.FullMatrixLeft.Checked = true;
            this.FullMatrixLeft.Location = new System.Drawing.Point(6, 37);
            this.FullMatrixLeft.Name = "FullMatrixLeft";
            this.FullMatrixLeft.Size = new System.Drawing.Size(66, 21);
            this.FullMatrixLeft.TabIndex = 0;
            this.FullMatrixLeft.TabStop = true;
            this.FullMatrixLeft.Text = "⇐ Left";
            this.FullMatrixLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.HalfHorizontal);
            this.groupBox14.Controls.Add(this.HalfVertical);
            this.groupBox14.Location = new System.Drawing.Point(174, 22);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(181, 48);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Type of Half Matrix";
            // 
            // HalfHorizontal
            // 
            this.HalfHorizontal.AutoSize = true;
            this.HalfHorizontal.Location = new System.Drawing.Point(83, 21);
            this.HalfHorizontal.Name = "HalfHorizontal";
            this.HalfHorizontal.Size = new System.Drawing.Size(93, 21);
            this.HalfHorizontal.TabIndex = 1;
            this.HalfHorizontal.Text = "Horizontal";
            this.HalfHorizontal.UseVisualStyleBackColor = true;
            // 
            // HalfVertical
            // 
            this.HalfVertical.AutoSize = true;
            this.HalfVertical.Checked = true;
            this.HalfVertical.Location = new System.Drawing.Point(6, 21);
            this.HalfVertical.Name = "HalfVertical";
            this.HalfVertical.Size = new System.Drawing.Size(76, 21);
            this.HalfVertical.TabIndex = 0;
            this.HalfVertical.TabStop = true;
            this.HalfVertical.Text = "Vertical";
            this.HalfVertical.UseVisualStyleBackColor = true;
            // 
            // ClearHalfMatrix
            // 
            this.ClearHalfMatrix.AutoSize = true;
            this.ClearHalfMatrix.Location = new System.Drawing.Point(46, 36);
            this.ClearHalfMatrix.Name = "ClearHalfMatrix";
            this.ClearHalfMatrix.Size = new System.Drawing.Size(91, 21);
            this.ClearHalfMatrix.TabIndex = 1;
            this.ClearHalfMatrix.Text = "HalfMatrix";
            this.ClearHalfMatrix.UseVisualStyleBackColor = true;
            // 
            // ClearFullMatrix
            // 
            this.ClearFullMatrix.AutoSize = true;
            this.ClearFullMatrix.Checked = true;
            this.ClearFullMatrix.Location = new System.Drawing.Point(46, 154);
            this.ClearFullMatrix.Name = "ClearFullMatrix";
            this.ClearFullMatrix.Size = new System.Drawing.Size(92, 21);
            this.ClearFullMatrix.TabIndex = 0;
            this.ClearFullMatrix.TabStop = true;
            this.ClearFullMatrix.Text = "Full Matrix";
            this.ClearFullMatrix.UseVisualStyleBackColor = true;
            // 
            // ClearSpecialSendFrame
            // 
            this.ClearSpecialSendFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClearSpecialSendFrame.DropDownWidth = 250;
            this.ClearSpecialSendFrame.FormattingEnabled = true;
            this.ClearSpecialSendFrame.Items.AddRange(new object[] {
            "Clear Each Point",
            "Send Frame after Clearing Each Column/Line",
            "Not Applicable"});
            this.ClearSpecialSendFrame.Location = new System.Drawing.Point(677, 247);
            this.ClearSpecialSendFrame.Name = "ClearSpecialSendFrame";
            this.ClearSpecialSendFrame.Size = new System.Drawing.Size(172, 24);
            this.ClearSpecialSendFrame.TabIndex = 71;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(590, 250);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 17);
            this.label48.TabIndex = 70;
            this.label48.Text = "Send Frame";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(616, 154);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 17);
            this.label33.TabIndex = 69;
            this.label33.Text = "Delay";
            // 
            // InputClearSpecialDelay
            // 
            this.InputClearSpecialDelay.Location = new System.Drawing.Point(672, 149);
            this.InputClearSpecialDelay.Margin = new System.Windows.Forms.Padding(4);
            this.InputClearSpecialDelay.Name = "InputClearSpecialDelay";
            this.InputClearSpecialDelay.Size = new System.Drawing.Size(43, 22);
            this.InputClearSpecialDelay.TabIndex = 68;
            this.InputClearSpecialDelay.Text = "0";
            this.InputClearSpecialDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddSpecialClearEffectsToScript
            // 
            this.AddSpecialClearEffectsToScript.BackColor = System.Drawing.Color.Orange;
            this.AddSpecialClearEffectsToScript.Location = new System.Drawing.Point(749, 6);
            this.AddSpecialClearEffectsToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddSpecialClearEffectsToScript.Name = "AddSpecialClearEffectsToScript";
            this.AddSpecialClearEffectsToScript.Size = new System.Drawing.Size(113, 133);
            this.AddSpecialClearEffectsToScript.TabIndex = 66;
            this.AddSpecialClearEffectsToScript.Text = "Add Special Clear Effects to the Script";
            this.AddSpecialClearEffectsToScript.UseVisualStyleBackColor = false;
            this.AddSpecialClearEffectsToScript.Click += new System.EventHandler(this.AddSpecialClearEffectsToScript_Click);
            // 
            // TestSpecialClearEffects
            // 
            this.TestSpecialClearEffects.BackColor = System.Drawing.Color.Red;
            this.TestSpecialClearEffects.ForeColor = System.Drawing.Color.White;
            this.TestSpecialClearEffects.Location = new System.Drawing.Point(629, 6);
            this.TestSpecialClearEffects.Margin = new System.Windows.Forms.Padding(4);
            this.TestSpecialClearEffects.Name = "TestSpecialClearEffects";
            this.TestSpecialClearEffects.Size = new System.Drawing.Size(113, 65);
            this.TestSpecialClearEffects.TabIndex = 65;
            this.TestSpecialClearEffects.Text = "Test Special Clear Effects";
            this.TestSpecialClearEffects.UseVisualStyleBackColor = false;
            this.TestSpecialClearEffects.Click += new System.EventHandler(this.TestSpecialClearEffects_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 424);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 24);
            this.label19.TabIndex = 37;
            this.label19.Text = "Matrix Script";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // OpenScript
            // 
            this.OpenScript.BackColor = System.Drawing.Color.Green;
            this.OpenScript.ForeColor = System.Drawing.Color.White;
            this.OpenScript.Location = new System.Drawing.Point(532, 758);
            this.OpenScript.Margin = new System.Windows.Forms.Padding(4);
            this.OpenScript.Name = "OpenScript";
            this.OpenScript.Size = new System.Drawing.Size(85, 65);
            this.OpenScript.TabIndex = 38;
            this.OpenScript.Text = "Open Text Script File";
            this.OpenScript.UseVisualStyleBackColor = false;
            this.OpenScript.Click += new System.EventHandler(this.OpenScript_Click);
            // 
            // SaveScriptText
            // 
            this.SaveScriptText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.SaveScriptText.ForeColor = System.Drawing.Color.Black;
            this.SaveScriptText.Location = new System.Drawing.Point(659, 758);
            this.SaveScriptText.Margin = new System.Windows.Forms.Padding(4);
            this.SaveScriptText.Name = "SaveScriptText";
            this.SaveScriptText.Size = new System.Drawing.Size(85, 65);
            this.SaveScriptText.TabIndex = 39;
            this.SaveScriptText.Text = "Save Script as Text File";
            this.SaveScriptText.UseVisualStyleBackColor = false;
            this.SaveScriptText.Click += new System.EventHandler(this.SaveScriptText_Click);
            // 
            // CopyArduinoScriptToClipboard
            // 
            this.CopyArduinoScriptToClipboard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CopyArduinoScriptToClipboard.ForeColor = System.Drawing.Color.White;
            this.CopyArduinoScriptToClipboard.Location = new System.Drawing.Point(786, 758);
            this.CopyArduinoScriptToClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.CopyArduinoScriptToClipboard.Name = "CopyArduinoScriptToClipboard";
            this.CopyArduinoScriptToClipboard.Size = new System.Drawing.Size(113, 65);
            this.CopyArduinoScriptToClipboard.TabIndex = 40;
            this.CopyArduinoScriptToClipboard.Text = "&Copy Script as Arduino File to Clipboard";
            this.CopyArduinoScriptToClipboard.UseVisualStyleBackColor = false;
            this.CopyArduinoScriptToClipboard.Click += new System.EventHandler(this.CopyArduinoScriptToClipboard_Click);
            // 
            // RemoveRow
            // 
            this.RemoveRow.Location = new System.Drawing.Point(492, 720);
            this.RemoveRow.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.Size = new System.Drawing.Size(180, 34);
            this.RemoveRow.TabIndex = 41;
            this.RemoveRow.Text = "⊟X  Remove Current Row";
            this.RemoveRow.UseVisualStyleBackColor = true;
            this.RemoveRow.Click += new System.EventHandler(this.RemoveRow_Click);
            // 
            // RemoveAll
            // 
            this.RemoveAll.Location = new System.Drawing.Point(721, 720);
            this.RemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(180, 34);
            this.RemoveAll.TabIndex = 42;
            this.RemoveAll.Text = "⊡X Remove All Entries";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // RowUp
            // 
            this.RowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowUp.Location = new System.Drawing.Point(24, 720);
            this.RowUp.Margin = new System.Windows.Forms.Padding(4);
            this.RowUp.Name = "RowUp";
            this.RowUp.Size = new System.Drawing.Size(78, 34);
            this.RowUp.TabIndex = 43;
            this.RowUp.Text = "▲";
            this.RowUp.UseVisualStyleBackColor = true;
            this.RowUp.Click += new System.EventHandler(this.RowUp_Click);
            // 
            // RowDown
            // 
            this.RowDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowDown.Location = new System.Drawing.Point(146, 720);
            this.RowDown.Margin = new System.Windows.Forms.Padding(4);
            this.RowDown.Name = "RowDown";
            this.RowDown.Size = new System.Drawing.Size(78, 34);
            this.RowDown.TabIndex = 44;
            this.RowDown.Text = "▼";
            this.RowDown.UseVisualStyleBackColor = true;
            this.RowDown.Click += new System.EventHandler(this.RowDown_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(583, 428);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 48;
            this.label20.Text = "Delay";
            // 
            // DelayScript
            // 
            this.DelayScript.Location = new System.Drawing.Point(629, 425);
            this.DelayScript.Margin = new System.Windows.Forms.Padding(4);
            this.DelayScript.Name = "DelayScript";
            this.DelayScript.Size = new System.Drawing.Size(43, 22);
            this.DelayScript.TabIndex = 47;
            this.DelayScript.Text = "1000";
            this.DelayScript.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddDelayToScript
            // 
            this.AddDelayToScript.BackColor = System.Drawing.Color.Orange;
            this.AddDelayToScript.Location = new System.Drawing.Point(680, 422);
            this.AddDelayToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddDelayToScript.Name = "AddDelayToScript";
            this.AddDelayToScript.Size = new System.Drawing.Size(212, 28);
            this.AddDelayToScript.TabIndex = 49;
            this.AddDelayToScript.Text = "Add Delay to the Script";
            this.AddDelayToScript.UseVisualStyleBackColor = false;
            this.AddDelayToScript.Click += new System.EventHandler(this.AddDelayToScript_Click);
            // 
            // AddClearToScript
            // 
            this.AddClearToScript.BackColor = System.Drawing.Color.Orange;
            this.AddClearToScript.Location = new System.Drawing.Point(152, 422);
            this.AddClearToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddClearToScript.Name = "AddClearToScript";
            this.AddClearToScript.Size = new System.Drawing.Size(212, 28);
            this.AddClearToScript.TabIndex = 50;
            this.AddClearToScript.Text = "Add Clear Matrix to the Script";
            this.AddClearToScript.UseVisualStyleBackColor = false;
            this.AddClearToScript.Click += new System.EventHandler(this.AddClearToScript_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.CommonColumsLines);
            this.groupBox8.Controls.Add(this.SaveSettings);
            this.groupBox8.Controls.Add(this.OpenSettings);
            this.groupBox8.Controls.Add(this.CLK);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.CS);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.DataText);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.WR);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.NumberOfYMatrix);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.NumberOfXMatrix);
            this.groupBox8.Controls.Add(this.SPorts);
            this.groupBox8.Controls.Add(this.groupBox18);
            this.groupBox8.Location = new System.Drawing.Point(2, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(922, 87);
            this.groupBox8.TabIndex = 51;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Settings";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(467, 41);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(161, 13);
            this.label44.TabIndex = 36;
            this.label44.Text = "Common Random Columns/Lines";
            // 
            // CommonColumsLines
            // 
            this.CommonColumsLines.Location = new System.Drawing.Point(633, 36);
            this.CommonColumsLines.Name = "CommonColumsLines";
            this.CommonColumsLines.Size = new System.Drawing.Size(20, 22);
            this.CommonColumsLines.TabIndex = 35;
            this.CommonColumsLines.Text = "3";
            // 
            // SaveSettings
            // 
            this.SaveSettings.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.SaveSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveSettings.Location = new System.Drawing.Point(725, 10);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(95, 56);
            this.SaveSettings.TabIndex = 33;
            this.SaveSettings.Text = "Save Settings";
            this.SaveSettings.UseVisualStyleBackColor = false;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // OpenSettings
            // 
            this.OpenSettings.BackColor = System.Drawing.Color.Green;
            this.OpenSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenSettings.Location = new System.Drawing.Point(819, 10);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(95, 56);
            this.OpenSettings.TabIndex = 32;
            this.OpenSettings.Text = "Open Settings";
            this.OpenSettings.UseVisualStyleBackColor = false;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // CLK
            // 
            this.CLK.Location = new System.Drawing.Point(610, 12);
            this.CLK.Name = "CLK";
            this.CLK.Size = new System.Drawing.Size(20, 22);
            this.CLK.TabIndex = 31;
            this.CLK.Text = "5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(578, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 17);
            this.label23.TabIndex = 30;
            this.label23.Text = "CLK";
            // 
            // CS
            // 
            this.CS.Location = new System.Drawing.Point(656, 12);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(20, 22);
            this.CS.TabIndex = 29;
            this.CS.Text = "3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(631, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 17);
            this.label24.TabIndex = 28;
            this.label24.Text = "CS";
            // 
            // DataText
            // 
            this.DataText.Location = new System.Drawing.Point(507, 12);
            this.DataText.Name = "DataText";
            this.DataText.Size = new System.Drawing.Size(20, 22);
            this.DataText.TabIndex = 27;
            this.DataText.Text = "7";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(467, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 17);
            this.label22.TabIndex = 26;
            this.label22.Text = "Data";
            // 
            // WR
            // 
            this.WR.Location = new System.Drawing.Point(558, 12);
            this.WR.Name = "WR";
            this.WR.Size = new System.Drawing.Size(20, 22);
            this.WR.TabIndex = 25;
            this.WR.Text = "6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(527, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "WR";
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.Red;
            this.groupBox18.Controls.Add(this.SPortsClose);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.TestUDPPort);
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Controls.Add(this.TestUDPIPAddress);
            this.groupBox18.Controls.Add(this.TestUDP);
            this.groupBox18.Controls.Add(this.TestSerialPort);
            this.groupBox18.ForeColor = System.Drawing.Color.White;
            this.groupBox18.Location = new System.Drawing.Point(6, 14);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(455, 70);
            this.groupBox18.TabIndex = 37;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Select the Test Matrix Communication method";
            // 
            // SPortsClose
            // 
            this.SPortsClose.BackColor = System.Drawing.Color.White;
            this.SPortsClose.ForeColor = System.Drawing.Color.Black;
            this.SPortsClose.Location = new System.Drawing.Point(400, 16);
            this.SPortsClose.Name = "SPortsClose";
            this.SPortsClose.Size = new System.Drawing.Size(52, 24);
            this.SPortsClose.TabIndex = 6;
            this.SPortsClose.Text = "Close";
            this.SPortsClose.UseVisualStyleBackColor = false;
            this.SPortsClose.Click += new System.EventHandler(this.SPortsClose_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(299, 46);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(34, 17);
            this.label55.TabIndex = 5;
            this.label55.Text = "Port";
            // 
            // TestUDPPort
            // 
            this.TestUDPPort.Location = new System.Drawing.Point(335, 43);
            this.TestUDPPort.Name = "TestUDPPort";
            this.TestUDPPort.Size = new System.Drawing.Size(61, 22);
            this.TestUDPPort.TabIndex = 4;
            this.TestUDPPort.Text = "8888";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-Address";
            // 
            // TestUDPIPAddress
            // 
            this.TestUDPIPAddress.Location = new System.Drawing.Point(197, 41);
            this.TestUDPIPAddress.Name = "TestUDPIPAddress";
            this.TestUDPIPAddress.Size = new System.Drawing.Size(100, 22);
            this.TestUDPIPAddress.TabIndex = 2;
            this.TestUDPIPAddress.Text = "192.168.178.20";
            // 
            // TestUDP
            // 
            this.TestUDP.AutoSize = true;
            this.TestUDP.ForeColor = System.Drawing.Color.White;
            this.TestUDP.Location = new System.Drawing.Point(9, 43);
            this.TestUDP.Name = "TestUDP";
            this.TestUDP.Size = new System.Drawing.Size(116, 21);
            this.TestUDP.TabIndex = 1;
            this.TestUDP.Text = "UDP/Ethernet";
            this.TestUDP.UseVisualStyleBackColor = true;
            // 
            // TestSerialPort
            // 
            this.TestSerialPort.AutoSize = true;
            this.TestSerialPort.Checked = true;
            this.TestSerialPort.ForeColor = System.Drawing.Color.White;
            this.TestSerialPort.Location = new System.Drawing.Point(9, 22);
            this.TestSerialPort.Name = "TestSerialPort";
            this.TestSerialPort.Size = new System.Drawing.Size(311, 21);
            this.TestSerialPort.TabIndex = 0;
            this.TestSerialPort.TabStop = true;
            this.TestSerialPort.Text = "Serial (Select or input the Arduino COM port)";
            this.TestSerialPort.UseVisualStyleBackColor = true;
            // 
            // AddSendFrameToScript
            // 
            this.AddSendFrameToScript.BackColor = System.Drawing.Color.Orange;
            this.AddSendFrameToScript.Location = new System.Drawing.Point(368, 422);
            this.AddSendFrameToScript.Margin = new System.Windows.Forms.Padding(4);
            this.AddSendFrameToScript.Name = "AddSendFrameToScript";
            this.AddSendFrameToScript.Size = new System.Drawing.Size(212, 28);
            this.AddSendFrameToScript.TabIndex = 52;
            this.AddSendFrameToScript.Text = "Add Send Frame to the Script";
            this.AddSendFrameToScript.UseVisualStyleBackColor = false;
            this.AddSendFrameToScript.Click += new System.EventHandler(this.AddSendFrameToScript_Click);
            // 
            // CopyRow
            // 
            this.CopyRow.Location = new System.Drawing.Point(268, 720);
            this.CopyRow.Margin = new System.Windows.Forms.Padding(4);
            this.CopyRow.Name = "CopyRow";
            this.CopyRow.Size = new System.Drawing.Size(180, 34);
            this.CopyRow.TabIndex = 53;
            this.CopyRow.Text = "Copy Current Entry";
            this.CopyRow.UseVisualStyleBackColor = true;
            this.CopyRow.Click += new System.EventHandler(this.CopyRow_Click);
            // 
            // TestMatrixScript
            // 
            this.TestMatrixScript.BackColor = System.Drawing.Color.Red;
            this.TestMatrixScript.ForeColor = System.Drawing.Color.White;
            this.TestMatrixScript.Location = new System.Drawing.Point(151, 758);
            this.TestMatrixScript.Margin = new System.Windows.Forms.Padding(4);
            this.TestMatrixScript.Name = "TestMatrixScript";
            this.TestMatrixScript.Size = new System.Drawing.Size(85, 65);
            this.TestMatrixScript.TabIndex = 55;
            this.TestMatrixScript.Text = "Test the Matrix Script ∞";
            this.TestMatrixScript.UseVisualStyleBackColor = false;
            this.TestMatrixScript.Click += new System.EventHandler(this.TestMatrixScript_Click);
            // 
            // StopTheScriptLoop
            // 
            this.StopTheScriptLoop.BackColor = System.Drawing.Color.Orange;
            this.StopTheScriptLoop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.StopTheScriptLoop.FlatAppearance.BorderSize = 2;
            this.StopTheScriptLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.StopTheScriptLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopTheScriptLoop.ForeColor = System.Drawing.Color.Red;
            this.StopTheScriptLoop.Location = new System.Drawing.Point(278, 758);
            this.StopTheScriptLoop.Margin = new System.Windows.Forms.Padding(4);
            this.StopTheScriptLoop.Name = "StopTheScriptLoop";
            this.StopTheScriptLoop.Size = new System.Drawing.Size(85, 65);
            this.StopTheScriptLoop.TabIndex = 57;
            this.StopTheScriptLoop.Text = "     ✺       Stop the Script Loop ∞";
            this.StopTheScriptLoop.UseVisualStyleBackColor = false;
            this.StopTheScriptLoop.Click += new System.EventHandler(this.StopTheScriptLoop_Click);
            // 
            // CopyToSDCardRunRemotely
            // 
            this.CopyToSDCardRunRemotely.BackColor = System.Drawing.Color.Silver;
            this.CopyToSDCardRunRemotely.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyToSDCardRunRemotely.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CopyToSDCardRunRemotely.Location = new System.Drawing.Point(405, 758);
            this.CopyToSDCardRunRemotely.Margin = new System.Windows.Forms.Padding(4);
            this.CopyToSDCardRunRemotely.Name = "CopyToSDCardRunRemotely";
            this.CopyToSDCardRunRemotely.Size = new System.Drawing.Size(85, 65);
            this.CopyToSDCardRunRemotely.TabIndex = 58;
            this.CopyToSDCardRunRemotely.Text = "Copy to SD Card Run Remotely";
            this.CopyToSDCardRunRemotely.UseVisualStyleBackColor = false;
            this.CopyToSDCardRunRemotely.Click += new System.EventHandler(this.CopyToSDCardRunRemotely_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testMatrixFilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 26);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testMatrixFilesToolStripMenuItem
            // 
            this.testMatrixFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySerialTestFileToClipboardToolStripMenuItem,
            this.CopyUDPTestFileToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.CopySerialToSDCardFileToolStripMenuItem});
            this.testMatrixFilesToolStripMenuItem.Name = "testMatrixFilesToolStripMenuItem";
            this.testMatrixFilesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.testMatrixFilesToolStripMenuItem.Text = "Test Matrix Files";
            // 
            // CopySerialTestFileToClipboardToolStripMenuItem
            // 
            this.CopySerialTestFileToClipboardToolStripMenuItem.Name = "CopySerialTestFileToClipboardToolStripMenuItem";
            this.CopySerialTestFileToClipboardToolStripMenuItem.Size = new System.Drawing.Size(407, 22);
            this.CopySerialTestFileToClipboardToolStripMenuItem.Text = "Copy Serial Test File to Clipboard";
            this.CopySerialTestFileToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopySerialArduinoTestFileToClipboard_Click);
            // 
            // CopyUDPTestFileToClipboardToolStripMenuItem
            // 
            this.CopyUDPTestFileToClipboardToolStripMenuItem.Name = "CopyUDPTestFileToClipboardToolStripMenuItem";
            this.CopyUDPTestFileToClipboardToolStripMenuItem.Size = new System.Drawing.Size(407, 22);
            this.CopyUDPTestFileToClipboardToolStripMenuItem.Text = "Copy UDP Test File for Ethernet Shield to Clipboard";
            this.CopyUDPTestFileToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyUDPArduinoTestFileToClipboard_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(404, 6);
            // 
            // CopySerialToSDCardFileToolStripMenuItem
            // 
            this.CopySerialToSDCardFileToolStripMenuItem.Name = "CopySerialToSDCardFileToolStripMenuItem";
            this.CopySerialToSDCardFileToolStripMenuItem.Size = new System.Drawing.Size(407, 22);
            this.CopySerialToSDCardFileToolStripMenuItem.Text = "Copy Serial to SD Card File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 826);
            this.Controls.Add(this.CopyToSDCardRunRemotely);
            this.Controls.Add(this.StopTheScriptLoop);
            this.Controls.Add(this.TestMatrixScript);
            this.Controls.Add(this.CopyRow);
            this.Controls.Add(this.AddSendFrameToScript);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.AddClearToScript);
            this.Controls.Add(this.AddDelayToScript);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DelayScript);
            this.Controls.Add(this.RowDown);
            this.Controls.Add(this.RowUp);
            this.Controls.Add(this.RemoveAll);
            this.Controls.Add(this.RemoveRow);
            this.Controls.Add(this.CopyArduinoScriptToClipboard);
            this.Controls.Add(this.SaveScriptText);
            this.Controls.Add(this.OpenScript);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TestClearMatrix);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "C# Arduino Matrix Skripter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfXMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfYMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestText;
        private System.Windows.Forms.Button TestClearMatrix;
        private System.Windows.Forms.ComboBox SPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NumericUpDown NumberOfXMatrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumberOfYMatrix;
        private System.Windows.Forms.Button AddBitmapToScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button TestTextBitmap;
        private System.Windows.Forms.Button BitmapOpener;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BitmapScrollY;
        private System.Windows.Forms.RadioButton BitmapScrollX;
        private System.Windows.Forms.RadioButton BitmapShow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox BitmapColor15;
        private System.Windows.Forms.Label cl15label;
        private System.Windows.Forms.ComboBox BitmapColor14;
        private System.Windows.Forms.Label cl14label;
        private System.Windows.Forms.ComboBox BitmapColor11;
        private System.Windows.Forms.Label cl11label;
        private System.Windows.Forms.ComboBox BitmapColor10;
        private System.Windows.Forms.Label cl10label;
        private System.Windows.Forms.ComboBox BitmapColor12;
        private System.Windows.Forms.Label cl12label;
        private System.Windows.Forms.ComboBox BitmapColor13;
        private System.Windows.Forms.Label cl13label;
        private System.Windows.Forms.ComboBox BitmapColor8;
        private System.Windows.Forms.Label cl8label;
        private System.Windows.Forms.ComboBox BitmapColor7;
        private System.Windows.Forms.Label cl7label;
        private System.Windows.Forms.ComboBox BitmapColor9;
        private System.Windows.Forms.Label cl9label;
        private System.Windows.Forms.ComboBox BitmapColor6;
        private System.Windows.Forms.Label cl6label;
        private System.Windows.Forms.ComboBox BitmapColor5;
        private System.Windows.Forms.Label cl5label;
        private System.Windows.Forms.ComboBox BitmapColor3;
        private System.Windows.Forms.Label cl3label;
        private System.Windows.Forms.ComboBox BitmapColor2;
        private System.Windows.Forms.Label cl2label;
        private System.Windows.Forms.ComboBox BitmapColor4;
        private System.Windows.Forms.Label cl4label;
        private System.Windows.Forms.ComboBox BitmapColor1;
        private System.Windows.Forms.Label cl1label;
        private System.Windows.Forms.ComboBox BitmapColor0;
        private System.Windows.Forms.Label cl0label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InputBitmapDelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox InputBitmapY;
        private System.Windows.Forms.TextBox InputBitmapX;
        private System.Windows.Forms.Label TextBitmapBackColorLabel;
        private System.Windows.Forms.ComboBox TextBitmapBackgroundColor;
        private System.Windows.Forms.Label TextBitmapFontColorLabel;
        private System.Windows.Forms.ComboBox TextBitmapFrontColor;
        private System.Windows.Forms.Button SelectFont;
        private System.Windows.Forms.TextBox InputStringTextBitmap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox InputTextBitmapDelay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox InputTextBitmapY;
        private System.Windows.Forms.TextBox InputTextBitmapX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton TextBitmapShow;
        private System.Windows.Forms.RadioButton TextBitmapScrollY;
        private System.Windows.Forms.RadioButton TextBitmapScrollX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TextShow;
        private System.Windows.Forms.RadioButton TextScrollY;
        private System.Windows.Forms.RadioButton TextScrollX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox TextFrontColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputTextY;
        private System.Windows.Forms.TextBox InputTextX;
        private System.Windows.Forms.Button TestBitmap;
        private System.Windows.Forms.Button AddTextBitmapToScript;
        private System.Windows.Forms.Button AddTextToScript;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button OpenScript;
        private System.Windows.Forms.Button SaveScriptText;
        private System.Windows.Forms.Button CopyArduinoScriptToClipboard;
        private System.Windows.Forms.Button RemoveRow;
        private System.Windows.Forms.Button RemoveAll;
        private System.Windows.Forms.Button RowUp;
        private System.Windows.Forms.Button RowDown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox DelayScript;
        private System.Windows.Forms.Button AddDelayToScript;
        private System.Windows.Forms.Button AddClearToScript;
        private System.Windows.Forms.RadioButton TextShowY;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox WR;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox CLK;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox CS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button OpenSettings;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton BitmapTransparent;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RadioButton BitmapErase;
        private System.Windows.Forms.RadioButton BitmapNormal;
        private System.Windows.Forms.RadioButton BitmapBlack;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton TextBitmapPictureErase;
        private System.Windows.Forms.RadioButton TextBitmapNormal;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton TextBitmapTransparent;
        private System.Windows.Forms.RadioButton TextBitmapBlack;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button AddSpecialClearEffectsToScript;
        private System.Windows.Forms.Button TestSpecialClearEffects;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox InputClearSpecialDelay;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox DrawColor;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox InputDrawDelay;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox InputDrawY;
        private System.Windows.Forms.TextBox InputDrawX;
        private System.Windows.Forms.RadioButton DrawEllipse;
        private System.Windows.Forms.RadioButton DrawRectangle;
        private System.Windows.Forms.RadioButton DrawLine;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox InputDrawSecondY;
        private System.Windows.Forms.TextBox InputDrawSecondX;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox InputDrawCircleRadius;
        private System.Windows.Forms.RadioButton DrawCircle;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox InputDrawBezierThirdY;
        private System.Windows.Forms.TextBox InputDrawBezierThirdX;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox InputDrawBezierSecondY;
        private System.Windows.Forms.TextBox InputDrawBezierSecondX;
        private System.Windows.Forms.RadioButton DrawBezier;
        private System.Windows.Forms.Button AddDrawingsToScript;
        private System.Windows.Forms.Button TestDrawings;
        private System.Windows.Forms.RadioButton DrawFill;
        private System.Windows.Forms.TextBox CommonColumsLines;
        private System.Windows.Forms.ComboBox BitmapSendFrame;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox TextBitmapSendFrame;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox TextSendFrame;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox ClearSpecialSendFrame;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button AddSendFrameToScript;
        private System.Windows.Forms.ComboBox DrawSendFrame;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button CopyRow;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.RadioButton HalfMatrixOutside;
        private System.Windows.Forms.RadioButton HalfMatrixCenter;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton FullMatrixUp;
        private System.Windows.Forms.RadioButton FullMatrixTop;
        private System.Windows.Forms.RadioButton FullMatrixRight;
        private System.Windows.Forms.RadioButton FullMatrixLeft;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton HalfHorizontal;
        private System.Windows.Forms.RadioButton HalfVertical;
        private System.Windows.Forms.RadioButton ClearHalfMatrix;
        private System.Windows.Forms.RadioButton ClearFullMatrix;
        private System.Windows.Forms.ComboBox BitmapScrollDirection;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox TextScrollDirection;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox TextBackgroundColor;
        private System.Windows.Forms.ComboBox TextBitmapScrollDirection;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.RadioButton DrawPlot;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox ClearFillColor;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button TestMatrixScript;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox TestUDPPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestUDPIPAddress;
        private System.Windows.Forms.RadioButton TestUDP;
        private System.Windows.Forms.RadioButton TestSerialPort;
        private System.Windows.Forms.Button StopTheScriptLoop;
        private System.Windows.Forms.Button CopyToSDCardRunRemotely;
        private System.Windows.Forms.Button SPortsClose;
        private System.Windows.Forms.MaskedTextBox InputStringText;
        private System.Windows.Forms.ComboBox BitmapRotate;
        private System.Windows.Forms.ComboBox BitmapFlipMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testMatrixFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopySerialTestFileToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyUDPTestFileToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CopySerialToSDCardFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox TextBitmapRotate;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox TextBitmapFlipMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InputStringTextBitmapControl;
        private System.Windows.Forms.ComboBox BitmapScrollBlinking;
        private System.Windows.Forms.ComboBox TextScrollBlinking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TextBitmapScrollBlinking;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShwType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowIdentifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextData;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDelay;
        private System.Windows.Forms.DataGridViewComboBoxColumn SendFrame;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrollDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn XCoordinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn YCoordinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitmapWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitmapHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitmapData;
        private System.Windows.Forms.DataGridViewComboBoxColumn Transparency;
        private System.Windows.Forms.DataGridViewComboBoxColumn BitmapMode;
        private System.Windows.Forms.DataGridViewComboBoxColumn FrontTextColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn BackTextColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrollBlinking;
           
    }
}

