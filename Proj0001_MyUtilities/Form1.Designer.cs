namespace Proj0001_MyUtilities
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNatepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageConverter = new System.Windows.Forms.TabPage();
            this.cmBxMetrics = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txBxTo = new System.Windows.Forms.TextBox();
            this.txBxFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmBxTo = new System.Windows.Forms.ComboBox();
            this.cmBxFrom = new System.Windows.Forms.ComboBox();
            this.tabPageGetPassword = new System.Windows.Forms.TabPage();
            this.btnChBxClear = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnCopyToBuffer = new System.Windows.Forms.Button();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.btnNumericLengthReset = new System.Windows.Forms.Button();
            this.numericPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChLBxReset = new System.Windows.Forms.Button();
            this.chlstbxSimbols = new System.Windows.Forms.CheckedListBox();
            this.tabPageNotePad = new System.Windows.Forms.TabPage();
            this.richTxtBxNotePad = new System.Windows.Forms.RichTextBox();
            this.tabPageCounter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.tabPageGenerator = new System.Windows.Forms.TabPage();
            this.lblResetInterval = new System.Windows.Forms.Button();
            this.btnCopyRandom = new System.Windows.Forms.Button();
            this.btnTxtBxClear = new System.Windows.Forms.Button();
            this.richTxtBxRandomNumbers = new System.Windows.Forms.RichTextBox();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnGetRandom = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageConverter.SuspendLayout();
            this.tabPageGetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).BeginInit();
            this.tabPageNotePad.SuspendLayout();
            this.tabPageCounter.SuspendLayout();
            this.tabPageGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiNatepad,
            this.tsmiHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(993, 33);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(69, 29);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(166, 34);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiNatepad
            // 
            this.tsmiNatepad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiNotepad,
            this.tsmiClear,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.tsmiNatepad.Name = "tsmiNatepad";
            this.tsmiNatepad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiNatepad.Size = new System.Drawing.Size(95, 29);
            this.tsmiNatepad.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(354, 34);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiNotepad
            // 
            this.tsmiNotepad.Name = "tsmiNotepad";
            this.tsmiNotepad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiNotepad.Size = new System.Drawing.Size(354, 34);
            this.tsmiNotepad.Text = "Вставить время";
            this.tsmiNotepad.Click += new System.EventHandler(this.tsmiNotepad_Click);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsmiClear.Size = new System.Drawing.Size(354, 34);
            this.tsmiClear.Text = "Очистить";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(351, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiSave.Size = new System.Drawing.Size(354, 34);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(354, 34);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(97, 29);
            this.tsmiHelp.Text = "Справка";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(227, 34);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageConverter);
            this.mainTabControl.Controls.Add(this.tabPageGetPassword);
            this.mainTabControl.Controls.Add(this.tabPageNotePad);
            this.mainTabControl.Controls.Add(this.tabPageCounter);
            this.mainTabControl.Controls.Add(this.tabPageGenerator);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 33);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(993, 621);
            this.mainTabControl.TabIndex = 1;
            // 
            // tabPageConverter
            // 
            this.tabPageConverter.Controls.Add(this.cmBxMetrics);
            this.tabPageConverter.Controls.Add(this.btnSwap);
            this.tabPageConverter.Controls.Add(this.txBxTo);
            this.tabPageConverter.Controls.Add(this.txBxFrom);
            this.tabPageConverter.Controls.Add(this.btnConvert);
            this.tabPageConverter.Controls.Add(this.cmBxTo);
            this.tabPageConverter.Controls.Add(this.cmBxFrom);
            this.tabPageConverter.Location = new System.Drawing.Point(4, 34);
            this.tabPageConverter.Name = "tabPageConverter";
            this.tabPageConverter.Size = new System.Drawing.Size(985, 583);
            this.tabPageConverter.TabIndex = 4;
            this.tabPageConverter.Text = "Конверетер";
            this.tabPageConverter.UseVisualStyleBackColor = true;
            // 
            // cmBxMetrics
            // 
            this.cmBxMetrics.FormattingEnabled = true;
            this.cmBxMetrics.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cmBxMetrics.Location = new System.Drawing.Point(398, 129);
            this.cmBxMetrics.Name = "cmBxMetrics";
            this.cmBxMetrics.Size = new System.Drawing.Size(174, 33);
            this.cmBxMetrics.TabIndex = 6;
            this.cmBxMetrics.Text = "длинна";
            this.cmBxMetrics.SelectedIndexChanged += new System.EventHandler(this.cmBxSwap_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(398, 210);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(174, 34);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<-->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txBxTo
            // 
            this.txBxTo.Location = new System.Drawing.Point(693, 312);
            this.txBxTo.Name = "txBxTo";
            this.txBxTo.ReadOnly = true;
            this.txBxTo.Size = new System.Drawing.Size(169, 31);
            this.txBxTo.TabIndex = 4;
            this.txBxTo.Text = "0";
            // 
            // txBxFrom
            // 
            this.txBxFrom.Location = new System.Drawing.Point(120, 312);
            this.txBxFrom.Name = "txBxFrom";
            this.txBxFrom.Size = new System.Drawing.Size(150, 31);
            this.txBxFrom.TabIndex = 3;
            this.txBxFrom.Text = "0";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(398, 312);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(174, 39);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmBxTo
            // 
            this.cmBxTo.FormattingEnabled = true;
            this.cmBxTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "km",
            "mile"});
            this.cmBxTo.Location = new System.Drawing.Point(693, 211);
            this.cmBxTo.Name = "cmBxTo";
            this.cmBxTo.Size = new System.Drawing.Size(169, 33);
            this.cmBxTo.TabIndex = 1;
            this.cmBxTo.Text = "mm";
            // 
            // cmBxFrom
            // 
            this.cmBxFrom.FormattingEnabled = true;
            this.cmBxFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "km",
            "mile"});
            this.cmBxFrom.Location = new System.Drawing.Point(120, 211);
            this.cmBxFrom.Name = "cmBxFrom";
            this.cmBxFrom.Size = new System.Drawing.Size(150, 33);
            this.cmBxFrom.TabIndex = 0;
            this.cmBxFrom.Text = "mm";
            // 
            // tabPageGetPassword
            // 
            this.tabPageGetPassword.Controls.Add(this.btnChBxClear);
            this.tabPageGetPassword.Controls.Add(this.txtBxPassword);
            this.tabPageGetPassword.Controls.Add(this.btnCopyToBuffer);
            this.tabPageGetPassword.Controls.Add(this.btnCreatePassword);
            this.tabPageGetPassword.Controls.Add(this.btnNumericLengthReset);
            this.tabPageGetPassword.Controls.Add(this.numericPasswordLength);
            this.tabPageGetPassword.Controls.Add(this.lblPassword);
            this.tabPageGetPassword.Controls.Add(this.btnChLBxReset);
            this.tabPageGetPassword.Controls.Add(this.chlstbxSimbols);
            this.tabPageGetPassword.Location = new System.Drawing.Point(4, 34);
            this.tabPageGetPassword.Name = "tabPageGetPassword";
            this.tabPageGetPassword.Size = new System.Drawing.Size(985, 583);
            this.tabPageGetPassword.TabIndex = 3;
            this.tabPageGetPassword.Text = "Генератор паролей";
            this.tabPageGetPassword.UseVisualStyleBackColor = true;
            // 
            // btnChBxClear
            // 
            this.btnChBxClear.Location = new System.Drawing.Point(176, 462);
            this.btnChBxClear.Name = "btnChBxClear";
            this.btnChBxClear.Size = new System.Drawing.Size(227, 34);
            this.btnChBxClear.TabIndex = 8;
            this.btnChBxClear.Text = "Сброс";
            this.btnChBxClear.UseVisualStyleBackColor = true;
            this.btnChBxClear.Click += new System.EventHandler(this.btnChBxClear_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBxPassword.Location = new System.Drawing.Point(29, 393);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(512, 31);
            this.txtBxPassword.TabIndex = 7;
            // 
            // btnCopyToBuffer
            // 
            this.btnCopyToBuffer.Location = new System.Drawing.Point(333, 317);
            this.btnCopyToBuffer.Name = "btnCopyToBuffer";
            this.btnCopyToBuffer.Size = new System.Drawing.Size(208, 34);
            this.btnCopyToBuffer.TabIndex = 6;
            this.btnCopyToBuffer.Text = "Копировать в буффер";
            this.btnCopyToBuffer.UseVisualStyleBackColor = true;
            this.btnCopyToBuffer.Click += new System.EventHandler(this.btnCopyToBuffer_Click);
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Location = new System.Drawing.Point(29, 317);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(208, 34);
            this.btnCreatePassword.TabIndex = 5;
            this.btnCreatePassword.Text = "Создать пароль";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // btnNumericLengthReset
            // 
            this.btnNumericLengthReset.Location = new System.Drawing.Point(674, 240);
            this.btnNumericLengthReset.Name = "btnNumericLengthReset";
            this.btnNumericLengthReset.Size = new System.Drawing.Size(208, 34);
            this.btnNumericLengthReset.TabIndex = 4;
            this.btnNumericLengthReset.Text = "Сброс";
            this.btnNumericLengthReset.UseVisualStyleBackColor = true;
            this.btnNumericLengthReset.Click += new System.EventHandler(this.btnNumericLengthReset_Click);
            // 
            // numericPasswordLength
            // 
            this.numericPasswordLength.Location = new System.Drawing.Point(333, 243);
            this.numericPasswordLength.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericPasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericPasswordLength.Name = "numericPasswordLength";
            this.numericPasswordLength.Size = new System.Drawing.Size(208, 31);
            this.numericPasswordLength.TabIndex = 3;
            this.numericPasswordLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericPasswordLength.ValueChanged += new System.EventHandler(this.numericPasswordLength_ValueChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(68, 245);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Длинна пароля:\r\n";
            // 
            // btnChLBxReset
            // 
            this.btnChLBxReset.Location = new System.Drawing.Point(29, 180);
            this.btnChLBxReset.Name = "btnChLBxReset";
            this.btnChLBxReset.Size = new System.Drawing.Size(208, 34);
            this.btnChLBxReset.TabIndex = 1;
            this.btnChLBxReset.Text = "Сброс";
            this.btnChLBxReset.UseVisualStyleBackColor = true;
            this.btnChLBxReset.Click += new System.EventHandler(this.btnChLBxReset_Click);
            // 
            // chlstbxSimbols
            // 
            this.chlstbxSimbols.BackColor = System.Drawing.SystemColors.Window;
            this.chlstbxSimbols.CheckOnClick = true;
            this.chlstbxSimbols.FormattingEnabled = true;
            this.chlstbxSimbols.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: ~, `, !, @, #, $, %, ^, &, *, (, ), _, =, +, -, <, >, [, ], {, }, " +
                ";, :, ,, \", /, ?."});
            this.chlstbxSimbols.Location = new System.Drawing.Point(29, 39);
            this.chlstbxSimbols.Name = "chlstbxSimbols";
            this.chlstbxSimbols.Size = new System.Drawing.Size(663, 116);
            this.chlstbxSimbols.TabIndex = 0;
            // 
            // tabPageNotePad
            // 
            this.tabPageNotePad.Controls.Add(this.richTxtBxNotePad);
            this.tabPageNotePad.Location = new System.Drawing.Point(4, 34);
            this.tabPageNotePad.Name = "tabPageNotePad";
            this.tabPageNotePad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotePad.Size = new System.Drawing.Size(985, 583);
            this.tabPageNotePad.TabIndex = 2;
            this.tabPageNotePad.Text = "Блокнот";
            this.tabPageNotePad.UseVisualStyleBackColor = true;
            // 
            // richTxtBxNotePad
            // 
            this.richTxtBxNotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxNotePad.Location = new System.Drawing.Point(3, 3);
            this.richTxtBxNotePad.Name = "richTxtBxNotePad";
            this.richTxtBxNotePad.Size = new System.Drawing.Size(979, 577);
            this.richTxtBxNotePad.TabIndex = 0;
            this.richTxtBxNotePad.Text = "";
            // 
            // tabPageCounter
            // 
            this.tabPageCounter.Controls.Add(this.lblCount);
            this.tabPageCounter.Controls.Add(this.btnPlus);
            this.tabPageCounter.Controls.Add(this.btnReset);
            this.tabPageCounter.Controls.Add(this.btnMinus);
            this.tabPageCounter.Location = new System.Drawing.Point(4, 34);
            this.tabPageCounter.Name = "tabPageCounter";
            this.tabPageCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCounter.Size = new System.Drawing.Size(985, 583);
            this.tabPageCounter.TabIndex = 0;
            this.tabPageCounter.Text = "Счетчик";
            this.tabPageCounter.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(442, 248);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(34, 39);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(376, 72);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(177, 104);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(679, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(177, 104);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(376, 365);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(177, 104);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // tabPageGenerator
            // 
            this.tabPageGenerator.Controls.Add(this.lblResetInterval);
            this.tabPageGenerator.Controls.Add(this.btnCopyRandom);
            this.tabPageGenerator.Controls.Add(this.btnTxtBxClear);
            this.tabPageGenerator.Controls.Add(this.richTxtBxRandomNumbers);
            this.tabPageGenerator.Controls.Add(this.numericMax);
            this.tabPageGenerator.Controls.Add(this.numericMin);
            this.tabPageGenerator.Controls.Add(this.lblMax);
            this.tabPageGenerator.Controls.Add(this.lblMin);
            this.tabPageGenerator.Controls.Add(this.lblRandomNumber);
            this.tabPageGenerator.Controls.Add(this.btnGetRandom);
            this.tabPageGenerator.Location = new System.Drawing.Point(4, 34);
            this.tabPageGenerator.Name = "tabPageGenerator";
            this.tabPageGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerator.Size = new System.Drawing.Size(985, 583);
            this.tabPageGenerator.TabIndex = 1;
            this.tabPageGenerator.Text = "Генератор";
            this.tabPageGenerator.UseVisualStyleBackColor = true;
            // 
            // lblResetInterval
            // 
            this.lblResetInterval.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResetInterval.Location = new System.Drawing.Point(140, 204);
            this.lblResetInterval.Name = "lblResetInterval";
            this.lblResetInterval.Size = new System.Drawing.Size(220, 67);
            this.lblResetInterval.TabIndex = 11;
            this.lblResetInterval.Text = "Сбросить";
            this.lblResetInterval.UseVisualStyleBackColor = true;
            this.lblResetInterval.Click += new System.EventHandler(this.lblResetInterval_Click);
            // 
            // btnCopyRandom
            // 
            this.btnCopyRandom.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyRandom.Location = new System.Drawing.Point(670, 286);
            this.btnCopyRandom.Name = "btnCopyRandom";
            this.btnCopyRandom.Size = new System.Drawing.Size(223, 68);
            this.btnCopyRandom.TabIndex = 9;
            this.btnCopyRandom.Text = "Копировать";
            this.btnCopyRandom.UseVisualStyleBackColor = true;
            this.btnCopyRandom.Click += new System.EventHandler(this.btnCopyRandom_Click);
            // 
            // btnTxtBxClear
            // 
            this.btnTxtBxClear.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTxtBxClear.Location = new System.Drawing.Point(670, 192);
            this.btnTxtBxClear.Name = "btnTxtBxClear";
            this.btnTxtBxClear.Size = new System.Drawing.Size(223, 67);
            this.btnTxtBxClear.TabIndex = 8;
            this.btnTxtBxClear.Text = "Очистить";
            this.btnTxtBxClear.UseVisualStyleBackColor = true;
            this.btnTxtBxClear.Click += new System.EventHandler(this.btnTxtBxClear_Click);
            // 
            // richTxtBxRandomNumbers
            // 
            this.richTxtBxRandomNumbers.Location = new System.Drawing.Point(406, 192);
            this.richTxtBxRandomNumbers.Name = "richTxtBxRandomNumbers";
            this.richTxtBxRandomNumbers.Size = new System.Drawing.Size(229, 368);
            this.richTxtBxRandomNumbers.TabIndex = 7;
            this.richTxtBxRandomNumbers.Text = "";
            this.richTxtBxRandomNumbers.TextChanged += new System.EventHandler(this.richTxtBxRandomNumbers_TextChanged);
            // 
            // numericMax
            // 
            this.numericMax.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericMax.Location = new System.Drawing.Point(140, 123);
            this.numericMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericMax.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(220, 41);
            this.numericMax.TabIndex = 5;
            this.numericMax.ValueChanged += new System.EventHandler(this.numericMax_ValueChanged);
            // 
            // numericMin
            // 
            this.numericMin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericMin.Location = new System.Drawing.Point(140, 47);
            this.numericMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericMin.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(220, 41);
            this.numericMin.TabIndex = 4;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMax.Location = new System.Drawing.Point(48, 125);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(47, 35);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "До";
            this.lblMax.Click += new System.EventHandler(this.lblMax_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMin.Location = new System.Drawing.Point(48, 53);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(45, 35);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "От";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRandomNumber.Location = new System.Drawing.Point(492, 88);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(30, 35);
            this.lblRandomNumber.TabIndex = 1;
            this.lblRandomNumber.Text = "0";
            // 
            // btnGetRandom
            // 
            this.btnGetRandom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetRandom.Location = new System.Drawing.Point(670, 47);
            this.btnGetRandom.Name = "btnGetRandom";
            this.btnGetRandom.Size = new System.Drawing.Size(229, 117);
            this.btnGetRandom.TabIndex = 0;
            this.btnGetRandom.Text = "Сгенерировать случайное число";
            this.btnGetRandom.UseVisualStyleBackColor = true;
            this.btnGetRandom.Click += new System.EventHandler(this.btnGetRandom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 654);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageConverter.ResumeLayout(false);
            this.tabPageConverter.PerformLayout();
            this.tabPageGetPassword.ResumeLayout(false);
            this.tabPageGetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).EndInit();
            this.tabPageNotePad.ResumeLayout(false);
            this.tabPageCounter.ResumeLayout(false);
            this.tabPageCounter.PerformLayout();
            this.tabPageGenerator.ResumeLayout(false);
            this.tabPageGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiAbout;
        private TabControl mainTabControl;
        private TabPage tabPageCounter;
        private Button btnReset;
        private Button btnMinus;
        private TabPage tabPageGenerator;
        private Button btnPlus;
        private Button btnGetRandom;
        private Label lblCount;
        private NumericUpDown numericMax;
        private NumericUpDown numericMin;
        private Label lblMax;
        private Label lblMin;
        private Label lblRandomNumber;
        private RichTextBox richTxtBxRandomNumbers;
        private Button btnTxtBxClear;
        private Button btnCopyRandom;
        private Button lblResetInterval;
        private TabPage tabPageNotePad;
        private RichTextBox richTxtBxNotePad;
        private ToolStripMenuItem tsmiNatepad;
        private ToolStripMenuItem tsmiInsertDate;
        private ToolStripMenuItem tsmiNotepad;
        private ToolStripMenuItem tsmiClear;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiLoad;
        private TabPage tabPageGetPassword;
        private CheckedListBox chlstbxSimbols;
        private Button btnChLBxReset;
        private Button btnNumericLengthReset;
        private NumericUpDown numericPasswordLength;
        private Label lblPassword;
        private TextBox txtBxPassword;
        private Button btnCopyToBuffer;
        private Button btnCreatePassword;
        private Button btnChBxClear;
        private TabPage tabPageConverter;
        private TextBox txBxTo;
        private TextBox txBxFrom;
        private Button btnConvert;
        private ComboBox cmBxTo;
        private ComboBox cmBxFrom;
        private Button btnSwap;
        private ComboBox cmBxMetrics;
    }
}