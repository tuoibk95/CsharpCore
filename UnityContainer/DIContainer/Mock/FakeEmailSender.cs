using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer.Mock
{
	public class FakeEmailSender : IEmailSender
	{
		public void SendEmail(int userId)
		{
			Console.WriteLine("Fake Send email");
		}
	}
}
