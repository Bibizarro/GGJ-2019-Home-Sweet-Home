using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public GameObject player;
  public GameObject fingertip;
  public Transform kitchenPlayerPos;
  private static Singleton instance;


    
    public Weapon weapon;
   public static Singleton GetInstance
   {
       get
       {
            if(instance == null)
            {
            instance = GameObject.FindObjectOfType<Singleton>();
            }
            return instance;
        }


   }
}
