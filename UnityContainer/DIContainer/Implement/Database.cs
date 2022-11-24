using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Implement
{
	public class Database : IDatabase
	{
		public void Save(int orderId)
		{
			Console.WriteLine("Saved to real database");
		}
	}
}
