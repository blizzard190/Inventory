using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour {

    public Inventory inventory;
	// Use this for initialization
    public void Use()
    {
        DragHandler dragHandler = gameObject.transform.Find("Image").GetComponent<DragHandler>();

        IInventoryItem item = dragHandler.Item;

        item.ItemUse();

        Transform count = this.gameObject.transform;

        Count counter = count.GetChild(0).GetChild(0).GetComponent<Count>();
        counter.MinCount();
        if(counter.number <= 0)
        {
            inventory.RemoveItem(item);
        }
    }
}
