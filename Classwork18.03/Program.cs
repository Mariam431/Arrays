namespace Classwork18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int [] Array = new int[10] {1, 20, 0, 0, 0, 0, 34, 6, 34, 78};
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    if (Array[i] >= 10)
            //        Console.WriteLine(Array[i]);
            //}


            int[,] myMatrix = new int[3, 4];

            // fill the matrix with some values
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {                   
                    myMatrix[i, j] = i + j;
                }
            }

            // print the matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {                    
                    if (myMatrix[i, j] >2)
                        Console.Write(myMatrix[i,j]+"    ");

                    
                }
                Console.WriteLine();
            }
            

        }
    }
}