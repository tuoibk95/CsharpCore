using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Mock
{
	public class FakeLogger : ILogger
	{
		public void LogInfo(string info)
		{
			Console.WriteLine("Fake log");
		}
	}
}
