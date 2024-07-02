using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션분차트</summary>
public class MultiOpt50067
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(8), Required]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(8), Required]
    public string? TradingVolume
    {
        get; set;
    }

    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간"), StringLength(0x10), Key]
    public string? Time
    {
        get; set;
    }

    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(8), Required]
    public string? OpenPrice
    {
        get; set;
    }

    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(8), Required]
    public string? HighPrice
    {
        get; set;
    }

    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(8), Required]
    public string? LowPrice
    {
        get; set;
    }

    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가"), StringLength(8)]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
}