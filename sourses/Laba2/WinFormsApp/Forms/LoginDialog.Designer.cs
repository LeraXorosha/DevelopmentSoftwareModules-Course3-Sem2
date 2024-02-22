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
			txrLogLog = new TextBox();
			label1 = new Label();
			btnLogin = new Button();
			lblPassw = new Label();
			txtLogPas = new TextBox();
			SuspendLayout();
			// 
			// txrLogLog
			// 
			txrLogLog.Location = new Point(67, 61);
			txrLogLog.Name = "txrLogLog";
			txrLogLog.Size = new Size(269, 27);
			txrLogLog.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(67, 38);
			label1.Name = "label1";
			label1.Size = new Size(43, 20);
			label1.TabIndex = 3;
			label1.Text = "login";
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(111, 170);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(175, 52);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// lblPassw
			// 
			lblPassw.AutoSize = true;
			lblPassw.Location = new Point(67, 101);
			lblPassw.Name = "lblPassw";
			lblPassw.Size = new Size(72, 20);
			lblPassw.TabIndex = 6;
			lblPassw.Text = "password";
			// 
			// txtLogPas
			// 
			txtLogPas.Location = new Point(67, 124);
			txtLogPas.Name = "txtLogPas";
			txtLogPas.Size = new Size(269, 27);
			txtLogPas.TabIndex = 5;
			// 
			// LoginDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(417, 264);
			Controls.Add(lblPassw);
			Controls.Add(txtLogPas);
			Controls.Add(btnLogin);
			Controls.Add(label1);
			Controls.Add(txrLogLog);
			Name = "LoginDialog";
			Text = "LoginForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MyUserControl1 myUserControl11;
		private MyUserControl1 myUserControl12;
		private TextBox txrLogLog;
		private Label label1;
		private Button btnLogin;
		private Label lblPassw;
		private TextBox txtLogPas;
	}
}