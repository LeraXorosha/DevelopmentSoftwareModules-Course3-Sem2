using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
	public partial class MyComponent : Component
	{
		public int interval { get; set; } = 1000;
		public event EventHandler Tick;
		public bool Enabled { get; set; } = false;


		public void Start()
		{
			Enabled = true;
		}

		public void Stop()
		{
			Enabled = false;
		}

		private async void Worker()
		{
			while (true)
			{
				while (Enabled)
				{
					await Task.Delay(interval);
					Tick.Invoke(this, EventArgs.Empty); //при подписание на событие, оно происходит это вызов inwoke
				}
			}
			
		}
		public MyComponent()
		{
			InitializeComponent();

		}

		public MyComponent(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
