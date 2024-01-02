namespace ShareInvest.OpenAPI;

public class Conclusion
{
    /// <summary>원주문번호</summary>
    public string? OriginalOrderNumber
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    public OrderStatus OrderStatus
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    public int OrderQuantity
    {
        get; set;
    }
    /// <summary>미체결수량</summary>
    public int UntradedQuantity
    {
        get; set;
    }
    /// <summary>주문가격</summary>
    public decimal OrderPrice
    {
        get; set;
    }
    /// <summary>종목코드_업종코드</summary>
    public string? Code
    {
        get; set;
    }
    /// <summary>단위체결량</summary>
    public int UnitContractAmount
    {
        get; set;
    }
    /// <summary>단위체결가</summary>
    public decimal UnitContractPrice
    {
        get; set;
    }
    /// <summary>당일매매세금</summary>
    public int Tax
    {
        get; set;
    }
    /// <summary>당일매매수수료</summary>
    public int TradingFee
    {
        get; set;
    }
}