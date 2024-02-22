namespace WinFormsApp
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
			btnLogMain = new Button();
			btnRegistr = new Button();
			lblWel = new Label();
			SuspendLayout();
			// 
			// btnLogMain
			// 
			btnLogMain.Location = new Point(105, 141);
			btnLogMain.Name = "btnLogMain";
			btnLogMain.Size = new Size(133, 47);
			btnLogMain.TabIndex = 0;
			btnLogMain.Text = "Login";
			btnLogMain.UseVisualStyleBackColor = true;
			btnLogMain.Click += btnLogMain_Click;
			// 
			// btnRegistr
			// 
			btnRegistr.Location = new Point(283, 141);
			btnRegistr.Name = "btnRegistr";
			btnRegistr.Size = new Size(133, 47);
			btnRegistr.TabIndex = 1;
			btnRegistr.Text = "Registration";
			btnRegistr.UseVisualStyleBackColor = true;
			btnRegistr.Click += btnRegistr_Click;
			// 
			// lblWel
			// 
			lblWel.AutoSize = true;
			lblWel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lblWel.Location = new Point(105, 76);
			lblWel.Name = "lblWel";
			lblWel.Size = new Size(308, 34);
			lblWel.TabIndex = 2;
			lblWel.Text = "Welcome to the system))";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(520, 274);
			Controls.Add(lblWel);
			Controls.Add(btnRegistr);
			Controls.Add(btnLogMain);
			Name = "MainForm";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogMain;
		private Button btnRegistr;
		private Label lblWel;
	}
}
