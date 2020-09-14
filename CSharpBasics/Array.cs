class Array
{
    void Learn1DArrays()
    {
        int[] ages1 = new int[5];
        ages1[0] = 23;
        ages1[1] = 23;
        ages1[2] = 23;
        ages1[3] = 23;

        float[] ages2 = new float[] { 45, 67, 23 };

        decimal[] ages3 = { 45, 67, 23 };
    }

    void LearnMDArrays()
    {
        int[,] mulTable = new int[3, 4];
        mulTable[0, 0] = 2;

        // 3-D
        double[,,] mulTable2 = new double[3, 4, 2];
        mulTable2[0, 0, 0] = 2.56;

        byte[,] numbers = { { 10, 27, 34 }, { 33, 14, 56 } };
    }

    void LearnJaggedArrays()
    {
        int[][] mulTable = new int[3][];
        mulTable[0] = new int[] { 2, 4, 6 };
        mulTable[1] = new int[] { 2, 4 };
        mulTable[2] = new int[] { 2, 4, 6, 45, 23 };
    }

}