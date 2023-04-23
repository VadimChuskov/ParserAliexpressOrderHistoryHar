namespace ParserAliexpressOrderHistoryHar.Classes.Models;

public class Order
{
    public string CurrencyCode { get; set; }
    public string FormatPriceInfo { get; set; }
    public string OrderDateText { get; set; }
    public string OrderDateTitle { get; set; }
    public string OrderDetailText { get; set; }
    public string OrderDetailUrl { get; set; }
    public string OrderId { get; set; }
    public List<OrderLine> OrderLines { get; set; }
    public bool PaymentDisableBox { get; set; }
    public string PaymentOutId { get; set; }
    public string SellerConnectUrl { get; set; }
    public string ShopIcon { get; set; }
    public string StoreName { get; set; }
    public string StorePageUrl { get; set; }
    public string TotalPriceText { get; set; }
    public string TotalPriceTitle { get; set; }
}