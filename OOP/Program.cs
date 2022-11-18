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

// Name space đóng một vai trò quan trọng trong việc quản lý các lớp liên quan trong C#.
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
