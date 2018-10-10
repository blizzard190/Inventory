using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class HuD : MonoBehaviour {

    public Inventory inventory;
    [SerializeField]
    private Sprite _empty;
    
	void Start ()
    {
        inventory.ItemAdded += InventoryScript_ItemAdded;
        inventory.ItemRemoved += Inventory_ItemRemoved;
	}
	
	private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            DragHandler itemDragHandler = imageTransform.GetComponent<DragHandler>();
            
            if (image.sprite == _empty||image.sprite == e.Item.Image)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;
                Text number = slot.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>();
                int numbers = slot.GetChild(0).GetChild(0).GetChild(0).GetComponent<Count>().Counts(e.Item.Max);
                number.text = numbers.ToString();

                itemDragHandler.Item = e.Item;
                break;
            }
        }
    }

    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            DragHandler itemDragHandler = imageTransform.GetComponent<DragHandler>();

            if (itemDragHandler.Item.Equals(e.Item))
            {
                image.sprite = _empty;
                itemDragHandler.Item = null;
                break;
            }
        }
    }
}
