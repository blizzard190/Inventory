using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryItem {
    
    string Name { get; }
    Sprite Image { get; }
    int Max { get; }
    void OnPickUp();
    void ItemUse();
}

public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item;
}
