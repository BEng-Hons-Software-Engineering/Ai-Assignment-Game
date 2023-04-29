using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizonal;
    private float moveVertical; 



    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
        jumpForce = 60f;
        isJumping = false;
    }
    
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) ==true|| Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
          body.velocity = Vector2.up * 10;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            body.velocity = Vector2.right * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            body.velocity = Vector2.left * moveSpeed;
        }

    }

    /*  void FixedUpdate()
      {
          if (moveHorizonal > 0.1f || moveHorizonal < -0.1f)
          {
              body.AddForce(new Vetor2(moveHorizonal * moveSpeed, 0f), ForceMode2D.Impulse);
          }
      }*/
}
