using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (MovementModule))]
public class PlayerInteractionModule : MonoBehaviour
{
    [SerializeField] private Transform interactionSensorObj;

    private List<Interactable> interactablesInRange = new List<Interactable>();

    private MovementModule movementModule;

    private void Awake()
    {
        movementModule = this.GetComponent<MovementModule>();
    }

    private void Update()
    {
        UpdateInteractionSensor(movementModule.Movement);
    }

    private void UpdateInteractionSensor(Vector2 moveDirection)
    {
        if (moveDirection == Vector2.zero) return;

        float angle = Vector3.SignedAngle(this.transform.up, moveDirection, Vector3.forward);
        interactionSensorObj.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void TryInteraction()
    {
        if (interactablesInRange.Count == 0) return;

        float maxDistance = float.MaxValue;
        Interactable closest = interactablesInRange[0];
        foreach (Interactable item in interactablesInRange)
        {
            float itemDistance = Vector2.Distance(this.transform.position, item.GetTransform().position);
            if (itemDistance < maxDistance)
            {
                closest = item;
                maxDistance = itemDistance;
            }
        }

        closest.Interact();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!HasInteractable(collision, out Interactable interactable)) return;

        if(!interactablesInRange.Contains(interactable))
            interactablesInRange.Add(interactable);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!HasInteractable(collision, out Interactable interactable)) return;

        if(interactablesInRange.Contains(interactable))
            interactablesInRange.Remove(interactable);
    }

    private bool HasInteractable(Collider2D collision, out Interactable interactableObj)
    {
        Interactable interactable = collision.GetComponent<Interactable>();
        interactableObj = interactable;
        return interactable != null;
    }
}
