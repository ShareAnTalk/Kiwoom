using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종현재가</summary>
public class SingleOpt20001
{
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가"), StringLength(0x10)]
    public string? CurrentPrice
    {
        get; set;
    }
    /// <summary>전일대비기호</summary>
    [DataMember, JsonProperty("전일대비기호"), StringLength(0x8)]
    public string? SignsComparedToThePreviousDay
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
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금"), StringLength(0x10)]
    public string? TransactionAmount
    {
        get; set;
    }
    /// <summary>거래형성종목수</summary>
    [DataMember, JsonProperty("거래형성종목수"), StringLength(0x8)]
    public string? TransactionFormationStock
    {
        get; set;
    }
    /// <summary>거래형성비율</summary>
    [DataMember, JsonProperty("거래형성비율"), StringLength(0x8)]
    public string? TransactionFormationRatio
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가"), StringLength(0x10)]
    public string? StartPrice
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가"), StringLength(0x10)]
    public string? HighPrice
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가"), StringLength(0x10)]
    public string? LowPrice
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
    /// <summary>52주최고가</summary>
    [DataMember, JsonProperty("52주최고가"), StringLength(0x10)]
    public string? HighPriceFor52week
    {
        get; set;
    }
    /// <summary>52주최고가일</summary>
    [DataMember, JsonProperty("52주최고가일"), StringLength(0x8)]
    public string? HighPriceDayFor52week
    {
        get; set;
    }
    /// <summary>52주최고가대비율</summary>
    [DataMember, JsonProperty("52주최고가대비율"), StringLength(0x10)]
    public string? HighPriceRatioFor52week
    {
        get; set;
    }
    /// <summary>52주최저가</summary>
    [DataMember, JsonProperty("52주최저가"), StringLength(0x10)]
    public string? LowPriceFor52week
    {
        get; set;
    }
    /// <summary>52주최저가일</summary>
    [DataMember, JsonProperty("52주최저가일"), StringLength(0x8)]
    public string? LowPriceDayFor52week
    {
        get; set;
    }
    /// <summary>52주최저가대비율</summary>
    [DataMember, JsonProperty("52주최저가대비율"), StringLength(0x8)]
    public string? LowPriceRatioFor52week
    {
        get; set;
    }
}