using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dailyCycle : MonoBehaviour
{
    public float cycleFunction;
    public float currentTime = 0;
    //float nextTime = 0;
    public float nextCycleVal = 0;
    public float angularFrequency;
    public float frequency = (1f / 120f);

    public Text cycleText;
    public Text timeText;
    public Text cycleValText;

    // Start is called before the first frame update
    void Start()
    {
        angularFrequency = 2 * Mathf.PI * (frequency);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        timeText.text = "Time: " + currentTime.ToString();

        cycleFunction = Mathf.Sin(angularFrequency * currentTime);
        

        cycleValText.text = cycleFunction.ToString();

        nextCycleVal = Mathf.Sin(angularFrequency * (currentTime + 1));

        if ( 0 < cycleFunction && cycleFunction < 1 && cycleFunction < nextCycleVal)
        {
            //its morning
            cycleText.text = "Morning";
            
        }

        if (0 < cycleFunction && cycleFunction < 1 && cycleFunction > nextCycleVal)
        {
            //its morning
            cycleText.text = "Afternoon";
            
        }

        if (-1 < cycleFunction && cycleFunction < 0 && cycleFunction > nextCycleVal)
        {
            //its morning
            cycleText.text = "Evening";
            
        }

        if (-1 < cycleFunction && cycleFunction < 0 && cycleFunction < nextCycleVal)
        {
            //its morning
            cycleText.text = "Night";
            
        }

    }
}
