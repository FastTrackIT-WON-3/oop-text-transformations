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
                new StringReplaceRule("world", "C#"),
                new StringRemoveRule("Hello "));

            string transformed = engine.Transform(text);

            Console.WriteLine($"Original text={text}");
            Console.WriteLine($"Transformed text={transformed}");
        }
    }
}
