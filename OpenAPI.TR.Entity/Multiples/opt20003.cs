using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>전업종지수</summary>
public class MultiOpt20003
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드"), StringLength(0x8), Key]
    public string? Code
    {
        get; set;
    }

    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명"), StringLength(0x20)]
    public string? Name
    {
        get; set;
    }

    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10)]
    public string? CurrentPrice
    {
        get; set;
    }

    /// <summary>대비기호</summary>
    [DataMember, JsonProperty("대비기호"), StringLength(0x8)]
    public string? ContrastSymbol
    {
        get; set;
    }

    /// <summary>전일대비</summary>
    [DataMember, JsonProperty("전일대비"), StringLength(0x10)]
    public string? ComparedToThePreviousDay
    {
        get; set;
    }

    /// <summary>등락률</summary>
    [DataMember, JsonProperty("등락률"), StringLength(0x8)]
    public string? Rate
    {
        get; set;
    }

    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량"), StringLength(0x10)]
    public string? Volume
    {
        get; set;
    }

    /// <summary>비중</summary>
    [DataMember, JsonProperty("비중"), StringLength(0x8)]
    public string? Weight
    {
        get; set;
    }

    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금"), StringLength(0x10)]
    public string? TransactionAmount
    {
        get; set;
    }

    /// <summary>상한</summary>
    [DataMember, JsonProperty("상한"), StringLength(0x8)]
    public string? UpperLimit
    {
        get; set;
    }

    /// <summary>상승</summary>
    [DataMember, JsonProperty("상승"), StringLength(0x8)]
    public string? Rising
    {
        get; set;
    }

    /// <summary>보합</summary>
    [DataMember, JsonProperty("보합"), StringLength(0x8)]
    public string? Flat
    {
        get; set;
    }

    /// <summary>하락</summary>
    [DataMember, JsonProperty("하락"), StringLength(0x8)]
    public string? Falling
    {
        get; set;
    }

    /// <summary>하한</summary>
    [DataMember, JsonProperty("하한"), StringLength(0x8)]
    public string? LowerLimit
    {
        get; set;
    }

    /// <summary>상장종목수</summary>
    [DataMember, JsonProperty("상장종목수"), StringLength(0x8)]
    public string? ListedNumberOfStocks
    {
        get; set;
    }
}