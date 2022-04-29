using NUnit.Framework;
using ReportPortal.Shared;
using System;
using System.Collections;

namespace ExampleUnitTests.NUnitTests
{
    public class UnitTest2
    {
        [Test, Description("This is NUnit description"), Category("Category1")]
        public void NUnitTestMethod1()
        {
            Log.Info("Message from logger");
            Console.WriteLine("Console output from UnitTest2 - TestMetod1");
        }

        [Test, TestCaseSource(typeof(UnitTest2), "TestCases")]
        public void NUnitTestMethod2(string p)
        {
            Console.WriteLine("Income parameter is " + p);
            System.Threading.Thread.Sleep(1000);
        }

        public static IEnumerable TestCases
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return new TestCaseData(i.ToString() + ".postfixpart");
                }
            }
        }
    }
}
