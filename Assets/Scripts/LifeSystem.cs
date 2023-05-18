using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour { 

    public int initialLife = 3;
private int currentLife;
public GameObject lifeIndicatorPrefab; // Prefab of the life indicator object
public Transform lifeIndicatorParent; // Parent object to hold the life indicators
private GameObject[] lifeIndicators;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = initialLife;
        CreateLifeIndicators();
    }

    private void CreateLifeIndicators()
    {
        lifeIndicators = new GameObject[initialLife];

        for (int i = 0; i < initialLife; i++)
        {
            GameObject lifeIndicator = Instantiate(lifeIndicatorPrefab, lifeIndicatorParent);
            lifeIndicators[i] = lifeIndicator;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lifes"))
        {
            currentLife--;
            UpdateLifeIndicators();

            if (currentLife <= 0)
            {
                // Game over logic
                Debug.Log("Game Over");
            }
        }
    }
    private void UpdateLifeIndicators()
    {
        for (int i = 0; i < initialLife; i++)
        {
            if (i < currentLife)
            {
                lifeIndicators[i].SetActive(true); // Activate life indicators based on current life
            }
            else
            {
                lifeIndicators[i].SetActive(false); // Deactivate life indicators for lost lives
            }
        }
    }
    // Update is called once per frame
    //void Update()
    //{
    //    
//}
}
