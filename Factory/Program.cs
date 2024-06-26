using Factory.Sample_1;
using Factory.Sample_2;


/*
 * Birden fazla sub-class(alt sınıf), sahip olduğumuz bir bir super class(üst sınıf) olduğu senaryolarda bir girdi ya da parametreye bağlı olarak alt sınıflardan hangisinin örneğinin alınacağına karar verilmesi gerekebilir. Bu durumda Factory Pattern kullanılabilir.
 */


//////////////////////////SAMPLE 1//////////////////////////
CreatorComputer gameComputer = FactoryCreator.FactoryComputer("gamerComputer", "16GB", "1TB", "256GB", "i7");
Console.WriteLine(gameComputer.ToString());
CreatorComputer developerComputer = FactoryCreator.FactoryComputer("developerComputer", "16GB", "1TB", "256GB", "i7");
Console.WriteLine(developerComputer.ToString());
//////////////////////////SAMPLE 1//////////////////////////


//////////////////////////SAMPLE 2//////////////////////////
ICreatorMobileApp AppWindows = FactoryMobileApp.CreateMobileApp("Windows");
ICreatorMobileApp AppAndroid = FactoryMobileApp.CreateMobileApp("Android");
ICreatorMobileApp AppIOS = FactoryMobileApp.CreateMobileApp("IOS");
AppWindows.Platform();
AppAndroid.Platform();
AppIOS.Platform();
//////////////////////////SAMPLE 2//////////////////////////

