namespace Laba3.Forms
{
	partial class MaterialsCustomForm
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
			btnSaveMaterialsCust = new Button();
			PanelMaterial = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// btnSaveMaterialsCust
			// 
			btnSaveMaterialsCust.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnSaveMaterialsCust.Location = new Point(28, 23);
			btnSaveMaterialsCust.Name = "btnSaveMaterialsCust";
			btnSaveMaterialsCust.Size = new Size(94, 40);
			btnSaveMaterialsCust.TabIndex = 2;
			btnSaveMaterialsCust.Text = "Save";
			btnSaveMaterialsCust.UseVisualStyleBackColor = true;
			btnSaveMaterialsCust.Click += btnSaveMaterialsCust_Click;
			// 
			// PanelMaterial
			// 
			PanelMaterial.Location = new Point(28, 91);
			PanelMaterial.Name = "PanelMaterial";
			PanelMaterial.Size = new Size(424, 411);
			PanelMaterial.TabIndex = 3;
			// 
			// MaterialsCustomForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(490, 527);
			Controls.Add(PanelMaterial);
			Controls.Add(btnSaveMaterialsCust);
			Name = "MaterialsCustomForm";
			Text = "MaterialsCustomForm";
			Load += MaterialsCustomForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnSaveMaterialsCust;
		private FlowLayoutPanel PanelMaterial;
	}
}