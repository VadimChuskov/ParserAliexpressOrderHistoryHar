namespace ParserAliexpressOrderHistoryHar.Classes.Models;

public class OrderLine
{
    public string CurrencyCode { get; set; }
    public string FormatPriceInfo { get; set; }
    public string ItemDetailUrl { get; set; }
    public string ItemImgUrl { get; set; }
    public string ItemPriceText { get; set; }
    public string ItemTitle { get; set; }
    public string OrderLineId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public string SkuId { get; set; }
}