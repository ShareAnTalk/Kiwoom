using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결정보</summary>
public class MultiOpt10003
{
    /// <summary>시간</summary>
    [DataMember, JsonProperty("시간"), StringLength(6), Required]
    public string? Time
    {
        get; set;
    }

    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10), Required]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(0x10)]
    public string? ComparedToPreviousDay
    {
        get; set;
    }

    /// <summary>대비율</summary>
    [DataMember, JsonProperty("대비율"), StringLength(0x10)]
    public string? ContrastRatio
    {
        get; set;
    }

    /// <summary>우선매도호가단위</summary>
    [DataMember, JsonProperty("우선매도호가단위"), StringLength(0x10)]
    public string? PreferredSellingPriceUnit
    {
        get; set;
    }

    /// <summary>우선매수호가단위</summary>
    [DataMember, JsonProperty("우선매수호가단위"), StringLength(0x10)]
    public string? PreferredPurchasePriceUnit
    {
        get; set;
    }

    /// <summary>체결거래량</summary>
    [DataMember, JsonProperty("체결거래량"), StringLength(0x10), Required]
    public string? Volume
    {
        get; set;
    }

    /// <summary>sign</summary>
    [DataMember, JsonProperty("sign"), StringLength(0x10)]
    public string? Sign
    {
        get; set;
    }

    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량"), StringLength(0x10), Key]
    public string? CumulativeVolume
    {
        get; set;
    }

    /// <summary>누적거래대금</summary>
    [DataMember, JsonProperty("누적거래대금"), StringLength(0x10)]
    public string? CumulativeTransactionAmount
    {
        get; set;
    }

    /// <summary>체결강도</summary>
    [DataMember, JsonProperty("체결강도"), StringLength(0x10), Required]
    public string? Pressure
    {
        get; set;
    }
}