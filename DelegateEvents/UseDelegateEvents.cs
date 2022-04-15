
namespace DelegateEvents
{
	public delegate string DelegateEvent(string str, int a);

	public class UseDelegateEvents
	{
		private event DelegateEvent MyEventDelegate;

		public UseDelegateEvents()
		{
			this.MyEventDelegate += new DelegateEvent(this.WelcomeUser);
			Console.CancelKeyPress += Console_CancelKeyPress;
		}

		private void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
		{
			throw new NotImplementedException();
		}

		public string WelcomeUser(string username, int age)
		{
			return "Test Event Delegate " + username + age;
		}

		//static void Main(string[] args)
		//{
		//	UseDelegateEvents objInstance = new UseDelegateEvents();
		//	string result = objInstance.MyEventDelegate("LVT", 6);
		//	Console.WriteLine(result);
		//}
	}
}