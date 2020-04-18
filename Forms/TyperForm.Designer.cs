namespace SpaceKill_Kill
{
	// Token: 0x0200001F RID: 31
	public partial class TyperForm : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		private void InitializeComponent()
		{
            this.comboBox_placement = new MaterialSkin.Controls.MaterialCombobox();
            this.button_launch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label_textsCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown_sendingDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_typingDelay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_placement
            // 
            this.comboBox_placement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_placement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_placement.Depth = 0;
            this.comboBox_placement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_placement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_placement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_placement.FormattingEnabled = true;
            this.comboBox_placement.ItemHeight = 22;
            this.comboBox_placement.Items.AddRange(new object[] {
            "В начале",
            "В конце",
            "В начале и в конце (через :)"});
            this.comboBox_placement.Location = new System.Drawing.Point(17, 261);
            this.comboBox_placement.MouseLocation = new System.Drawing.Point(0, 0);
            this.comboBox_placement.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox_placement.Name = "comboBox_placement";
            this.comboBox_placement.Size = new System.Drawing.Size(293, 28);
            this.comboBox_placement.TabIndex = 39;
            // 
            // button_launch
            // 
            this.button_launch.AutoSize = true;
            this.button_launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_launch.Depth = 0;
            this.button_launch.Icon = null;
            this.button_launch.Location = new System.Drawing.Point(103, 295);
            this.button_launch.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_launch.Name = "button_launch";
            this.button_launch.Primary = true;
            this.button_launch.Size = new System.Drawing.Size(118, 36);
            this.button_launch.TabIndex = 38;
            this.button_launch.Text = "Старт (Alt+T)";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(79, 239);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(198, 19);
            this.materialLabel5.TabIndex = 37;
            this.materialLabel5.Text = "Расположение обращения";
            // 
            // textBox_name
            // 
            this.textBox_name.Depth = 0;
            this.textBox_name.Hint = "Обращение";
            this.textBox_name.Location = new System.Drawing.Point(17, 205);
            this.textBox_name.MaxLength = 32767;
            this.textBox_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_name.Multiline = false;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.PasswordChar = '\0';
            this.textBox_name.SelectedText = "";
            this.textBox_name.SelectionLength = 0;
            this.textBox_name.SelectionStart = 0;
            this.textBox_name.Size = new System.Drawing.Size(304, 23);
            this.textBox_name.TabIndex = 36;
            this.textBox_name.TabStop = false;
            this.textBox_name.UseSystemPasswordChar = false;
            this.textBox_name.Click += new System.EventHandler(this.textBox_name_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(340, 19);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Задержка между отправками сообщений (мс):";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 103);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(308, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Задержка между нажатиями клавиш (мс):";
            // 
            // label_textsCount
            // 
            this.label_textsCount.AutoSize = true;
            this.label_textsCount.Depth = 0;
            this.label_textsCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_textsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_textsCount.Location = new System.Drawing.Point(221, 70);
            this.label_textsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_textsCount.Name = "label_textsCount";
            this.label_textsCount.Size = new System.Drawing.Size(17, 19);
            this.label_textsCount.TabIndex = 33;
            this.label_textsCount.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(204, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Сообщений в typerTexts.txt:";
            // 
            // numericUpDown_sendingDelay
            // 
            this.numericUpDown_sendingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_sendingDelay.Location = new System.Drawing.Point(17, 179);
            this.numericUpDown_sendingDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Name = "numericUpDown_sendingDelay";
            this.numericUpDown_sendingDelay.Size = new System.Drawing.Size(304, 20);
            this.numericUpDown_sendingDelay.TabIndex = 31;
            this.numericUpDown_sendingDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.ValueChanged += new System.EventHandler(this.numericUpDown_sendingDelay_ValueChanged);
            // 
            // numericUpDown_typingDelay
            // 
            this.numericUpDown_typingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_typingDelay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_typingDelay.Location = new System.Drawing.Point(17, 125);
            this.numericUpDown_typingDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Name = "numericUpDown_typingDelay";
            this.numericUpDown_typingDelay.Size = new System.Drawing.Size(304, 20);
            this.numericUpDown_typingDelay.TabIndex = 30;
            this.numericUpDown_typingDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.ValueChanged += new System.EventHandler(this.numericUpDown_typingDelay_ValueChanged);
            // 
            // TyperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 341);
            this.Controls.Add(this.comboBox_placement);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label_textsCount);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.numericUpDown_sendingDelay);
            this.Controls.Add(this.numericUpDown_typingDelay);
            this.MaximizeBox = false;
            this.Name = "TyperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TyperForm :: SPACE KILL";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000106 RID: 262
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000108 RID: 264
		private global::MaterialSkin.Controls.MaterialCombobox comboBox_placement;

		// Token: 0x04000109 RID: 265
		private global::MaterialSkin.Controls.MaterialRaisedButton button_launch;

		// Token: 0x0400010A RID: 266
		private global::MaterialSkin.Controls.MaterialLabel materialLabel5;

		// Token: 0x0400010B RID: 267
		private global::MaterialSkin.Controls.MaterialSingleLineTextField textBox_name;

		// Token: 0x0400010C RID: 268
		private global::MaterialSkin.Controls.MaterialLabel materialLabel3;

		// Token: 0x0400010D RID: 269
		private global::MaterialSkin.Controls.MaterialLabel materialLabel2;

		// Token: 0x0400010E RID: 270
		private global::MaterialSkin.Controls.MaterialLabel label_textsCount;

		// Token: 0x0400010F RID: 271
		private global::MaterialSkin.Controls.MaterialLabel materialLabel1;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.NumericUpDown numericUpDown_sendingDelay;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.NumericUpDown numericUpDown_typingDelay;
	}
}
