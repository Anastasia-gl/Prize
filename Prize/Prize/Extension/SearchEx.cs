namespace Prize.Extension
{
    public static class SearchEx
    {
        public static void Search(this string[,] clothes, string search)
        {
            char[] firstLetter = search.ToCharArray();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                for (int j = 0; j < clothes.GetLength(1); j++)
                {
                    if ((clothes[i, 0]).Contains(firstLetter[0]))
                    {
                        Console.Write(clothes[i, j] + "\t");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}