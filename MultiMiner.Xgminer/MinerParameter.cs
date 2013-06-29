﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMiner.Xgminer
{
    public static class MinerParameter
    {
        public const string DisableGpu = "--disable-gpu";
        public const string DisableUsb = "--usb :0";
        public const string Benchmark = "--benchmark";
        public const string ApiListen = "--api-listen";
        public const string EnumerateDevices = "--ndevs";
    }
}