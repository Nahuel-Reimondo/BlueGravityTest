using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Action<bool> OnToogleStore;

    public static GameManager instance;

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

    public void HandleStoreToogle(bool open)
    {
        OnToogleStore?.Invoke(open);
    }
}
