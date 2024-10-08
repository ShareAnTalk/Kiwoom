﻿using System.Text;

namespace ShareInvest.RealType;

public class KiwoomOption
{
    public static string FidList
    {
        get
        {
            StringBuilder sb = new();

            var optionQuoteBalances = Enum.GetValues<옵션호가잔량>().Select(e => (int)e);
            var optionQuotes = Enum.GetValues<옵션시세>().Select(e => (int)e);
            var optionTheoreticalPrice = Enum.GetValues<옵션이론가>().Select(e => (int)e);

            foreach (var e in optionQuoteBalances.Union(optionQuotes).Union(optionTheoreticalPrice))
            {
                sb.Append(e);
                sb.Append(';');
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }
    }
}

public enum 옵션이론가
{
    미결제약정 = 195,
    이론가 = 182,
    괴리율 = 186,
    델타 = 190,
    감마 = 191,
    세타 = 193,
    베가 = 192,
    로 = 194,
    미결제약정전일대비 = 181,
    시초미결제약정수량 = 246,
    최고미결제약정수량 = 247,
    최저미결제약정수량 = 248,
    내재가치 = 187,
    시간가치 = 188,
    내재변동성 = 189
}

public enum 옵션시세
{
    체결시간 = 20,
    현재가 = 10,
    전일대비 = 11,
    등락율 = 12,
    최우선_매도호가 = 27,
    최우선_매수호가 = 28,
    거래량 = 15,
    누적거래량 = 13,
    누적거래대금 = 14,
    시가 = 16,
    고가 = 17,
    저가 = 18,
    미결제약정 = 195,
    이론가 = 182,
    괴리율 = 186,
    델타 = 190,
    감마 = 191,
    세타 = 193,
    베가 = 192,
    로 = 194,
    미결제약정전일대비 = 181,
    전일대비기호 = 25,
    전일거래량대비 = 26,
    호가순잔량 = 137,
    내재가치 = 187,
    KOSPI200 = 197,
    시초미결제약정수량 = 246,
    최고미결제약정수량 = 247,
    최저미결제약정수량 = 248,
    선물최근월물지수 = 219,
    미결제증감 = 196,
    시간가치 = 188,
    내재변동성 = 189,
    전일거래량대비_비율 = 30,
    기준가대비시가등락율 = 391,
    기준가대비고가등락율 = 392,
    기준가대비저가등락율 = 393,
    실시간상한가 = 1365,
    실시간하한가 = 1366,
    협의대량누적체결수량 = 1367,
    상한가 = 305,
    하한가 = 306
}

public enum 옵션호가잔량
{
    호가시간 = 21,
    최우선_매도호가 = 27,
    최우선_매수호가 = 28,
    매도호가1 = 41,
    매도호가수량1 = 61,
    매도호가직전대비1 = 81,
    매도호가건수1 = 101,
    매수호가1 = 51,
    매수호가수량1 = 71,
    매수호가직전대비1 = 91,
    매수호가건수1 = 111,
    매도호가2 = 42,
    매도호가수량2 = 62,
    매도호가직전대비2 = 82,
    매도호가건수2 = 102,
    매수호가2 = 52,
    매수호가수량2 = 72,
    매수호가직전대비2 = 92,
    매수호가건수2 = 112,
    매도호가3 = 43,
    매도호가수량3 = 63,
    매도호가직전대비3 = 83,
    매도호가건수3 = 103,
    매수호가3 = 53,
    매수호가수량3 = 73,
    매수호가직전대비3 = 93,
    매수호가건수3 = 113,
    매도호가4 = 44,
    매도호가수량4 = 64,
    매도호가직전대비4 = 84,
    매도호가건수4 = 104,
    매수호가4 = 54,
    매수호가수량4 = 74,
    매수호가직전대비4 = 94,
    매수호가건수4 = 114,
    매도호가5 = 45,
    매도호가수량5 = 65,
    매도호가직전대비5 = 85,
    매도호가건수5 = 105,
    매수호가5 = 55,
    매수호가수량5 = 75,
    매수호가직전대비5 = 95,
    매수호가건수5 = 115,
    매도호가총잔량 = 121,
    매도호가총잔량직전대비 = 122,
    매도호가총건수 = 123,
    매수호가총잔량 = 125,
    매수호가총잔량직전대비 = 126,
    매수호가총건수 = 127,
    호가순잔량 = 137,
    순매수잔량 = 128,
    누적거래량 = 13,
    예상체결가 = 23,
    예상체결가전일종가대비기호 = 238,
    예상체결가전일종가대비 = 200,
    예상체결가전일종가대비등락율 = 201,
    예상체결가_예상체결시간동안에만유효한값 = 291,
    예상체결가전일대비기호 = 293,
    예상체결가전일대비 = 294,
    예상체결가전일대비등락율 = 295
}