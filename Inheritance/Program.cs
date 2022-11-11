using System;

namespace Inheritance_ex
{
	class Bird
	{
		private int weight;

		public int Weight
		{
			get => weight;
			set {
				if (value > 0)
				{
					weight = value;
				}
			}
		}
		public Bird() => Console.WriteLine("Bird created");
		public Bird(int weight)
		{
			this.weight = weight;
			Console.WriteLine($"Bird created, {weight} gr.");
		}
		public void Feed() => weight += 10;
		public void Fly() => Console.WriteLine("Bird is flying");
	}

	class Parrot : Bird
	{
		public Parrot() => Console.WriteLine("Parrot created");
		// Hàm tạo của lớp cha được gọi bằng lệnh base<ds tham số>
		public Parrot(int weight) : base(weight) { }
		public void Speak() => Console.WriteLine("Parrot is speaking");
	}
	class Cockatoo : Parrot
	{
		public Cockatoo() => Console.WriteLine("Cockatoo created");
		public void Dance() => Console.WriteLine("Cockatoo is dancing");
	}

	/// <summary>
	/// Mỗi khi khởi tạo object của class con thì hàm tạo của class cha luôn được gọi trước
	/// Trước khi khởi tạo object của class con thì object của class cha được khởi tạo => bản thân object của class con có chứa trong nó là object cha
	/// Object cha được truy cập từ object con thông qua từ khóa base => từ khóa base cũng có thể truy xuất các thành viên của lớp cha.
	/// </summary>
	//class MainClass
	//{
	//	public static void Main(string[] args)
	//	{
	//		Console.WriteLine("Bird:");
	//		Bird bird = new Bird(50) { Weight = 100 };
	//		bird.Feed();
	//		Console.WriteLine($"Weight: {bird.Weight}");
	//		bird.Fly();

	//		Console.WriteLine($"Parrot: ");
	//		Parrot parrot = new Parrot(200);
	//		parrot.Feed();
	//		Console.WriteLine($"Weight: {parrot.Weight}");
	//		parrot.Fly();
	//		parrot.Speak();

	//		// Hàm tạo không được kế thừa mà hàm tạo của lớp cha được gọi tự động(nếu là hàm tạo không tham số)
	//		// OR được gọi từ hàm tạo của lớp con (nếu là hàm tạo có tham số)
	//		Console.WriteLine($"Cockatoo: ");
	//		Cockatoo cockatoo = new Cockatoo() { Weight = 300 };
	//		cockatoo.Feed();
	//		Console.WriteLine($"Weight: {cockatoo.Weight}");
	//		cockatoo.Fly();
	//		cockatoo.Speak();
	//		cockatoo.Dance();
	//		Console.ReadKey();
	//	}
	//}
}