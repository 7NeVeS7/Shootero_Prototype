using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Rigidbody rb;
    Vector3 movement;
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
