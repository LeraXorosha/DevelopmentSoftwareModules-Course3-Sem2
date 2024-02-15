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
			SuspendLayout();
			// 
			// btnLogMain
			// 
			btnLogMain.Location = new Point(630, 28);
			btnLogMain.Name = "btnLogMain";
			btnLogMain.Size = new Size(94, 29);
			btnLogMain.TabIndex = 0;
			btnLogMain.Text = "Login";
			btnLogMain.UseVisualStyleBackColor = true;

			// 
			// btnRegistr
			// 
			btnRegistr.Location = new Point(630, 63);
			btnRegistr.Name = "btnRegistr";
			btnRegistr.Size = new Size(94, 29);
			btnRegistr.TabIndex = 1;
			btnRegistr.Text = "Registration";
			btnRegistr.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnRegistr);
			Controls.Add(btnLogMain);
			Name = "MainForm";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnLogMain;
		private Button btnRegistr;
	}
}
