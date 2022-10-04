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

    //public GameObject cameraObj;

    public Camera cameraObj;
    Color32 afternoonColour = new Color32(186, 188, 127, 255);
    Color32 morningColour = new Color32(223, 224, 171, 255);
    Color32 eveningColour = new Color32(149, 150, 99, 255);
    Color32 nightColour = new Color32(117, 117, 109, 255);

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    public GameObject enemy;
    bool instantiated = false;

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
            instantiated = false;
            //its morning
            cycleText.text = "Morning";
            cameraObj.backgroundColor = morningColour;

            GameObject[] enemyList = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in enemyList)
            {
                Destroy(enemy.gameObject);
            }

        }

        if (0 < cycleFunction && cycleFunction < 1 && cycleFunction > nextCycleVal)
        {
            //its morning
            cycleText.text = "Afternoon";
            cameraObj.backgroundColor = afternoonColour;

            

        }

        if (-1 < cycleFunction && cycleFunction < 0 && cycleFunction > nextCycleVal)
        {
            //its morning
            cycleText.text = "Evening";
            cameraObj.backgroundColor = eveningColour;
        }

        if (-1 < cycleFunction && cycleFunction < 0 && cycleFunction < nextCycleVal)
        {
            //its morning
            cycleText.text = "Night";
            cameraObj.backgroundColor = nightColour;

            //Instantiate(enemy, spawnPoint1.transform.position, Quaternion.identity);
            //Instantiate(enemy, spawnPoint2.transform.position, Quaternion.identity);
            //Instantiate(enemy, spawnPoint3.transform.position, Quaternion.identity);

            if (!instantiated)
            {
                Instantiate(enemy, spawnPoint1.transform.position, Quaternion.identity);
                Instantiate(enemy, spawnPoint2.transform.position, Quaternion.identity);
                Instantiate(enemy, spawnPoint3.transform.position, Quaternion.identity);
                instantiated = true;
            }


        }

    }
}
