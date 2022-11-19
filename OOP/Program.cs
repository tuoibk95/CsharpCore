using System;
using Variables;
using OOP.DataTypes.StringAndStringBuilder;
using OOP.DataTypes.Structure;
using OOP.DataTypes.Enumeration;
using OOP.DataTypes.AnonymousTypes;
using OOP.DataTypes.DynamicTypes;
using OOP.DataTypes.NullableTypes;
using OOP.DataTypes.TwoTypes;
using OOP.Indexers;
using OOP.Exceptions;
using OOP.Delegates;
using OOP.Delegates.FuncDelegate;
using OOP.Delegates.ActionDelegate;
using OOP.Delegates.PredicateDelegate;
using OOP.Events;

/// <summary>
/// Namespace đóng một vai trò quan trọng trong việc quản lý các lớp liên quan trong C#.
/// OOP: một cách phát triển các ứng dụng phần mềm sử dụng các thuật ngữ trong thế giới thực để tạo ra các thực thể tương tác với nhau bằng cách sử dụng các object
/// OOP: Làm cho các ứng dụng trở nên linh hoạt (dễ thay đổi or thêm các tính năng mới) có thể tái sử dụng, có cấu trúc tốt, dễ gỡ lỗi và kiểm tra
/// Basic building blocks to build object-oriented applications =>
/// 1: Classes: Định nghĩa cấu trúc bằng cách sử dụng methods and properties/fields giống với thực thể trong thế giới thực
/// 2: Methods: đại diện cho 1 hành vi cụ thể,Nó thực hiện một số hành động và có thể trả về thông tin về một đối tượng
/// 3: Properties: thuộc tính chứa data tạm thời trong giá trình thực thi ứng dụng
/// 4: Objects: Các object là các thể hiện (instances) của lớp chứa data khác nhau trong các properties/fields và có thể tương tác với các đối tượng khác
/// 5: Interface: 1 contract xác định bộ quy tắc cho một chức năng cụ thể. được sử dụng với các lớp theo OOP như kế thừa và đa hình làm cho app linh hoạt
/// </summary>
namespace OOP
{
    /// <summary>
    /// 1 - Abstraction
    /// 2 - Encapsulation
    /// 3 - Inheritance
    /// 4 - polymorphism
    /// </summary>
    public class Program
    {
        // string là alias của System.String để sử dụng được String thì phải using System, còn string thì không cần
        static void Main(String[] args)
        {
            AutoImplementedProperty prog = new AutoImplementedProperty("Luc","Van Tien");
			Console.WriteLine(prog.GetFullName());
            // Extentions method
            // Console.WriteLine(prog.Print());
            TestDataTypes();
        }
        public static void TestDataTypes()
        {
            MethodAndPropertiesInStruct methodAndPropertiesInStruct = new MethodAndPropertiesInStruct();
            methodAndPropertiesInStruct.SetOrigin();
            MethodAndPropertiesInStruct.GetOrigin();
			Console.WriteLine(methodAndPropertiesInStruct.x);
			Console.WriteLine(methodAndPropertiesInStruct.y);
            Coordinate coordinate = new Coordinate(10,20);
			Console.WriteLine(coordinate.x);
			Console.WriteLine((Int32)WeekDays.Saturday);
            StringAndStringBuilder.PrintString();
            StringAndStringBuilder.PrintStringBuilder();
            AnonymousTypes.Test();
            DynamicTypes.TestDynamicType();
            BoxingAndUnboxing.PerformsBoxing();
            BoxingAndUnboxing.CastingBoxed();
            NullableTypes.TestNullableTypes();
            ValueTypes.TestValueChanged();
            ReferenceTypes.TestReferenceType();
            Hocsinh.TestReferenceTypes();
            ClassIndexers.TestIndexers();
            ClassIndexers.TestOverloadIndexers();
            GenericIndexers<int>.TestGenericIndexers();
//            AppException.TestException();
            ClassA.TestDelegate();
			MulticastDelegates.TestMulticastDelegate();
			MulticastDelegates.TestIntMulticastDelegate();
            MulticastDelegates.ABC();
            GenericDelegate.TestGenericDelegate();
            FuncDelegate.TestFunc();
            FuncDelegate.TestFunc1();
            ActionDelegate.TestActionDelegate();
            PredicateDelegate.TestPredicate();
            ProcessBusinessLogic.TestEvent();
            EventHandlerDelegate.TestEventHandler();
            EventDataHanlder.TestEventDataHanlder();
            ConstantReadonlyStatic.TestConstant();
        }
    }
}
