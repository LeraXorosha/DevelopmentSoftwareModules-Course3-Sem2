namespace WinFormsApp
{
	partial class MyForm
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
			components = new System.ComponentModel.Container();
			myComponent = new MyComponent(components);
			SuspendLayout();
			// 
			// myComponent
			// 
			myComponent.Enabled = false;
			myComponent.interval = 1000;
			myComponent.Tick += myComponent_Tick;
			// 
			// MyForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Name = "MyForm";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private MyUserControl1 myUserControl11;
		private MyComponent myComponent;
	}
}
