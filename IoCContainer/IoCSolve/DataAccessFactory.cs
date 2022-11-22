namespace IoCContainer.IoCSolve
{
	// Sử dụng Factory Pattern triển khai IoC để đạt được thiết kế lỏng lẻo
	// we have inverted the control of creating an object of a dependent class from the CustomerBusinessLogic class to the DataAccessFactory class.
	public class DataAccessFactory
	{
		public static DataAccess GetDataAccessObj()
		{
			// returns an object of the DataAccess class
			return new DataAccess();
		}
	}
}
