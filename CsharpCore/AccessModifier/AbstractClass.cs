using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.AccessModifier
{
	abstract class AbstractClass
	{
		public virtual string ValidateString(string name, string value, bool isRequiredField, int maxLength)
		{
			if (value == null)
			{
				Console.WriteLine("Value is not null...");
				return string.Empty;
			}

			if (isRequiredField && value.Length == 0)
			{
				Console.WriteLine("Value is required & is not Empty...");
				return string.Empty;
			}

			if (maxLength < value.Length)
			{
				Console.WriteLine("value không được vượt quá maxLength...");
				return string.Empty;
			}

			return value;
		}
	}
}
