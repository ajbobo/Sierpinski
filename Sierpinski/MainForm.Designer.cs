namespace Sierpinski
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnlControls = new System.Windows.Forms.Panel();
			this.txtDotCount = new System.Windows.Forms.TextBox();
			this.lblDotCount = new System.Windows.Forms.Label();
			this.btnDraw = new System.Windows.Forms.Button();
			this.btnClearDots = new System.Windows.Forms.Button();
			this.btnClearVertices = new System.Windows.Forms.Button();
			this.pnlDisplay = new Sierpinski.BufferedPanel();
			this.pnlControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlControls
			// 
			this.pnlControls.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlControls.Controls.Add(this.txtDotCount);
			this.pnlControls.Controls.Add(this.lblDotCount);
			this.pnlControls.Controls.Add(this.btnDraw);
			this.pnlControls.Controls.Add(this.btnClearDots);
			this.pnlControls.Controls.Add(this.btnClearVertices);
			this.pnlControls.Location = new System.Drawing.Point(69, 12);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(508, 30);
			this.pnlControls.TabIndex = 1;
			// 
			// txtDotCount
			// 
			this.txtDotCount.Location = new System.Drawing.Point(405, 5);
			this.txtDotCount.Name = "txtDotCount";
			this.txtDotCount.Size = new System.Drawing.Size(100, 20);
			this.txtDotCount.TabIndex = 6;
			this.txtDotCount.Text = "30000";
			// 
			// lblDotCount
			// 
			this.lblDotCount.AutoSize = true;
			this.lblDotCount.Location = new System.Drawing.Point(315, 8);
			this.lblDotCount.Name = "lblDotCount";
			this.lblDotCount.Size = new System.Drawing.Size(84, 13);
			this.lblDotCount.TabIndex = 5;
			this.lblDotCount.Text = "Number of Dots:";
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(211, 3);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(98, 23);
			this.btnDraw.TabIndex = 4;
			this.btnDraw.Text = "&Draw";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// btnClearDots
			// 
			this.btnClearDots.Location = new System.Drawing.Point(107, 3);
			this.btnClearDots.Name = "btnClearDots";
			this.btnClearDots.Size = new System.Drawing.Size(98, 23);
			this.btnClearDots.TabIndex = 3;
			this.btnClearDots.Text = "&Clear Dots";
			this.btnClearDots.UseVisualStyleBackColor = true;
			this.btnClearDots.Click += new System.EventHandler(this.btnClearDots_Click);
			// 
			// btnClearVertices
			// 
			this.btnClearVertices.Location = new System.Drawing.Point(3, 3);
			this.btnClearVertices.Name = "btnClearVertices";
			this.btnClearVertices.Size = new System.Drawing.Size(98, 23);
			this.btnClearVertices.TabIndex = 2;
			this.btnClearVertices.Text = "Clear &Vertices";
			this.btnClearVertices.UseVisualStyleBackColor = true;
			this.btnClearVertices.Click += new System.EventHandler(this.btnClearVertices_Click);
			// 
			// pnlDisplay
			// 
			this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlDisplay.Location = new System.Drawing.Point(13, 48);
			this.pnlDisplay.Name = "pnlDisplay";
			this.pnlDisplay.Size = new System.Drawing.Size(622, 538);
			this.pnlDisplay.TabIndex = 0;
			this.pnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisplay_Paint);
			this.pnlDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDisplay_MouseClick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 598);
			this.Controls.Add(this.pnlControls);
			this.Controls.Add(this.pnlDisplay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sierpinski Shapes";
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Button btnClearDots;
		private System.Windows.Forms.Button btnClearVertices;
		private System.Windows.Forms.Button btnDraw;
		private BufferedPanel pnlDisplay;
		private System.Windows.Forms.TextBox txtDotCount;
		private System.Windows.Forms.Label lblDotCount;
	}
}

