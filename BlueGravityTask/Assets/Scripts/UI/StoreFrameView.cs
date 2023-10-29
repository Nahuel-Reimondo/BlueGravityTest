using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreFrameView : BaseView
{
    [SerializeField] private Button closeButton;

    public Action OnCloseButton;

    public void SetUp()
    {
        closeButton.onClick.AddListener(HandleCloseButton);
    }

    public void HandleCloseButton()
    {
        OnCloseButton?.Invoke();
    }
    
}
