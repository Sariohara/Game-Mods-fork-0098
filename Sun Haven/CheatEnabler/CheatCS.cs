﻿
namespace CheatEnabler;

[CommandPrefix("/")]
public static class QuantumConsoleManager
{

    [CommandDescription("Generates a user manual for any given command, including built in ones. To use the man command, simply put the desired command name in front of it. For example, 'man my-command' will generate the manual for 'my-command'")]
    [Command("help")]
    [Command("manual")]
    [Command]
    public static void man(string commandName)
    {
        //remove all / from commandName, and add just one to the beginning
        commandName = commandName.Replace("/", "");
        commandName = "/" + commandName;

        var manual = QuantumConsoleProcessor.GenerateCommandManual(commandName);
        if (string.IsNullOrWhiteSpace(manual))
        {
            Shared.Utils.SendNotification($"Manual for command '{commandName}' not found!");
        }
        else
        {
            throw new ArgumentException(manual);
        }
    }
    
    
    [Command(Description = "Save the current game.")]
    public static void savegame()
    {
        SingletonBehaviour<GameSave>.Instance.SaveGame(true);
        SingletonBehaviour<NotificationStack>.Instance.SendNotification("Game Saved!");
    }

    [Command(Description = "Add item to the player inventory using the numeric item code.")]
    public static void additembyid(int itemId, int amount = 1)
    {
        var item = ItemDatabase.ids.Where(a => a.Value == itemId).Select(a => a.Key).FirstOrDefault();
        if (!item.IsNullOrWhiteSpace())
        {
            Player.Instance.Inventory.AddItem(itemId, amount, true);
        }
        else
        {
            Shared.Utils.SendNotification($"Item with itemID {itemId} not found!");
        }
    }
}