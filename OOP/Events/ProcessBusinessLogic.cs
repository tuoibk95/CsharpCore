using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Events
{
	/// <summary>
	/// Publisher: lớp tạo ra các event
	/// Subcriber: Lớp nhận được thông báo, có thể có nhiều người (subcriber) đăng ký 1 sự kiện
	/// Subcriber quan tâm đến sự kiện và nhận thông báo khi 1 hành động xẩy ra.=> nên đăng ký sự kiện và xử lý event đó
	/// Event là 1 delegate đóng gói, phụ thuộc vào delegate. Delegate định nghĩa cho EventHandler method của class đăng ký
	/// </summary>
	public delegate void Notify();
	public class ProcessBusinessLogic
	{
		public event Notify ProcessCompleted;
		/// Khi khai báo delegate Notify và event ProcessCompleted của delegate kiểu Notify thì ProcessBusinessLogic class là Publisher
		/// Notify delegate chỉ định ProcessCompleted event handler => phương thức chỉ định return type là void và k có tham số
		/// 
		public void StartProcess()
		{
			Console.WriteLine("Process Started!");
			// some code here..
			OnProcessCompleted(); // Tạo ra 1 Event
		}

		protected virtual void OnProcessCompleted() //protected virtual method
		{
			//if ProcessCompleted is not null then call delegate
			ProcessCompleted?.Invoke(); // Sẽ gọi tất cả Event Handler method đã đăng ký (subcriber) với event ProcessCompleted
		}

		// Event Handler
		public static void Bl_ProcessCompleted()
		{
			Console.WriteLine("Process Completed!");
		}

		public static void Bl_EventHandling()
		{
			Console.WriteLine("Event handling!");
		}
		public static void TestEvent()
		{
			ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
			processBusinessLogic.ProcessCompleted += Bl_EventHandling; // subcriber with an event handling
			processBusinessLogic.ProcessCompleted += Bl_ProcessCompleted; // subcriber with an event Process Completed!
			processBusinessLogic.StartProcess();
		}
	}
}
