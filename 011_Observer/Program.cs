// Observer (Спостерігач)
// Описує техніку видавець(publisher) - підписник(subscriber)


using _011_Observer;

ConcreteSubject subject = new ConcreteSubject();
ConcreteObserver concreteObserver = new ConcreteObserver(subject);

subject.Attach(concreteObserver);

subject.State = "40.15";

subject.Notify();

Console.WriteLine(concreteObserver.ObserverState);

subject.State = "40.20";

subject.Notify();

Console.WriteLine(concreteObserver.ObserverState);
