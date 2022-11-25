namespace UnityContainerEx
{
	public class BMW : ICar
	{
		private int _miles = 0;
		public int Run()
		{
			return ++_miles;
		}
	}
}
