using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public GameObject player;
  public GameObject fingertip;
  public Transform kitchenPlayerPos;

  public Transform gotUpstairsPlayerPos;

 public Transform leaveDadRoomPlayerPos;

 public Transform leaveBrotherRoomPlayerPos;
  
   public Transform GotDownstairsPlayerPos;

    public Transform leaveKitchenPlayerPos;

    public Transform dadRoomPlayerPos;

    public Transform brotherRoomPlayerPos;
     public Transform kiddoRoomPlayerPos;
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
