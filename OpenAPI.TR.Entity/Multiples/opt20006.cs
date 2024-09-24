using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종일봉조회</summary>
public class MultiOpt20006
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10), Required]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(0x10), Required]
    public string? TradingVolume
    {
        get; set;
    }

    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자"), StringLength(8), Key]
    public string? Date
    {
        get; set;
    }

    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(0x10), Required]
    public string? OpenPrice
    {
        get; set;
    }

    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(0x10), Required]
    public string? HighPrice
    {
        get; set;
    }

    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(0x10), Required]
    public string? LowPrice
    {
        get; set;
    }

    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금"), StringLength(0x10)]
    public string? TransactionPrice
    {
        get; set;
    }

    /// <summary>대업종구분</summary>
    [DataMember, JsonProperty("대업종구분"), StringLength(0x10)]
    public string? LargeIndustryClassification
    {
        get; set;
    }

    /// <summary>소업종구분</summary>
    [DataMember, JsonProperty("소업종구분"), StringLength(0x10)]
    public string? SmallBusinessClassification
    {
        get; set;
    }

    /// <summary>종목정보</summary>
    [DataMember, JsonProperty("종목정보"), StringLength(0x10)]
    public string? StockInformation
    {
        get; set;
    }

    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가"), StringLength(0x10)]
    public string? ClosingPriceOfTheDayBefore
    {
        get; set;
    }
}