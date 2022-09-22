using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void goToFarm()
    {
        SceneManager.LoadScene("Diane_Scene");
    }

    public void goExplore()
    {
        SceneManager.LoadScene("Shen_Scene");
    }

}
