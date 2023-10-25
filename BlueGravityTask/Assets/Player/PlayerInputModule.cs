using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(MovementModule))]
[RequireComponent(typeof(PlayerInteractionModule))]
public class PlayerInputModule : MonoBehaviour
{
    [SerializeField] private Vector2 movement;
    private MovementModule movementModule;
    private PlayerInteractionModule interactionModule;

    private void Awake()
    {
        movementModule = this.GetComponent<MovementModule>();
        interactionModule = this.GetComponent<PlayerInteractionModule>();
    }

    private void Update()
    {
        movementModule.Move(movement);
    }

    public void OnMove(InputValue input)
    {
        Vector2 processedInput = input.Get<Vector2>();
        if (Mathf.Abs(processedInput.x )< 1)
            processedInput.x = 0f;

        if (Mathf.Abs(processedInput.y) < 1)
            processedInput.y = 0f;

        movement = processedInput;
    }

    public void OnInteract()
    {
        interactionModule.TryInteraction();
    }
}
