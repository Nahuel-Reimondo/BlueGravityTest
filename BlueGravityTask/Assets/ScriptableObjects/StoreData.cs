using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StoreData", menuName = "ScriptableObjects/Stores/StoreData")]
public class StoreData : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private List<ItemData> items;

    public string StoreName => name;
    public List<ItemData> Items => items;
}