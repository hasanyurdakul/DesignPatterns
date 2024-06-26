/*
 * Observer Pattern nesnenin durumunu/davranışını inceler ve ona göre operasyonlar geliştirir.
 * Örneğin bir borsa app yapısını ele alalım. X bir firmanın hissesinin düşüşü veya yükselişi durumunda kullanıcıları bilgilendirmek istiyoruz. Kullanıcı da bu duruma göre alım ya da satım yapabilir.
 */



using Observer;

Subject topic = new Subject();
IObserve observer1 = new SubjectSubscribe("Observer 1");
IObserve observer2 = new SubjectSubscribe("Observer 2");
IObserve observer3 = new SubjectSubscribe("Observer 3");

topic.Register(observer1);
topic.Register(observer2);
topic.Register(observer3);

observer1.SetSubject(topic);
observer2.SetSubject(topic);
observer3.SetSubject(topic);

observer1.Update();

observer2.Update();

observer3.Update();

topic.PostMessage("New Message");