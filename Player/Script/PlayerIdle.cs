using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : MonoBehaviour
{
    private bool facingRight = true;

    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mouseWorldPos - transform.position;

        if (direction.x < 0 && facingRight){
            Flip();
        }
        else if (direction.x > 0 && !facingRight){
            Flip();
        }

        float moveInput = Input.GetAxisRaw("Horizontal");
        movement = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    void FixedUpdate(){
        rb.linearVelocity = movement;
    }

    void Flip(){
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
