/*
 * Sınıfın yapısında değişikliğe gitmeden belirli bir nesneye veya bazı nesnelere yeni ek özellikler ya da fonksiyonları dinamik olarak eklemek istediğimizde kullanılır.
 * 
 * Buradaki önemli ayrıntı, yeni özelliğin sınıfa değil, sınıftan türeyen belirli bir nesneye(instance'a) eklenmesidir.
 * Yani bu sınıftan türetilen diğer nesneler,bu ek özellikten veya fonksiyondan etkilenmezler.
 */



using Decorator;

//Window w1 = new LoginWindow("Sisteme Giriş Ekranı");
//Window w2 = new ReportWindow("Stok Rapor Ekranı");
//Window w3 = new ReportWindow("Satış Raporu Ekranı");

//ThemeDecorator decorator1 = new ThemeDecorator(w1, "Sisteme Giriş");
//ThemeDecorator decorator2 = new ThemeDecorator(w2, "Stok Raporu");
//ThemeDecorator decorator3 = new ThemeDecorator(w3, "Satış Raporu");

//decorator1.SetTheme("Karanlık Tema");
//decorator2.SetTheme("Aydınlık Tema");
//decorator3.SetTheme("Sepya Tema");



//İndirim decorator'ı
CarBase car = new CarSuv()
{
    Brand = "Mercedes",
    Model = "G300",
    ListPrice = 100000

};

OfferDiscountPrice offerDiscount = new OfferDiscountPrice(car)
{
    DiscountRate = 10
};

offerDiscount.DiscountRate = 20;
Console.WriteLine($"Liste Fiyatı = {car.ListPrice}");
Console.WriteLine($"İndirimli Fiyat = {offerDiscount.ListPrice}");