using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreWidget : MonoBehaviour
{
    [SerializeField] private List<ItemData> itemsToDisplay = new List<ItemData>();
    [SerializeField] private ScrollRect viewRect;
    [SerializeField] private ItemWidget itemWidget;

    public void SetUp(List<ItemData> items)
    {
        itemsToDisplay = items;
        ArrengeView();
    }

    private void ArrengeView()
    {
        foreach (ItemData item in itemsToDisplay)
        {
            ItemWidget widget = Instantiate(itemWidget, viewRect.content.transform);
            widget.SetUp(item,HandleItemSelection);
        }
    }

    private void HandleItemSelection(ItemData data)
    {
        //Update UI
        //StoreService o algo por el estilo
        print("Selected -> " + data.ItemName);
    }


}
