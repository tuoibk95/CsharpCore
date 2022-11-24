using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Mock
{
	public class XMLDatabase : IDatabase
	{
		public void Save(int orderId)
		{
			Console.WriteLine("Fake Save to XML file");
		}
	}
}
