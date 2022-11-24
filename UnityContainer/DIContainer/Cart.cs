using UnityContainerEx.DIContainer.Implement;
using UnityContainerEx.DIContainer.Interface;

namespace UnityContainerEx.DIContainer
{
	public class Cart
	{
		private readonly IDatabase _database;
		private readonly IEmailSender _emailSender;
		private readonly ILogger _logger;

		public Cart(IDatabase database, IEmailSender emailSender, ILogger logger)
		{
			_database = database;
			_logger = logger;
			_emailSender = emailSender;
		}

		public void Checkout(int orderId, int userId)
		{
			_database.Save(orderId);
			_logger.LogInfo("Order has been checkout");
			_emailSender.SendEmail(userId);
		}
	}
}
