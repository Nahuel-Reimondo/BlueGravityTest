using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreWidget : MonoBehaviour
{
    [SerializeField] private List<ItemData> itemsToDisplay = new List<ItemData>();
    [SerializeField] private ScrollRect viewRect;
    [SerializeField] private GameObject itemWidget;

    public void SetUp(List<ItemData> items)
    {
        itemsToDisplay = items;
        ArrengeView();
    }

    private void ArrengeView()
    {
        foreach (ItemData item in itemsToDisplay)
        {
            GameObject go= Instantiate(itemWidget, viewRect.content.transform);
            //go.SetUp();
        }
    }
}
