using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Events
{
	public class EventDataHanlder
	{
		// Nếu muốn chuyển nhiều hơn 1 giá trị làm dữ liệu sự kiện => tạo ra đối tượng có các filed và thay vào TEventArgs
		public event EventHandler<bool> ProcessCompleted;
		public void StartProcess()
		{
			try
			{
				Console.WriteLine("Process Started!");

				// some code here..

				OnProcessCompleted(true);
			}
			catch (Exception ex)
			{
				OnProcessCompleted(false);
			}
		}
		protected virtual void OnProcessCompleted(bool IsSuccessful)
		{
			ProcessCompleted?.Invoke(this,IsSuccessful);
		}
		public static void Bl_ProcessCompled(object sender, bool IsSuccessful)
		{
			Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
		}
		public static void TestEventDataHanlder()
		{
			EventDataHanlder eventDataHanlder = new EventDataHanlder();
			eventDataHanlder.ProcessCompleted += Bl_ProcessCompled;
			eventDataHanlder.StartProcess();
		}
	}
}
