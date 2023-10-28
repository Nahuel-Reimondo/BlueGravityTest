using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableExample : MonoBehaviour, Interactable
{
    public void Interact()
    {
        print("Interacted> " + this.gameObject.name);
    }

    public Transform GetTransform() => this.transform;
}
