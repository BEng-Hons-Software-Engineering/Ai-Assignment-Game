using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{


    public Transform maincam;
    public Transform middleBG;
    public Transform sideBG;

    public float lenght = 38.4f;


    // Update is called once per frame
    void Update()
    {
        if (maincam.position.x > middleBG.position.x)
            sideBG.position = middleBG.position + Vector3.right * lenght;
        if (maincam.position.x < middleBG.position.x)
            sideBG.position = middleBG.position + Vector3.left * lenght;

        if (maincam.position.x > sideBG.position.x || maincam.position.x < sideBG.position.x )
        {

            Transform z = middleBG;
            middleBG = sideBG;
            sideBG = z; }
    }
}
