namespace SOLID.InterfaceSegregationPrinciple
{
	public class StudentRepository : IStudentRepository
	{
		public void AddStudent(Student std)
		{
			throw new NotImplementedException();
		}

		public void DeleteStudent(Student std)
		{
			throw new NotImplementedException();
		}

		public void EditStudent(Student std)
		{
			throw new NotImplementedException();
		}

		public IList<Student> GetAllStudents()
		{
			throw new NotImplementedException();
		}

		public IList<Student> GetAllStudents(Course cs)
		{
			throw new NotImplementedException();
		}

		public bool SubscribeCourse(Course cs)
		{
			throw new NotImplementedException();
		}

		public bool UnSubscribeCourse(Course cs)
		{
			throw new NotImplementedException();
		}
	}
}
