namespace WinFormsApp.Forms
{
	partial class LoginDialog
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
			textBox1 = new TextBox();
			label1 = new Label();
			btnLogin = new Button();
			lblPassw = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(62, 153);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(269, 27);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(62, 130);
			label1.Name = "label1";
			label1.Size = new Size(43, 20);
			label1.TabIndex = 3;
			label1.Text = "login";
			label1.Click += label1_Click;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(109, 393);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(175, 52);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			// 
			// lblPassw
			// 
			lblPassw.AutoSize = true;
			lblPassw.Location = new Point(62, 193);
			lblPassw.Name = "lblPassw";
			lblPassw.Size = new Size(43, 20);
			lblPassw.TabIndex = 6;
			lblPassw.Text = "login";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(62, 216);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(269, 27);
			textBox2.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(62, 254);
			label3.Name = "label3";
			label3.Size = new Size(43, 20);
			label3.TabIndex = 8;
			label3.Text = "login";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(62, 277);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(269, 27);
			textBox3.TabIndex = 7;
			// 
			// LoginDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(417, 534);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(lblPassw);
			Controls.Add(textBox2);
			Controls.Add(btnLogin);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "LoginDialog";
			Text = "LoginForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MyUserControl1 myUserControl11;
		private MyUserControl1 myUserControl12;
		private TextBox textBox1;
		private Label label1;
		private Button btnLogin;
		private Label lblPassw;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox3;
	}
}