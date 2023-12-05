﻿namespace ShareInvest;

public enum MarketOperation
{
    장시작전 = 0,
    장마감전_동시호가 = 2,
    장시작 = 3,
    장종료_예상지수종료 = 4,
    장마감 = 8,
    장종료_시간외종료 = 9,
    시간외_종가매매_시작 = 'a',
    시간외_종가매매_종료 = 'b',
    시간외_단일가_매매시작 = 'c',
    시간외_단일가_매매종료 = 'd',
    선옵_장마감전_동시호가_시작 = 's',
    선옵_장마감전_동시호가_종료 = 'e',
    선옵_조기개장_알림 = 'f'
}
public static class Operation
{
    public static MarketOperation Get(string? arg)
    {
        if (arg?.Length == 1)
        {
            var index = char.IsDigit(arg[0]) ? Convert.ToInt32(arg) : Convert.ToChar(arg);

            if (Enum.IsDefined(typeof(MarketOperation), index))
            {
                return (MarketOperation)index;
            }
        }
        return MarketOperation.장종료_시간외종료;
    }
}