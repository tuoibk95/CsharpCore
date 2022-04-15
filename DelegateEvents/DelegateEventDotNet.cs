using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
	public class DelegateEventDotNet
	{
		static void Main(string[] args)
		{
			HocSinh hs = new HocSinh();
			hs.NameChanged += Hs_NameChanged;
			hs.Name = "LVT";
			hs.Name = "LVX";
			Console.ReadLine();
		}

		private static void Hs_NameChanged(object? sender, NameChangedEventArgs e)
		{
			Console.WriteLine("Name changed ..." + e.Name);
		}
	}

	public class HocSinh
	{
		private string _Name;

		// Sự kiện
		private event EventHandler<NameChangedEventArgs> _NameChanged;
		// Event nhận hàm ủy thác add và remove
		public event EventHandler<NameChangedEventArgs> NameChanged
		{
			add
			{
				_NameChanged += value;
			}
			remove
			{
				_NameChanged -= value;
			}
		}

		public string Name
		{
			get => _Name;
			set
			{
				_Name = value;
				OnNameChanged(_Name);
			}
		}

		void OnNameChanged(string name)
		{
			if (_NameChanged != null)
			{
				_NameChanged(this, new NameChangedEventArgs(name));
			}
		}
	}

	public class NameChangedEventArgs : EventArgs
	{
		public string Name { get; set; }
		public NameChangedEventArgs(string name)
		{
			Name = name;
		}
	}

}
