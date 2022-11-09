using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
/// struct cannot include a parameterless constructor or a destructor.
/// struct can implement interfaces, same as class.
/// struct cannot inherit another structure or class, and it cannot be the base of a class.
/// struct members cannot be specified as abstract, sealed, virtual, or protected.
/// </summary>
namespace OOP.DataTypes.Structure
{
    /// <summary>
    /// A struct can contain properties, auto-implemented properties, methods, etc., same as classes.
    /// // TH:Nếu khai báo struct mà không có new MethodAndPropertiesInStruct() thì các biến chưa được gián giá trị => Phải gán giá trị của chúng trước khi truy xuất.
    /// </summary>
	struct MethodAndPropertiesInStruct
	{
        public int x { get; set; }
        public int y { get; set; }

        public void SetOrigin()
        {
            this.x = 10;
            this.y = 20;
        }

        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }
    }
}
