using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreFramePresenter : BasePresenter<StoreFrameModel, StoreFrameView>
{

    public StoreFramePresenter (StoreFrameModel model) : base (model)
    {
        
    }

    private void OnEnable()
    {
        Bind();
    }

    protected override void Bind()
    {
        base.Bind();
        StoreData currentStoreData = model.storeInfo.StoreData;
        StoreData playerInventory = model.storeInfo.StoreData; //Insert Playerinventory
        view.SetUp(currentStoreData, playerInventory);
        view.OnCloseButton += Close;
    }

    public override void GoWith(StoreFrameModel model)
    {
        Debug.Log("Set up Model");
        this.model = model;
    }

    private void OnDisable()
    {
        Unbind();
    }

    protected override void Unbind()
    {
       
    }

    private void Close()
    {
        ShopManager.instance.CloseStore();

        Unbind();

        this.gameObject.SetActive(false);
    }
}