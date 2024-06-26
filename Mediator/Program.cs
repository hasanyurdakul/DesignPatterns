/*
 * Farklı nesne gruplarının iletişim kurma şeklini özetleyerek gevşek bağlantıya izin verir. Her nesne kümesinin eylemlerinin birbirinden
 * bağımsız olarak değişmesine izin verir.
 * 
 * Birden çok nesnenin birbiri ile etkileşime girdiği bir kurumsal uygulamada kullanılması gereken bir tasarım desenidir.
 * 
 * Nesneler birbirleri ile doğrudan etkileşime girerse sistem bileşenleri birbirleri ile tightly coupled olur. Bu da bakım maliyeti ve efor
 * gerektirir.
 * 
 * Mediator tasarım kalıbı iletişim için, nesneler arasında bir arabulucu olarak loose coupled bir model uygulanmasına bir imkan tanır.
 * 
 * Hava trafik kontrol istasyonu bir mediator örneğidir. Kontrol kulesi uçaklar arasındaki iletişimi sağlar ve uçaklar birbirleri ile
 * doğrudan iletişim kurmaz.
 */

using Mediator;

IChatMediator chatMediator = new ChatMediator();    
User user1 = new UserImplemented("User1",chatMediator);
User user2 = new UserImplemented("User2", chatMediator);
User user3 = new UserImplemented("User3", chatMediator);

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);
chatMediator.AddUser(user3);

user1.Send("Hello from User1");