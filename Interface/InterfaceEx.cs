namespace Interface
{
	/// <summary>
	/// The default access level for all interface members is public.
	/// An interface member whose declaration includes a body is a virtual member unless the sealed or private modifier is used.
	/// A private or sealed function member of an interface must have implementation body.
	/// Interfaces may declare static members which can be accessed by interface name.
	/// </summary>
	public class InterfaceEx : AbstractClass, ISpeak
	{
		public void Speak()
		{
			Console.WriteLine("abc0");
		}

		public override void Speak1()
		{
			Console.WriteLine("abc");
			Console.WriteLine(base.Age);
		}

		public static void Main()
		{
			InterfaceEx s = new InterfaceEx();
			s.Speak();
			s.Speak1();
			AbstractClass s1 = new InterfaceEx();
			s1.Speak1();

			string a = "";
			string b = string.Empty;
			if (a == b)
			{
				Console.WriteLine("ss = ok");
			}
		}
	}
}
