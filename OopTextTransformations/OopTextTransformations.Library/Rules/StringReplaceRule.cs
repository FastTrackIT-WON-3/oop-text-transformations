namespace OopTextTransformations.Library.Rules
{
    public class StringReplaceRule : TransformationRule
    {
        public StringReplaceRule(string oldText, string newText)
        {
            OldText = oldText;
            NewText = newText;
        }

        public string OldText { get; }

        public string NewText { get; }

        public override string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.Replace(OldText, NewText);
        }
    }
}
