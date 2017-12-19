﻿using System;
using System.Runtime.InteropServices;

namespace ToolBox.System
{
    public static class Platform
    {
        public static bool IsWin() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsMac() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static bool IsGnu() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        public static string GetCurrent() 
            =>  (IsWin() ? "win" : null) ??
                (IsMac() ? "mac" : null) ??
                (IsGnu() ? "gnu" : null) ;
    }
}
