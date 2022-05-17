namespace Prize.Actions
{
    internal class Fill : Interfaces.IFill
    {
        Models.ItemFromShop shop = new Models.ItemFromShop();
        Random random = new Random();

        public string[,] Items { get; set; } = new string[15, 2];

        public void ListOfItems()
        {
            Filling(shop.Clothes);
            Print(Items);
        }

        public void Filling(string[] item)
        {
            int index = 0;

            for (int i = 0; i < Items.GetLength(0); i++)
            {
                Items[i, 0] += item[index++];

                for (int j = 0; j < Items.GetLength(1); j++)
                {
                    shop.Value = random.Next(50, 200);
                    Items[i, 1] = shop.Value.ToString();
                }
            }
        }

        public void Print(string[,] items)
        {
            Console.Write("Clothes available:");
            Console.WriteLine();
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write(items[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
