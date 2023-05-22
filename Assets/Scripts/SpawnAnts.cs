using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnts : MonoBehaviour
{

    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
