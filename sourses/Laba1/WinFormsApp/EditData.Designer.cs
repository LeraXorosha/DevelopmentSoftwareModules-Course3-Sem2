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
			txtEditId = new TextBox();
			txtEditFamily = new TextBox();
			btnSave = new Button();
			lblEditId = new Label();
			lblEditFamily = new Label();
			lblEditName = new Label();
			txtEditName = new TextBox();
			lblEditFather = new Label();
			txtEditFather = new TextBox();
			lblEditAge = new Label();
			txtEditAge = new TextBox();
			SuspendLayout();
			// 
			// txtEditId
			// 
			txtEditId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtEditId.Location = new Point(244, 28);
			txtEditId.Name = "txtEditId";
			txtEditId.ReadOnly = true;
			txtEditId.Size = new Size(51, 27);
			txtEditId.TabIndex = 0;
			// 
			// txtEditFamily
			// 
			txtEditFamily.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtEditFamily.Location = new Point(43, 104);
			txtEditFamily.Name = "txtEditFamily";
			txtEditFamily.Size = new Size(252, 27);
			txtEditFamily.TabIndex = 1;
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
			btnSave.Click += btnSave_Click;
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
			// txtEditName
			// 
			txtEditName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtEditName.Location = new Point(43, 176);
			txtEditName.Name = "txtEditName";
			txtEditName.Size = new Size(252, 27);
			txtEditName.TabIndex = 8;
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
			// txtEditFather
			// 
			txtEditFather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtEditFather.Location = new Point(43, 243);
			txtEditFather.Name = "txtEditFather";
			txtEditFather.Size = new Size(252, 27);
			txtEditFather.TabIndex = 10;
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
			// txtEditAge
			// 
			txtEditAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtEditAge.Location = new Point(43, 309);
			txtEditAge.Name = "txtEditAge";
			txtEditAge.Size = new Size(252, 27);
			txtEditAge.TabIndex = 12;
			// 
			// EditData
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(339, 450);
			Controls.Add(lblEditAge);
			Controls.Add(txtEditAge);
			Controls.Add(lblEditFather);
			Controls.Add(txtEditFather);
			Controls.Add(lblEditName);
			Controls.Add(txtEditName);
			Controls.Add(lblEditFamily);
			Controls.Add(lblEditId);
			Controls.Add(btnSave);
			Controls.Add(txtEditFamily);
			Controls.Add(txtEditId);
			Name = "EditData";
			Text = "EditData";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtEditId;
		private TextBox txtEditFamily;
		private Button btnSave;
		private Label lblEditId;
		private Label lblEditFamily;
		private Label lblEditName;
		private TextBox txtEditName;
		private Label lblEditFather;
		private TextBox txtEditFather;
		private Label lblEditAge;
		private TextBox txtEditAge;
	}
}