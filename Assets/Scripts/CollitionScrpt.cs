using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionScrpt : MonoBehaviour
{
 private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Debug.Log("Game Over");
        }
    }
}
