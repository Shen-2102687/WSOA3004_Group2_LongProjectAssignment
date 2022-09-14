using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{

    private int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Grow", timeBetweenGrowths, timeBetweenGrowths);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grow()
    {
        if(currentProgression != maxGrowth)
        {
            gameObject.transform.GetChild(currentProgression).gameObject.SetActive(true);
        }

        if(currentProgression >0 && currentProgression < maxGrowth)
        {
            gameObject.transform.GetChild(currentProgression - 1).gameObject.SetActive(false);
        }

        if(currentProgression < maxGrowth)
        {
            currentProgression++;
        }
    }
}
