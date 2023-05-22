using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulitiAnt : MonoBehaviour
{


    public GameObject ant;
    public int numberOfInstances = 5;
    public float speed = 5;
    public float delayBetweenInstances = 2;

    public bool createAtStart = true;

    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (createAtStart)
        {
            CreateInstance();
            createAtStart = false;
        }
        else
        {
            if (timer < delayBetweenInstances)
            {
                timer += Time.deltaTime;
            }
            else
            {
                //Instantiate(ant, transform.position, transform.rotation);
                for (int i = 0; i < numberOfInstances; i++)
                {
                    GameObject instance = Instantiate(ant, transform.position, transform.rotation);
                    instance.AddComponent<MovementScript>();
                    instance.GetComponent<MovementScript>().speed = speed;
                    timer = 0;
                }
            }
        }

       
    }


    private void CreateInstance() {
        GameObject instance = Instantiate(ant, transform.position, transform.rotation);
        instance.AddComponent<MovementScript>();
        instance.GetComponent<MovementScript>().speed = speed;
        timer = 0;
    }
}



public class MovementScript : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}