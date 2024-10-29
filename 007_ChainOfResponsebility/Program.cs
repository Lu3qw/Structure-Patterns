// Ланцюжок відповідальностей

// Створює ланцюжки з обробників запитів

using _007_ChainOfResponsebility;

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();

h1.Successor = h2;
h2.Successor = h3;

h1.HandleRequest(3);