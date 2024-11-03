using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션매도주문증거금</summary>
public class MultiOpw20015
{
    /// <summary>콜조정이론가</summary>
    [DataMember, JsonProperty("콜조정이론가"), StringLength(0x10)]
    public string? CallOA
    {
        get; set;
    }

    /// <summary>콜최대이론가</summary>
    [DataMember, JsonProperty("콜최대이론가"), StringLength(0x10)]
    public string? CallMaxTheoryPrice
    {
        get; set;
    }

    /// <summary>콜전일종가</summary>
    [DataMember, JsonProperty("콜전일종가"), StringLength(0x10)]
    public string? CallPreviousPrice
    {
        get; set;
    }

    /// <summary>콜주문증거금</summary>
    [DataMember, JsonProperty("콜주문증거금"), StringLength(0x10)]
    public string? CallOrderMargin
    {
        get; set;
    }

    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격"), Key, StringLength(0x10)]
    public string? StrikePrice
    {
        get; set;
    }

    /// <summary>풋주문증거금</summary>
    [DataMember, JsonProperty("풋주문증거금"), StringLength(0x10)]
    public string? PutOrderMargin
    {
        get; set;
    }

    /// <summary>풋전일종가</summary>
    [DataMember, JsonProperty("풋전일종가"), StringLength(0x10)]
    public string? PutPreviousPrice
    {
        get; set;
    }

    /// <summary>풋최대이론가</summary>
    [DataMember, JsonProperty("풋최대이론가"), StringLength(0x10)]
    public string? PutMaxTheoryPrice
    {
        get; set;
    }

    /// <summary>풋조정이론가</summary>
    [DataMember, JsonProperty("풋조정이론가"), StringLength(0x10)]
    public string? PutOA
    {
        get; set;
    }
}