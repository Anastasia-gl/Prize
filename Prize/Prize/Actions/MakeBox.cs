namespace Prize.Actions
{
    public class MakeBox : InfoAboutPlace, Interfaces.IMakeBox
    {
        Models.Prize prize = new Models.Prize();
        Actions.InfoAboutPlace place = new Actions.InfoAboutPlace();
        Actions.Fill fill = new Actions.Fill();
        Models.ItemFromShop items = new Models.ItemFromShop();

        public override void WinPlace(string ans)
        {
            place.WinPlace(ans);
            MakingBox(fill.Items, prize.SumPriz, ans);
        }

        public void MakingBox(string[,] str, int[] sumPrize, string ans)
        {
            fill.Filling(items.Clothes);

            int price = 0;
            int sum = 0;
            int index = 0;

            for (int i = 0; i < str.GetLength(0); i++)
            {
                price = int.Parse(str[i, 1]);
                if (ans == "1")
                {
                    sum += price;
                    if (sum < sumPrize[index])
                    {
                        Console.WriteLine(str[i, 0] + " " + price);
                    }
                    else if (sum > sumPrize[index])
                    {
                        break;
                    }
                }
                else if (ans == "2")
                {
                    sum += price;
                    index = 1;
                    if (sum < sumPrize[index])
                    {
                        Console.WriteLine(str[i, 0] + " " + price);
                    }
                    else if (sum > sumPrize[index])
                    {
                        break;
                    }
                }
                else if (ans == "3")
                {
                    index = 1;
                    sum += price;
                    if (sum < sumPrize[index++])
                    {
                        Console.WriteLine(str[i, 0] + " " + price);
                    }
                    else if (sum > sumPrize[index++])
                    {
                        break;
                    }
                }
            }
        }
    }
}