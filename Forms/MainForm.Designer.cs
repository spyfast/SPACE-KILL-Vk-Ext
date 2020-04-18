using MaterialSkin.Controls;
namespace SpaceKill_Kill
{
	// Token: 0x02000010 RID: 16
	public partial class MainForm : MaterialForm
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00007C9C File Offset: 0x00005E9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007CD8 File Offset: 0x00005ED8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.turnOffOn = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CaptPic = new System.Windows.Forms.PictureBox();
            this.accsTable = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TokenOk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTimer = new System.Windows.Forms.Timer(this.components);
            this.ManualCaptTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericDelayRE = new System.Windows.Forms.NumericUpDown();
            this.numericDelayAA = new System.Windows.Forms.NumericUpDown();
            this.targetsGridAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericDelayPicFL = new System.Windows.Forms.NumericUpDown();
            this.targetsGridFLPic = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetsGridFLText = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericDelayTextFL = new System.Windows.Forms.NumericUpDown();
            this.numericDelayCH = new System.Windows.Forms.NumericUpDown();
            this.chatsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SpeedVO = new System.Windows.Forms.NumericUpDown();
            this.numericDelayGE = new System.Windows.Forms.NumericUpDown();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.materialGroupBox4 = new MaterialSkin.Controls.MaterialGroupBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LogEnabled = new MaterialSkin.Controls.MaterialCheckBox();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.GetTokensBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.CurrAccComboBox = new MaterialSkin.Controls.MaterialCombobox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialVerticalTabSelector1 = new MaterialSkin.Controls.MaterialVerticalTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AccEnabledFL = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.floodInOrder = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.AccEnabledFL1 = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.commentPhotos = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.AccEnabledCH = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.FloodPicsCH = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.AccEnabledAA = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.SendVO = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.EmotionVO = new MaterialSkin.Controls.MaterialCombobox();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.VoiceVO = new MaterialSkin.Controls.MaterialCombobox();
            this.TargetVO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.MessageVO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.AccEnabledGE = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.TargetGE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.AccEnabledRE = new MaterialSkin.Controls.MaterialOnOffBox();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.MasterRE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.materialGroupBox6 = new MaterialSkin.Controls.MaterialGroupBox();
            this.enableAutoTurnOff = new MaterialSkin.Controls.MaterialCheckBox();
            this.MainRun = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialGroupBox5 = new MaterialSkin.Controls.MaterialGroupBox();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CurrBalance = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.ManualCaptBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CaptAns = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveCaptcha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rb_CaptAnticaptcha = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_CaptRucaptcha = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_CaptManual = new MaterialSkin.Controls.MaterialRadioButton();
            this.ApiKeyTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayPicFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayTextFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedVO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayGE)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.materialGroupBox4.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.materialGroupBox6.SuspendLayout();
            this.materialGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnOffOn
            // 
            this.turnOffOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.turnOffOn.Location = new System.Drawing.Point(234, 244);
            this.turnOffOn.Name = "turnOffOn";
            this.turnOffOn.Size = new System.Drawing.Size(238, 23);
            this.turnOffOn.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(472, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(453, 133);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // CaptPic
            // 
            this.CaptPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptPic.Location = new System.Drawing.Point(60, 99);
            this.CaptPic.Name = "CaptPic";
            this.CaptPic.Size = new System.Drawing.Size(130, 50);
            this.CaptPic.TabIndex = 10;
            this.CaptPic.TabStop = false;
            this.CaptPic.Visible = false;
            // 
            // accsTable
            // 
            this.accsTable.AllowUserToAddRows = false;
            this.accsTable.AllowUserToDeleteRows = false;
            this.accsTable.AllowUserToResizeColumns = false;
            this.accsTable.AllowUserToResizeRows = false;
            this.accsTable.BackgroundColor = System.Drawing.Color.White;
            this.accsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Passw,
            this.TokenOk});
            this.accsTable.Location = new System.Drawing.Point(9, 55);
            this.accsTable.Name = "accsTable";
            this.accsTable.ReadOnly = true;
            this.accsTable.Size = new System.Drawing.Size(453, 182);
            this.accsTable.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 130;
            // 
            // Passw
            // 
            this.Passw.HeaderText = "Пароль";
            this.Passw.Name = "Passw";
            this.Passw.ReadOnly = true;
            this.Passw.Visible = false;
            this.Passw.Width = 160;
            // 
            // TokenOk
            // 
            this.TokenOk.HeaderText = "Статус токена";
            this.TokenOk.Name = "TokenOk";
            this.TokenOk.ReadOnly = true;
            this.TokenOk.Width = 280;
            // 
            // LogTimer
            // 
            this.LogTimer.Enabled = true;
            this.LogTimer.Interval = 1000;
            this.LogTimer.Tick += new System.EventHandler(this.LogTimer_Tick);
            // 
            // ManualCaptTimer
            // 
            this.ManualCaptTimer.Enabled = true;
            this.ManualCaptTimer.Interval = 1000;
            this.ManualCaptTimer.Tick += new System.EventHandler(this.ManualCaptTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numericDelayRE
            // 
            this.numericDelayRE.Location = new System.Drawing.Point(13, 143);
            this.numericDelayRE.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericDelayRE.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayRE.Name = "numericDelayRE";
            this.numericDelayRE.Size = new System.Drawing.Size(103, 20);
            this.numericDelayRE.TabIndex = 26;
            this.numericDelayRE.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // numericDelayAA
            // 
            this.numericDelayAA.Location = new System.Drawing.Point(13, 306);
            this.numericDelayAA.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericDelayAA.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayAA.Name = "numericDelayAA";
            this.numericDelayAA.Size = new System.Drawing.Size(103, 20);
            this.numericDelayAA.TabIndex = 20;
            this.numericDelayAA.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // targetsGridAA
            // 
            this.targetsGridAA.BackgroundColor = System.Drawing.Color.White;
            this.targetsGridAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetsGridAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.targetsGridAA.Location = new System.Drawing.Point(13, 30);
            this.targetsGridAA.Name = "targetsGridAA";
            this.targetsGridAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.targetsGridAA.Size = new System.Drawing.Size(431, 175);
            this.targetsGridAA.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Обращение(лс)/список id(чат)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // numericDelayPicFL
            // 
            this.numericDelayPicFL.Location = new System.Drawing.Point(13, 253);
            this.numericDelayPicFL.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericDelayPicFL.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayPicFL.Name = "numericDelayPicFL";
            this.numericDelayPicFL.Size = new System.Drawing.Size(103, 20);
            this.numericDelayPicFL.TabIndex = 19;
            this.numericDelayPicFL.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // targetsGridFLPic
            // 
            this.targetsGridFLPic.BackgroundColor = System.Drawing.Color.White;
            this.targetsGridFLPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetsGridFLPic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.targetsGridFLPic.Location = new System.Drawing.Point(13, 30);
            this.targetsGridFLPic.Name = "targetsGridFLPic";
            this.targetsGridFLPic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.targetsGridFLPic.Size = new System.Drawing.Size(441, 157);
            this.targetsGridFLPic.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // targetsGridFLText
            // 
            this.targetsGridFLText.BackgroundColor = System.Drawing.Color.White;
            this.targetsGridFLText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetsGridFLText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.targetsGridFLText.Location = new System.Drawing.Point(13, 31);
            this.targetsGridFLText.Name = "targetsGridFLText";
            this.targetsGridFLText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.targetsGridFLText.Size = new System.Drawing.Size(441, 157);
            this.targetsGridFLText.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // numericDelayTextFL
            // 
            this.numericDelayTextFL.Location = new System.Drawing.Point(20, 259);
            this.numericDelayTextFL.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericDelayTextFL.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayTextFL.Name = "numericDelayTextFL";
            this.numericDelayTextFL.Size = new System.Drawing.Size(103, 20);
            this.numericDelayTextFL.TabIndex = 12;
            this.numericDelayTextFL.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // numericDelayCH
            // 
            this.numericDelayCH.Location = new System.Drawing.Point(278, 296);
            this.numericDelayCH.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericDelayCH.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayCH.Name = "numericDelayCH";
            this.numericDelayCH.Size = new System.Drawing.Size(103, 20);
            this.numericDelayCH.TabIndex = 22;
            this.numericDelayCH.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // chatsGrid
            // 
            this.chatsGrid.BackgroundColor = System.Drawing.Color.White;
            this.chatsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chatsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.chatsGrid.Location = new System.Drawing.Point(13, 30);
            this.chatsGrid.Name = "chatsGrid";
            this.chatsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatsGrid.Size = new System.Drawing.Size(433, 149);
            this.chatsGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ссылка на беседу";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Изменять заголовок на";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Работа с аватаром";
            this.Column3.Items.AddRange(new object[] {
            "Ничего",
            "Удалять"});
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // SpeedVO
            // 
            this.SpeedVO.Location = new System.Drawing.Point(13, 322);
            this.SpeedVO.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SpeedVO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedVO.Name = "SpeedVO";
            this.SpeedVO.Size = new System.Drawing.Size(103, 20);
            this.SpeedVO.TabIndex = 10;
            this.SpeedVO.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericDelayGE
            // 
            this.numericDelayGE.Location = new System.Drawing.Point(13, 143);
            this.numericDelayGE.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericDelayGE.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericDelayGE.Name = "numericDelayGE";
            this.numericDelayGE.Size = new System.Drawing.Size(103, 20);
            this.numericDelayGE.TabIndex = 26;
            this.numericDelayGE.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(0, 0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(200, 100);
            this.tabPage9.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.HeaderTextLocation = new System.Drawing.Point(16, 5);
            this.materialTabSelector1.ImageLocation = new System.Drawing.Point(30, 13);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1174, 23);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TextLocation = new System.Drawing.Point(50, 2);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage10);
            this.materialTabControl1.Controls.Add(this.tabPage11);
            this.materialTabControl1.Controls.Add(this.tabPage12);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 92);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1046, 449);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.White;
            this.tabPage10.Controls.Add(this.materialGroupBox4);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1038, 423);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Авторизация";
            // 
            // materialGroupBox4
            // 
            this.materialGroupBox4.BackColor = System.Drawing.Color.White;
            this.materialGroupBox4.Controls.Add(this.materialRaisedButton1);
            this.materialGroupBox4.Controls.Add(this.LogEnabled);
            this.materialGroupBox4.Controls.Add(this.label5);
            this.materialGroupBox4.Controls.Add(this.GetTokensBtn);
            this.materialGroupBox4.Controls.Add(this.accsTable);
            this.materialGroupBox4.Controls.Add(this.richTextBox1);
            this.materialGroupBox4.Depth = 0;
            this.materialGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialGroupBox4.Image = null;
            this.materialGroupBox4.Location = new System.Drawing.Point(6, 6);
            this.materialGroupBox4.Name = "materialGroupBox4";
            this.materialGroupBox4.Size = new System.Drawing.Size(963, 309);
            this.materialGroupBox4.Style = MaterialSkin.Controls.MaterialGroupBox.iStyle.Blue;
            this.materialGroupBox4.TabIndex = 0;
            this.materialGroupBox4.Text = "Авторизация и логирование";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(801, 243);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(124, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Очистить лог";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_7);
            // 
            // LogEnabled
            // 
            this.LogEnabled.AutoSize = true;
            this.LogEnabled.Depth = 0;
            this.LogEnabled.Font = new System.Drawing.Font("Roboto", 10F);
            this.LogEnabled.Location = new System.Drawing.Point(472, 222);
            this.LogEnabled.Margin = new System.Windows.Forms.Padding(0);
            this.LogEnabled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LogEnabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogEnabled.Name = "LogEnabled";
            this.LogEnabled.Ripple = true;
            this.LogEnabled.Size = new System.Drawing.Size(265, 30);
            this.LogEnabled.TabIndex = 3;
            this.LogEnabled.Text = "Полностью отключить логирование";
            this.LogEnabled.UseVisualStyleBackColor = true;
            this.LogEnabled.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(468, 55);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Логирование";
            // 
            // GetTokensBtn
            // 
            this.GetTokensBtn.AutoSize = true;
            this.GetTokensBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetTokensBtn.Depth = 0;
            this.GetTokensBtn.Icon = null;
            this.GetTokensBtn.Location = new System.Drawing.Point(166, 243);
            this.GetTokensBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetTokensBtn.Name = "GetTokensBtn";
            this.GetTokensBtn.Primary = true;
            this.GetTokensBtn.Size = new System.Drawing.Size(296, 36);
            this.GetTokensBtn.TabIndex = 1;
            this.GetTokensBtn.Text = "Получить токен для всех аккаунтов";
            this.GetTokensBtn.UseVisualStyleBackColor = true;
            this.GetTokensBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.White;
            this.tabPage11.Controls.Add(this.CurrAccComboBox);
            this.tabPage11.Controls.Add(this.materialLabel4);
            this.tabPage11.Controls.Add(this.materialVerticalTabSelector1);
            this.tabPage11.Controls.Add(this.materialTabControl2);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1038, 423);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Функционал";
            // 
            // CurrAccComboBox
            // 
            this.CurrAccComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CurrAccComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrAccComboBox.Depth = 0;
            this.CurrAccComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CurrAccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrAccComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CurrAccComboBox.FormattingEnabled = true;
            this.CurrAccComboBox.ItemHeight = 22;
            this.CurrAccComboBox.Location = new System.Drawing.Point(377, 5);
            this.CurrAccComboBox.MouseLocation = new System.Drawing.Point(0, 0);
            this.CurrAccComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CurrAccComboBox.Name = "CurrAccComboBox";
            this.CurrAccComboBox.Size = new System.Drawing.Size(561, 28);
            this.CurrAccComboBox.TabIndex = 3;
            this.CurrAccComboBox.SelectedIndexChanged += new System.EventHandler(this.materialCombobox1_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(215, 5);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(156, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Выбранный аккаунт:";
            // 
            // materialVerticalTabSelector1
            // 
            this.materialVerticalTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialVerticalTabSelector1.Depth = 0;
            this.materialVerticalTabSelector1.Location = new System.Drawing.Point(5, 3);
            this.materialVerticalTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialVerticalTabSelector1.Name = "materialVerticalTabSelector1";
            this.materialVerticalTabSelector1.Size = new System.Drawing.Size(204, 412);
            this.materialVerticalTabSelector1.TabIndex = 1;
            this.materialVerticalTabSelector1.Text = "materialVerticalTabSelector1";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage13);
            this.materialTabControl2.Controls.Add(this.tabPage20);
            this.materialTabControl2.Controls.Add(this.tabPage14);
            this.materialTabControl2.Controls.Add(this.tabPage15);
            this.materialTabControl2.Controls.Add(this.tabPage16);
            this.materialTabControl2.Controls.Add(this.tabPage17);
            this.materialTabControl2.Controls.Add(this.tabPage18);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(215, 39);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(727, 376);
            this.materialTabControl2.TabIndex = 0;
            // 
            // tabPage13
            // 
            this.tabPage13.BackColor = System.Drawing.Color.White;
            this.tabPage13.Controls.Add(this.materialRaisedButton2);
            this.tabPage13.Controls.Add(this.AccEnabledFL);
            this.tabPage13.Controls.Add(this.materialLabel16);
            this.tabPage13.Controls.Add(this.materialLabel15);
            this.tabPage13.Controls.Add(this.floodInOrder);
            this.tabPage13.Controls.Add(this.materialLabel13);
            this.tabPage13.Controls.Add(this.targetsGridFLText);
            this.tabPage13.Controls.Add(this.numericDelayTextFL);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(719, 350);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "Спамер текстом";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(460, 31);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton2.TabIndex = 22;
            this.materialRaisedButton2.Text = "Сохранить всё";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click_2);
            // 
            // AccEnabledFL
            // 
            this.AccEnabledFL.AutoSize = true;
            this.AccEnabledFL.Depth = 0;
            this.AccEnabledFL.EllipseBorderColor = "#3b73d1";
            this.AccEnabledFL.EllipseColor = "#508ef5";
            this.AccEnabledFL.Location = new System.Drawing.Point(20, 309);
            this.AccEnabledFL.Name = "AccEnabledFL";
            this.AccEnabledFL.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledFL.TabIndex = 21;
            this.AccEnabledFL.Text = "materialOnOffBox1";
            this.AccEnabledFL.UseVisualStyleBackColor = true;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(18, 285);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(86, 19);
            this.materialLabel16.TabIndex = 20;
            this.materialLabel16.Text = "Включить?";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(15, 235);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(292, 19);
            this.materialLabel15.TabIndex = 19;
            this.materialLabel15.Text = "Задержка между постами текстом (мс):";
            // 
            // floodInOrder
            // 
            this.floodInOrder.AutoSize = true;
            this.floodInOrder.Checked = true;
            this.floodInOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.floodInOrder.Depth = 0;
            this.floodInOrder.Font = new System.Drawing.Font("Roboto", 10F);
            this.floodInOrder.Location = new System.Drawing.Point(13, 191);
            this.floodInOrder.Margin = new System.Windows.Forms.Padding(0);
            this.floodInOrder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.floodInOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.floodInOrder.Name = "floodInOrder";
            this.floodInOrder.Ripple = true;
            this.floodInOrder.Size = new System.Drawing.Size(276, 30);
            this.floodInOrder.TabIndex = 18;
            this.floodInOrder.Text = "Отправлять цели и фразы по порядку";
            this.floodInOrder.UseVisualStyleBackColor = true;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(9, 8);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(204, 19);
            this.materialLabel13.TabIndex = 17;
            this.materialLabel13.Text = "Цель(и) для спама текстом";
            // 
            // tabPage20
            // 
            this.tabPage20.BackColor = System.Drawing.Color.White;
            this.tabPage20.Controls.Add(this.materialRaisedButton3);
            this.tabPage20.Controls.Add(this.materialLabel19);
            this.tabPage20.Controls.Add(this.AccEnabledFL1);
            this.tabPage20.Controls.Add(this.materialLabel18);
            this.tabPage20.Controls.Add(this.commentPhotos);
            this.tabPage20.Controls.Add(this.numericDelayPicFL);
            this.tabPage20.Controls.Add(this.materialLabel17);
            this.tabPage20.Controls.Add(this.targetsGridFLPic);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(719, 350);
            this.tabPage20.TabIndex = 7;
            this.tabPage20.Text = "Спамер картинками";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(460, 30);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton3.TabIndex = 23;
            this.materialRaisedButton3.Text = "Сохранить всё";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click_2);
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(9, 279);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(86, 19);
            this.materialLabel19.TabIndex = 22;
            this.materialLabel19.Text = "Включить?";
            // 
            // AccEnabledFL1
            // 
            this.AccEnabledFL1.AutoSize = true;
            this.AccEnabledFL1.Depth = 0;
            this.AccEnabledFL1.EllipseBorderColor = "#3b73d1";
            this.AccEnabledFL1.EllipseColor = "#508ef5";
            this.AccEnabledFL1.Location = new System.Drawing.Point(10, 304);
            this.AccEnabledFL1.Name = "AccEnabledFL1";
            this.AccEnabledFL1.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledFL1.TabIndex = 21;
            this.AccEnabledFL1.Text = "materialOnOffBox1";
            this.AccEnabledFL1.UseVisualStyleBackColor = true;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(9, 228);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(319, 19);
            this.materialLabel18.TabIndex = 20;
            this.materialLabel18.Text = "Задержка между постами картинками (мс):";
            // 
            // commentPhotos
            // 
            this.commentPhotos.AutoSize = true;
            this.commentPhotos.Depth = 0;
            this.commentPhotos.Font = new System.Drawing.Font("Roboto", 10F);
            this.commentPhotos.Location = new System.Drawing.Point(8, 194);
            this.commentPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.commentPhotos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.commentPhotos.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentPhotos.Name = "commentPhotos";
            this.commentPhotos.Ripple = true;
            this.commentPhotos.Size = new System.Drawing.Size(285, 30);
            this.commentPhotos.TabIndex = 19;
            this.commentPhotos.Text = "Добавлять текст из photoComments.txt";
            this.commentPhotos.UseVisualStyleBackColor = true;
            this.commentPhotos.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged_1);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(9, 8);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(231, 19);
            this.materialLabel17.TabIndex = 18;
            this.materialLabel17.Text = "Цель(и) для спама картинками";
            // 
            // tabPage14
            // 
            this.tabPage14.BackColor = System.Drawing.Color.White;
            this.tabPage14.Controls.Add(this.materialRaisedButton4);
            this.tabPage14.Controls.Add(this.materialLabel22);
            this.tabPage14.Controls.Add(this.AccEnabledCH);
            this.tabPage14.Controls.Add(this.materialLabel21);
            this.tabPage14.Controls.Add(this.FloodPicsCH);
            this.tabPage14.Controls.Add(this.materialLabel20);
            this.tabPage14.Controls.Add(this.chatsGrid);
            this.tabPage14.Controls.Add(this.numericDelayCH);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(719, 350);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "Беседы";
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(452, 30);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton4.TabIndex = 26;
            this.materialRaisedButton4.Text = "Сохранить всё";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(16, 294);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(256, 19);
            this.materialLabel22.TabIndex = 25;
            this.materialLabel22.Text = "Задержка между проверками (мс):";
            // 
            // AccEnabledCH
            // 
            this.AccEnabledCH.AutoSize = true;
            this.AccEnabledCH.Depth = 0;
            this.AccEnabledCH.EllipseBorderColor = "#3b73d1";
            this.AccEnabledCH.EllipseColor = "#508ef5";
            this.AccEnabledCH.Location = new System.Drawing.Point(20, 251);
            this.AccEnabledCH.Name = "AccEnabledCH";
            this.AccEnabledCH.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledCH.TabIndex = 24;
            this.AccEnabledCH.Text = "materialOnOffBox1";
            this.AccEnabledCH.UseVisualStyleBackColor = true;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(19, 229);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(86, 19);
            this.materialLabel21.TabIndex = 23;
            this.materialLabel21.Text = "Включить?";
            // 
            // FloodPicsCH
            // 
            this.FloodPicsCH.AutoSize = true;
            this.FloodPicsCH.Depth = 0;
            this.FloodPicsCH.Font = new System.Drawing.Font("Roboto", 10F);
            this.FloodPicsCH.Location = new System.Drawing.Point(13, 192);
            this.FloodPicsCH.Margin = new System.Windows.Forms.Padding(0);
            this.FloodPicsCH.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FloodPicsCH.MouseState = MaterialSkin.MouseState.HOVER;
            this.FloodPicsCH.Name = "FloodPicsCH";
            this.FloodPicsCH.Ripple = true;
            this.FloodPicsCH.Size = new System.Drawing.Size(262, 30);
            this.FloodPicsCH.TabIndex = 20;
            this.FloodPicsCH.Text = "Спамить заменой аватарки беседы";
            this.FloodPicsCH.UseVisualStyleBackColor = true;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(9, 8);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(139, 19);
            this.materialLabel20.TabIndex = 19;
            this.materialLabel20.Text = "Цель(и) для бесед";
            // 
            // tabPage15
            // 
            this.tabPage15.BackColor = System.Drawing.Color.White;
            this.tabPage15.Controls.Add(this.materialRaisedButton5);
            this.tabPage15.Controls.Add(this.numericDelayAA);
            this.tabPage15.Controls.Add(this.materialLabel25);
            this.tabPage15.Controls.Add(this.AccEnabledAA);
            this.tabPage15.Controls.Add(this.materialLabel24);
            this.tabPage15.Controls.Add(this.materialLabel23);
            this.tabPage15.Controls.Add(this.targetsGridAA);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(719, 350);
            this.tabPage15.TabIndex = 2;
            this.tabPage15.Text = "Автоответчик";
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
            this.materialRaisedButton5.Location = new System.Drawing.Point(450, 30);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton5.TabIndex = 27;
            this.materialRaisedButton5.Text = "Сохранить всё";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(9, 284);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(359, 19);
            this.materialLabel25.TabIndex = 22;
            this.materialLabel25.Text = "Задержка между проверками автоотвечика (мс):";
            // 
            // AccEnabledAA
            // 
            this.AccEnabledAA.AutoSize = true;
            this.AccEnabledAA.Depth = 0;
            this.AccEnabledAA.EllipseBorderColor = "#3b73d1";
            this.AccEnabledAA.EllipseColor = "#508ef5";
            this.AccEnabledAA.Location = new System.Drawing.Point(13, 253);
            this.AccEnabledAA.Name = "AccEnabledAA";
            this.AccEnabledAA.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledAA.TabIndex = 11;
            this.AccEnabledAA.Text = "materialOnOffBox1";
            this.AccEnabledAA.UseVisualStyleBackColor = true;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(9, 231);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(86, 19);
            this.materialLabel24.TabIndex = 10;
            this.materialLabel24.Text = "Включить?";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(9, 8);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(296, 19);
            this.materialLabel23.TabIndex = 0;
            this.materialLabel23.Text = "Фразы для ответа берутся из phrases.txt";
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.White;
            this.tabPage16.Controls.Add(this.SendVO);
            this.tabPage16.Controls.Add(this.materialLabel29);
            this.tabPage16.Controls.Add(this.SpeedVO);
            this.tabPage16.Controls.Add(this.materialLabel28);
            this.tabPage16.Controls.Add(this.EmotionVO);
            this.tabPage16.Controls.Add(this.materialLabel27);
            this.tabPage16.Controls.Add(this.VoiceVO);
            this.tabPage16.Controls.Add(this.TargetVO);
            this.tabPage16.Controls.Add(this.materialLabel26);
            this.tabPage16.Controls.Add(this.MessageVO);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(719, 350);
            this.tabPage16.TabIndex = 3;
            this.tabPage16.Text = "Голосовые сообщения";
            // 
            // SendVO
            // 
            this.SendVO.AutoSize = true;
            this.SendVO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendVO.Depth = 0;
            this.SendVO.Icon = null;
            this.SendVO.Location = new System.Drawing.Point(398, 177);
            this.SendVO.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendVO.Name = "SendVO";
            this.SendVO.Primary = true;
            this.SendVO.Size = new System.Drawing.Size(102, 36);
            this.SendVO.TabIndex = 12;
            this.SendVO.Text = "Отправить";
            this.SendVO.UseVisualStyleBackColor = true;
            this.SendVO.Click += new System.EventHandler(this.materialRaisedButton1_Click_2);
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel29.Location = new System.Drawing.Point(9, 297);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(157, 19);
            this.materialLabel29.TabIndex = 11;
            this.materialLabel29.Text = "Скорость речи 1..300";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel28.Location = new System.Drawing.Point(9, 238);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(66, 19);
            this.materialLabel28.TabIndex = 6;
            this.materialLabel28.Text = "Эмоции";
            // 
            // EmotionVO
            // 
            this.EmotionVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmotionVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmotionVO.Depth = 0;
            this.EmotionVO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmotionVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmotionVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.EmotionVO.FormattingEnabled = true;
            this.EmotionVO.ItemHeight = 22;
            this.EmotionVO.Items.AddRange(new object[] {
            "neutral",
            "good",
            "evil"});
            this.EmotionVO.Location = new System.Drawing.Point(13, 263);
            this.EmotionVO.MouseLocation = new System.Drawing.Point(0, 0);
            this.EmotionVO.MouseState = MaterialSkin.MouseState.OUT;
            this.EmotionVO.Name = "EmotionVO";
            this.EmotionVO.Size = new System.Drawing.Size(180, 28);
            this.EmotionVO.TabIndex = 5;
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel27.Location = new System.Drawing.Point(9, 177);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(52, 19);
            this.materialLabel27.TabIndex = 4;
            this.materialLabel27.Text = "Голос";
            // 
            // VoiceVO
            // 
            this.VoiceVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VoiceVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoiceVO.Depth = 0;
            this.VoiceVO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.VoiceVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoiceVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.VoiceVO.FormattingEnabled = true;
            this.VoiceVO.ItemHeight = 22;
            this.VoiceVO.Items.AddRange(new object[] {
            "zahar",
            "ermil",
            "jane",
            "oksana",
            "alyss",
            "omazh"});
            this.VoiceVO.Location = new System.Drawing.Point(13, 202);
            this.VoiceVO.MouseLocation = new System.Drawing.Point(0, 0);
            this.VoiceVO.MouseState = MaterialSkin.MouseState.OUT;
            this.VoiceVO.Name = "VoiceVO";
            this.VoiceVO.Size = new System.Drawing.Size(180, 28);
            this.VoiceVO.TabIndex = 3;
            // 
            // TargetVO
            // 
            this.TargetVO.Depth = 0;
            this.TargetVO.Hint = "Цель";
            this.TargetVO.Location = new System.Drawing.Point(13, 137);
            this.TargetVO.MaxLength = 32767;
            this.TargetVO.MouseState = MaterialSkin.MouseState.HOVER;
            this.TargetVO.Multiline = false;
            this.TargetVO.Name = "TargetVO";
            this.TargetVO.PasswordChar = '\0';
            this.TargetVO.SelectedText = "";
            this.TargetVO.SelectionLength = 0;
            this.TargetVO.SelectionStart = 0;
            this.TargetVO.Size = new System.Drawing.Size(487, 23);
            this.TargetVO.TabIndex = 2;
            this.TargetVO.TabStop = false;
            this.TargetVO.UseSystemPasswordChar = false;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(9, 8);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(91, 19);
            this.materialLabel26.TabIndex = 1;
            this.materialLabel26.Text = "Сообщение";
            // 
            // MessageVO
            // 
            this.MessageVO.Depth = 0;
            this.MessageVO.Hint = "";
            this.MessageVO.Location = new System.Drawing.Point(13, 32);
            this.MessageVO.MaxLength = 32767;
            this.MessageVO.MouseState = MaterialSkin.MouseState.HOVER;
            this.MessageVO.Multiline = true;
            this.MessageVO.Name = "MessageVO";
            this.MessageVO.PasswordChar = '\0';
            this.MessageVO.SelectedText = "";
            this.MessageVO.SelectionLength = 0;
            this.MessageVO.SelectionStart = 0;
            this.MessageVO.Size = new System.Drawing.Size(487, 83);
            this.MessageVO.TabIndex = 0;
            this.MessageVO.TabStop = false;
            this.MessageVO.UseSystemPasswordChar = false;
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.White;
            this.tabPage17.Controls.Add(this.materialRaisedButton6);
            this.tabPage17.Controls.Add(this.materialLabel32);
            this.tabPage17.Controls.Add(this.AccEnabledGE);
            this.tabPage17.Controls.Add(this.materialLabel31);
            this.tabPage17.Controls.Add(this.numericDelayGE);
            this.tabPage17.Controls.Add(this.TargetGE);
            this.tabPage17.Controls.Add(this.materialLabel30);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(719, 350);
            this.tabPage17.TabIndex = 4;
            this.tabPage17.Text = "Генератор сообщений";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = null;
            this.materialRaisedButton6.Location = new System.Drawing.Point(101, 73);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton6.TabIndex = 28;
            this.materialRaisedButton6.Text = "Сохранить всё";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel32.Location = new System.Drawing.Point(9, 121);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(230, 19);
            this.materialLabel32.TabIndex = 27;
            this.materialLabel32.Text = "Задержка между постами (мс):";
            // 
            // AccEnabledGE
            // 
            this.AccEnabledGE.AutoSize = true;
            this.AccEnabledGE.Depth = 0;
            this.AccEnabledGE.EllipseBorderColor = "#3b73d1";
            this.AccEnabledGE.EllipseColor = "#508ef5";
            this.AccEnabledGE.Location = new System.Drawing.Point(13, 90);
            this.AccEnabledGE.Name = "AccEnabledGE";
            this.AccEnabledGE.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledGE.TabIndex = 3;
            this.AccEnabledGE.Text = "materialOnOffBox1";
            this.AccEnabledGE.UseVisualStyleBackColor = true;
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel31.Location = new System.Drawing.Point(9, 68);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(86, 19);
            this.materialLabel31.TabIndex = 2;
            this.materialLabel31.Text = "Включить?";
            // 
            // TargetGE
            // 
            this.TargetGE.Depth = 0;
            this.TargetGE.Hint = "Цель (беседа)";
            this.TargetGE.Location = new System.Drawing.Point(13, 33);
            this.TargetGE.MaxLength = 32767;
            this.TargetGE.MouseState = MaterialSkin.MouseState.HOVER;
            this.TargetGE.Multiline = false;
            this.TargetGE.Name = "TargetGE";
            this.TargetGE.PasswordChar = '\0';
            this.TargetGE.SelectedText = "";
            this.TargetGE.SelectionLength = 0;
            this.TargetGE.SelectionStart = 0;
            this.TargetGE.Size = new System.Drawing.Size(479, 23);
            this.TargetGE.TabIndex = 1;
            this.TargetGE.TabStop = false;
            this.TargetGE.UseSystemPasswordChar = false;
            // 
            // materialLabel30
            // 
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel30.Location = new System.Drawing.Point(9, 8);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(234, 19);
            this.materialLabel30.TabIndex = 0;
            this.materialLabel30.Text = "Генератор сообщений (беседы)";
            // 
            // tabPage18
            // 
            this.tabPage18.BackColor = System.Drawing.Color.White;
            this.tabPage18.Controls.Add(this.materialRaisedButton7);
            this.tabPage18.Controls.Add(this.materialLabel35);
            this.tabPage18.Controls.Add(this.AccEnabledRE);
            this.tabPage18.Controls.Add(this.materialLabel34);
            this.tabPage18.Controls.Add(this.numericDelayRE);
            this.tabPage18.Controls.Add(this.MasterRE);
            this.tabPage18.Controls.Add(this.materialLabel33);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(719, 350);
            this.tabPage18.TabIndex = 5;
            this.tabPage18.Text = "Удаленное управление";
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.AutoSize = true;
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Icon = null;
            this.materialRaisedButton7.Location = new System.Drawing.Point(121, 81);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(131, 36);
            this.materialRaisedButton7.TabIndex = 29;
            this.materialRaisedButton7.Text = "Сохранить всё";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel35.Location = new System.Drawing.Point(9, 119);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(256, 19);
            this.materialLabel35.TabIndex = 27;
            this.materialLabel35.Text = "Задержка между проверками (мс):";
            // 
            // AccEnabledRE
            // 
            this.AccEnabledRE.AutoSize = true;
            this.AccEnabledRE.Depth = 0;
            this.AccEnabledRE.EllipseBorderColor = "#3b73d1";
            this.AccEnabledRE.EllipseColor = "#508ef5";
            this.AccEnabledRE.Location = new System.Drawing.Point(13, 91);
            this.AccEnabledRE.Name = "AccEnabledRE";
            this.AccEnabledRE.Size = new System.Drawing.Size(47, 19);
            this.AccEnabledRE.TabIndex = 3;
            this.AccEnabledRE.Text = "materialOnOffBox1";
            this.AccEnabledRE.UseVisualStyleBackColor = true;
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel34.Location = new System.Drawing.Point(9, 69);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(86, 19);
            this.materialLabel34.TabIndex = 2;
            this.materialLabel34.Text = "Включить?";
            // 
            // MasterRE
            // 
            this.MasterRE.Depth = 0;
            this.MasterRE.Hint = "ID управляющего аккаунта";
            this.MasterRE.Location = new System.Drawing.Point(13, 33);
            this.MasterRE.MaxLength = 32767;
            this.MasterRE.MouseState = MaterialSkin.MouseState.HOVER;
            this.MasterRE.Multiline = false;
            this.MasterRE.Name = "MasterRE";
            this.MasterRE.PasswordChar = '\0';
            this.MasterRE.SelectedText = "";
            this.MasterRE.SelectionLength = 0;
            this.MasterRE.SelectionStart = 0;
            this.MasterRE.Size = new System.Drawing.Size(479, 23);
            this.MasterRE.TabIndex = 1;
            this.MasterRE.TabStop = false;
            this.MasterRE.UseSystemPasswordChar = false;
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel33.Location = new System.Drawing.Point(9, 8);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(175, 19);
            this.materialLabel33.TabIndex = 0;
            this.materialLabel33.Text = "Удаленное управление";
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.White;
            this.tabPage12.Controls.Add(this.materialGroupBox6);
            this.tabPage12.Controls.Add(this.materialGroupBox5);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1038, 423);
            this.tabPage12.TabIndex = 3;
            this.tabPage12.Text = "Антикапча и запуск";
            // 
            // materialGroupBox6
            // 
            this.materialGroupBox6.BackColor = System.Drawing.Color.White;
            this.materialGroupBox6.Controls.Add(this.enableAutoTurnOff);
            this.materialGroupBox6.Controls.Add(this.MainRun);
            this.materialGroupBox6.Controls.Add(this.turnOffOn);
            this.materialGroupBox6.Depth = 0;
            this.materialGroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialGroupBox6.Image = null;
            this.materialGroupBox6.Location = new System.Drawing.Point(551, 3);
            this.materialGroupBox6.Name = "materialGroupBox6";
            this.materialGroupBox6.Size = new System.Drawing.Size(484, 287);
            this.materialGroupBox6.Style = MaterialSkin.Controls.MaterialGroupBox.iStyle.Blue;
            this.materialGroupBox6.TabIndex = 1;
            this.materialGroupBox6.Text = "Запуск бота";
            // 
            // enableAutoTurnOff
            // 
            this.enableAutoTurnOff.AutoSize = true;
            this.enableAutoTurnOff.Depth = 0;
            this.enableAutoTurnOff.Font = new System.Drawing.Font("Roboto", 10F);
            this.enableAutoTurnOff.Location = new System.Drawing.Point(10, 241);
            this.enableAutoTurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.enableAutoTurnOff.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enableAutoTurnOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.enableAutoTurnOff.Name = "enableAutoTurnOff";
            this.enableAutoTurnOff.Ripple = true;
            this.enableAutoTurnOff.Size = new System.Drawing.Size(221, 30);
            this.enableAutoTurnOff.TabIndex = 5;
            this.enableAutoTurnOff.Text = "Автоматически отключить в:";
            this.enableAutoTurnOff.UseVisualStyleBackColor = true;
            // 
            // MainRun
            // 
            this.MainRun.AutoSize = true;
            this.MainRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainRun.Depth = 0;
            this.MainRun.Icon = null;
            this.MainRun.Location = new System.Drawing.Point(10, 57);
            this.MainRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainRun.Name = "MainRun";
            this.MainRun.Primary = true;
            this.MainRun.Size = new System.Drawing.Size(292, 36);
            this.MainRun.TabIndex = 0;
            this.MainRun.Text = "Запустить все  включенные задачи";
            this.MainRun.UseVisualStyleBackColor = true;
            this.MainRun.Click += new System.EventHandler(this.materialRaisedButton1_Click_6);
            // 
            // materialGroupBox5
            // 
            this.materialGroupBox5.BackColor = System.Drawing.Color.White;
            this.materialGroupBox5.Controls.Add(this.button1);
            this.materialGroupBox5.Controls.Add(this.CurrBalance);
            this.materialGroupBox5.Controls.Add(this.label8);
            this.materialGroupBox5.Controls.Add(this.ManualCaptBox);
            this.materialGroupBox5.Controls.Add(this.CaptAns);
            this.materialGroupBox5.Controls.Add(this.saveCaptcha);
            this.materialGroupBox5.Controls.Add(this.rb_CaptAnticaptcha);
            this.materialGroupBox5.Controls.Add(this.rb_CaptRucaptcha);
            this.materialGroupBox5.Controls.Add(this.rb_CaptManual);
            this.materialGroupBox5.Controls.Add(this.CaptPic);
            this.materialGroupBox5.Controls.Add(this.ApiKeyTextBox);
            this.materialGroupBox5.Depth = 0;
            this.materialGroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialGroupBox5.Image = null;
            this.materialGroupBox5.Location = new System.Drawing.Point(5, 3);
            this.materialGroupBox5.Name = "materialGroupBox5";
            this.materialGroupBox5.Size = new System.Drawing.Size(540, 287);
            this.materialGroupBox5.Style = MaterialSkin.Controls.MaterialGroupBox.iStyle.Blue;
            this.materialGroupBox5.TabIndex = 0;
            this.materialGroupBox5.Text = "Антикапча";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(17, 235);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Проверить баланс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.materialRaisedButton1_Click_5);
            // 
            // CurrBalance
            // 
            this.CurrBalance.AutoSize = true;
            this.CurrBalance.Depth = 0;
            this.CurrBalance.Font = new System.Drawing.Font("Roboto", 11F);
            this.CurrBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrBalance.Location = new System.Drawing.Point(83, 213);
            this.CurrBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrBalance.Name = "CurrBalance";
            this.CurrBalance.Size = new System.Drawing.Size(21, 19);
            this.CurrBalance.TabIndex = 15;
            this.CurrBalance.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(13, 213);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Баланс:";
            // 
            // ManualCaptBox
            // 
            this.ManualCaptBox.Depth = 0;
            this.ManualCaptBox.Hint = "";
            this.ManualCaptBox.Location = new System.Drawing.Point(196, 99);
            this.ManualCaptBox.MaxLength = 32767;
            this.ManualCaptBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManualCaptBox.Multiline = false;
            this.ManualCaptBox.Name = "ManualCaptBox";
            this.ManualCaptBox.PasswordChar = '\0';
            this.ManualCaptBox.SelectedText = "";
            this.ManualCaptBox.SelectionLength = 0;
            this.ManualCaptBox.SelectionStart = 0;
            this.ManualCaptBox.Size = new System.Drawing.Size(120, 23);
            this.ManualCaptBox.TabIndex = 13;
            this.ManualCaptBox.TabStop = false;
            this.ManualCaptBox.UseSystemPasswordChar = false;
            this.ManualCaptBox.Visible = false;
            // 
            // CaptAns
            // 
            this.CaptAns.AutoSize = true;
            this.CaptAns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CaptAns.Depth = 0;
            this.CaptAns.Icon = null;
            this.CaptAns.Location = new System.Drawing.Point(196, 128);
            this.CaptAns.MouseState = MaterialSkin.MouseState.HOVER;
            this.CaptAns.Name = "CaptAns";
            this.CaptAns.Primary = true;
            this.CaptAns.Size = new System.Drawing.Size(102, 36);
            this.CaptAns.TabIndex = 12;
            this.CaptAns.Text = "Отправить";
            this.CaptAns.UseVisualStyleBackColor = true;
            this.CaptAns.Visible = false;
            this.CaptAns.Click += new System.EventHandler(this.materialRaisedButton1_Click_4);
            // 
            // saveCaptcha
            // 
            this.saveCaptcha.AutoSize = true;
            this.saveCaptcha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveCaptcha.Depth = 0;
            this.saveCaptcha.Icon = null;
            this.saveCaptcha.Location = new System.Drawing.Point(19, 165);
            this.saveCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveCaptcha.Name = "saveCaptcha";
            this.saveCaptcha.Primary = true;
            this.saveCaptcha.Size = new System.Drawing.Size(156, 36);
            this.saveCaptcha.TabIndex = 11;
            this.saveCaptcha.Text = "Сохранить API Key";
            this.saveCaptcha.UseVisualStyleBackColor = true;
            this.saveCaptcha.Click += new System.EventHandler(this.materialRaisedButton1_Click_3);
            // 
            // rb_CaptAnticaptcha
            // 
            this.rb_CaptAnticaptcha.AutoSize = true;
            this.rb_CaptAnticaptcha.Depth = 0;
            this.rb_CaptAnticaptcha.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_CaptAnticaptcha.Location = new System.Drawing.Point(288, 57);
            this.rb_CaptAnticaptcha.Margin = new System.Windows.Forms.Padding(0);
            this.rb_CaptAnticaptcha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_CaptAnticaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_CaptAnticaptcha.Name = "rb_CaptAnticaptcha";
            this.rb_CaptAnticaptcha.Ripple = true;
            this.rb_CaptAnticaptcha.Size = new System.Drawing.Size(137, 30);
            this.rb_CaptAnticaptcha.TabIndex = 10;
            this.rb_CaptAnticaptcha.TabStop = true;
            this.rb_CaptAnticaptcha.Text = "anti-captcha.com";
            this.rb_CaptAnticaptcha.UseVisualStyleBackColor = true;
            // 
            // rb_CaptRucaptcha
            // 
            this.rb_CaptRucaptcha.AutoSize = true;
            this.rb_CaptRucaptcha.Depth = 0;
            this.rb_CaptRucaptcha.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_CaptRucaptcha.Location = new System.Drawing.Point(134, 57);
            this.rb_CaptRucaptcha.Margin = new System.Windows.Forms.Padding(0);
            this.rb_CaptRucaptcha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_CaptRucaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_CaptRucaptcha.Name = "rb_CaptRucaptcha";
            this.rb_CaptRucaptcha.Ripple = true;
            this.rb_CaptRucaptcha.Size = new System.Drawing.Size(121, 30);
            this.rb_CaptRucaptcha.TabIndex = 9;
            this.rb_CaptRucaptcha.TabStop = true;
            this.rb_CaptRucaptcha.Text = "rucaptcha.com";
            this.rb_CaptRucaptcha.UseVisualStyleBackColor = true;
            // 
            // rb_CaptManual
            // 
            this.rb_CaptManual.AutoSize = true;
            this.rb_CaptManual.Depth = 0;
            this.rb_CaptManual.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_CaptManual.Location = new System.Drawing.Point(17, 57);
            this.rb_CaptManual.Margin = new System.Windows.Forms.Padding(0);
            this.rb_CaptManual.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_CaptManual.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_CaptManual.Name = "rb_CaptManual";
            this.rb_CaptManual.Ripple = true;
            this.rb_CaptManual.Size = new System.Drawing.Size(85, 30);
            this.rb_CaptManual.TabIndex = 8;
            this.rb_CaptManual.TabStop = true;
            this.rb_CaptManual.Text = "Вручную";
            this.rb_CaptManual.UseVisualStyleBackColor = true;
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.Depth = 0;
            this.ApiKeyTextBox.Hint = "Введите ключ антикапчи";
            this.ApiKeyTextBox.Location = new System.Drawing.Point(19, 115);
            this.ApiKeyTextBox.MaxLength = 32767;
            this.ApiKeyTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApiKeyTextBox.Multiline = false;
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.PasswordChar = '\0';
            this.ApiKeyTextBox.SelectedText = "";
            this.ApiKeyTextBox.SelectionLength = 0;
            this.ApiKeyTextBox.SelectionStart = 0;
            this.ApiKeyTextBox.Size = new System.Drawing.Size(449, 23);
            this.ApiKeyTextBox.TabIndex = 7;
            this.ApiKeyTextBox.TabStop = false;
            this.ApiKeyTextBox.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 543);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPACE KILL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayPicFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayTextFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedVO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayGE)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.materialGroupBox4.ResumeLayout(false);
            this.materialGroupBox4.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.tabPage20.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.materialGroupBox6.ResumeLayout(false);
            this.materialGroupBox6.PerformLayout();
            this.materialGroupBox5.ResumeLayout(false);
            this.materialGroupBox5.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x0400005A RID: 90
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.PictureBox CaptPic;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.DataGridView accsTable;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Timer LogTimer;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Timer ManualCaptTimer;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000061 RID: 97
		public global::System.Windows.Forms.NumericUpDown numericDelayAA;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.DataGridView targetsGridAA;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.DataGridView targetsGridFLPic;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.DataGridView targetsGridFLText;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x04000069 RID: 105
		public global::System.Windows.Forms.NumericUpDown numericDelayTextFL;

		// Token: 0x0400006A RID: 106
		public global::System.Windows.Forms.NumericUpDown numericDelayCH;

		// Token: 0x0400006B RID: 107
		public global::System.Windows.Forms.DataGridView chatsGrid;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.DataGridViewComboBoxColumn Column3;

		// Token: 0x0400006F RID: 111
		public global::System.Windows.Forms.DateTimePicker turnOffOn;

		// Token: 0x04000070 RID: 112
		public global::System.Windows.Forms.NumericUpDown numericDelayPicFL;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.NumericUpDown SpeedVO;

		// Token: 0x04000074 RID: 116
		public global::System.Windows.Forms.NumericUpDown numericDelayGE;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.NumericUpDown numericDelayRE;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.TabPage tabPage9;

		// Token: 0x04000077 RID: 119
		private global::MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;

		// Token: 0x04000078 RID: 120
		private global::MaterialSkin.Controls.MaterialTabControl materialTabControl1;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.TabPage tabPage10;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TabPage tabPage11;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TabPage tabPage12;

		// Token: 0x0400008E RID: 142
		private global::MaterialSkin.Controls.MaterialGroupBox materialGroupBox4;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Login;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Passw;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.DataGridViewTextBoxColumn TokenOk;

		// Token: 0x04000092 RID: 146
		private global::MaterialSkin.Controls.MaterialRaisedButton GetTokensBtn;

		// Token: 0x04000093 RID: 147
		private global::MaterialSkin.Controls.MaterialCheckBox LogEnabled;

		// Token: 0x04000094 RID: 148
		private global::MaterialSkin.Controls.MaterialLabel label5;

		// Token: 0x04000095 RID: 149
		private global::MaterialSkin.Controls.MaterialCombobox CurrAccComboBox;

		// Token: 0x04000096 RID: 150
		private global::MaterialSkin.Controls.MaterialLabel materialLabel4;

		// Token: 0x04000097 RID: 151
		private global::MaterialSkin.Controls.MaterialVerticalTabSelector materialVerticalTabSelector1;

		// Token: 0x04000098 RID: 152
		private global::MaterialSkin.Controls.MaterialTabControl materialTabControl2;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.TabPage tabPage13;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.TabPage tabPage14;

		// Token: 0x0400009B RID: 155
		private global::MaterialSkin.Controls.MaterialCheckBox floodInOrder;

		// Token: 0x0400009C RID: 156
		private global::MaterialSkin.Controls.MaterialLabel materialLabel13;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.TabPage tabPage15;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.TabPage tabPage16;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.TabPage tabPage17;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.TabPage tabPage18;

		// Token: 0x040000A2 RID: 162
		private global::MaterialSkin.Controls.MaterialLabel materialLabel15;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.TabPage tabPage20;

		// Token: 0x040000A4 RID: 164
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledFL;

		// Token: 0x040000A5 RID: 165
		private global::MaterialSkin.Controls.MaterialLabel materialLabel16;

		// Token: 0x040000A6 RID: 166
		private global::MaterialSkin.Controls.MaterialLabel materialLabel19;

		// Token: 0x040000A7 RID: 167
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledFL1;

		// Token: 0x040000A8 RID: 168
		private global::MaterialSkin.Controls.MaterialLabel materialLabel18;

		// Token: 0x040000A9 RID: 169
		private global::MaterialSkin.Controls.MaterialCheckBox commentPhotos;

		// Token: 0x040000AA RID: 170
		private global::MaterialSkin.Controls.MaterialLabel materialLabel17;

		// Token: 0x040000AB RID: 171
		private global::MaterialSkin.Controls.MaterialCheckBox FloodPicsCH;

		// Token: 0x040000AC RID: 172
		private global::MaterialSkin.Controls.MaterialLabel materialLabel20;

		// Token: 0x040000AD RID: 173
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledCH;

		// Token: 0x040000AE RID: 174
		private global::MaterialSkin.Controls.MaterialLabel materialLabel21;

		// Token: 0x040000AF RID: 175
		private global::MaterialSkin.Controls.MaterialLabel materialLabel22;

		// Token: 0x040000B0 RID: 176
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledAA;

		// Token: 0x040000B1 RID: 177
		private global::MaterialSkin.Controls.MaterialLabel materialLabel24;

		// Token: 0x040000B2 RID: 178
		private global::MaterialSkin.Controls.MaterialLabel materialLabel23;

		// Token: 0x040000B3 RID: 179
		private global::MaterialSkin.Controls.MaterialLabel materialLabel25;

		// Token: 0x040000B4 RID: 180
		private global::MaterialSkin.Controls.MaterialSingleLineTextField MessageVO;

		// Token: 0x040000B5 RID: 181
		private global::MaterialSkin.Controls.MaterialSingleLineTextField TargetVO;

		// Token: 0x040000B6 RID: 182
		private global::MaterialSkin.Controls.MaterialLabel materialLabel26;

		// Token: 0x040000B7 RID: 183
		private global::MaterialSkin.Controls.MaterialRaisedButton SendVO;

		// Token: 0x040000B8 RID: 184
		private global::MaterialSkin.Controls.MaterialLabel materialLabel29;

		// Token: 0x040000B9 RID: 185
		private global::MaterialSkin.Controls.MaterialLabel materialLabel28;

		// Token: 0x040000BA RID: 186
		private global::MaterialSkin.Controls.MaterialCombobox EmotionVO;

		// Token: 0x040000BB RID: 187
		private global::MaterialSkin.Controls.MaterialLabel materialLabel27;

		// Token: 0x040000BC RID: 188
		private global::MaterialSkin.Controls.MaterialCombobox VoiceVO;

		// Token: 0x040000BD RID: 189
		private global::MaterialSkin.Controls.MaterialSingleLineTextField TargetGE;

		// Token: 0x040000BE RID: 190
		private global::MaterialSkin.Controls.MaterialLabel materialLabel30;

		// Token: 0x040000BF RID: 191
		private global::MaterialSkin.Controls.MaterialLabel materialLabel32;

		// Token: 0x040000C0 RID: 192
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledGE;

		// Token: 0x040000C1 RID: 193
		private global::MaterialSkin.Controls.MaterialLabel materialLabel31;

		// Token: 0x040000C2 RID: 194
		private global::MaterialSkin.Controls.MaterialOnOffBox AccEnabledRE;

		// Token: 0x040000C3 RID: 195
		private global::MaterialSkin.Controls.MaterialLabel materialLabel34;

		// Token: 0x040000C4 RID: 196
		private global::MaterialSkin.Controls.MaterialSingleLineTextField MasterRE;

		// Token: 0x040000C5 RID: 197
		private global::MaterialSkin.Controls.MaterialLabel materialLabel33;

		// Token: 0x040000C6 RID: 198
		private global::MaterialSkin.Controls.MaterialLabel materialLabel35;

		// Token: 0x040000C7 RID: 199
		private global::MaterialSkin.Controls.MaterialGroupBox materialGroupBox5;

		// Token: 0x040000C8 RID: 200
		private global::MaterialSkin.Controls.MaterialSingleLineTextField ApiKeyTextBox;

		// Token: 0x040000C9 RID: 201
		private global::MaterialSkin.Controls.MaterialRadioButton rb_CaptAnticaptcha;

		// Token: 0x040000CA RID: 202
		private global::MaterialSkin.Controls.MaterialRadioButton rb_CaptRucaptcha;

		// Token: 0x040000CB RID: 203
		private global::MaterialSkin.Controls.MaterialRadioButton rb_CaptManual;

		// Token: 0x040000CC RID: 204
		private global::MaterialSkin.Controls.MaterialRaisedButton saveCaptcha;

		// Token: 0x040000CD RID: 205
		private global::MaterialSkin.Controls.MaterialRaisedButton CaptAns;

		// Token: 0x040000CE RID: 206
		private global::MaterialSkin.Controls.MaterialSingleLineTextField ManualCaptBox;

		// Token: 0x040000CF RID: 207
		private global::MaterialSkin.Controls.MaterialLabel CurrBalance;

		// Token: 0x040000D0 RID: 208
		private global::MaterialSkin.Controls.MaterialLabel label8;

		// Token: 0x040000D1 RID: 209
		private global::MaterialSkin.Controls.MaterialRaisedButton button1;

		// Token: 0x040000D2 RID: 210
		private global::MaterialSkin.Controls.MaterialGroupBox materialGroupBox6;

		// Token: 0x040000D3 RID: 211
		private global::MaterialSkin.Controls.MaterialCheckBox enableAutoTurnOff;

		// Token: 0x040000D4 RID: 212
		private global::MaterialSkin.Controls.MaterialRaisedButton MainRun;

		// Token: 0x040000D5 RID: 213
		private global::MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
    }
}
