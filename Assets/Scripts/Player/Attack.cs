using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

   MovementtControll controlls;

   float direction = 0;

   public Rigidbody2D playerRB;
   public Animator animator;
   public float speed = 400;
   public float jumpForce = 5;
   bool isFacingRight = true;
   bool isGrounded;

   private int noOfJumps = 0;

   public Transform groundCheck;
   public LayerMask groundLayer;
   // Start is called before the first frame update

   public float stoppingDistance = 8;
   public float retreatDistance = 5;
   private Transform target;

   public GameObject enemyObj;

   // Start is called before the first frame update
   void Start()
   {

      //   targetTag = GameObject.FindGameObjectWithTag("Player");
      target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
   }


   // Update is called once per frame
   void FixedUpdate()
   {

      if (Vector2.Distance(transform.position, target.position) < stoppingDistance)
      {
         Debug.Log("Touched");


         animator.SetBool("kill", true);
         enemyObj.SetActive(false);
         //  animator.SetBool("kill", false);
      }
      else if (
         Vector2.Distance(transform.position, target.position) == stoppingDistance
      )
      {
         Debug.Log("Touched");

         animator.SetBool("kill", true);
      }






   }



}

