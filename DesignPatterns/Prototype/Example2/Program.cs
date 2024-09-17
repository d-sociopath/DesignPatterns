namespace DesignPatterns.Prototype.Example2
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Create an original chocolate chip cookie
            ChocolateChipCookie originalChocolateChipCookie = new ChocolateChipCookie("Chocolate", true, 20);

            // Clone the original chocolate chip cookie
            ChocolateChipCookie clonedChocolateChipCookie = (ChocolateChipCookie)originalChocolateChipCookie.Clone();

            // Modify the cloned chocolate chip cookie
            clonedChocolateChipCookie.ChocolateChipCount = 30;

            // Create an original oatmeal raisin cookie
            OatmealRaisinCookie originalOatmealRaisinCookie = new OatmealRaisinCookie("Oatmeal", false, 15);

            // Clone the original oatmeal raisin cookie
            OatmealRaisinCookie clonedOatmealRaisinCookie = (OatmealRaisinCookie)originalOatmealRaisinCookie.Clone();

            // Modify the cloned oatmeal raisin cookie
            clonedOatmealRaisinCookie.RaisinCount = 25;

            // Display the original and cloned cookies
            Console.WriteLine("Original Chocolate Chip Cookie:");
            Console.WriteLine(originalChocolateChipCookie);

            Console.WriteLine("\nCloned Chocolate Chip Cookie:");
            Console.WriteLine(clonedChocolateChipCookie);

            Console.WriteLine("\nOriginal Oatmeal Raisin Cookie:");
            Console.WriteLine(originalOatmealRaisinCookie);

            Console.WriteLine("\nCloned Oatmeal Raisin Cookie:");
            Console.WriteLine(clonedOatmealRaisinCookie);
        }
    }
}
