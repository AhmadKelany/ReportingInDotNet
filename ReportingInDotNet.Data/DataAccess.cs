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
            RuleFor(i => i.ItemNameArabic , _ => ArabicSentenceGenerator.GetArabicSentence(7)).
            RuleFor(i=>i.Quantity,f=>f.Random.Int(5,9999)).
            RuleFor(i => i.Price , f=> f.Random.Decimal(5.75m,999m)).
            RuleFor(i => i.LastSold , f => f.Date.Past(2)).
            RuleFor(i=>i.Category , f => f.Random.Enum<Category>());


        List<Item> items = await Task.Run(() => itemFaker.Generate(count));
       
        return items;
    }

   

}
