using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    Scene curScene;
    void Start()
    {
    curScene = SceneManager.GetActiveScene();
    if(curScene.name == "Menu")
    {
        PlayerPrefs.SetInt("JustEnteredHouse",0);
        PlayerPrefs.SetInt("GotGUn",0);
        PlayerPrefs.SetInt("KilledDad",0);
        PlayerPrefs.SetInt("KilledBro",0);
        PlayerPrefs.SetInt("KilledMom",0);
    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
