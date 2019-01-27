using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [HideInInspector]public Scene curScene;

    void Start()
    {

    curScene = SceneManager.GetActiveScene();
    if(curScene.name == "Menu")
    {
        PlayerPrefs.SetString("previousScene" , "Menu");
        PlayerPrefs.SetInt("JustEnteredHouse",0);
        PlayerPrefs.SetInt("GotOpener",0);
        PlayerPrefs.SetInt("GotKey",0);
        PlayerPrefs.SetInt("JustGotUpstairs",0);
        PlayerPrefs.SetInt("GotGun",0);
        PlayerPrefs.SetInt("KilledDad",0);
        PlayerPrefs.SetInt("KilledBro",0);
        PlayerPrefs.SetInt("KilledMom",0);
    }

    }
    void Update()
    {
        
    }
}
