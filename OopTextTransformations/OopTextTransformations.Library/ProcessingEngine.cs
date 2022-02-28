using OopTextTransformations.Library.Rules;

namespace OopTextTransformations.Library
{
    public class ProcessingEngine
    {
        public ProcessingEngine(params TransformationRule[] rules)
        {
            Rules = rules ?? new TransformationRule[0];
        }

        public TransformationRule[] Rules { get; }

        public string Transform(string input)
        {
            string result = input;
            foreach (TransformationRule rule in Rules)
            {
                result = rule.Transform(result);
            }

            return result;
        }
    }
}
