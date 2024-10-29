// Декоратор(Decorator)

// Добавляє об'єкту новий стан та поведінку


using _004_Decorator;

Component component = new ConcreteComponent();
Decorator decoratorA = new ConcreteDecoratorA();
Decorator decoratorB = new ConcreteDecoratorB();


// component.Operation();

//decoratorA.Component = component;
//decoratorA.Operation();

//decoratorB.Component = component;
//decoratorB.Operation();


decoratorA.Component = component;
decoratorB.Component = decoratorA;

decoratorB.Operation();
