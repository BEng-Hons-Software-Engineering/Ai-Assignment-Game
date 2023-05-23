using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJumb : MonoBehaviour
{



   public float stoppingDistance = 5;
   public float retreatDistance;
   private Transform target;


   JohnMovement john;

   // Start is called before the first frame update
   void Start()
   {
      target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      john = new JohnMovement();
   }

   // Update is called once per frame
   void Update()
   {
      Debug.Log(Vector2.Distance(transform.position, target.position));
      if (Vector2.Distance(transform.position, target.position) == 1)
      {
         john.Jump();

      }
   }
}
