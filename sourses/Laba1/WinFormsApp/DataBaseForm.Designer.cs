namespace WinFormsApp
{
	partial class DataBaseForm
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
			btnFormAdd = new Button();
			lblCount = new Label();
			lblSumAge = new Label();
			txtCount = new TextBox();
			txtSumAge = new TextBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// btnFormAdd
			// 
			btnFormAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnFormAdd.BackColor = Color.Green;
			btnFormAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnFormAdd.ForeColor = SystemColors.Control;
			btnFormAdd.Location = new Point(899, 56);
			btnFormAdd.MaximumSize = new Size(136, 44);
			btnFormAdd.MinimumSize = new Size(136, 44);
			btnFormAdd.Name = "btnFormAdd";
			btnFormAdd.Size = new Size(136, 44);
			btnFormAdd.TabIndex = 1;
			btnFormAdd.Text = "Добавить";
			btnFormAdd.UseVisualStyleBackColor = false;
			btnFormAdd.Click += btnFormAdd_Click;
			// 
			// lblCount
			// 
			lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblCount.AutoSize = true;
			lblCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblCount.Location = new Point(361, 66);
			lblCount.Name = "lblCount";
			lblCount.Size = new Size(131, 23);
			lblCount.TabIndex = 2;
			lblCount.Text = "Всего записей:";
			// 
			// lblSumAge
			// 
			lblSumAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblSumAge.AutoSize = true;
			lblSumAge.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblSumAge.Location = new Point(650, 66);
			lblSumAge.Name = "lblSumAge";
			lblSumAge.Size = new Size(102, 23);
			lblSumAge.TabIndex = 3;
			lblSumAge.Text = "Сумма лет:";
			// 
			// txtCount
			// 
			txtCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtCount.Location = new Point(498, 66);
			txtCount.MaximumSize = new Size(125, 27);
			txtCount.MinimumSize = new Size(125, 27);
			txtCount.Name = "txtCount";
			txtCount.ReadOnly = true;
			txtCount.Size = new Size(125, 27);
			txtCount.TabIndex = 4;
			txtCount.TextChanged += txtCount_TextChanged;
			// 
			// txtSumAge
			// 
			txtSumAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtSumAge.Location = new Point(758, 66);
			txtSumAge.MaximumSize = new Size(125, 27);
			txtSumAge.MinimumSize = new Size(125, 27);
			txtSumAge.Name = "txtSumAge";
			txtSumAge.ReadOnly = true;
			txtSumAge.Size = new Size(125, 27);
			txtSumAge.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(48, 128);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1010, 394);
			flowLayoutPanel1.TabIndex = 6;
			flowLayoutPanel1.WrapContents = false;
			// 
			// DataBaseForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1103, 643);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(txtSumAge);
			Controls.Add(txtCount);
			Controls.Add(lblSumAge);
			Controls.Add(lblCount);
			Controls.Add(btnFormAdd);
			Name = "DataBaseForm";
			Text = "DataBaseForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnFormAdd;
		private Label lblCount;
		private Label lblSumAge;
		private TextBox txtCount;
		private TextBox txtSumAge;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}