namespace ReportingInDotNet.Data;

public class Item
{
    public string ItemNameEnglish { get; set; }
    public string ItemNameArabic { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime LastSold { get; set; }
    public Category Category { get; set; }
    public override string ToString()
    {
        return $"{ItemNameEnglish}-Price:{Price:N2}, Qty:{Quantity}, Last Sold:{LastSold:yyyy-MM-dd}";
    }

}