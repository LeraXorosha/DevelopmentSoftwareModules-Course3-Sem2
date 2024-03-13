namespace Laba3.Forms
{
	partial class ProductsCustomForm
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
			btnSaveProductsCust = new Button();
			PanelProducts = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// btnSaveProductsCust
			// 
			btnSaveProductsCust.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnSaveProductsCust.Location = new Point(32, 30);
			btnSaveProductsCust.Name = "btnSaveProductsCust";
			btnSaveProductsCust.Size = new Size(94, 40);
			btnSaveProductsCust.TabIndex = 2;
			btnSaveProductsCust.Text = "Save";
			btnSaveProductsCust.UseVisualStyleBackColor = true;
			btnSaveProductsCust.Click += btnSaveProductsCust_Click;
			// 
			// PanelProducts
			// 
			PanelProducts.AutoScroll = true;
			PanelProducts.Location = new Point(32, 89);
			PanelProducts.Name = "PanelProducts";
			PanelProducts.Size = new Size(1115, 412);
			PanelProducts.TabIndex = 3;
			// 
			// ProductsCustomForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1179, 534);
			Controls.Add(PanelProducts);
			Controls.Add(btnSaveProductsCust);
			Name = "ProductsCustomForm";
			Text = "ProductsCustomForm";
			Load += ProductsCustomForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnSaveProductsCust;
		private FlowLayoutPanel PanelProducts;
	}
}