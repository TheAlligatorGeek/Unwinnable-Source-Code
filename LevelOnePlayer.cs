using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnePlayer : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    public float jumpingPower = 16f;
    private bool isFacingRight = true;
    private bool isJumpActive = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    Score healthFunction;
    [SerializeField] GameObject manager;

    void Start()
    {
        healthFunction = manager.GetComponent<Score>();
        StartCoroutine(timer1());
    }

    void Update()
    {
        //horizontal = 1f;

        if (isJumpActive == true && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (isJumpActive == false && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    IEnumerator timer1() 
    {
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        horizontal = 1f;
        yield return new WaitForSeconds(2f);
        isJumpActive = true;
        yield return new WaitForSeconds(1.0f);
        isJumpActive = false;
        yield return new WaitForSeconds(0.5f);
        horizontal = 0f;
        yield return new WaitForSeconds(0.75f);
        horizontal = 1f;
        yield return new WaitForSeconds(1.15f);
        isJumpActive = true;
        yield return new WaitForSeconds(0.5f);
        isJumpActive = false;
        yield return new WaitForSeconds(1.26f);
        isJumpActive = true;
        yield return new WaitForSeconds(1.0f);
        isJumpActive = false;
    }
}
