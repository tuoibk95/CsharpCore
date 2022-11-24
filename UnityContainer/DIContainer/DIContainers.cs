using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerEx.DIContainer
{
	public class DIContainers
	{
		// Dictionary để chứa các interface và module tương ứng
		private static readonly Dictionary<Type, object> RegisterModules = new Dictionary<Type, object>();
        public static T GetModule<T>()
		{
            return (T)GetModule(typeof(T));
		}

        public static object GetModule(Type interfaceType)
		{
			if (RegisterModules.ContainsKey(interfaceType))
			{
                return RegisterModules[interfaceType];
			}
            throw new Exception("Module not register");
		}

        public static void SetModule<TInterface, TModule>()
        {
            SetModule(typeof(TInterface), typeof(TModule));
		}

		public static void SetModule(Type interfaceType, Type moduleType)
		{
			// Kiểm tra module đã implement interface chưa
			if (!interfaceType.IsAssignableFrom(moduleType))
			{
                throw new Exception("Wrong Module type");
			}

			// Khi cài đặt một module, container sẽ tìm Constructor đầu tiên của module đó.
			var firstConstructor = moduleType.GetConstructors()[0];
			object module = null;
			if (!firstConstructor.GetParameters().Any())
			{
				// Nếu contructor không có tham số (Module không có dependency), container sẽ gọi constructor này để khởi tạo module.
				module = firstConstructor.Invoke(null);
			}
			else
			{
				// Nếu constructor này có tham số (Có dependency), container sẽ khởi tạo các tham số này, gán chúng vào constructor của module.
				// Đây là quá trình injection.
				var constructorParameters = firstConstructor.GetParameters();
                var moduleDependencies = new List<object>();
                foreach (var parameter in constructorParameters)
				{
                    var dependency = GetModule(parameter.ParameterType);
                    moduleDependencies.Add(dependency);
				}
				// Inject các dependency vào constructor của module
				module = firstConstructor.Invoke(moduleDependencies.ToArray());
			}
			// Lưu trữ interface và module tương ứng
			RegisterModules.Add(interfaceType, module);
		}
	}
}
