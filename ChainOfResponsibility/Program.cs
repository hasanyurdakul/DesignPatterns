using ChainOfResponsibility;
using System.Security;


#region Banka ATM Süreci

//ATMWithdrawChain atm = new ATMWithdrawChain();

//while (true)
//{
//    Console.WriteLine("Enter the amount to withdraw:");
//    int amount = Convert.ToInt32(Console.ReadLine());
//    if (amount % 50 != 0)
//    {
//        Console.WriteLine("Tutar 50'nin katı olmalıdır.");
//        return;
//    }
//    atm.c1.withdraw(new Currency(amount));
//}

#endregion




#region Image Format Süreci
Image image = new Image("milli_mac_fotografları","Other");
if(image.Extension == "JPG")
{
    //TODO: JPG Handler is handling the request.
}

JPEGHandler jpegHandler = new JPEGHandler();
JPGHandler jpgHandler = new JPGHandler();
CustomHandler customHandler = new CustomHandler();

jpegHandler.SetNextHandler(jpgHandler);
jpgHandler.SetNextHandler(customHandler);

jpegHandler.HandleRequest(image);

#endregion