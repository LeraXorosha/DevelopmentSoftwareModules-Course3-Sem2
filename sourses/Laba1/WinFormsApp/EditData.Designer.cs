namespace WinFormsApp
{
	partial class EditData
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
			textBox2 = new TextBox();
			btnSave = new Button();
			lblEditId = new Label();
			lblEditFamily = new Label();
			lblEditName = new Label();
			textBox3 = new TextBox();
			lblEditFather = new Label();
			textBox4 = new TextBox();
			lblEditAge = new Label();
			textBox5 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(244, 28);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(51, 27);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Location = new Point(43, 104);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(252, 27);
			textBox2.TabIndex = 1;
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnSave.BackColor = Color.Green;
			btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnSave.ForeColor = SystemColors.Control;
			btnSave.Location = new Point(82, 368);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(156, 46);
			btnSave.TabIndex = 5;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = false;
			// 
			// lblEditId
			// 
			lblEditId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblEditId.AutoSize = true;
			lblEditId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblEditId.Location = new Point(213, 31);
			lblEditId.Name = "lblEditId";
			lblEditId.Size = new Size(25, 20);
			lblEditId.TabIndex = 6;
			lblEditId.Text = "ID";
			// 
			// lblEditFamily
			// 
			lblEditFamily.AutoSize = true;
			lblEditFamily.Location = new Point(42, 80);
			lblEditFamily.Name = "lblEditFamily";
			lblEditFamily.Size = new Size(73, 20);
			lblEditFamily.TabIndex = 7;
			lblEditFamily.Text = "Фамилия";
			// 
			// lblEditName
			// 
			lblEditName.AutoSize = true;
			lblEditName.Location = new Point(42, 152);
			lblEditName.Name = "lblEditName";
			lblEditName.Size = new Size(39, 20);
			lblEditName.TabIndex = 9;
			lblEditName.Text = "Имя";
			// 
			// textBox3
			// 
			textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox3.Location = new Point(43, 176);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(252, 27);
			textBox3.TabIndex = 8;
			// 
			// lblEditFather
			// 
			lblEditFather.AutoSize = true;
			lblEditFather.Location = new Point(42, 219);
			lblEditFather.Name = "lblEditFather";
			lblEditFather.Size = new Size(72, 20);
			lblEditFather.TabIndex = 11;
			lblEditFather.Text = "Отчество";
			// 
			// textBox4
			// 
			textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox4.Location = new Point(43, 243);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(252, 27);
			textBox4.TabIndex = 10;
			// 
			// lblEditAge
			// 
			lblEditAge.AutoSize = true;
			lblEditAge.Location = new Point(42, 285);
			lblEditAge.Name = "lblEditAge";
			lblEditAge.Size = new Size(64, 20);
			lblEditAge.TabIndex = 13;
			lblEditAge.Text = "Возраст";
			// 
			// textBox5
			// 
			textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox5.Location = new Point(43, 309);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(252, 27);
			textBox5.TabIndex = 12;
			// 
			// EditData
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(339, 450);
			Controls.Add(lblEditAge);
			Controls.Add(textBox5);
			Controls.Add(lblEditFather);
			Controls.Add(textBox4);
			Controls.Add(lblEditName);
			Controls.Add(textBox3);
			Controls.Add(lblEditFamily);
			Controls.Add(lblEditId);
			Controls.Add(btnSave);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "EditData";
			Text = "EditData";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Button btnSave;
		private Label lblEditId;
		private Label lblEditFamily;
		private Label lblEditName;
		private TextBox textBox3;
		private Label lblEditFather;
		private TextBox textBox4;
		private Label lblEditAge;
		private TextBox textBox5;
	}
}