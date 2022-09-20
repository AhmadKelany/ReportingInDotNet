using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingInDotNet.Data;

public static class DataAccess
{
    public async static Task<List<Item>> GetItemsAsync(int count)
    {
        Faker<Item> itemFaker = new Faker<Item>().
            RuleFor(i=> i.ItemNameEnglish , f => f.Lorem.Sentence(7)).
            RuleFor(i => i.ItemNameArabic , _ => GenerateRandomArabicSentence(3,7)).
            RuleFor(i=>i.Quantity,f=>f.Random.Int(5,9999)).
            RuleFor(i => i.Price , f=> f.Random.Decimal(5.75m,999m)).
            RuleFor(i => i.LastSold , f => f.Date.Past(2)).
            RuleFor(i=>i.Category , f => f.Random.Enum<Category>());


        List<Item> items = await Task.Run(() => itemFaker.GenerateBetween(count,count));
       
        return items;
    }

    public static string GenerateRandomArabicWord()
    {
        Random rnd = new Random();
        string vowels = "اوي";
        string nonVowels = "بتجحدذرزسعفكلمنه";
        int wordLength = rnd.Next(2, 6);
        StringBuilder sb = new();
        for (int i = 0; i < wordLength; i++)
        {
            sb.Append(rnd.Next(0, 2) == 0 ? vowels[rnd.Next(0, 3)] : nonVowels[rnd.Next(0, nonVowels.Length)]);
        }
        return sb.ToString();
    }
    public static string GenerateRandomArabicSentence(int minWordsCount ,  int maxWordsCount)
    {
        Random rnd = new Random();
        int wordsCount = rnd.Next(minWordsCount, maxWordsCount + 1);
        string[] words = new string[wordsCount];
        for (int i = 0; i < wordsCount; i++)
        {
            words[i] = GenerateRandomArabicWord();
        }
        return string.Join(" ", words);
    }
}
