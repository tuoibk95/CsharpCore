namespace polymorphismClass
{
	public abstract class Animal
	{
		// Lớp cha phải là phương thức virtual thì phương thức dẫn xuất mới có thể override
		//public virtual void Speak()
		//{
		//	Console.WriteLine(" Animal is speaking. . .");
		//}

		public abstract void Speak();

	}
}
