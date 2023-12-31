using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물일차트요청</summary>
public class Opt50030 : TR
{
    /// <summary>선물옵션일차트</summary>
    [DataMember, JsonProperty("선물옵션일차트")]
    public MultiOpt50030[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[]
    {
        "종목코드",
        "기준일자"
    };
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
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
        get => "선물일차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50030);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Multiple => new[]
    {
        "현재가",
        "누적거래량",
        "일자",
        "시가",
        "고가",
        "저가",
        "수정주가이벤트",
        "전일종가"
    };
    public override string[] Single => Array.Empty<string>();
}