namespace BasicProgrammsForTesting
{
    internal class Basic
    {
        public static void Main(string[] args)
        {
            int[][] queries = new int[][] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 3, 4 } };
            int copy = 0;
            Dictionary<int, int> set = new Dictionary<int, int>();
            Dictionary<int, int> color = new Dictionary<int, int>();
            foreach (int[] a in queries)
            {
                if (set.ContainsKey(a[0]))
                {
                    color.Remove(a[1]);
                    set[a[0]] = a[1];

                }
                else
                {
                    set[a[0]] = a[1];

                }
                if (color[a[1]]>0)
                {
                    copy++;
                }
                else
                {
                    color[a[1]] = 1;
                }
            }

            Console.WriteLine(set.Count-copy);
        }


    }
}

    



