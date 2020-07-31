namespace MyProject
{
    internal class SummerNumbers
    {
        private int a;
        private int b;

        public SummerNumbers(int aaa, int bbb)
        {
            a = aaa;
            b = bbb;
        }

        public int getSumValue()
        {
            int answer = a + b;
            return answer;
        }
    }
}