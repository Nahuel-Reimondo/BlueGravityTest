using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private StoreFrameUI storeUI;
    private Action<bool> OnStoreToogle;

    public static ShopManager instance;

    private void Awake()
    {
        InitializeSingleton();
    }

    private void InitializeSingleton()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }


    void Start()
    {
        OnStoreToogle += GameManager.instance.HandleStoreToogle;
    }

    public void DisplayStore(StoreData data)
    {
        OnStoreToogle?.Invoke(true);
        storeUI.gameObject.SetActive(true);
    }

    public void CloseStore()
    {
        OnStoreToogle?.Invoke(false);
    }
}
