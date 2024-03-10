namespace Laba3.UserControls
{
	partial class ProductsControl
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
			lblPriceProduct = new Label();
			tbNameProduct = new TextBox();
			tbIdProduct = new TextBox();
			lblNameProduct = new Label();
			lblIdProduct = new Label();
			tbPriceProduct = new TextBox();
			cbMaterialProduct = new ComboBox();
			lblMaterialProduct = new Label();
			SuspendLayout();
			// 
			// lblPriceProduct
			// 
			lblPriceProduct.AutoSize = true;
			lblPriceProduct.Location = new Point(693, 12);
			lblPriceProduct.Name = "lblPriceProduct";
			lblPriceProduct.Size = new Size(41, 20);
			lblPriceProduct.TabIndex = 11;
			lblPriceProduct.Text = "Price";
			// 
			// tbNameProduct
			// 
			tbNameProduct.Location = new Point(88, 40);
			tbNameProduct.Name = "tbNameProduct";
			tbNameProduct.Size = new Size(580, 27);
			tbNameProduct.TabIndex = 9;
			// 
			// tbIdProduct
			// 
			tbIdProduct.Location = new Point(16, 39);
			tbIdProduct.Name = "tbIdProduct";
			tbIdProduct.Size = new Size(50, 27);
			tbIdProduct.TabIndex = 8;
			// 
			// lblNameProduct
			// 
			lblNameProduct.AutoSize = true;
			lblNameProduct.Location = new Point(88, 12);
			lblNameProduct.Name = "lblNameProduct";
			lblNameProduct.Size = new Size(49, 20);
			lblNameProduct.TabIndex = 7;
			lblNameProduct.Text = "Name";
			// 
			// lblIdProduct
			// 
			lblIdProduct.AutoSize = true;
			lblIdProduct.Location = new Point(16, 12);
			lblIdProduct.Name = "lblIdProduct";
			lblIdProduct.Size = new Size(22, 20);
			lblIdProduct.TabIndex = 6;
			lblIdProduct.Text = "id";
			// 
			// tbPriceProduct
			// 
			tbPriceProduct.Location = new Point(693, 40);
			tbPriceProduct.Name = "tbPriceProduct";
			tbPriceProduct.Size = new Size(183, 27);
			tbPriceProduct.TabIndex = 12;
			// 
			// cbMaterialProduct
			// 
			cbMaterialProduct.FormattingEnabled = true;
			cbMaterialProduct.Location = new Point(899, 39);
			cbMaterialProduct.Name = "cbMaterialProduct";
			cbMaterialProduct.Size = new Size(183, 28);
			cbMaterialProduct.TabIndex = 13;
			// 
			// lblMaterialProduct
			// 
			lblMaterialProduct.AutoSize = true;
			lblMaterialProduct.Location = new Point(899, 12);
			lblMaterialProduct.Name = "lblMaterialProduct";
			lblMaterialProduct.Size = new Size(64, 20);
			lblMaterialProduct.TabIndex = 14;
			lblMaterialProduct.Text = "Material";
			// 
			// ProductsControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lblMaterialProduct);
			Controls.Add(cbMaterialProduct);
			Controls.Add(tbPriceProduct);
			Controls.Add(lblPriceProduct);
			Controls.Add(tbNameProduct);
			Controls.Add(tbIdProduct);
			Controls.Add(lblNameProduct);
			Controls.Add(lblIdProduct);
			Name = "ProductsControl";
			Size = new Size(1103, 81);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPriceProduct;
		private TextBox tbNameProduct;
		private TextBox tbIdProduct;
		private Label lblNameProduct;
		private Label lblIdProduct;
		private TextBox tbPriceProduct;
		private ComboBox cbMaterialProduct;
		private Label lblMaterialProduct;
	}
}
