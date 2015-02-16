using System;

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
        #endregion

        #region version2
        public int CSharpSomethingOld { get; set; }

        public int CSharpSomethingOldTwo { get; private set; }

        public AutoProperties()
        {
            CSharpSomethingOld = 42;
        }
        #endregion

        #region version6
        public int CSharpSixOne { get; set; } = 42;

        public int CSharpSixTwo { get; } = 42;
        #endregion
    }
}