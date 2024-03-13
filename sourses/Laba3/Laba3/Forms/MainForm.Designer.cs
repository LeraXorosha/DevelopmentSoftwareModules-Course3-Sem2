namespace Laba3
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnOpenMaterials = new Button();
			btnOpenProducts = new Button();
			btnOpenCustProducts = new Button();
			btnOpenCustMaterials = new Button();
			SuspendLayout();
			// 
			// btnOpenMaterials
			// 
			btnOpenMaterials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnOpenMaterials.Location = new Point(106, 29);
			btnOpenMaterials.Name = "btnOpenMaterials";
			btnOpenMaterials.Size = new Size(212, 178);
			btnOpenMaterials.TabIndex = 0;
			btnOpenMaterials.Text = "Open materials ";
			btnOpenMaterials.UseVisualStyleBackColor = true;
			btnOpenMaterials.Click += btnOpenMaterials_Click;
			// 
			// btnOpenProducts
			// 
			btnOpenProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnOpenProducts.Location = new Point(375, 29);
			btnOpenProducts.Name = "btnOpenProducts";
			btnOpenProducts.Size = new Size(212, 178);
			btnOpenProducts.TabIndex = 1;
			btnOpenProducts.Text = "Open products";
			btnOpenProducts.UseVisualStyleBackColor = true;
			btnOpenProducts.Click += btnOpenProducts_Click;
			// 
			// btnOpenCustProducts
			// 
			btnOpenCustProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnOpenCustProducts.Location = new Point(375, 240);
			btnOpenCustProducts.Name = "btnOpenCustProducts";
			btnOpenCustProducts.Size = new Size(212, 178);
			btnOpenCustProducts.TabIndex = 3;
			btnOpenCustProducts.Text = "Open products  custom";
			btnOpenCustProducts.UseVisualStyleBackColor = true;
			btnOpenCustProducts.Click += btnOpenCustProducts_Click;
			// 
			// btnOpenCustMaterials
			// 
			btnOpenCustMaterials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnOpenCustMaterials.Location = new Point(106, 240);
			btnOpenCustMaterials.Name = "btnOpenCustMaterials";
			btnOpenCustMaterials.Size = new Size(212, 178);
			btnOpenCustMaterials.TabIndex = 2;
			btnOpenCustMaterials.Text = "Open materials custom";
			btnOpenCustMaterials.UseVisualStyleBackColor = true;
			btnOpenCustMaterials.Click += btnOpenCustMaterials_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(715, 450);
			Controls.Add(btnOpenCustProducts);
			Controls.Add(btnOpenCustMaterials);
			Controls.Add(btnOpenProducts);
			Controls.Add(btnOpenMaterials);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
		}

		#endregion

		private Button btnOpenMaterials;
		private Button btnOpenProducts;
		private Button btnOpenCustProducts;
		private Button btnOpenCustMaterials;
	}
}
