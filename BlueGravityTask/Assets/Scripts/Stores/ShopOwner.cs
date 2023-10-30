using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopOwner : MonoBehaviour
{
    [SerializeField] private StoreInfo storeInfo;
    [SerializeField] private InteractableHandler interactableHandler;

    private bool isBeingExaminated = false;

    void Start()
    {
       SetUpInteraction();
    }

    private void SetUpInteraction()
    {
        if (interactableHandler == null)
        {
            Debug.LogWarning("InteractableHandler not assinged");
            return;
        }

        interactableHandler.SetUp(HandleInteraction);
    }

    private void HandleInteraction()
    {
        Debug.Log("Player interacted with: " + this.gameObject.name);
        ShowStore();
    }

    private void ShowStore()
    {
        if (isBeingExaminated) return;

        isBeingExaminated = true;
        ShopManager.instance.DisplayStore(storeInfo);
    }
  
}

[System.Serializable]
public class StoreInfo
{
    [SerializeField] private StoreData storeData;

    public StoreData StoreData => storeData;
}