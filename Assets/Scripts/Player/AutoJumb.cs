using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJumb : MonoBehaviour
{



   public float stoppingDistance = 5;
   public float retreatDistance;
   private Transform target;



   private JohnMovement yourScript;
   // Start is called before the first frame update
   void Start()
   {

      yourScript = GetComponent<JohnMovement>();
      yourScript.jumpForce = 12;
   }

   // Update is called once per frame
   //    void Update()
   //    {
   //       Debug.Log(Vector2.Distance(transform.position, target.position));
   //       if (Vector2.Distance(transform.position, target.position) == 1)
   //       {
   //          john.Jump();

   //       }
   //    }


   private void OnTriggerEnter2D(Collider2D other)
   {

      Debug.Log("Trigger Entered");

      // Could use other.GetComponent<Player>() to see if the game object has a Player component
      // Tags work too. Maybe some players have different script components?
      if (other.tag == "Autojumb")
      {

         Debug.Log("Autojumb");
         // Player entered, so move level
         //  print("Switching Scene to " + sceneBuildIndex);
         //  SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
         yourScript.Jump();

         yourScript.jumpForce = 8;
      }
   }



}
