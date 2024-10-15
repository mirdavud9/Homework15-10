using System;

#region Task 1

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Cumle daxil et:");
//        string input = Console.ReadLine();
//        Console.WriteLine(FormatSentence(input));
//    }

//    static string FormatSentence(string sentence)
//    {
//        string[] words = sentence.Trim().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        for (int i = 0; i < words.Length; i++)
//        {
//            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
//        }
//        return string.Join(" ", words);
//    }
//}
#endregion


//Task 2
using System;
using static Homework14._10.ProductApp;

namespace Productapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Apple", "Iphone13", 1500, 1000, 10);

            product.GetInfo();
            product.Sale(3);
            product.GetInfo();
        }
    }
}
