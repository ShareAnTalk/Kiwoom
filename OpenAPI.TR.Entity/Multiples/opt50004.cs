using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>콜옵션행사가</summary>
public class MultiOpt50004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드"), Key, StringLength(8)]
    public string? Code
    {
        get; set;
    }

    /// <summary>ATM구분</summary>
    [DataMember, JsonProperty("ATM구분"), StringLength(1)]
    public string? ATM
    {
        get; set;
    }

    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가"), StringLength(8)]
    public string? StrikePrice
    {
        get; set;
    }
}