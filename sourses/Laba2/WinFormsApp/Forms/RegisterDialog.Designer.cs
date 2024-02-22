namespace WinFormsApp.Forms
{
	partial class RegisterDialog
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
			lblPassw = new Label();
			txrRegPas = new TextBox();
			btnRegis = new Button();
			label1 = new Label();
			txtRegLog = new TextBox();
			lblPasAgain = new Label();
			txrRegPasAg = new TextBox();
			SuspendLayout();
			// 
			// lblPassw
			// 
			lblPassw.AutoSize = true;
			lblPassw.Location = new Point(77, 127);
			lblPassw.Name = "lblPassw";
			lblPassw.Size = new Size(72, 20);
			lblPassw.TabIndex = 16;
			lblPassw.Text = "password";
			// 
			// txrRegPas
			// 
			txrRegPas.Location = new Point(77, 150);
			txrRegPas.Name = "txrRegPas";
			txrRegPas.Size = new Size(269, 27);
			txrRegPas.TabIndex = 15;
			// 
			// btnRegis
			// 
			btnRegis.Location = new Point(119, 294);
			btnRegis.Name = "btnRegis";
			btnRegis.Size = new Size(175, 52);
			btnRegis.TabIndex = 14;
			btnRegis.Text = "Registr";
			btnRegis.UseVisualStyleBackColor = true;
			btnRegis.Click += btnRegis_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(77, 64);
			label1.Name = "label1";
			label1.Size = new Size(43, 20);
			label1.TabIndex = 13;
			label1.Text = "login";
			// 
			// txtRegLog
			// 
			txtRegLog.Location = new Point(77, 87);
			txtRegLog.Name = "txtRegLog";
			txtRegLog.Size = new Size(269, 27);
			txtRegLog.TabIndex = 12;
			// 
			// lblPasAgain
			// 
			lblPasAgain.AutoSize = true;
			lblPasAgain.Location = new Point(77, 203);
			lblPasAgain.Name = "lblPasAgain";
			lblPasAgain.Size = new Size(113, 20);
			lblPasAgain.TabIndex = 18;
			lblPasAgain.Text = "password again";
			// 
			// txrRegPasAg
			// 
			txrRegPasAg.Location = new Point(77, 226);
			txrRegPasAg.Name = "txrRegPasAg";
			txrRegPasAg.Size = new Size(269, 27);
			txrRegPasAg.TabIndex = 17;
			// 
			// RegisterDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(440, 398);
			Controls.Add(lblPasAgain);
			Controls.Add(txrRegPasAg);
			Controls.Add(lblPassw);
			Controls.Add(txrRegPas);
			Controls.Add(btnRegis);
			Controls.Add(label1);
			Controls.Add(txtRegLog);
			Name = "RegisterDialog";
			Text = "RegisterDialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPassw;
		private TextBox txrRegPas;
		private Button btnRegis;
		private Label label1;
		private TextBox txtRegLog;
		private Label lblPasAgain;
		private TextBox txrRegPasAg;
	}
}