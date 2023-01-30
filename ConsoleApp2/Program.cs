using DesignPatterns.SOLID;
using DesignPatterns.CREATIONAL.Builder;






//SRTesterRoutine.Run();

//OCTesterRoutine.Run();

//LSTesterRoutine.Run();

//FluentBuilderTester.Run();

//SWBRoutineRester.Run();

//var builder = new HtmlBuilder("ul");
//builder.AddChild("li", "andre");

//builder.AddChildFluent("li", "Luiz").AddChild("li", "elis");

//Console.WriteLine(builder.ToString());

var cb = new CodeBuilder("Person")
    .AddField("Name", "string")
    .AddField("Age", "int")
    .AddField("Address", "string");

Console.WriteLine(cb.ToString());








