using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>콜옵션행사가요청</summary>
public class Opt50004 : TR
{
    /// <summary>콜옵션행사가</summary>
    [DataMember, JsonProperty("콜옵션행사가")]
    public MultiOpt50004[]? MultiResponse
    {
        get; set;
    }

    public override string[] Id => ["만기년월"];

    /// <summary>
    /// 1.만기년월
    /// </summary>
    public override string[]? Value
    {
        get; set;
    }

    public override string? RQName
    {
        set
        {

        }
        get => "콜옵션행사가요청";
    }

    public override string TrCode
    {
        get => nameof(Opt50004);
    }

    public override int PrevNext
    {
        get; set;
    }

    public override string ScreenNo
    {
        get => LookupScreenNo;
    }

    public override string[] Single => [];

    public override string[] Multiple => ["종목코드", "ATM구분", "행사가"];
}