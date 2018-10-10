using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour, IInventoryItem {

    public Sprite _Image;
    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public virtual int Max
    {
        get
        {
            return 99;
        }
    }

    public virtual string Name
    {
        get
        {
            return "_base item_";
        }
    }

    public virtual void ItemUse()
    {

    }

    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }
}
