namespace ShareInvest.OpenAPI;

public class Balance
{
    /// <summary>보유수량</summary>
    public int HoldingQuantity
    {
        get; set;
    }
    /// <summary>주문가능수량</summary>
    public int QuantityAvailableForOrder
    {
        get; set;
    }
    /// <summary>매도_매수구분</summary>
    public OrderStatus OrderStatus
    {
        get; set;
    }
}