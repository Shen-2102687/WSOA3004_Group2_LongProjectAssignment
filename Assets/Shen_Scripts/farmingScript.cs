using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class farmingScript : MonoBehaviour
{
    int inventoryCount = 0;
    int gridCount = 0;

    public Text inventoryText;
    public Text gridText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickObject();
        }
        inventoryText.text = "Seeds: " + inventoryCount.ToString();
        gridText.text = "Grid count: " + gridCount.ToString();
            
    }

    public void clickObject()
    {
        Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D clicked = Physics2D.Raycast(rayCast.origin, rayCast.direction, Mathf.Infinity);
        if(clicked.collider != null)
        {
            switch (clicked.collider.gameObject.name)
            {
                case "seed":
                    inventoryCount++;
                    Destroy(clicked.collider.gameObject);
                    break;
                case "grid":
                    if (gridCount == 0 && inventoryCount > 0)
                    {
                        gridCount++;
                        inventoryCount--;
                        //10 second timer
                        //when ten seconds up
                        Debug.Log("planted the seed");
                        gridCount = 3;
                    }
                    else
                    {
                        inventoryCount += gridCount;
                        gridCount = 0;
                    }
                    break;
            }
        }
    }
}
