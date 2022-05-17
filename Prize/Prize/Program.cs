namespace Prize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Actions.InfoAboutPlace info = new Actions.InfoAboutPlace();
            Actions.MakeBox makeBox = new Actions.MakeBox();
            Actions.Fill fill = new Actions.Fill();
            Models.ItemFromShop itemFromShop = new Models.ItemFromShop();

            fill.ListOfItems();

            Console.WriteLine("Enter your prize-winning place (1, 2 or 3): ");
            info.Win = Console.ReadLine();

            Console.WriteLine("Your prize box:");
            makeBox.WinPlace(info.Win);

            Console.WriteLine("You can make a search in the list of main shop. Just enter a letter(for example: J)");
            string letter = Console.ReadLine();
            Extension.SearchEx.Search(fill.Items, letter);
        }
    }
}