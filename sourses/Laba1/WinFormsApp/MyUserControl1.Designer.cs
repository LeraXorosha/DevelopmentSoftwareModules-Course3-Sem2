namespace WinFormsApp
{
	partial class MyUserControl1
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			btnShowPassword = new Button();
			txtShowPassword = new TextBox();
			lblShowPassword = new Label();
			SuspendLayout();
			// 
			// btnShowPassword
			// 
			btnShowPassword.Anchor = AnchorStyles.Right;
			btnShowPassword.Location = new Point(314, 46);
			btnShowPassword.Name = "btnShowPassword";
			btnShowPassword.Size = new Size(34, 29);
			btnShowPassword.TabIndex = 0;
			btnShowPassword.Text = "👀";
			btnShowPassword.UseVisualStyleBackColor = true;
			btnShowPassword.Click += button1_Click;
			// 
			// txtShowPassword
			// 
			txtShowPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtShowPassword.Location = new Point(16, 44);
			txtShowPassword.MaximumSize = new Size(0, 32);
			txtShowPassword.MinimumSize = new Size(220, 32);
			txtShowPassword.Name = "txtShowPassword";
			txtShowPassword.Size = new Size(277, 32);
			txtShowPassword.TabIndex = 1;
			// 
			// lblShowPassword
			// 
			lblShowPassword.AutoSize = true;
			lblShowPassword.Location = new Point(16, 15);
			lblShowPassword.Name = "lblShowPassword";
			lblShowPassword.Size = new Size(50, 20);
			lblShowPassword.TabIndex = 2;
			lblShowPassword.Text = "label1";
			// 
			// MyUserControl1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblShowPassword);
			Controls.Add(txtShowPassword);
			Controls.Add(btnShowPassword);
			Name = "MyUserControl1";
			Size = new Size(365, 95);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnShowPassword;
		private TextBox txtShowPassword;
		private Label lblShowPassword;
	}
}
