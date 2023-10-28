using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreFrameUI : MonoBehaviour
{
    [SerializeField] private Button closeButton;

    private void OnEnable()
    {
        closeButton.onClick.AddListener(Close);
    }

    private void Close()
    {
        ShopManager.instance.CloseStore();
        this.gameObject.SetActive(false);
    }
}
