using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : ItemBase {
    public override string Name
    {
        get
        {
            return "Potion";
        }
    }

    public override int Max
    {
        get
        {
            return 15;
        }
    }

    public override void ItemUse()
    {
        Debug.Log("Health +10");
    }
}
