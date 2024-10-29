// Bridge (Міст)

// Відділення абстракції від реалізації



using _003_Bridge;
using System.Net.Http.Headers;

Context context = new Context();

context.Draw(new Rectanle(), new DashLine(), "red");

Console.WriteLine(new string('-', 50));

context.Draw(new Triangle(), new DottLine(), "green");

Console.WriteLine(new string('-', 50));

context.Draw(new Polygon(), new SolidLine(), "blue");