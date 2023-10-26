using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * moveSpeed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        if (moveBy > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveBy < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


}
