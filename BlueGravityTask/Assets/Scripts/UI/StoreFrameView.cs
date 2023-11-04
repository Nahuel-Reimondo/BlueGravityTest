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
    [SerializeField] private GameObject sellTab;
    [Header("Buy")]
    [SerializeField] private Button buyTabButton;
    [SerializeField] private GameObject buyTab;

    public Action OnCloseButton;

    public void SetUp()
    {
        closeButton.onClick.AddListener(HandleCloseButton);
        sellTabButton.onClick.AddListener(HandleSellTab);
        buyTabButton.onClick.AddListener(HandleBuyTab);
    }

    private void HandleCloseButton()
    {
        OnCloseButton?.Invoke();
    }

    private void HandleSellTab()
    {
        sellTab.SetActive(true);
        buyTab.SetActive(false);
    }

    private void HandleBuyTab()
    {
        sellTab.SetActive(false);
        buyTab.SetActive(true);
    }

}
