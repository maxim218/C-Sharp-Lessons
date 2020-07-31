using System;
using Xunit;

namespace MyProject
{
    internal class TesterClass
    {
        public void testFirst()
        {
            SummerNumbers obj = new SummerNumbers(12, 8);
            int s = obj.getSumValue();
            Assert.Equal(20, s);
            Console.WriteLine("testFirst OK");
        }

        public void testSecond()
        {
            SummerNumbers obj = new SummerNumbers(-20, -70);
            int s = obj.getSumValue();
            Assert.Equal(-90, s);
            Console.WriteLine("testSecond OK");
        }
    }
}