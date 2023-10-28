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

    private bool inputsActivated = true;

    private void Awake()
    {
        movementModule = this.GetComponent<MovementModule>();
        interactionModule = this.GetComponent<PlayerInteractionModule>();
    }

    private void Start()
    {
        GameManager.instance.OnToogleStore += HandleStore;
    }

    private void Update()
    {
        if (!inputsActivated) return;

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

    private void HandleStore(bool open)
    {
        ToggleInputs(!open);
    }

    public void ToggleInputs(bool activate)
    {
        inputsActivated = activate;
    }
}
