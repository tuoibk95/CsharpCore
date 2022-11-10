namespace Interface
{
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

		//public static void Main()
		//{
		//	InterfaceEx s = new InterfaceEx();
		//	s.Speak();
		//	s.Speak1();
		//	AbstractClass s1 = new InterfaceEx();
		//	s1.Speak1();

		//	string a = "";
		//	string b = string.Empty;
		//	if (a == b)
		//	{
		//		Console.WriteLine("ss = ok");
		//	}
		//}
	}
}
