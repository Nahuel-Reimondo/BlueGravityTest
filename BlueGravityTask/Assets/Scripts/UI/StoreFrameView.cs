using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreFrameView : BaseView
{
    [SerializeField] private Button closeButton;
    [Header("Sell")]
    [SerializeField] private Button sellTabButton;
    [SerializeField] private StoreWidget sellTab;
    [Header("Buy")]
    [SerializeField] private Button buyTabButton;
    [SerializeField] private StoreWidget buyTab;

    public Action OnCloseButton;

    public void SetUp(StoreData storeData, StoreData playerInventory)
    {
        closeButton.onClick.AddListener(HandleCloseButton);
        sellTabButton.onClick.AddListener(HandleSellTab);
        buyTabButton.onClick.AddListener(HandleBuyTab);

        sellTab.SetUp(playerInventory.Items);
        buyTab.SetUp(storeData.Items);
    }

    private void HandleCloseButton()
    {
        OnCloseButton?.Invoke();
    }

    private void HandleSellTab()
    {
        sellTab.gameObject.SetActive(true);
        buyTab.gameObject.SetActive(false);
    }

    private void HandleBuyTab()
    {
        sellTab.gameObject.SetActive(false);
        buyTab.gameObject.SetActive(true);
    }

}
