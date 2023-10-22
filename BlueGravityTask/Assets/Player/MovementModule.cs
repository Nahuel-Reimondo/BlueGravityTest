using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementModule : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody2D rb;
    private Vector2 movement;

    public Vector2 GetMovement => movement.normalized;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        movement = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = rb.position + movement * Time.fixedDeltaTime;
        rb.MovePosition(targetPosition);
    }

}
