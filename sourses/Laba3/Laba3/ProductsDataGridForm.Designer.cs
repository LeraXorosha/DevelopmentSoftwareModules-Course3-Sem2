﻿namespace Laba3
{
	partial class ProductsDataGridForm
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
			dataGridView1 = new DataGridView();
			btnSaveProducts = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(30, 116);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1067, 443);
			dataGridView1.TabIndex = 0;
			// 
			// btnSaveProducts
			// 
			btnSaveProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnSaveProducts.Location = new Point(35, 44);
			btnSaveProducts.Name = "btnSaveProducts";
			btnSaveProducts.Size = new Size(94, 40);
			btnSaveProducts.TabIndex = 1;
			btnSaveProducts.Text = "Save";
			btnSaveProducts.UseVisualStyleBackColor = true;
			// 
			// ProductsDataGridForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1127, 591);
			Controls.Add(btnSaveProducts);
			Controls.Add(dataGridView1);
			Name = "ProductsDataGridForm";
			Text = "ProductsDataGridForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnSaveProducts;
	}
}