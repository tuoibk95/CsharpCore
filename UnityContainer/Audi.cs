namespace UnityContainerEx
{
	public class Audi : ICar
	{
		private int _miles = 0;
		public int Run()
		{
			return ++_miles;
		}
	}
}
