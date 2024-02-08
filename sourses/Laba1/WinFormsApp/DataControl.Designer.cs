namespace WinFormsApp
{
	partial class DataControl
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
			btnDelete = new Button();
			btnEdit = new Button();
			lblID = new Label();
			txtFamily = new TextBox();
			txtName = new TextBox();
			txtFather = new TextBox();
			txtAge = new TextBox();
			lblFamily = new Label();
			lblName = new Label();
			lblFather = new Label();
			lblAge = new Label();
			SuspendLayout();
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnDelete.BackColor = Color.Firebrick;
			btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnDelete.ForeColor = SystemColors.Control;
			btnDelete.Location = new Point(867, 40);
			btnDelete.MaximumSize = new Size(114, 39);
			btnDelete.MinimumSize = new Size(114, 39);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(114, 39);
			btnDelete.TabIndex = 5;
			btnDelete.Text = "Удалить";
			btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
			btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnEdit.BackColor = Color.Green;
			btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnEdit.ForeColor = SystemColors.Control;
			btnEdit.Location = new Point(747, 40);
			btnEdit.MaximumSize = new Size(114, 39);
			btnEdit.MinimumSize = new Size(114, 39);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(114, 39);
			btnEdit.TabIndex = 4;
			btnEdit.Text = "Изменить";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// lblID
			// 
			lblID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblID.AutoSize = true;
			lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblID.Location = new Point(13, 49);
			lblID.Name = "lblID";
			lblID.Size = new Size(22, 20);
			lblID.TabIndex = 6;
			lblID.Text = "id";
			lblID.Click += label1_Click_1;
			// 
			// txtFamily
			// 
			txtFamily.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtFamily.Location = new Point(41, 46);
			txtFamily.MaximumSize = new Size(252, 27);
			txtFamily.MinimumSize = new Size(252, 27);
			txtFamily.Name = "txtFamily";
			txtFamily.ReadOnly = true;
			txtFamily.Size = new Size(252, 27);
			txtFamily.TabIndex = 7;
			// 
			// txtName
			// 
			txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtName.Location = new Point(299, 46);
			txtName.MaximumSize = new Size(172, 27);
			txtName.MinimumSize = new Size(172, 27);
			txtName.Name = "txtName";
			txtName.ReadOnly = true;
			txtName.Size = new Size(172, 27);
			txtName.TabIndex = 8;
			// 
			// txtFather
			// 
			txtFather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtFather.Location = new Point(477, 46);
			txtFather.MaximumSize = new Size(196, 27);
			txtFather.MinimumSize = new Size(196, 27);
			txtFather.Name = "txtFather";
			txtFather.ReadOnly = true;
			txtFather.Size = new Size(196, 27);
			txtFather.TabIndex = 9;
			// 
			// txtAge
			// 
			txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtAge.Location = new Point(679, 46);
			txtAge.MaximumSize = new Size(62, 27);
			txtAge.MinimumSize = new Size(62, 27);
			txtAge.Name = "txtAge";
			txtAge.ReadOnly = true;
			txtAge.Size = new Size(62, 27);
			txtAge.TabIndex = 10;
			// 
			// lblFamily
			// 
			lblFamily.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblFamily.AutoSize = true;
			lblFamily.Location = new Point(41, 18);
			lblFamily.Name = "lblFamily";
			lblFamily.Size = new Size(73, 20);
			lblFamily.TabIndex = 11;
			lblFamily.Text = "Фамилия";
			// 
			// lblName
			// 
			lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblName.AutoSize = true;
			lblName.Location = new Point(299, 18);
			lblName.Name = "lblName";
			lblName.Size = new Size(39, 20);
			lblName.TabIndex = 12;
			lblName.Text = "Имя";
			// 
			// lblFather
			// 
			lblFather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblFather.AutoSize = true;
			lblFather.Location = new Point(477, 17);
			lblFather.Name = "lblFather";
			lblFather.Size = new Size(72, 20);
			lblFather.TabIndex = 13;
			lblFather.Text = "Отчество";
			// 
			// lblAge
			// 
			lblAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblAge.AutoSize = true;
			lblAge.Location = new Point(679, 18);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(64, 20);
			lblAge.TabIndex = 14;
			lblAge.Text = "Возраст";
			// 
			// DataControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblAge);
			Controls.Add(lblFather);
			Controls.Add(lblName);
			Controls.Add(lblFamily);
			Controls.Add(txtAge);
			Controls.Add(txtFather);
			Controls.Add(txtName);
			Controls.Add(txtFamily);
			Controls.Add(lblID);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Name = "DataControl";
			Size = new Size(997, 99);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDelete;
		private Button btnEdit;
		private Label lblID;
		private TextBox txtFamily;
		private TextBox txtName;
		private TextBox txtFather;
		private TextBox txtAge;
		private Label lblFamily;
		private Label lblName;
		private Label lblFather;
		private Label lblAge;
	}
}
