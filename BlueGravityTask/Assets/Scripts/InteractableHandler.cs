using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHandler : MonoBehaviour, Interactable
{
    public Action OnInteractWith;

    public Transform GetTransform() => this.transform.parent;

    public void Interact()
    {
        OnInteractWith?.Invoke();
    }

    public void SetUp(Action interactionCallback)
    {
        if (interactionCallback == null) return;

        OnInteractWith += interactionCallback;
    }
}
