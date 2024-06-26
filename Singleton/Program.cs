using Singleton;

//Singleton Design Pattern
//Bir sınıfın nesnesinin sadece bir instance yaratılmasını ve sürekli olarak aynı instance'ın kullanılmasını istediğimiz durumlarda kullanılır.
//Bir sınıftan bir tane olmasından kastımız, Herkesin istediği zaman bu sınıfın bir instance'ını oluşturmaya çalışmaması ve oluşturamaması, böylece var olan tek nesneseyi(instance'ı) kullanmasıdır.
//Kısacası Singleton Design Pattern, bir sınıfın yalnızca bir örneğinin oluşturulmasını sağlar ve bu örneğe global erişim noktası sağlar.
//
//
//Basic Singleton 
//Lazy Singleton
//Multithread Singleton


////////////////////////LAZY SINGLETON////////////////////////
var systemManager_1 = SystemManager.CreateSingletonObject();
var systemManager_2 = SystemManager.CreateSingletonObject();
var systemManager_3 = SystemManager.CreateSingletonObject();
systemManager_1.CreateLog();
systemManager_2.CreateLog();
systemManager_3.CreateLog();
Console.WriteLine(systemManager_1.GetHashCode());
Console.WriteLine(systemManager_2.GetHashCode());
Console.WriteLine(systemManager_3.GetHashCode());
////////////////////////LAZY SINGLETON////////////////////////

////////////////////////LAZY SINGLETON////////////////////////
SampleSingleton sampleSingleton_1 = SampleSingleton.GetInstance();
sampleSingleton_1.Data = "Data 1";
SampleSingleton sampleSingleton_2 = SampleSingleton.GetInstance();
sampleSingleton_2.Data = "Data 2";
Console.WriteLine($"Sample_1 => {sampleSingleton_1.Data}");
Console.WriteLine($"Sample_2 => {sampleSingleton_2.Data}");
////////////////////////LAZY SINGLETON////////////////////////

