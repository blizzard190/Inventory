using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;

    private void OnMouseDown()
    {
        IInventoryItem item = this.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
            item.OnPickUp();
        }
        //Debug.Log(item);
    }
}