﻿using laba4.Model.Database.Entity;
using laba4.Services.Implementations;
using laba4.Services.Interfaces;
using laba4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laba4.View
{
	/// <summary>
	/// Логика взаимодействия для MaterialDataGridWindow.xaml
	/// </summary>
	public partial class MaterialDataGridWindow : Window
	{
		public event EventHandler SaveBtnClicked = null!;

		public MaterialDataGridWindow()
		{
			InitializeComponent();
		}

		private void btn_save_materials(object sender, RoutedEventArgs e)
		{
			SaveBtnClicked?.Invoke(this, EventArgs.Empty);
		}

    }
}
