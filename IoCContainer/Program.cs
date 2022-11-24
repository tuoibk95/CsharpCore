namespace IocContainer;

/// <summary>
/// Inversion of Control: Là một nguyên tắc thiết kế khuyến nghị đảo ngược các control khác nhau trong OOD để đạt đc liên kết lỏng lẻo giữa các lớp app.
/// DIP: cũng giúp đạt được sự liên kết lỏng lẻo giữa các lớp 
/// Dependency Injection: là design pattern thực hiện IoC principle to invert the creation of dependent  objects.
/// IoC Container: là 1 framework được sử dụng để quản lý tự động Dependency Injection  trong toàn bộ app.
/// </summary>
public class program
{
    /// Ioc là all về invert of control
    /// => Giải thích: Giả sử lái 1 chiếc xe oto đến nơi làm việc (control the car).
    /// Thay vì lái xe, thuê một taxi, một người khác sẽ lái xe => Điều này được gọi là inversion of the control: từ mình sang tài xế lái xe
    /// không cần tự lái xe mà đưa cho tài xế lái xe để mình có thể tập trung vào công việc chính của mình. (ủy quyền điều khiển xe cho tài xế)
    /// The IoC principle helps in designing loosely coupled classes which make them testable, maintainable and extensible.
    ///     It manages object creation and it's life-time, and also injects dependencies to the class.
    /// 
    static void Main(string[] args)
    {
        bool continueExecution = true;
        do
        {
            Console.Write("Enter First Name:");
            var firstName = Console.ReadLine();

            Console.Write("Enter Last Name:");
            var lastName = Console.ReadLine();

            Console.Write("Do you want to save it? Y/N: ");
            var wantToSave = Console.ReadLine();

            if (wantToSave.ToUpper() == "Y")
                SaveToDB(firstName, lastName);

            Console.Write("Do you want to exit? Y/N: ");
            var wantToExit = Console.ReadLine();

            if (wantToExit.ToUpper() == "Y")
                continueExecution = false;

        } while (continueExecution);

    }

    private static void SaveToDB(string firstName, string lastName)
    {
        //save firstName and lastName to the database here..
    }
}

#region Control Over the Dependent Object Creation
/// <summary>
///  "Class A is dependent on class B" or "class B is a dependency of class A".
///  Trong phương pháp object-oriented design, các lớp cần tương tác với nhau để hoàn thành 1 hoặc nhiều chức năng của app.
/// </summary>
public class A
{
    B b;

    public A()
    {
        b = new B();
    }

    /// <summary>
    /// Class A gọi b.SomeMethod() để hoàn thành task1()=> Class A k thể hoàn thành nếu không có class B
    /// 
    /// </summary>
    public void Task1()
    {
        // do something here..
        b.SomeMethod();
        // do something here..
    }

}

public class B
{

    public void SomeMethod()
    {
        //doing something..
    }
}
#endregion

#region delegate the control to another class
public class C
{
    B b;

    public C()
    {
        /// class C uses Factory class to get an object of class B.
        /// Thus, we have inverted the dependent object creation from class A to Factory.
        /// Class A no longer creates an object of class B, instead it uses the factory class to get the object of class B.
        b = Factory.GetObjectOfB();
    }

    public void Task1()
    {
        // do something here..
        b.SomeMethod();
        // do something here..
    }
}

public class Factory
{
    public static B GetObjectOfB()
    {
        return new B();
    }
}
#endregion