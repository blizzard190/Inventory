using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    private const int _Slots = 9;
    private List<IInventoryItem> _Items = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;
    public event EventHandler<InventoryEventArgs> ItemRemoved;

    public void AddItem(IInventoryItem item)
    {
        /* if(_Items.Count < _Slots)
         {
             if (ItemAdded != null)
             {
                 ItemAdded(this, new InventoryEventArgs(item));
             }
         }*/
        if (_Items.Count == 0)
        {
            _Items.Add(item);
            if (ItemAdded != null)
            {
                ItemAdded(this, new InventoryEventArgs(item));
            }
        } else if (_Items.Count > 0)
        { 
            for (int i = 0; i < _Slots; i++)
            {
                if (_Items[i] == item)
                {
                    ItemAdded(this, new InventoryEventArgs(item));
                    break;
                }else if(i == _Slots)
                {
                    _Items.Add(item);
                    if(ItemAdded != null)
                    {
                        ItemAdded(this, new InventoryEventArgs(item));
                    }
                }
            }
        }
    }

    public void RemoveItem(IInventoryItem item)
    {
        if (_Items.Contains(item))
        {
            _Items.Remove(item);
            if(ItemRemoved != null)
            {
                ItemRemoved(this, new InventoryEventArgs(item));
            }
        }
    }
}
