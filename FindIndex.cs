namespace Assignment3_2_Cleanup
{
    public class FindIndex
    {
        public static int FindingIndex()
        {

            int[] arrayUsed = { 1, 5, 3 };
            int finder = 1;
            for (int i = 0; i < arrayUsed.Length; i++)
            {

                if (arrayUsed[i] == finder)
                {
                    Console.WriteLine($"{finder} is at index = {i}", arrayUsed[i]);
                    return i;
                    break;

                }


                

                


            }
return -1;




        }
    }
}



