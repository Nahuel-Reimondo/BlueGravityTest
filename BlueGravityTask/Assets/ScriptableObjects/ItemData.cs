using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/Stores/ItemData")]
public class ItemData : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private Texture image;
    [Tooltip("If the player sell this item, he will recieve this amount of coins")]
    [SerializeField] private int sellPrice;
    [Tooltip("If the player buy this item, he will need to pay this amount of coins")]
    [SerializeField] private int buyPrice;

    public string ItemName => name;
    public Texture Image => image;
    public int Sellprice => sellPrice;
    public int BuyPrice => buyPrice;

}
