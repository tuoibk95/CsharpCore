using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Implement
{
	public class Logger : ILogger
	{
		public void LogInfo(string info)
		{
			Console.WriteLine("Write Real Log");
		}
	}
}
