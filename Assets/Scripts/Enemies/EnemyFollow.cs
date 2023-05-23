using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{


    public float speed;
    public float stoppingDistance=5;
    public float retreatDistance;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, target.position)>stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }else if(Vector2.Distance(transform.position, target.position) <stoppingDistance && Vector2.Distance(transform.position, target.position) > retreatDistance){
            transform.position = this.transform.position;
        }else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position= Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
         
       
    }
}
