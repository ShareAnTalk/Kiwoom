using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증권사별종목매매동향</summary>
public class MultiOPT10078
{
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? Date
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? PresentPrice
    {
        get; set;
    }
    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호")]
    public string? ContrastSymbol
    {
        get; set;
    }
    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비")]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? FluctuationRate
    {
        get; set;
    }
    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량")]
    public string? AccumulatedTradingVolume
    {
        get; set;
    }
    /// <summary>순매수수량</summary>
    [DataMember, JsonProperty("순매수수량")]
    public string? NetPurchaseQuantity
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? PurchaseQuantity
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? SalesVolume
    {
        get; set;
    }
}