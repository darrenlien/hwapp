using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] s = new char[]{'a','b','c','d'};
            int i = ReplaceAndRemove(4, s);

        }

        public static int ReplaceAndRemove(int size, char[] s)
        {
            int writeIdx = 0, aCount = 0;
            for(int i=0; i < size; ++i)
            {
                if (s[i] != 'b')
                    s[writeIdx++]= s[i];
                if (s[i] == 'a')
                    ++aCount;
            }

            int curIdx = writeIdx - 1;
            writeIdx = writeIdx + aCount -1;
            int finalSize = writeIdx + 1;
            while (curIdx >=0)
            {
                if (s[curIdx] == 'a')
                {
                    s[writeIdx--] = 'd';
                    s[writeIdx--] = 'd';
                }
                else
                {
                    s[writeIdx--] = s[curIdx];
                }
                --curIdx;
            }
            return finalSize;
        }

        public bool Rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
                return false;

            int n = matrix.Length;
            for(int layer =0; layer < n/2; layer++) {
               int first = layer;
               int last = n-1-layer;
               for (int i =0; i < last; i++)
               {
                   int offset = i - first;
                   int top = matrix[first][i];
                   matrix[first][i] = matrix[last-offset][i];

               }              
            }
            return true;
        }
    }

    
}
