using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.Structure
{
	//When to use Struct over Class in C#
	#region Hạn chế của Struct
	/// <summary>
	/// 1 - Class is a reference type, whereas Struct is a value type.
	/// 2 - A default constructor or destructor cannot be created in Struct.
	/// 3 - Structs inherit from System.ValueType, cannot be inherited from another Struct or Class, and cannot be a base class. * Có kế thừa interface
	/// 4 - Struct types cannot be abstract and are always sealed implicitly.
	/// 5 - Struct members cannot be abstract, sealed, virtual, or protected.
	/// 6 - Structs copy the entire value on the assignment, whereas reference types copy the reference on assignment. 
	///		So, large reference type assignments are cheaper than the value types.
	/// 7 - Instance field declarations in Struct cannot include variable initializers. But, static fields in Struct can include variable initializers.
	/// 8 - A null value can be assigned to a struct as it can be used as a nullable type.
	/// 9 - Structs are allocated either on the stack or inline in containingtypes and deallocated when the stack or the containing type gets deallocated.
	///		But, reference types are allocated on the heap and garbage-collected.
	///		So, the allocation and deallocation of structs are cheaper than classes.
	/// 10 - Array elements of reference types are references to the instances of the reference types that exist on the heap,
	///		whereas array elements of value types are the real instances of the value type.
	///		So, allocation and deallocation of value type arrays are much cheaper than the reference type arrays.
	/// 11 - Value types get boxed and unboxed during the typecasting.
	///		An excessive amount of boxing and unboxing results in a negative impact on the heap, garbage collector, and the application's performance.
	/// </summary>
	#endregion

	#region use Struct
	/// <summary>
	/// 1 - If all the member fields are value types.
	/// 2 - If instances of the type are small and short-lived or embedded to other instances.
	/// 3 - If it logically denotes a single value, same as primitive types like int, double, etc.
	/// 4 - If the size of the instance is below 16 bytes.
	/// 5 - If it will not be boxed and unboxed again and again.
	/// 6 - If it is immutable, that means when an instance of a reference type gets changed, it affects all the references indicating the instance.
	///		But, in the case of value types, it does not affect any of its copies.
	///		For this reason, changes in value types may raise confusion in many users. So, it should be immutable.
	/// 7 - 
	/// <summary>
	#endregion
	struct StructOrClass { }
}
