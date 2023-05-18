using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiAnt : MonoBehaviour
{

    public GameObject ant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(ant, transform.position, transform.rotation);
    }
}
