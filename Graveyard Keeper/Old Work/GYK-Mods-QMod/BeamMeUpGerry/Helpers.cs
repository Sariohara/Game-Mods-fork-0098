﻿using System.Threading;
using Helper;

namespace BeamMeUpGerry;

public static partial class MainPatcher
{
    private static string GetLocalizedString(string content)
    {
        Thread.CurrentThread.CurrentUICulture = CrossModFields.Culture;
        return content;
    }
    
    internal static void Log(string message, bool error = false)
    {
        if (!_cfg.debug) return;
        if (error)
            Tools.Log("BeamMeUpGerry", $"{message}", true);
        else
            Tools.Log("BeamMeUpGerry", $"{message}");
    }
}