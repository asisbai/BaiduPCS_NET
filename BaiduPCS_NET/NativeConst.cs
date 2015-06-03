﻿using System;

namespace BaiduPCS_NET
{
    public static class NativeConst
    {
        /// <summary>
        /// 本地代码中的 true
        /// </summary>
        public const byte True = 1;

        /// <summary>
        /// 本地代码中的 false
        /// </summary>
        public const byte False = 0;

        /// <summary>
        /// This is a return code for the read callback that, when returned, will
        /// signal libcurl to immediately abort the current transfer.
        /// Used by OnReadSliceFunction and NativePcsReadSliceFunction.
        /// </summary>
        public const int CURL_READFUNC_ABORT = 0x10000000;

        /// <summary>
        /// This is a return code for the read callback that, when returned, will
        /// signal libcurl to pause sending data on the current transfer.
        /// Used by OnReadSliceFunction and NativePcsReadSliceFunction.
        /// </summary>
        public const int CURL_READFUNC_PAUSE = 0x10000001;


        /// <summary>
        /// 全为 0 的 8x8 矩阵
        /// </summary>
        public static readonly byte[] ZERO_MATRIX_8X8 = new byte[] {
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
        };

    }
}
