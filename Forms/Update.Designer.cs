namespace SpaceKill_Kill
{
	// Token: 0x02000020 RID: 32
	public partial class Update : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x000108F0 File Offset: 0x0000EAF0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00010928 File Offset: 0x0000EB28
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SpaceKill_Kill.Update));
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.progressBar1.Location = new global::System.Drawing.Point(12, 368);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(342, 30);
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Visible = false;
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(600, 450);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(600, 450);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.progressBar1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Update";
			base.Sizable = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update";
			base.Load += new global::System.EventHandler(this.Update_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400011A RID: 282
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
