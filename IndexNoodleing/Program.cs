// having fun with using statement
using y = System.Console;

namespace ReviewTheBasics
{
    class TwoIndexer
    {
        //creating 2D internal array with 4 rows and 4 columns
        int[,] arr = new int[4, 4];
        //define 2D indexer for this 2D array using *this* followed by [ ] operator with get{} set{}
        public int this[int row, int col]
        {
            // set accessor - setting the initial values
            set
            {
                arr[row, col] = value; // value is a built in property. used to insert ... you guessed it VALUES!
            }
            get
            {
                return arr[row, col];
            }
        }
        static void Main()
        {
            // The fun with the using statement...
            y.WriteLine("---------------------------------");
            y.WriteLine("\t 2D Indexer (Integer)");
            y.WriteLine("---------------------------------");
            //object creations for current class
            TwoIndexer td = new TwoIndexer();
            //calling indesers storage via set
            // row 1, column 4
            td[0, 0] = 12;
            td[0, 1] = 23;
            td[0, 2] = 45;
            td[0, 3] = 54;
            // row 2, column 4
            td[1, 0] = 33;
            td[1, 1] = 44;
            td[1, 2] = 55;
            td[1, 3] = 66;
            // row 3, column 4
            td[2, 0] = 77;
            td[2, 1] = 88;
            td[2, 2] = 99;
            td[2, 3] = 11;
            // row 4, column 4
            td[3, 0] = 22;
            td[3, 1] = 98;
            td[3, 2] = 76;
            td[3, 3] = 49;

            //calling get. Data retireval using object name
            for (int i = 0; i < td.arr.GetLength(1); i++)
            {
                for (int j = 0; j < td.arr.GetLength(1); j++)
                {
                    // note the space before the object
                    y.Write($" {td[i, j]}");
                }
                y.WriteLine();
            }
        }
    }
}