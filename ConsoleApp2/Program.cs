using DesignPatterns.SOLID;
using DesignPatterns.CREATIONAL.Builder;






//SRTesterRoutine.Run();

//OCTesterRoutine.Run();

//LSTesterRoutine.Run();

//FluentBuilderTester.Run();

//SWBRoutineRester.Run();

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "andre");
builder.AddChild("li", "Luiz");
Console.WriteLine(builder.ToString());








