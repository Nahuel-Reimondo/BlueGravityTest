using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemWidget : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Toggle selectedToggle;

    private ItemData itemData;
    private Action<ItemData> OnChangeSelection;

    public void SetUp(ItemData data, Action<ItemData> callback)
    {
        itemData = data;
        nameText.text = itemData.ItemName;
        selectedToggle.onValueChanged.AddListener(HandleSelection);

        OnChangeSelection += callback;
    }

    private void HandleSelection(bool selected)
    {
        OnChangeSelection?.Invoke(itemData);
    }

}
