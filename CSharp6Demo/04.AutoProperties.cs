namespace ConsoleApplication1
{
    internal class AutoProperties
    {
        #region version1

        private int csharpOne = 42;

        public int CSharpOne
        {
            get { return csharpOne; }
            set { csharpOne = value; }
        }

        private int csharpOneTwo;

        public int CsharpOneTwo
        {
            get { return csharpOneTwo; }
            set { csharpOneTwo = value; }
        }

        #endregion version1
    }
}