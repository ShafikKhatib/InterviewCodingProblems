namespace InterviewCodingProblems
{
    public class MoveZeroToRight
    {
        public void Move(int[] numbers)
        {
            int nextNonZeroIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    (numbers[nextNonZeroIndex], numbers[i]) =
                        (numbers[i], numbers[nextNonZeroIndex]);

                    nextNonZeroIndex++;
                }
            }
        }

        //using LINQ    
        public int[] MoveWithLinq(int[] numbers)
        {
            var nonZeroNumbers = numbers.Where(n => n != 0);
            var zeroCount = numbers.Count(n => n == 0);
            return nonZeroNumbers.Concat(Enumerable.Repeat(0, zeroCount)).ToArray();
        }

        //move zero to right using two pointer approach
        public void MoveWithTwoPointer(int[] numbers)
        {
            int left = 0;
            int right = 0;
            while (right < numbers.Length)
            {
                if (numbers[right] != 0)
                {
                    (numbers[left], numbers[right]) = (numbers[right], numbers[left]);
                    left++;
                }
                right++;
            }
        }

        

    }
}