﻿using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace WheresMaPoints;

public static class Config
{
    private static Options _options;
    private static ConfigReader _con;

    public static Options GetOptions(bool external = false)
    {
        _options = new Options();
        _con = new ConfigReader(external);

        bool.TryParse(_con.Value("ShowPointGainAboveKeeper", "true"), out var showPointGainAboveKeeper);
        _options.showPointGainAboveKeeper = showPointGainAboveKeeper;
        
        bool.TryParse(_con.Value("StillPlayCollectAudio", "false"), out var stillPlayCollectAudio);
        _options.stillPlayCollectAudio = stillPlayCollectAudio;
        
        bool.TryParse(_con.Value("Debug", "false"), out var debug);
        _options.debug = debug;
        
        bool.TryParse(_con.Value("AlwaysShowXpBar", "true"), out var alwaysShowXpBar);
        _options.alwaysShowXpBar = alwaysShowXpBar;
        
        var key = Enum.TryParse<KeyCode>(_con.Value("ReloadConfigKeyBind", "F5"), true, out var a);
        if (key)
        {
            _options.reloadConfigKeyBind = a;
            if (!external)
            {
                Debug.LogWarning($"[WheresMaPoints]: Parsed '{a}' for 'ReloadConfigKeyBind'.");
            }
        }
        else
        {
            _options.reloadConfigKeyBind = KeyCode.F5;
            if (!external)
            {
                Debug.LogWarning($"[WheresMaPoints]: Failed to parse key for 'ReloadConfigKeyBind'. Setting to default F5.");
            }
        }
        
        _con.ConfigWrite();

        return _options;
    }

    [Serializable]
    public class Options
    {
        [FormerlySerializedAs("ReloadConfigKeyBind")] public KeyCode reloadConfigKeyBind;
        [FormerlySerializedAs("StillPlayCollectAudio")] public bool stillPlayCollectAudio;
        [FormerlySerializedAs("ShowPointGainAboveKeeper")] public bool showPointGainAboveKeeper;
        [FormerlySerializedAs("AlwaysShowXpBar")] public bool alwaysShowXpBar;
        [FormerlySerializedAs("Debug")] public bool debug;

    }
}