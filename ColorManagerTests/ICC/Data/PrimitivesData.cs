﻿
namespace ColorManagerTests.ICC.Data
{
    public static class PrimitivesData
    {
        #region UInt16

        public static readonly byte[] UInt16_0 = { 0x00, 0x00 };
        public static readonly byte[] UInt16_1 = { 0x00, 0x01 };
        public static readonly byte[] UInt16_2 = { 0x00, 0x02 };
        public static readonly byte[] UInt16_3 = { 0x00, 0x03 };
        public static readonly byte[] UInt16_4 = { 0x00, 0x04 };
        public static readonly byte[] UInt16_5 = { 0x00, 0x05 };
        public static readonly byte[] UInt16_6 = { 0x00, 0x06 };
        public static readonly byte[] UInt16_7 = { 0x00, 0x07 };
        public static readonly byte[] UInt16_8 = { 0x00, 0x08 };
        public static readonly byte[] UInt16_9 = { 0x00, 0x09 };
        public static readonly byte[] UInt16_32768 = { 0x80, 0x00 };
        public static readonly byte[] UInt16_Max = { 0xFF, 0xFF };

        #endregion

        #region Int16

        public static readonly byte[] Int16_Min = { 0x80, 0x00 };
        public static readonly byte[] Int16_0 = { 0x00, 0x00 };
        public static readonly byte[] Int16_1 = { 0x00, 0x01 };
        public static readonly byte[] Int16_Max = { 0x7F, 0xFF };

        #endregion

        #region UInt32

        public static readonly byte[] UInt32_0 = { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] UInt32_1 = { 0x00, 0x00, 0x00, 0x01 };
        public static readonly byte[] UInt32_Max = { 0xFF, 0xFF, 0xFF, 0xFF };


        public static readonly uint UInt32_ValRand1 = 1749014123;
        public static readonly uint UInt32_ValRand2 = 3870560989;
        public static readonly uint UInt32_ValRand3 = 1050090334;
        public static readonly uint UInt32_ValRand4 = 3550252874;

        public static readonly byte[] UInt32_Rand1 = { 0x68, 0x3F, 0xD6, 0x6B };
        public static readonly byte[] UInt32_Rand2 = { 0xE6, 0xB4, 0x12, 0xDD };
        public static readonly byte[] UInt32_Rand3 = { 0x3E, 0x97, 0x1B, 0x5E };
        public static readonly byte[] UInt32_Rand4 = { 0xD3, 0x9C, 0x8F, 0x4A };

        #endregion

        #region Int32

        public static readonly byte[] Int32_Min = { 0x80, 0x00, 0x00, 0x00 };
        public static readonly byte[] Int32_0 = { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Int32_1 = { 0x00, 0x00, 0x00, 0x01 };
        public static readonly byte[] Int32_Max = { 0x7F, 0xFF, 0xFF, 0xFF };

        #endregion

        #region UInt64

        public static readonly byte[] UInt64_0 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] UInt64_1 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        public static readonly byte[] UInt64_Max = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };

        #endregion

        #region Int64

        public static readonly byte[] Int64_Min = { 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Int64_0 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Int64_1 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        public static readonly byte[] Int64_Max = { 0x7F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };

        #endregion

        #region Single

        public static readonly byte[] Single_Min = { 0xFF, 0x7F, 0xFF, 0xFF };
        public static readonly byte[] Single_0 = { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Single_1 = { 0x3F, 0x80, 0x00, 0x00 };
        public static readonly byte[] Single_2 = { 0x40, 0x00, 0x00, 0x00 };
        public static readonly byte[] Single_3 = { 0x40, 0x40, 0x00, 0x00 };
        public static readonly byte[] Single_4 = { 0x40, 0x80, 0x00, 0x00 };
        public static readonly byte[] Single_5 = { 0x40, 0xA0, 0x00, 0x00 };
        public static readonly byte[] Single_6 = { 0x40, 0xC0, 0x00, 0x00 };
        public static readonly byte[] Single_7 = { 0x40, 0xE0, 0x00, 0x00 };
        public static readonly byte[] Single_8 = { 0x41, 0x00, 0x00, 0x00 };
        public static readonly byte[] Single_9 = { 0x41, 0x10, 0x00, 0x00 };
        public static readonly byte[] Single_Max = { 0x7F, 0x7F, 0xFF, 0xFF };

        #endregion

        #region Double

        public static readonly byte[] Double_Min = { 0xFF, 0xEF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
        public static readonly byte[] Double_0 = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Double_1 = { 0x3F, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Double_Max = { 0x7F, 0xEF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };

        #endregion

        #region Fix16

        public const double Fix16_ValMin = short.MinValue;
        public const double Fix16_ValMax = short.MaxValue + 65535d / 65536d;

        public static readonly byte[] Fix16_Min = { 0x80, 0x00, 0x00, 0x00 };
        public static readonly byte[] Fix16_0 = { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] Fix16_1 = { 0x00, 0x01, 0x00, 0x00 };
        public static readonly byte[] Fix16_2 = { 0x00, 0x02, 0x00, 0x00 };
        public static readonly byte[] Fix16_3 = { 0x00, 0x03, 0x00, 0x00 };
        public static readonly byte[] Fix16_4 = { 0x00, 0x04, 0x00, 0x00 };
        public static readonly byte[] Fix16_5 = { 0x00, 0x05, 0x00, 0x00 };
        public static readonly byte[] Fix16_6 = { 0x00, 0x06, 0x00, 0x00 };
        public static readonly byte[] Fix16_7 = { 0x00, 0x07, 0x00, 0x00 };
        public static readonly byte[] Fix16_8 = { 0x00, 0x08, 0x00, 0x00 };
        public static readonly byte[] Fix16_9 = { 0x00, 0x09, 0x00, 0x00 };
        public static readonly byte[] Fix16_Max = { 0x7F, 0xFF, 0xFF, 0xFF };

        #endregion

        #region UFix16

        public const double UFix16_ValMin = 0;
        public const double UFix16_ValMax = ushort.MaxValue + 65535d / 65536d;

        public static readonly byte[] UFix16_0 = { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] UFix16_1 = { 0x00, 0x01, 0x00, 0x00 };
        public static readonly byte[] UFix16_Max = { 0xFF, 0xFF, 0xFF, 0xFF };

        #endregion

        #region U1Fix15

        public const double U1Fix15_ValMin = 0;
        public const double U1Fix15_ValMax = 1d + 32767d / 32768d;

        public static readonly byte[] U1Fix15_0 = { 0x00, 0x00 };
        public static readonly byte[] U1Fix15_1 = { 0x80, 0x00 };
        public static readonly byte[] U1Fix15_Max = { 0xFF, 0xFF };

        #endregion

        #region UFix8

        public const double UFix8_ValMin = 0;
        public const double UFix8_ValMax = byte.MaxValue + 255d / 256d;

        public static readonly byte[] UFix8_0 = { 0x00, 0x00 };
        public static readonly byte[] UFix8_1 = { 0x01, 0x00 };
        public static readonly byte[] UFix8_Max = { 0xFF, 0xFF };

        #endregion
    }
}