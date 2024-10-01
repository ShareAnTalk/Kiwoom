using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵체결추이</summary>
public class MultiOPT50006
{
    /// <summary>체결시간</summary>
    [DataMember, JsonProperty("체결시간"), StringLength(6), Required]
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

    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호"), StringLength(0x10), Required]
    public string? ComparedToThePreviousSign
    {
        get; set;
    }

    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(0x10)]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }

    /// <summary>체결량</summary>
    [DataMember, JsonProperty("체결량"), StringLength(0x10), Required]
    public string? Amount
    {
        get; set;
    }

    /// <summary>누적거래량</summary>
    [DataMember, JsonProperty("누적거래량"), StringLength(0x10), Key]
    public string? CumulativeVolume
    {
        get; set;
    }

    /// <summary>미결제약정</summary>
    [DataMember, JsonProperty("미결제약정"), StringLength(0x10)]
    public string? OpenInterest
    {
        get; set;
    }

    /// <summary>미결제증감</summary>
    [DataMember, JsonProperty("미결제증감"), StringLength(0x10)]
    public string? OpenInterestCompareToPreviousDay
    {
        get; set;
    }

    /// <summary>전일거래량대비</summary>
    [DataMember, JsonProperty("전일거래량대비"), StringLength(0x10)]
    public string? ComparedToPreviousVolume
    {
        get; set;
    }

    /// <summary>전일거래량</summary>
    [DataMember, JsonProperty("전일거래량"), StringLength(0x10)]
    public string? PreviousVolume
    {
        get; set;
    }

    /// <summary>기준가</summary>
    [DataMember, JsonProperty("기준가"), StringLength(0x10)]
    public string? StandardPrice
    {
        get; set;
    }
}