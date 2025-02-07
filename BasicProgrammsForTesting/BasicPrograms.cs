namespace BasicProgrammsForTesting;

public class BasicProgram
{
    
        public int SumOfTwoNums(int a, int b)
        {
            return a + b;
        }

        public bool OddOrEven(int num)
        {
            return num % 2 == 0;
        }

        public List<int> BubbleSortAscendingOrder(List<int> a)
        { 
            for (int i = 0; i < a.Count-1; i++)
                {
                    for (int j = i+1; j < a.Count; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;

                        }
                    }
                }
            return new List<int> (a);
        }
}