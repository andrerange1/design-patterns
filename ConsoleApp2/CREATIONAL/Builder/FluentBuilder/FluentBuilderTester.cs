using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CREATIONAL.Builder
{
    public static class FluentBuilderTester
    {
        class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
        {

        }

        public static void Run()
        {
            var me = Person.New
              .Called("Andre")
              .WorksAsA("Dev")
              .Born(DateTime.UtcNow)
              .Build();
            Console.WriteLine(me);
        }
    }
}
