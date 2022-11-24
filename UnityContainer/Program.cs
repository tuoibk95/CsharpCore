using Unity;

namespace UnityContainerEx;

public class Program
{
	public static void Main(String[] args)
	{
		UseUnityContainer();
	}

	public static void UseUnityContainer()
	{
		IUnityContainer unityContainer = new UnityContainer();

		unityContainer.RegisterType<ICar,Audi>();
		unityContainer.RegisterType<ICar,BMW>();
		// Unity container will inject the last registered type if you register multiple mappings of the same type.
		unityContainer.RegisterType<ICar,Ford>();
		// Unity container creates an object of the Driver class
		// The Driver class is a dependency of ICar.
		// container.Resolve<Driver>() returns an object of the Driver class by automatically creating and injecting a BMW object in it.
		// The BMW object is created and injected because register the BMW type with ICar.
		Driver driver = unityContainer.Resolve<Driver>();
		driver.RunCar();
		// both have references to separate BMW objects.
		Driver driver2 = unityContainer.Resolve<Driver>();
		driver2.RunCar();
	}

	public static void RegisterNamedType()
	{

	}
}