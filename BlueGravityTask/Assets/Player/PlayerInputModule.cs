using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementModule))]
public class PlayerInputModule : MonoBehaviour
{
    [SerializeField] private Vector2 movement;
    private MovementModule movementModule;

    private void Awake()
    {
        movementModule = this.GetComponent<MovementModule>();
    }

    private void Update()
    {
        movementModule.Move(movement);
    }
}
