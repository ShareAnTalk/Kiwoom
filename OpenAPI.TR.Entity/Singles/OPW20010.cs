using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵예탁금및증거금조회</summary>
public class SingleOPW20010
{
    /// <summary>예탁총액</summary>
    [DataMember, JsonProperty("예탁총액"), StringLength(0x10)]
    public string? TotalDeposit
    {
        get; set;
    }
    /// <summary>예탁현금</summary>
    [DataMember, JsonProperty("예탁현금"), StringLength(0x10)]
    public string? DepositCash
    {
        get; set;
    }
    /// <summary>에탁대용</summary>
    [DataMember, JsonProperty("에탁대용"), StringLength(0x10)]
    public string? DepositSubstitute
    {
        get; set;
    }
    /// <summary>증거금총액</summary>
    [DataMember, JsonProperty("증거금총액"), StringLength(0x10)]
    public string? TotalAmountOfDeposits
    {
        get; set;
    }
    /// <summary>증거금현금</summary>
    [DataMember, JsonProperty("증거금현금"), StringLength(0x10)]
    public string? CashOnDeposit
    {
        get; set;
    }
    /// <summary>증거금대용금</summary>
    [DataMember, JsonProperty("증거금대용금"), StringLength(0x10)]
    public string? DepositForEvidence
    {
        get; set;
    }
    /// <summary>주문가능총액</summary>
    [DataMember, JsonProperty("주문가능총액"), StringLength(0x10)]
    public string? TotalOrderableAmount
    {
        get; set;
    }
    /// <summary>주문가능현금</summary>
    [DataMember, JsonProperty("주문가능현금"), StringLength(0x10)]
    public string? CashAvailableForOrderable
    {
        get; set;
    }
    /// <summary>주문가능대용금</summary>
    [DataMember, JsonProperty("주문가능대용금"), StringLength(0x10)]
    public string? OrderableSubstitute
    {
        get; set;
    }
    /// <summary>추가증거금총액</summary>
    [DataMember, JsonProperty("추가증거금총액"), StringLength(0x10)]
    public string? TotalAmountOfAdditionalDeposits
    {
        get; set;
    }
    /// <summary>추가증거금현금</summary>
    [DataMember, JsonProperty("추가증거금현금"), StringLength(0x10)]
    public string? AdditionalMarginCash
    {
        get; set;
    }
    /// <summary>추가증거금대용금</summary>
    [DataMember, JsonProperty("추가증거금대용금"), StringLength(0x10)]
    public string? AdditionalChargeForMargin
    {
        get; set;
    }
    /// <summary>인출가능총액</summary>
    [DataMember, JsonProperty("인출가능총액"), StringLength(0x10)]
    public string? TotalWithdrawableAmount
    {
        get; set;
    }
    /// <summary>인출가능현금</summary>
    [DataMember, JsonProperty("인출가능현금"), StringLength(0x10)]
    public string? WithdrawableCash
    {
        get; set;
    }
    /// <summary>인출가능대용금</summary>
    [DataMember, JsonProperty("인출가능대용금"), StringLength(0x10)]
    public string? WithdrawableLoan
    {
        get; set;
    }
    /// <summary>순자산금액</summary>
    [DataMember, JsonProperty("순자산금액"), StringLength(0x10)]
    public string? NetAssetAmount
    {
        get; set;
    }
    /// <summary>익일예탁총액</summary>
    [DataMember, JsonProperty("익일예탁총액"), StringLength(0x10)]
    public string? TotalDepositForTheNextDay
    {
        get; set;
    }
    /// <summary>개장예탁총액</summary>
    [DataMember, JsonProperty("개장예탁총액"), StringLength(0x10)]
    public string? TotalOpeningDeposit
    {
        get; set;
    }
    /// <summary>선물정산차금</summary>
    [DataMember, JsonProperty("선물정산차금"), StringLength(0x10)]
    public string? ForwardSettlementDifference
    {
        get; set;
    }
    /// <summary>선물청산손익</summary>
    [DataMember, JsonProperty("선물청산손익"), StringLength(0x10)]
    public string? GainOrLossOnTheSettlementOfFutures
    {
        get; set;
    }
    /// <summary>선물평가손익</summary>
    [DataMember, JsonProperty("선물평가손익"), StringLength(0x10)]
    public string? GainOrLossOnFuturesValuation
    {
        get; set;
    }
    /// <summary>선물약정금액</summary>
    [DataMember, JsonProperty("선물약정금액"), StringLength(0x10)]
    public string? ForwardCommitmentAmount
    {
        get; set;
    }
    /// <summary>옵션결제차금</summary>
    [DataMember, JsonProperty("옵션결제차금"), StringLength(0x10)]
    public string? OptionPaymentDifference
    {
        get; set;
    }
    /// <summary>옵션청산손익</summary>
    [DataMember, JsonProperty("옵션청산손익"), StringLength(0x10)]
    public string? GainOrLossOnOptionSettlement
    {
        get; set;
    }
    /// <summary>옵션평가손익</summary>
    [DataMember, JsonProperty("옵션평가손익"), StringLength(0x10)]
    public string? GainOrLossOnValuationOfOptions
    {
        get; set;
    }
    /// <summary>옵션약정금액</summary>
    [DataMember, JsonProperty("옵션약정금액"), StringLength(0x10)]
    public string? OptionCommitmentAmount
    {
        get; set;
    }
    /// <summary>전일장종료예탁총액</summary>
    [DataMember, JsonProperty("전일장종료예탁총액"), StringLength(0x10)]
    public string? TotalDepositAtTheEndOfThePreviousSession
    {
        get; set;
    }
    /// <summary>전일장종료예탁현금</summary>
    [DataMember, JsonProperty("전일장종료예탁현금"), StringLength(0x10)]
    public string? FullTimeEndDepositCash
    {
        get; set;
    }
    /// <summary>전일장종료예탁대용금</summary>
    [DataMember, JsonProperty("전일장종료예탁대용금"), StringLength(0x10)]
    public string? FullTimeTerminationDeposit
    {
        get; set;
    }
}