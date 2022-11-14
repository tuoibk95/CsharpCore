using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Events
{
	public class EventHandlerDelegate
	{
		// declaring an event using built-in EventHandler
		public event EventHandler EventHandler;

		public void StartProcess()
		{
			Console.WriteLine("Started Process");
			OnEventHandler(this,EventArgs.Empty); // No event data, dùng với this vì không cần bất kì data cho event
		}

		protected virtual void OnEventHandler(object sender,EventArgs e)
		{
			EventHandler?.Invoke(sender, e);
		}

		// event handler
		public static void Bl_ProcessCompleted(object sender, EventArgs e)
		{
			Console.WriteLine("Process Completed");
		}

		public static void TestEventHandler()
		{
			EventHandlerDelegate eventHandlerDelegate = new EventHandlerDelegate();
			eventHandlerDelegate.EventHandler += Bl_ProcessCompleted; // register with an event
			eventHandlerDelegate.StartProcess();
		}
	}
}
