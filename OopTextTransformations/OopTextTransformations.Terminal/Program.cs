using OopTextTransformations.Library;
using OopTextTransformations.Library.Rules;
using System;

namespace OopTextTransformations.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";

            ProcessingEngine engine = new ProcessingEngine(
                new StringInsertRule(0, "Test "),
                new StringRemoveRule("Hello "),
                new StringReplaceRule("world", "C#"));

            string transformed = engine.Transform(text);

            Console.WriteLine($"Original text={text}");
            Console.WriteLine($"Transformed text={transformed}");
        }
    }
}
