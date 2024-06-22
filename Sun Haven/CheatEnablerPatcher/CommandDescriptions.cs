﻿using System.Collections.Generic;

namespace CheatEnablerPatcher;

public static class CommandDescriptions
{
    public readonly static Dictionary<string, string> Commands = new()
    {
        { "setarenaboss", "Set the arena boss by name.\nUsage: /setarenaboss bossName" },
        { "additem", "Add a specified item to the player's inventory.\nUsage: /additem itemName [amount]" },
        { "addrangeofitems", "Add a range of items to the player's inventory.\nUsage: /addrangeofitems itemName range [amount]" },
        { "adddevitems", "Add developer-specific items to the player's inventory.\nUsage: /adddevitems" },
        { "addstat", "Add a specified amount to a player's stat.\nUsage: /addstat statName amount" },
        { "addpermenentstatbonus", "Add a permanent bonus to a player's stat.\nUsage: /addpermenentstatbonus statName amount" },
        { "resetpermanentstatbonuses", "Reset all permanent stat bonuses for the current character.\nUsage: /resetpermanentstatbonuses" },
        { "setstat", "Set a player's stat to a specific amount.\nUsage: /setstat statName amount" },
        { "getstat", "Get the current value of a specified stat.\nUsage: /getstat statName" },
        { "skipday", "Skip one day in the game.\nUsage: /skipday" },
        { "skipday_single", "Skip one day in the game.\nUsage: /skipday" },
        { "skipday_multiple", "Skip a specified number of days in the game.\nUsage: /skipday days" },
        { "addtime", "Add a specified amount of time to the current day.\nUsage: /addtime hours" },
        { "settime", "Set the current time to a specific hour.\nUsage: /settime hour" },
        { "pausetime", "Pause the progression of time in the game.\nUsage: /pausetime" },
        { "unpausetime", "Resume the progression of time in the game.\nUsage: /unpausetime" },
        { "setseason", "Set the current season in the game.\nUsage: /setseason seasonName" },
        { "brinestonedeepssaved", "Set the 'Brinestone Deeps Saved' status.\nUsage: /brinestonedeepssaved true|false" },
        { "setday", "Set the current day in the game.\nUsage: /setday dayNumber" },
        { "setdayspeed", "Set the speed of the day cycle.\nUsage: /setdayspeed speed" },
        { "setbirthday", "Set the player's birthday.\nUsage: /setbirthday season day" },
        { "enabledaycycle", "Enable or disable the day cycle.\nUsage: /enabledaycycle true|false" },
        { "teleport", "Teleport the player to a specified scene.\nUsage: /teleport sceneName" },
        { "addmoney", "Add money to the player's inventory.\nUsage: /addmoney amount" },
        { "resetmoney", "Reset the player's money to zero.\nUsage: /resetmoney" },
        { "resetfoodstats", "Reset the player's food stats.\nUsage: /resetfoodstats" },
        { "setmaxfoodstats", "Set the maximum food stats for the player.\nUsage: /setmaxfoodstats amount" },
        { "resetalldecoration", "Reset all decorations in the game.\nUsage: /resetalldecoration" },
        { "resetfarminginfo", "Reset all farming information.\nUsage: /resetfarminginfo" },
        { "setuiactive", "Set the UI active or inactive.\nUsage: /setuiactive true|false" },
        { "noclip", "Enable or disable noclip mode.\nUsage: /noclip true|false" },
        { "godmode", "Enable or disable god mode.\nUsage: /godmode true|false" },
        { "setuiactivebutactionbar", "Set the UI active or inactive except for the action bar.\nUsage: /setuiactivebutactionbar true|false" },
        { "resetprogress", "Reset the game's progress.\nUsage: /resetprogress" },
        { "resetcharacterprogress", "Reset the progress for a specified character.\nUsage: /resetcharacterprogress progressName" },
        { "setcharacterprogress", "Set the progress for a specified character.\nUsage: /setcharacterprogress progressName" },
        { "unlockmines", "Unlock all mines in the game.\nUsage: /unlockmines" },
        { "lockmines", "Lock all mines in the game.\nUsage: /lockmines" },
        { "resetworldprogress", "Reset the progress for the game world.\nUsage: /resetworldprogress progressName" },
        { "setworldprogress", "Set the progress for the game world.\nUsage: /setworldprogress progressName" },
        { "resetrelationships", "Reset all relationships in the game.\nUsage: /resetrelationships" },
        { "getrelationships", "Get all relationships in the game.\nUsage: /getrelationships" },
        { "setrelationship", "Set the relationship level with a specified NPC.\nUsage: /setrelationship npcName amount" },
        { "marryNPC", "Marry a specified NPC.\nUsage: /marryNPC npcName" },
        { "divorceNPC", "Divorce the currently married NPC.\nUsage: /divorceNPC npcName" },
        { "resetinventory", "Reset the player's inventory.\nUsage: /resetinventory" },
        { "skipintro", "Skip the game's intro sequence.\nUsage: /skipintro" },
        { "skiptonpccycle", "Skip to a specified NPC cycle.\nUsage: /skiptonpccycle npcName cycleNumber" },
        { "skiptoworldquest", "Skip to a specified world quest.\nUsage: /skiptoworldquest breakpoint" },
        { "skiptoworldquestwithergate", "Skip to a specified world quest in Withergate.\nUsage: /skiptoworldquestwithergate breakpoint" },
        { "skiptoworldquestnelvari", "Skip to a specified world quest in Nelvari.\nUsage: /skiptoworldquestnelvari breakpoint" },
        { "skiptoworldepilogue", "Skip to a specified world epilogue.\nUsage: /skiptoworldepilogue breakpoint" },
        { "addexp", "Add experience points to a specified profession.\nUsage: /addexp professionName amount" },
        { "setexp", "Set the experience points for a specified profession.\nUsage: /setexp professionName amount" },
        { "resetskills", "Reset all skills.\nUsage: /resetskills" },
        { "resetquests", "Reset all quests.\nUsage: /resetquests" },
        { "spawnpet", "Spawn a pet.\nUsage: /spawnpet petName" },
        { "despawnpet", "Despawn the current pet.\nUsage: /despawnpet" },
        { "hidePlayer", "Hide the player.\nUsage: /hidePlayer" },
        { "setzoom", "Set the camera zoom level.\nUsage: /setzoom zoomLevel" },
        { "sethealth", "Set the player's health.\nUsage: /sethealth amount" },
        { "setmana", "Set the player's mana.\nUsage: /setmana amount" },
        { "startquest", "Start a specified quest.\nUsage: /startquest questName" },
        { "abandonquest", "Abandon a specified quest.\nUsage: /abandonquest questName" },
        { "setbulletinboardquest", "Set a specified bulletin board quest.\nUsage: /setbulletinboardquest questName" },
        { "resetanimals", "Reset all animals.\nUsage: /resetanimals" },
        { "setpreplaceddecorations", "Set pre-placed decorations.\nUsage: /setpreplaceddecorations" },
        { "setnpcquest", "Set a specified NPC quest.\nUsage: /setnpcquest questName" },
        { "sendmail", "Send a mail to the player.\nUsage: /sendmail mailID" },
        { "resetmail", "Reset all mails.\nUsage: /resetmail" },
        { "resethelpnotifications", "Reset all help notifications.\nUsage: /resethelpnotifications" },
        { "setdaya", "Set the current day to type A.\nUsage: /setdaya" },
        { "setdayb", "Set the current day to type B.\nUsage: /setdayb" },
        { "setdayrain", "Set the current day to rain.\nUsage: /setdayrain" },
        { "setdaylightsnow", "Set the current day to light snow.\nUsage: /setdaylightsnow" },
        { "setdaygloomyrain", "Set the current day to gloomy rain.\nUsage: /setdaygloomyrain" },
        { "setdayfoggy", "Set the current day to foggy.\nUsage: /setdayfoggy" },
        { "setdaywindy", "Set the current day to windy.\nUsage: /setdaywindy" },
        { "FixPets", "Fix the pets.\nUsage: /FixPets" },
        { "setdayseasonalparticle", "Set the current day to seasonal particle effect.\nUsage: /setdayseasonalparticle" },
        { "SetCloathingGloves", "Set the player's clothing gloves.\nUsage: /SetClothingGloves glovesID" },
        { "TestPlaceAllDecorations", "Test place all decorations.\nUsage: /TestPlaceAllDecorations" }
    };
}