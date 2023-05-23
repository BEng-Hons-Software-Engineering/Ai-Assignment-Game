using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGirlMovement : MonoBehaviour
{

    MovementtControll controlls;

    float direction = 0;

    public Rigidbody2D playerRB;
    public Animator animator;
    public float speed = 400;
    public float jumpForce = 5;
    bool isFacingRight = true;
    bool isGrounded;

    private int noOfJumps=0;

    public Transform groundCheck;
    public LayerMask groundLayer; 
    // Start is called before the first frame update
    private void Awake()
    {

        controlls = new MovementtControll();
        controlls.Enable();
        controlls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };


        controlls.Land.Jump.performed += ctx => Jump();
     

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        Debug.Log(isGrounded);
        animator.SetBool("isGrounded", isGrounded);

        animator.SetFloat("speed", Mathf.Abs(direction));
        playerRB.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));

        if (isFacingRight && direction < 0|| !isFacingRight && direction > 0)
            Flip();

    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
    void Jump()
    {
        if (isGrounded)
        {
            noOfJumps = 0;
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
            noOfJumps++;
        }
        else
        {
            if (noOfJumps == 1)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
                noOfJumps++;
            }
        }
       
    }

}

