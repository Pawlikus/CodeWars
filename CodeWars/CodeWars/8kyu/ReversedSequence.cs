namespace CodeWars.CodeWars._8kyu
{
    internal class ReversedSequence
    {
        public static int[] ReverseSeq(int n)
        {
            var resultArray = new int[n];
            var j = 0;
            for (var i = n; i >= 1; i--)
            {
                resultArray[j] = i;
                j++;
            }

            return resultArray;
        }
    }
}