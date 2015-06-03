﻿using System;
using System.Runtime.InteropServices;

namespace BaiduPCS_NET
{
    [StructLayoutAttribute(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
    public struct NativePcsPanApiResInfoList
    {
        public PcsPanApiResInfo info;
        public IntPtr next;
    }
}
