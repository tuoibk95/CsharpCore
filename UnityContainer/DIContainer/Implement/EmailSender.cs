using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Implement
{
	public class EmailSender : IEmailSender
	{
		public void SendEmail(int userId)
		{
			Console.WriteLine("Send real email");
		}
	}
}
