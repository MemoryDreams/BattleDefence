using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSystemScript : MonoBehaviour
{
    public GameObject MainLoop;
    public GameObject GameOver;

    public void InitiateGameOverScreen()
    {
        MainLoop.SetActive(false);
        GameOver.SetActive(true);
    }
    
}
