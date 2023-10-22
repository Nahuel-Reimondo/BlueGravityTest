using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MovementModule))]
[RequireComponent(typeof(Animator))]
public class AnimationModule : MonoBehaviour
{
    [SerializeField] private string speedParameter;
    [SerializeField] private string xMovementParameter;
    [SerializeField] private string yMovementParameter;

    private MovementModule movementModule;
    private Animator animator;

    private void Awake()
    {
        movementModule = this.GetComponent<MovementModule>();
        animator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        Vector2 currentMovement = movementModule.Movement;
        animator.SetFloat(speedParameter, currentMovement.magnitude);
        animator.SetFloat(xMovementParameter, currentMovement.x);
        animator.SetFloat(yMovementParameter, currentMovement.y);
    }
}