namespace ConsoleApplication1
{
    internal class AutoProperties
    {
        // C# One Examples
        private int csharpOne = 42;

        public int CSharpOne
        {
            get { return csharpOne; }
            set { csharpOne = value; }
        }

        private int csharpOneReadOnly = 42;

        public int CSharpOneReadOnly
        {
            get { return csharpOne; }
        }

        // C# Two Examples
        public int CSharpTwoDefaultValue { get; set; }

        public int CSharpTwoPrivateSetter { get; private set; }

        public AutoProperties()
        {
            CSharpTwoDefaultValue = 42;
        }

        // C# Six Examples

        public int CSharpSixDefaultValue { get; set; } = 42;

        public int CSharpSixReadOnly { get; } = 42;
    }
}