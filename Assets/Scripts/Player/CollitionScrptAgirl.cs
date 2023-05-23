using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionScrptAgirl : MonoBehaviour
{

    //hi
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {

            //gameObject.setActive(false);


            HealthManager.health--;
            if (HealthManager.health <= 0)
            {
                Debug.Log("Game Over");
                GetComponent<Animator>().SetLayerWeight(1, 1);
                PlayerManager.isGameOver = true;
            }
            else
            {
                StartCoroutine(GetHurt());

            }
        }

        IEnumerator GetHurt()
        {
            Physics2D.IgnoreLayerCollision(6, 8);
            GetComponent<Animator>().SetLayerWeight(2, 1);
            yield return new WaitForSeconds(3);
           GetComponent<Animator>().SetLayerWeight(2, 0);
            Physics2D.IgnoreLayerCollision(6, 8, false);
        }
    }
}
