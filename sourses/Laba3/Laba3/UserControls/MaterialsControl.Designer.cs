namespace Laba3.UserControls
{
	partial class MaterialsControl
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
			lblIdMaterial = new Label();
			lblNameMaterial = new Label();
			tbIdMaterial = new TextBox();
			tbNameMaterial = new TextBox();
			btnProductsMaterial = new Button();
			lblProductsMaterial = new Label();
			SuspendLayout();
			// 
			// lblIdMaterial
			// 
			lblIdMaterial.AutoSize = true;
			lblIdMaterial.Location = new Point(20, 18);
			lblIdMaterial.Name = "lblIdMaterial";
			lblIdMaterial.Size = new Size(22, 20);
			lblIdMaterial.TabIndex = 0;
			lblIdMaterial.Text = "id";
			// 
			// lblNameMaterial
			// 
			lblNameMaterial.AutoSize = true;
			lblNameMaterial.Location = new Point(92, 18);
			lblNameMaterial.Name = "lblNameMaterial";
			lblNameMaterial.Size = new Size(49, 20);
			lblNameMaterial.TabIndex = 1;
			lblNameMaterial.Text = "Name";
			// 
			// tbIdMaterial
			// 
			tbIdMaterial.Location = new Point(20, 45);
			tbIdMaterial.Name = "tbIdMaterial";
			tbIdMaterial.Size = new Size(50, 27);
			tbIdMaterial.TabIndex = 2;
			// 
			// tbNameMaterial
			// 
			tbNameMaterial.Location = new Point(92, 46);
			tbNameMaterial.Name = "tbNameMaterial";
			tbNameMaterial.Size = new Size(183, 27);
			tbNameMaterial.TabIndex = 3;
			// 
			// btnProductsMaterial
			// 
			btnProductsMaterial.BackColor = Color.FromArgb(192, 255, 192);
			btnProductsMaterial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnProductsMaterial.Location = new Point(296, 44);
			btnProductsMaterial.Name = "btnProductsMaterial";
			btnProductsMaterial.Size = new Size(94, 29);
			btnProductsMaterial.TabIndex = 4;
			btnProductsMaterial.Text = "view";
			btnProductsMaterial.UseVisualStyleBackColor = false;
			btnProductsMaterial.Click += btnProductsMaterial_Click;
			// 
			// lblProductsMaterial
			// 
			lblProductsMaterial.AutoSize = true;
			lblProductsMaterial.Location = new Point(296, 18);
			lblProductsMaterial.Name = "lblProductsMaterial";
			lblProductsMaterial.Size = new Size(66, 20);
			lblProductsMaterial.TabIndex = 5;
			lblProductsMaterial.Text = "Products";
			// 
			// MaterialsControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblProductsMaterial);
			Controls.Add(btnProductsMaterial);
			Controls.Add(tbNameMaterial);
			Controls.Add(tbIdMaterial);
			Controls.Add(lblNameMaterial);
			Controls.Add(lblIdMaterial);
			Name = "MaterialsControl";
			Size = new Size(408, 90);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblIdMaterial;
		private Label lblNameMaterial;
		private TextBox tbIdMaterial;
		private TextBox tbNameMaterial;
		private Button btnProductsMaterial;
		private Label lblProductsMaterial;
	}
}
