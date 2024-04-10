namespace Laba3
{
	partial class MaterialsDataGridForm
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
			dataGridMaterials = new DataGridView();
			btnOpenMaterials = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridMaterials).BeginInit();
			SuspendLayout();
			// 
			// dataGridMaterials
			// 
			dataGridMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridMaterials.Location = new Point(30, 116);
			dataGridMaterials.Name = "dataGridMaterials";
			dataGridMaterials.RowHeadersWidth = 51;
			dataGridMaterials.Size = new Size(1067, 443);
			dataGridMaterials.TabIndex = 0;
			// 
			// btnOpenMaterials
			// 
			btnOpenMaterials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnOpenMaterials.Location = new Point(35, 44);
			btnOpenMaterials.Name = "btnOpenMaterials";
			btnOpenMaterials.Size = new Size(94, 40);
			btnOpenMaterials.TabIndex = 1;
			btnOpenMaterials.Text = "Save";
			btnOpenMaterials.UseVisualStyleBackColor = true;
			btnOpenMaterials.Click += btnOpenMaterials_Click;
			// 
			// MaterialsDataGridForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1127, 591);
			Controls.Add(btnOpenMaterials);
			Controls.Add(dataGridMaterials);
			Name = "MaterialsDataGridForm";
			Text = "MaterialsDataGridForm";
			Load += MaterialsDataGridForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridMaterials).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridMaterials;
		private Button btnOpenMaterials;
	}
}